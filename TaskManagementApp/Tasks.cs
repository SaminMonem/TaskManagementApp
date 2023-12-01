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
using System.Diagnostics;
using System.IO;
using TaskManagementApp;
using System.Xml.Linq;
using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Configuration;

namespace TaskManagement1
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
            DisplayTasksListDGV();
            

        }

        public DataGridViewRowCollection GetAllTasks()
        {
            return TasksListDGV.Rows;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\My Documents\Development\FinalProject\DoneDay\TaskManagementApp\TaskManagementApp\taskDb.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(TaskManagementApp.Properties.Settings.Default.taskDbConnectionString);
        private void DisplayTasksListDGV()
        {
            Con.Open();
            string Query = "Select * from TaskListTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            //Tasks1 task1Form = Application.OpenForms["Task1"] as Tasks1;
            TasksListDGV.DataSource = ds.Tables[0];
            //Tasks1 TaskListDGV = new Tasks1();
            //TaskList.Show();
            //TaskListDGV.Show(this);

            if (TasksListDGV.Columns["OpenFile"] == null)
            {
                // Add the OpenFile link column to the DataGridView
                DataGridViewLinkColumn lnkCol = new DataGridViewLinkColumn();
                lnkCol.HeaderText = "Open File";
                lnkCol.Name = "OpenFile";
                lnkCol.Text = "Open";
                lnkCol.UseColumnTextForLinkValue = true;
                TasksListDGV.Columns.Add(lnkCol);

            }
                Con.Close();
            
        }

        private void Reset()
        {
            Key = 0;
            TaskName.Text = "";
            Owner.Text = "";
            StartDate.Text = "";
            DueDate.Text = "";
            Timeline.Text = "";
            Priority.Text = "";
            Status.Text = "";
            Category.Text = "";
            Note.Text = "";
        }

        private void CreateTaskBtn_Click_1(object sender, EventArgs e)
        {
            if (TaskName.Text == "" || Owner.Text == "" || StartDate.Text == "" || DueDate.Text == "" || Timeline.Text == "" || Category.SelectedIndex == -1 || Priority.SelectedIndex == -1 || Status.SelectedIndex == -1 || Note.Text == "" || Files.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TaskListTb(TaskName,Owner,StartDate,DueDate,Timeline,Category,Priority,Status,Note,Files) values (@TaskName,@Owner,@StartDate,@DueDate,@Timeline,@Category,@Priority,@Status,@Note,@Files)", Con);
                    //cmd.Parameters.AddWithValue("@TaskID", TaskID.Text);
                    cmd.Parameters.AddWithValue("@TaskName", TaskName.Text);
                    cmd.Parameters.AddWithValue("@Owner", Owner.Text);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@DueDate", DueDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Timeline", Timeline.Text);
                    cmd.Parameters.AddWithValue("@Category", Category.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Priority", Priority.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Status", Status.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Note", Note.Text);
                    cmd.Parameters.AddWithValue("@Files", Files.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Task is added.");
                    Con.Close();
                    DisplayTasksListDGV();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        

         int Key = 0;
        //private string selectedOption;

        private void TasksListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TaskName.Text = TasksListDGV.SelectedRows[0].Cells[1].Value.ToString();
            Owner.Text = TasksListDGV.SelectedRows[0].Cells[2].Value.ToString();
            StartDate.Text = TasksListDGV.SelectedRows[0].Cells[3].Value.ToString();
            DueDate.Text = TasksListDGV.SelectedRows[0].Cells[4].Value.ToString();
            Timeline.Text = TasksListDGV.SelectedRows[0].Cells[5].Value.ToString();
            Category.SelectedItem = TasksListDGV.SelectedRows[0].Cells[6].Value.ToString();
            Priority.SelectedItem = TasksListDGV.SelectedRows[0].Cells[7].Value.ToString();
            Status.SelectedItem = TasksListDGV.SelectedRows[0].Cells[8].Value.ToString();
            Note.Text = TasksListDGV.SelectedRows[0].Cells[9].Value.ToString();
            Files.Text = TasksListDGV.SelectedRows[0].Cells[10].Value.ToString();


            if (TaskName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TasksListDGV.SelectedRows[0].Cells[10].Value.ToString());
            }

            
            if (e.ColumnIndex == TasksListDGV.Columns["Files"].Index && e.RowIndex >= 0)
            {
                string filePath = TasksListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

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
        
            
        
        private void DeleteTaskBtn_Click(object sender, EventArgs e)
         {
             if(Key == 0)
             {
                 MessageBox.Show("Please Select the task.");
             }
             else
             {
                 try
                 {
                     Con.Open();
                     SqlCommand cmd = new SqlCommand("Delete from TaskListTb where TaskID= @TaskKey", Con);
                     cmd.Parameters.AddWithValue("@TaskKey", Key);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("The selected Tasks is deleted!");
                     Con.Close();
                     DisplayTasksListDGV();

                 }
                 catch(Exception Ex)
                 {
                     MessageBox.Show(Ex.Message);
                 }
                 
                 
             }
         }

         private void EditTaskBtn_Click(object sender, EventArgs e)
         {
             if (TaskName.Text == "" || Owner.Text == "" || StartDate.Text == "" || DueDate.Text == "" || Timeline.Text == "" || Category.SelectedIndex == -1 || Priority.SelectedIndex == -1 || Status.SelectedIndex == -1 || Note.Text == "" || Files.Text == "")
             {
                 MessageBox.Show("Missing Data!");
             }
             else
             {
                 try
                 {
                     Con.Open();
                     SqlCommand cmd = new SqlCommand("Update TaskListTb set TaskName=@TaskName,Owner=@Owner, StartDate=@StartDate, DueDate=@DueDate,Timeline=@Timeline,Category=@Category, Priority=@Priority, Status=@Status, Note=@Note, Files=@Files",Con);
                     //cmd.Parameters.AddWithValue("@TaskID", TaskID.Text);
                     cmd.Parameters.AddWithValue("@TaskName", TaskName.Text);
                     cmd.Parameters.AddWithValue("@Owner", Owner.Text);
                     cmd.Parameters.AddWithValue("@StartDate", StartDate.Value.Date);
                     cmd.Parameters.AddWithValue("@DueDate", DueDate.Value.Date);
                     cmd.Parameters.AddWithValue("@Timeline", Timeline.Text);
                     cmd.Parameters.AddWithValue("@Category", Category.SelectedItem.ToString());
                     cmd.Parameters.AddWithValue("@Priority", Priority.SelectedItem.ToString());
                     cmd.Parameters.AddWithValue("@Status", Status.SelectedItem.ToString());
                     cmd.Parameters.AddWithValue("@Note", Note.Text);
                     cmd.Parameters.AddWithValue("@Files", Files.Text);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Task is Updated");
                     Con.Close();
                     DisplayTasksListDGV();
                     Reset();
                 }
                 catch(Exception Ex)
                 {
                     MessageBox.Show(Ex.Message);
                 }
                 
             }
             
         }

        private void AddFileBtn_Click(object sender, EventArgs e)
        {
            Files FilesForm = new Files();
            //this.Hide();
            FilesForm.Task2Form = this;
            FilesForm.ShowDialog();
        }

        private void Files_TextChanged(string FileName)
        {
            //Files.Text = FileName;
        }

        public void SetFileName(string FileName)
        {
            Files.Text = FileName;
        }

        private void TasksListDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            Invitation InvitationForm = new Invitation();
            this.Hide();
            InvitationForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Methods MethodsForm = new Methods();
            this.Hide();
            MethodsForm.Show();
        }

        private void TaskName_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
