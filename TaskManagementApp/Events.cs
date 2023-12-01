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
using TaskManagement1;
using System.Runtime.InteropServices.ComTypes;

namespace TaskManagementApp
{
    public partial class Events : Form
    {
        public DataGridViewRowCollection GetAllEvents()
        {
            return EventsListDGV.Rows;
        }
        public Events()
        {
            InitializeComponent();
            DisplayEventsListDGV();
        }

        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\My Documents\Development\FinalProject\DoneDay\TaskManagementApp\TaskManagementApp\taskDb.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(TaskManagementApp.Properties.Settings.Default.taskDbConnectionString);

        private void DisplayEventsListDGV()
        {
            Con.Open();
            string Query = "Select * from EventListTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EventsListDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            Key = 0;
            EventName.Text = "";
            EventDate.Text = "";
          

        }
        private void CreateEventBtn_Click(object sender, EventArgs e)
        {
            if (EventName.Text == "" ||  EventDate.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EventListTb(EventName,EventDate) values (@EventName,@EventDate)", Con);
                    cmd.Parameters.AddWithValue("@EventName", EventName.Text);
                    cmd.Parameters.AddWithValue("@EventDate", EventDate.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event is added.");
                    Con.Close();
                    DisplayEventsListDGV();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }

        int Key = 0;
        private string selectedOption;

        private void EventsListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EventName.Text = EventsListDGV.SelectedRows[0].Cells[1].Value.ToString();
            EventDate.Text = EventsListDGV.SelectedRows[0].Cells[2].Value.ToString();
            
            if (EventName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EventsListDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteEventBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Please Select the Event.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from EventListTb where EventId= @EventKey", Con);
                    cmd.Parameters.AddWithValue("@EventKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The selected Event is deleted!");
                    Con.Close();
                    DisplayEventsListDGV();
                    Reset();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditEventBtn_Click(object sender, EventArgs e)
        {
            if (EventName.Text == "" ||  EventDate.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EventListTb set EventName=@EventName, EventDate=@EventDate", Con);
                    cmd.Parameters.AddWithValue("@EventName", EventName.Text);
                    cmd.Parameters.AddWithValue("@EventDate", EventDate.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event is Updated");
                    Con.Close();
                    DisplayEventsListDGV();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

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
    }
}
