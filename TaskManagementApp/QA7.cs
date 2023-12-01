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
    public partial class QA7 : Form
    {
        private string selectedOption;

        public QA7(string selectedOption)
        {
            InitializeComponent();
            this.selectedOption = selectedOption;

            this.MarketingBtn.Click += new EventHandler(OptionButton_Click);
            this.HRBtn.Click += new EventHandler(OptionButton_Click);
            this.ITBtn.Click += new EventHandler(OptionButton_Click);
            this.FinanceBtn.Click += new EventHandler(OptionButton_Click);
            this.EducationBtn.Click += new EventHandler(OptionButton_Click);
            this.DesignBtn.Click += new EventHandler(OptionButton_Click);
            this.SoftwareBtn.Click += new EventHandler(OptionButton_Click);
            this.SaleCRMBtn.Click += new EventHandler(OptionButton_Click);
            this.ConstructionBtn.Click += new EventHandler(OptionButton_Click);
            this.OtherBtn.Click += new EventHandler(OptionButton_Click);
        }
        public QA7()
        {
        }

        private static Dictionary<string, int> counts = new Dictionary<string, int>
        {
            {"Marketing", 0},
            {"HR and Recruiting", 0},
            {"IT", 0},
            {"Finance", 0},
            {"Education", 0},
            {"Design and Creative", 0},
            {"Software Engineering", 0},
            {"Sales and CRM", 0},
            {"Construction", 0},
            {"Other", 0},
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
            MarketingBtn.BackColor = Color.FromName("Control");
            HRBtn.BackColor = Color.FromName("Control");
            ITBtn.BackColor = Color.FromName("Control");
            FinanceBtn.BackColor = Color.FromName("Control");
            EducationBtn.BackColor = Color.FromName("Control");
            DesignBtn.BackColor = Color.FromName("Control");
            SoftwareBtn.BackColor = Color.FromName("Control");
            SaleCRMBtn.BackColor = Color.FromName("Control");
            ConstructionBtn.BackColor = Color.FromName("Control");
            OtherBtn.BackColor = Color.FromName("Control");
        }
        private void NextBtn_Click_1(object sender, EventArgs e)
        {
            counts[selectedOption]++;

            Invitation InvitationForm = new Invitation(selectedOption); ;
            this.Hide();
            InvitationForm.ShowDialog();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            QA6 qa6Form = new QA6(selectedOption); ;
            this.Hide();
            qa6Form.ShowDialog();
        }
    }
}
