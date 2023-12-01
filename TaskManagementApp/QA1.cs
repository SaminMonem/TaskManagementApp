using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementApp;

namespace TaskManagement1
{
    public partial class QA1 : Form
    {
        private string selectedOption;
        public QA1()
        {
            InitializeComponent();

            this.WorkBtn.Click += new EventHandler(OptionButton_Click);
            this.SchoolBtn.Click += new EventHandler(OptionButton_Click);
            this.PersonalBtn.Click += new EventHandler(OptionButton_Click);
            this.PartyBtn.Click += new EventHandler(OptionButton_Click);
            this.OtherBtn.Click += new EventHandler(OptionButton_Click);
        }

        private static Dictionary<string, int> counts = new Dictionary<string, int>
        {
            {"Work/Company", 0},
            {"School/University", 0},
            {"Personal/Daily life", 0},
            {"Party/Gathering", 0},
            {"Other", 0}
        };
    
        private void OptionButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            Button selectedButton = sender as Button;
            selectedButton.BackColor = Color.LightBlue; 
            selectedOption = selectedButton.Text;

            NextBtn.Enabled = true;

            if (counts.ContainsKey(selectedOption))
            {
                counts[selectedOption]++;
            }
            else
            {
                counts.Add(selectedOption, 1);
            }
        }

        private void ResetButtonColors()
        {
            WorkBtn.BackColor = Color.FromName("Control");
            SchoolBtn.BackColor = Color.FromName("Control");
            PersonalBtn.BackColor = Color.FromName("Control");
            PartyBtn.BackColor = Color.FromName("Control");
            OtherBtn.BackColor = Color.FromName("Control");
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedOption))
            {
                counts[selectedOption]++;
                QA2 qa2Form = new QA2(selectedOption, counts);
                this.Hide();
                qa2Form.ShowDialog();
                this.Show();
            }

            else
            {
                MessageBox.Show("Please select an option before proceeding.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            this.Hide();
            LoginForm.ShowDialog();
            this.Show();
        }
    }

}
