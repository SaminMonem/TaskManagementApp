using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using TaskManagementApp;
using System.Runtime.InteropServices.ComTypes;

namespace TaskManagement1
{
    public partial class Project : Form
    {
        //public Project(string selectedOption)
        public Project()
        {
            InitializeComponent();
            DisplayProjectListDGV();
        }

        
        public DataGridViewRowCollection GetAllProjects()
        {
            return ProjectListDGV.Rows;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\My Documents\Development\FinalProject\DoneDay\TaskManagementApp\TaskManagementApp\taskDb.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(TaskManagementApp.Properties.Settings.Default.taskDbConnectionString);

        private void DisplayProjectListDGV()
        {
            Con.Open();
            string Query = "Select * from ProjectListTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            //Tasks1 task1Form = Application.OpenForms["Task1"] as Tasks1;
            ProjectListDGV.DataSource = ds.Tables[0];
            //Tasks1 TaskListDGV = new Tasks1();
            //TaskList.Show();
            //TaskListDGV.Show(this);
            if (ProjectListDGV.Columns["OpenFile"] == null)
            {
                // Add the OpenFile link column to the DataGridView
                DataGridViewLinkColumn lnkCol = new DataGridViewLinkColumn();
                lnkCol.HeaderText = "Open File";
                lnkCol.Name = "OpenFile";
                lnkCol.Text = "Open";
                lnkCol.UseColumnTextForLinkValue = true;
                ProjectListDGV.Columns.Add(lnkCol);

            }

            Con.Close();
        }

        

        int Key = 0;
        //private string selectedOption;

        private void ProjectListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PTaskName.Text = ProjectListDGV.SelectedRows[0].Cells[0].Value.ToString();
            POwner.Text = ProjectListDGV.SelectedRows[0].Cells[1].Value.ToString();
            PStartDate.Text = ProjectListDGV.SelectedRows[0].Cells[2].Value.ToString();
            PDueDate.Text = ProjectListDGV.SelectedRows[0].Cells[3].Value.ToString();
            PTimeline.Text = ProjectListDGV.SelectedRows[0].Cells[4].Value.ToString();
            //Category.SelectedItem = ProjectListDGV.SelectedRows[0].Cells[5].Value.ToString();
            PPriority.SelectedItem = ProjectListDGV.SelectedRows[0].Cells[6].Value.ToString();
            PStatus.SelectedItem = ProjectListDGV.SelectedRows[0].Cells[7].Value.ToString();
            PNote.Text = ProjectListDGV.SelectedRows[0].Cells[8].Value.ToString();

            if (PTaskName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProjectListDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

            if (e.ColumnIndex == ProjectListDGV.Columns["Files"].Index && e.RowIndex >= 0)
            {
                string filePath = ProjectListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(filePath);
                }
                else
                {
                    MessageBox.Show("File not found: " + filePath);
                }

            }
        }

        private void Reset()
        {
            Key = 0;
            ProjectName.Text = "";
            PTaskName.Text = "";
            Owner.Text = "";
            PStartDate.Text = "";
            PDueDate.Text = "";
            PTimeline.Text = "";
            PPriority.Text = "";
            PStatus.Text = "";
            PCategory.Text = "";
            PNote.Text = "";
        }
        private void DeleteProjectBtn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("Delete from ProjectListTb where ProjectID= @ProjectKey", Con);
                    cmd.Parameters.AddWithValue("@ProjectKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The selected project is deleted!");
                    Con.Close();
                    DisplayProjectListDGV();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

       

        private void AddTask_Click(object sender, EventArgs e)
        {
            string item = this.PTaskName.Text.ToString();
            if (item.Length <= 0)
                MessageBox.Show("Please fill the Task Names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                TaskList.Items.Add(item);
                this.PTaskName.Clear();
                this.PTaskName.Focus();
            }
        }


        private void RemoveTaskListBtn_Click(object sender, EventArgs e)
        {
            TaskList.Items.RemoveAt(TaskList.SelectedIndex);
        }

        private void CreateProjectBtn_Click_1(object sender, EventArgs e)
        {
            if (PTaskName.Text == "" || POwner.Text == "" || PStartDate.Text == "" || PDueDate.Text == "" || PTimeline.Text == "" || PCategory.SelectedIndex == -1 || PPriority.SelectedIndex == -1 || PStatus.SelectedIndex == -1 || PNote.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProjectListTb(ProjectName,TaskName,Owner,StartDate,DueDate,Timeline,Category,Priority,Status,Note) values (@ProjectName,@TaskName,@Owner,@StartDate,@DueDate,@Timeline,@Category,@Priority,@Status,@Note)", Con);
                    cmd.Parameters.AddWithValue("@ProjectName", ProjectName.Text);
                    cmd.Parameters.AddWithValue("@TaskName", PTaskName.Text);
                    cmd.Parameters.AddWithValue("@Owner", POwner.Text);
                    cmd.Parameters.AddWithValue("@StartDate", PStartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@DueDate", PDueDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Timeline", PTimeline.Text);
                    cmd.Parameters.AddWithValue("@Category", PCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Priority", PPriority.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Status", PStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Note", PNote.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Project is added.");
                    Con.Close();
                    DisplayProjectListDGV();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            //string item = this.ProjectTitle.Text.ToString();
            string t = ProjectName.Text;
            ProjectTitle.Text = t + " ";
        }

        private void AddFileBtn_Click(object sender, EventArgs e)
        {
            Files FilesForm = new Files();
            FilesForm.ProjectForm = this;
            FilesForm.ShowDialog();
        }

        public void SetFileName(string FileName)
        {
            Files.Text = FileName;
        }

        private void DashboardM_Click(object sender, EventArgs e)
        {
            Dashboard DashboardForm = new Dashboard();
            this.Hide();
            DashboardForm.Show();
        }

        private void TasksM_Click(object sender, EventArgs e)
        {
            Tasks TaskListForm = new Tasks();
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

        private void EditProjectBtn_Click_1(object sender, EventArgs e)
        {
            if (PTaskName.Text == "" || POwner.Text == "" || PStartDate.Text == "" || PDueDate.Text == "" || PTimeline.Text == "" || PCategory.SelectedIndex == -1 || PPriority.SelectedIndex == -1 || PStatus.SelectedIndex == -1 || PNote.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update ProjectListTb set TaskName=@TaskName,Owner=@Owner, StartDate=@StartDate, DueDate=@DueDate,Timeline=@Timeline,Category=@Category, Priority=@Priority, Status=@Status, Note=@Note", Con);
                    cmd.Parameters.AddWithValue("@ProjectName", ProjectName.Text);
                    cmd.Parameters.AddWithValue("@TaskName", PTaskName.Text);
                    cmd.Parameters.AddWithValue("@Owner", POwner.Text);
                    cmd.Parameters.AddWithValue("@StartDate", PStartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@DueDate", PDueDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Timeline", PTimeline.Text);
                    cmd.Parameters.AddWithValue("@Category", PCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Priority", PPriority.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Status", PStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Note", PNote.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Project is Updated");
                    Con.Close();
                    DisplayProjectListDGV();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Methods MethodsForm = new Methods();
            this.Hide();
            MethodsForm.Show();
        }

        private void ProjectName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}