using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using TaskManagementApp;

namespace TaskManagement1
{
    public partial class QA3 : Form
    {
        private string selectedOption;
        public QA3(string selectedOption, Dictionary<string, int> counts)
        {
            InitializeComponent();
            this.selectedOption = selectedOption;

            this.BusinessOwnerBtn.Click += new EventHandler(OptionButton_Click);
            this.TeamLeaderBtn.Click += new EventHandler(OptionButton_Click);
            this.TeamMemberBtn.Click += new EventHandler(OptionButton_Click);
            this.DirectorBtn.Click += new EventHandler(OptionButton_Click);
            this.OtherBtn.Click += new EventHandler(OptionButton_Click);
        }

        public QA3(string selectedOption)
        {
            this.selectedOption = selectedOption;
        }

        private static Dictionary<string, int> counts = new Dictionary<string, int>
        {
            {"Business Owner", 0},
            {"Team Leader", 0},
            {"Team Member", 0},
            {"Director", 0},
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
            BusinessOwnerBtn.BackColor = Color.FromName("Control");
            TeamLeaderBtn.BackColor = Color.FromName("Control");
            TeamMemberBtn.BackColor = Color.FromName("Control");
            DirectorBtn.BackColor = Color.FromName("Control");
            OtherBtn.BackColor = Color.FromName("Control");

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            QA2 qa2Form = new QA2(selectedOption); ;
            this.Hide();
            qa2Form.ShowDialog();
        }

        private void NextBtn_Click_1(object sender, EventArgs e)
        {
            counts[selectedOption]++;

            QA4 qa4Form = new QA4(selectedOption); ;
            this.Hide();
            qa4Form.ShowDialog();
        }
    }
}
