using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement1;
using static System.Windows.Forms.AxHost;

namespace TaskManagementApp
{
    public partial class Calendar : Form
    {
        int month, year;
        public static int static_month, static_year;
        public Calendar()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        public void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            bDate.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i =1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
            
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

        private void InviteBtn_Click(object sender, EventArgs e)
        {
            Invitation InvitationForm = new Invitation();
            this.Hide();
            InvitationForm.Show();
        }

        private void EventList_Click(object sender, EventArgs e)
        {
            Events EventsForm = new Events();
            this.Hide();
            EventsForm.Show();
            
        }

        private void CBackBtn_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            bDate.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void CNextBtn_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            bDate.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

        }
    }
    
}
