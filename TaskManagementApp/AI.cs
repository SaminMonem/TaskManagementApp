using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using System.Xml.Linq;
using CsvHelper;
using System.Configuration;
using TaskManagement1;

namespace TaskManagementApp
{
    public partial class AI : Form
    {
        public class ProjectTask
        {
            public string Area { get; set; }
            public string TaskName { get; set; }
            public double Duration { get; set; }
            public string DepartmentOrOffice { get; set; }
            public string ProjectName { get; set; }
            public string Owner { get; set; }
           
            //public DateTime StartDate { get; set; }
            //public DateTime DueDate { get; set; }
            
            //public string Priority { get; set; }
            //public string Status { get; set; }
            public string Deadline { get; set; }

        }
        public List<ProjectTask> Project_Management_Data;
        public const string CsvFilePath = "Project_Management_Data.csv";
        public AI()
        {
            InitializeComponent();
            LoadTasksFormCsv();
            PopulateTaskNameComboBox();
            PopulateAreaComboBox();
            PopulateProjectNameComboBox();
            DisplayPredictedTaskListDGV();
        }
        public void LoadTasksFormCsv()
        {
            try
            {
            
                using (var reader = new StreamReader("Project_Management_Data.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Project_Management_Data = csv.GetRecords<ProjectTask>().ToList();
                    
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Error!: {ex.Message}");
            }
        }

        private void PopulateTaskNameComboBox()
        {
            List<string> TaskNames = Project_Management_Data.Select(task => task.TaskName).Distinct().OrderBy(taskName => taskName).ToList();
            TaskName.Items.AddRange(TaskNames.ToArray());
        }

        private void PopulateAreaComboBox()
        {
            var area = Project_Management_Data.Select(task => task.Area).Distinct().OrderBy(areas => areas).ToList();
            Area.Items.AddRange(area.ToArray());
        }

        private void PopulateProjectNameComboBox()
        {
            var ProjectNames = Project_Management_Data.Select(task => task.ProjectName).Distinct().OrderBy(projectName => projectName).ToList();
            ProjectName.Items.AddRange(ProjectNames.ToArray());
        }
            private void SubmitBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TaskName.SelectedItem == null)
                {
                    MessageBox.Show("Please select the task you would want to manage");
                    return;
                }

                string selectedTaskName = TaskName.SelectedItem.ToString();
                var filteredTasks = Project_Management_Data.Where(task => task.TaskName.Equals(selectedTaskName, StringComparison.OrdinalIgnoreCase)).ToList();

                

                if (filteredTasks.Count == 0)
                {
                    MessageBox.Show("I cannot predict because no task found!");
                    return;
                }
               

                else
                {
                    double averageDuration = filteredTasks.Average(task => task.Duration);
                    PredictedDuration.Text = $"Average Duration in days: {averageDuration:N2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");

            }
          //PredictedTasksListDGV.DataSource = filteredTasks;
            
        }

        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\My Documents\Development\FinalProject\DoneDay\TaskManagementApp\TaskManagementApp\taskDb.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(TaskManagementApp.Properties.Settings.Default.taskDbConnectionString);

        private void DisplayPredictedTaskListDGV()
        {
            Con.Open();
            string Query = "Select * from PredictedTaskListTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PredictedTaskListDGV.DataSource = ds.Tables[0];
           
            Con.Close();
        }

        int Key = 0;
        private void PredictedTaskListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Area.Text = PredictedTaskListDGV.SelectedRows[0].Cells[0].Value.ToString();
            Owner.Text = PredictedTaskListDGV.SelectedRows[0].Cells[1].Value.ToString();
            SuggestedTasks.Text = PredictedTaskListDGV.SelectedRows[0].Cells[2].Value.ToString();
            PredictedDuration.Text = PredictedTaskListDGV.SelectedRows[0].Cells[3].Value.ToString();
            StartDate.Text = PredictedTaskListDGV.SelectedRows[0].Cells[4].Value.ToString();
            DueDate.Text = PredictedTaskListDGV.SelectedRows[0].Cells[5].Value.ToString();
            SuggestedStatus.Text = PredictedTaskListDGV.SelectedRows[0].Cells[6].Value.ToString();
            SuggestedPriority.Text = PredictedTaskListDGV.SelectedRows[0].Cells[7].Value.ToString();

