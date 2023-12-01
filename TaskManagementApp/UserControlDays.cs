using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TaskManagementApp
{
    public partial class UserControlDays : UserControl
    {
        String connString = "server=localhost;user id=root;database=db_calendar;ss1mode=none";

        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            bdays.Text = numday + "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = bdays.Text;
            timer1.Start();
            EventF eventc = new EventF();
            eventc.Show();
        }

        private void displayEvent()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "SELECT * FROM tb1_calendar where date = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", Calendar.static_year + "/" + Calendar.static_month + "/" + bdays.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                bdays.Text = reader["eventC"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }

}
