using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Diagnostics.Metrics;
using System.Data.SqlClient;
using System.Configuration;
namespace TaskManagement1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
            Password.UseSystemPasswordChar = true;
        }

        
        private void Login_Load(object sender, EventArgs e)
        {
            //if (Username.Text== "")
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\My Documents\Development\FinalProject\DoneDay\TaskManagementApp\TaskManagementApp\taskDb.mdf"";Integrated Security=True;Connect Timeout=30");
            SqlConnection Con = new SqlConnection(TaskManagementApp.Properties.Settings.Default.taskDbConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username = '" + Username.Text + "' and password='" + Password.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                QA1 QA1Form = new QA1();
                QA1Form.Show();
            }
            else
            {
                MessageBox.Show("The Username or Password is incorrect, Please try again.", "alert",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            /**
            if (Username.Text=="Username" && Password.Text=="Password")
            {
                
                Methods MethodsForm = new Methods();
                this.Hide();
                MethodsForm.ShowDialog();
                this.Show();
                
                QA1 QA1Form = new QA1();
                this.Hide();
                QA1Form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("The Username or Password is incorrect, Please try again.");
                Username.Clear();
                Password.Clear();
            }**/
        }
        private void Password_TextChanged(object sender, EventArgs e)
        {
            //Password.PasswordChar = '*';

            //Password.ForeColor = Color.Black;

            Password.UseSystemPasswordChar = true;
        }
    }
}