            if (TaskName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PredictedTaskListDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            Key = 0;
            ProjectName.Text = "";
            Area.Text = "";
            Owner.Text = "";
            SuggestedTasks.Text = "";
            PredictedDuration.Text = "";
            StartDate.Text = "";
            DueDate.Text = "";
            SuggestedPriority.Text = "";
            SuggestedStatus.Text = "";
        }
        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            //string item = this.ProjectTitle.Text.ToString();
            string t = ProjectName.Text;
            ProjectTitle.Text = t + " ";
        }
         
        private void Create_Click(object sender, EventArgs e)
        {
            if (ProjectName.Text == "" || Area.Text == "" || Owner.Text == "" || SuggestedTasks.Text == "" || PredictedDuration.Text == "" || StartDate.Text == "" || DueDate.Text == "" || SuggestedStatus.SelectedIndex == -1 || SuggestedPriority.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PredictedTaskListTb(ProjectName,Area,Owner,SuggestedTasks,PredictedDuration,StartDate,DueDate,SuggestedPriority,SuggestedStatus) values (@ProjectName,@Area,@Owner,@SuggestedTasks,@PredictedDuration, @StartDate,@DueDate,@SuggestedPriority,@SuggestedStatus)", Con);
                    cmd.Parameters.AddWithValue("@ProjectName", ProjectName.Text);
                    cmd.Parameters.AddWithValue("@Area", Area.Text);
                    cmd.Parameters.AddWithValue("@Owner", Owner.Text);
                    cmd.Parameters.AddWithValue("@SuggestedTasks", SuggestedTasks.Text);
                    cmd.Parameters.AddWithValue("@PredictedDuration", PredictedDuration.Text);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@DueDate", DueDate.Value.Date);
                    cmd.Parameters.AddWithValue("@SuggestedPriority", SuggestedPriority.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SuggestedStatus", SuggestedStatus.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Project is added.");
                    Con.Close();
                    DisplayPredictedTaskListDGV();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void SubmitBtn1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ProjectName.SelectedItem == null)
                {
                    MessageBox.Show("Please select the project you would want to work");
                    return;
                }
                if (Area.SelectedItem == null)
                {
                    MessageBox.Show("Please select the project area you would want to work");
                    return;
                }

                string selectedProjectName = ProjectName.SelectedItem.ToString();
                string selectedArea = Area.SelectedItem.ToString();

                var matchingTasks = Project_Management_Data.Where(task => task.ProjectName.Equals(selectedProjectName, StringComparison.OrdinalIgnoreCase)
                        && task.Area.Equals(selectedArea, StringComparison.OrdinalIgnoreCase)).ToList();

                var projectOwner = matchingTasks.First().Owner;
                Owner.Text = projectOwner;


                if (matchingTasks.Count == 0)
                {
                    MessageBox.Show("No tasks found for the selected project and area!");
                    return;
                }
                else
                {
                    // Assuming we just want to display the tasks for the given project and area
                    var taskNames = matchingTasks.Select(task => task.TaskName).Distinct();
                    SuggestedTasks.Text = string.Join(Environment.NewLine, taskNames);
                    //SuggestedTasks.Text = $"Common tasks are: {TaskName}";
                    // Assuming that all tasks for a project and area have the same owner, 
                    // we just take the first one. If this is not the case, you'll need additional logic here.
                    //Owner.Text = matchingTasks.First().Owner;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");

            }
        }
        private void SelectPriority_Click(object sender, EventArgs e)
        {
            DueDate_ValueChanged();
        }
        private void SelectStatus_Click_1(object sender, EventArgs e)
        {
            StartDate_ValueChanged();
        }
        /**
        private void SelectStatus_Click(object sender, EventArgs e)
        {

        }
        **/
        private void DueDate_ValueChanged()
        {
            DateTime dueDate = DueDate.Value;

            TimeSpan timeUntilDue = dueDate - DateTime.Now;

            if (timeUntilDue.TotalDays <= 7) 
            {
                SuggestedPriority.SelectedItem = "High";

            }
            else if (timeUntilDue.TotalDays <= 14) 
            {
                SuggestedPriority.SelectedItem = "Medium";
            }
            else 
            {
                SuggestedPriority.SelectedItem = "Low";
            }
        }

        private void SuggestedPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void StartDate_ValueChanged()
        {
            DateTime startDate = StartDate.Value;

            TimeSpan timeUntilDue = startDate - DateTime.Now;

            if (timeUntilDue.TotalDays <= 0) 
            {
                SuggestedPriority.SelectedItem = "Not Started";
            }
            else if (timeUntilDue.TotalDays <= 14) 
            {
                SuggestedPriority.SelectedItem = "In Process";
            }
            else 
            {
                SuggestedPriority.SelectedItem = "Completed";
            }
        }

        private void EditPredictedProjectBtn_Click_1(object sender, EventArgs e)
        {
            if (ProjectName.Text == "" || Area.Text == "" || Owner.Text == "" || SuggestedTasks.Text == "" || PredictedDuration.Text == "" || StartDate.Text == "" || DueDate.Text == "" || SuggestedStatus.SelectedIndex == -1 || SuggestedPriority.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update PredictedTaskListTb set ProjectName=@ProjectName, Area=@Area,Owner=@Owner, SuggestedTasks=@SuggestedTasks, PredictedDuration=@PredictedDuration, StartDate=@StartDate, DueDate=@DueDate, SuggestedPriority=@SuggestedPriority, SuggestedStatus=@SuggestedStatus", Con);
                    cmd.Parameters.AddWithValue("@ProjectName", ProjectName.Text);
                    cmd.Parameters.AddWithValue("@Area", Area.Text);
                    cmd.Parameters.AddWithValue("@Owner", Owner.Text);
                    cmd.Parameters.AddWithValue("@SuggestedTasks", SuggestedTasks.Text);
                    cmd.Parameters.AddWithValue("@PredictedDuration", PredictedDuration.Text);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@DueDate", DueDate.Value.Date);
                    cmd.Parameters.AddWithValue("@SuggestedPriority", SuggestedPriority.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SuggestedStatus", SuggestedStatus.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Project is Updated");
                    Con.Close();
                    DisplayPredictedTaskListDGV();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void DeletePredictedProjectBtn_Click_1(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Please Select the project.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from PredictedTaskListTb where TaskID= @TaskKey", Con);
                    cmd.Parameters.AddWithValue("@ProjectKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The selected project is deleted!");
                    Con.Close();
                    DisplayPredictedTaskListDGV();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //private string selectedOption;
        private void DashboardM_Click(object sender, EventArgs e)
        {
            Dashboard DashboardForm = new Dashboard();
            this.Hide();
            DashboardForm.Show();
        }

        private void TasksM_Click(object sender, EventArgs e)
        {
            TaskManagement1.Tasks TaskListForm = new TaskManagement1.Tasks();
            this.Hide();
            TaskListForm.Show();
        }

        private void ProjectsM_Click(object sender, EventArgs e)
        {
            Project ProjectForm = new Project();
            this.Hide();
            ProjectForm.Show();
        }

        private void CalendarM_Click(object sender, EventArgs e)
        {
            Calendar CalendarForm = new Calendar();
            this.Hide();
            CalendarForm.Show();
        }

        private void ChartsM_Click(object sender, EventArgs e)
        {
            UserData UserDataForm = new UserData();
            this.Hide();
            UserDataForm.Show();
        }

        private void InviteBtn_Click(object sender, EventArgs e)
        {
            Invitation InvitationForm = new Invitation();
            this.Hide();
            InvitationForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Methods MethodsForm = new Methods();
            this.Hide();
            MethodsForm.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Area_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}


    



