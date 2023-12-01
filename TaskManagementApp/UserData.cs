using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement1;

namespace TaskManagementApp
{
    public partial class UserData : Form
    {
        public UserData()
        {
            InitializeComponent();
        }

        private Dictionary<string, int> optionCounts;
        private string selectedOption;

        public UserData(Dictionary<string, int> optionCounts)
        {
            InitializeComponent();
            this.optionCounts = optionCounts;
        }

        

        private void UserData_Load(object sender, EventArgs e)
        {
            //int totalCount = optionCounts.Values.Sum();
            //foreach (var option in optionCounts)
            {
                //double percentage = (double)option.Value / totalCount * 100;
                //AreaChart.Series["Area"].Points.AddXY(option.Key, percentage);
                AreaChart.Series["Area"].Points.AddXY("Work/University", 1000);
                AreaChart.Series["Area"].Points.AddXY("School/University", 3000);
                AreaChart.Series["Area"].Points.AddXY("Personal/Daily life", 5000);
                AreaChart.Series["Area"].Points.AddXY("Party/Gathering", 2000);
                AreaChart.Series["Area"].Points.AddXY("Other", 1000);
            }
            
            
            GroupTypeChart.Series["Group Type"].Points.AddXY("For My Own", 2000);
            GroupTypeChart.Series["Group Type"].Points.AddXY("For Group", 7000);

            CurrentRoleChart.Series["Current Role"].Points.AddXY("Business Owner", 5000);
            CurrentRoleChart.Series["Current Role"].Points.AddXY("Team Leader", 2000);
            CurrentRoleChart.Series["Current Role"].Points.AddXY("Team Member", 3000);
            CurrentRoleChart.Series["Current Role"].Points.AddXY("Director", 6000);
            CurrentRoleChart.Series["Current Role"].Points.AddXY("Other", 1000);

            CareerLevelChart.Series["Career Level"].Points.AddXY("Internship", 2000);
            CareerLevelChart.Series["Career Level"].Points.AddXY("Entry-level", 2000);
            CareerLevelChart.Series["Career Level"].Points.AddXY("Mid-level", 2000);
            CareerLevelChart.Series["Career Level"].Points.AddXY("Senioe/Excutive-level", 2000);
            CareerLevelChart.Series["Career Level"].Points.AddXY("Other", 2000);

            TeamMemberChart.Series["Team Member"].Points.AddXY("Only me", 2000);
            TeamMemberChart.Series["Team Member"].Points.AddXY("2-10", 3000);
            TeamMemberChart.Series["Team Member"].Points.AddXY("10-50", 2000);
            TeamMemberChart.Series["Team Member"].Points.AddXY("50-100", 4000);
            TeamMemberChart.Series["Team Member"].Points.AddXY("100-500", 2000);
            TeamMemberChart.Series["Team Member"].Points.AddXY("More than 500", 5000);

            CompanyMemberChart.Series["Company Member"].Points.AddXY("Only me", 2000);
            CompanyMemberChart.Series["Company Member"].Points.AddXY("2-10", 600);
            CompanyMemberChart.Series["Company Member"].Points.AddXY("10-50", 2000);
            CompanyMemberChart.Series["Company Member"].Points.AddXY("50-100", 7000);
            CompanyMemberChart.Series["Company Member"].Points.AddXY("100-500", 2000);
            CompanyMemberChart.Series["Company Member"].Points.AddXY("More than 500", 500);

            TaskAreaChart.Series["Task Area"].Points.AddXY("Marketing", 4000);
            TaskAreaChart.Series["Task Area"].Points.AddXY("HR and Recruiting", 5000);
            TaskAreaChart.Series["Task Area"].Points.AddXY("IT", 2000);
            TaskAreaChart.Series["Task Area"].Points.AddXY("Finance", 2000);
            TaskAreaChart.Series["Task Area"].Points.AddXY("Education", 2000);
            TaskAreaChart.Series["Task Area"].Points.AddXY("Design and Creative", 3000);
            TaskAreaChart.Series["Task Area"].Points.AddXY("Software Engineering", 2000);
            TaskAreaChart.Series["Task Area"].Points.AddXY("Sales and CRM", 800);
            TaskAreaChart.Series["Task Area"].Points.AddXY("Construction", 1000);
            TaskAreaChart.Series["Task Area"].Points.AddXY("Other", 2000);
            
        }

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
    }
}
