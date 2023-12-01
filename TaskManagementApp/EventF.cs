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
    public partial class EventF : Form
    {
        String connString = "server=localhost;user id=root;database=db_calendar;ss1mode=none";
        public EventF()
        {
            InitializeComponent();
        }

        private void EventF_Load(object sender, EventArgs e)
        {
            DateC.Text = Calendar.static_year +"/"+Calendar.static_month+"/"+ UserControlDays.static_day;
        }

        private void EventSaveBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO tb1_calendar(date,event)values(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", DateC.Text);
            cmd.Parameters.AddWithValue("event", EventC.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved!");
            cmd.Dispose();
            conn.Close();
        }
    }
}
