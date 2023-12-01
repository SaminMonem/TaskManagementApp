using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementApp;

namespace TaskManagement1
{
    public partial class Methods : Form
    {
        //private string selectedOption;
        public Methods()
        {
            InitializeComponent();
        }
        private void CreateTask1_Click(object sender, EventArgs e)
        {
            Tasks Task2Form = new Tasks(); 
            this.Hide();
            Task2Form.ShowDialog();
        }
        private void CreateTask2_Click(object sender, EventArgs e)
        {
            AI AIForm = new AI(); 
            this.Hide();
            AIForm.ShowDialog();
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
