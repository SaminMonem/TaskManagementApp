using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TaskManagement1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            /**
            SqlConnection Con = new SqlConnection(TaskManagementApp.Properties.Settings.Default.taskDbConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from register where FirstNme = '" + FirstName.Text + "' and LastName='" + LastName.Text + "' and Email='" + Email.Text + "' and username = '" + Username.Text + "' and password='" + Password.Text + "' and confirmpassword='" + ConfirmPassword.Text + "'" , Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Login LoginForm = new Login();
                LoginForm.Show();
            }
            else
            {
                MessageBox.Show("Please try again.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            **/
            //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\My Documents\Development\FinalProject\New folder\TaskManagementApp\TaskManagementApp\taskDb.mdf"";Integrated Security=True;Connect Timeout=30");
            //SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where firstName = '" + FirstName.Text + "'" and lastName = '" + LastName.Text + "'" username = '" + Username.Text + "' and password2='" + Password2.Text + "'", Con);
            //string query = "SELECT COUNT(*) FROM login WHERE firstName = @FirstName AND lastName = @LastName AND email = @Email AND username = @Username AND password2 = @Password2 AND password3 = @Password3";
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            /**
            int rowCount = 0; // To store the count of matching records

            using (SqlConnection con = new SqlConnection())
            {
                con.Open();

                // Create a SqlCommand with parameters
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM register WHERE firstName = @FirstName AND lastName = @LastName AND email = @Email AND username = @Username AND password = @Password AND ConfirmPassword = @ConfirmPassword", con))
                {
                    // Set parameter values to prevent SQL injection
                    cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", LastName.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    cmd.Parameters.AddWithValue("@Username", Username.Text);
                    cmd.Parameters.AddWithValue("@Password", Password.Text);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", ConfirmPassword.Text);

                    rowCount = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the count

                    con.Close();
                }
            }
            

            if (FirstName.Text == "FirstName" && LastName.Text == "LastName" && Email.Text == "Email" && Username.Text == "Username" && Password.Text == "Password" && ConfirmPassword.Text == "ConfirmPassword")
            {
                Login LoginForm = new Login();
                this.Hide();
                LoginForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please try again.");
                FirstName.Clear();
                LastName.Clear();
                Email.Clear();
                Username.Clear();
                Password.Clear();
                ConfirmPassword.Clear();

            }
            **/

            using (SqlConnection con = new SqlConnection(TaskManagementApp.Properties.Settings.Default.taskDbConnectionString))
            {
                try
                {
                    con.Open();
                    // Use parameterized queries to prevent SQL Injection
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO register (FirstName, LastName, Email, Username, Password, ConfirmPassword) VALUES (@FirstName, @LastName, @Email, @Username, @Password, @ConfirmPassword)", con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastName.Text);
                        cmd.Parameters.AddWithValue("@Email", Email.Text);
                        cmd.Parameters.AddWithValue("@Username", Username.Text);
                        cmd.Parameters.AddWithValue("@Password", Password.Text);
                        cmd.Parameters.AddWithValue("@ConfirmPassword", ConfirmPassword.Text);


                        var result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Account created successfully.");
                            Login LoginForm = new Login();
                            this.Hide();
                            LoginForm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Account creation failed. Please try again.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
