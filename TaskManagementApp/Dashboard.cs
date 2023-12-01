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
using TaskManagementApp;
using System.Management.Instrumentation;

namespace TaskManagement1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\My Documents\Development\FinalProject\DoneDay\TaskManagementApp\TaskManagementApp\taskDb.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(TaskManagementApp.Properties.Settings.Default.taskDbConnectionString);

        //private string selectedOption;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public void CountTasks()
        {
            Con.Open();
            string Query = "Select * from TaskListTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            NumTasks.Text = dataTable.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountProjects()
        {
            Con.Open();
            string Query = "Select * from ProjectListTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            NumProjects.Text = dataTable.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountEvents()
        {
            Con.Open();
            string Query = "Select * from EventListTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            NumEvents.Text = dataTable.Rows[0][0].ToString();
            Con.Close();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountTasks();
            CountProjects();
            CountEvents();
        }

        private void TaskNameList_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void TStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTaskList();
        }

        private void DisplayTaskList()
        {
            if (TStatus.SelectedItem == null)
            {
                return; 
            }
            string selectedStatus = TStatus.SelectedItem.ToString();
            Tasks taskListForm = new Tasks(); 
            DataGridViewRowCollection rows = taskListForm.GetAllTasks(); 

            StringBuilder taskNames = new StringBuilder();
            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells["Status"].Value != null && row.Cells["TaskName"].Value != null)
                {
                    if (row.Cells["Status"].Value.ToString().Equals(selectedStatus, StringComparison.OrdinalIgnoreCase))
                    {
                        taskNames.AppendLine(row.Cells["TaskName"].Value.ToString());
                    }
                }
            }

            TaskNameList.Text = taskNames.ToString();
        }
        private void ProjectNameList_TextChanged(object sender, EventArgs e)
        {

        }
        private void PStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayProjectList();
        }
        private void DisplayProjectList()
        {
            if (TStatus.SelectedItem == null)
            {
                return;
            }
            string selectedStatus = TStatus.SelectedItem.ToString();
            Project projectListForm = new Project();
            DataGridViewRowCollection rows = projectListForm.GetAllProjects();

            StringBuilder projectNames = new StringBuilder();
            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells["Status"].Value != null && row.Cells["ProjectName"].Value != null)
                {
                    if (row.Cells["Status"].Value.ToString().Equals(selectedStatus, StringComparison.OrdinalIgnoreCase))
                    {
                        projectNames.AppendLine(row.Cells["ProjectName"].Value.ToString());
                    }
                }
            }

            ProjectNameList.Text = projectNames.ToString();
        }

        private void EDate_ValueChanged(object sender, EventArgs e)
        {
            DisplayEventList();
        }
        private void DisplayEventList()
        {
            /**
            if (EDate.Value == null)
            {
                return;
            }
            **/
            //string selectedDate = EventDate.SelectedItem.ToString();
            DateTime selectedDate = EDate.Value.Date;
            //List<Events> allEvents = GetAllEvents();
            Events eventListForm = new Events();
            DataGridViewRowCollection rows = eventListForm.GetAllEvents();

            StringBuilder eventNames = new StringBuilder();
            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells["Date"].Value != null && row.Cells["EventName"].Value != null)
                {
                    DateTime EventDate;
                    //if (row.Cells["Status"].Value.ToString().Equals(selectedStatus, StringComparison.OrdinalIgnoreCase))
                    if (DateTime.TryParse(row.Cells["Date"].Value.ToString(), out EventDate) && EventDate.Date == selectedDate)
                    {
                        eventNames.AppendLine(row.Cells["EventName"].Value.ToString());
                    }
                }
            }

            EventNameList.Text = eventNames.ToString();
        }
        private void EventNameList_TextChanged(object sender, EventArgs e)
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
    }
}
