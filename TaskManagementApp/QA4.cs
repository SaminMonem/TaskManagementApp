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
    public partial class QA4 : Form
    {
        private string selectedOption;

        public QA4(string selectedOption)
        {
            InitializeComponent();
            this.selectedOption = selectedOption;

            this.InternshipBtn.Click += new EventHandler(OptionButton_Click);
            this.EntryLevelBtn.Click += new EventHandler(OptionButton_Click);
            this.MidLevelBtn.Click += new EventHandler(OptionButton_Click);
            this.SeniorBtn.Click += new EventHandler(OptionButton_Click);
            this.OtherBtn.Click += new EventHandler(OptionButton_Click);
        }

        private static Dictionary<string, int> counts = new Dictionary<string, int>
        {
            {"Internship", 0},
            {"Entry-level", 0},
            {"Mid-level", 0},
            {"Senior/Excutive-level", 0},
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
            InternshipBtn.BackColor = Color.FromName("Control");
            EntryLevelBtn.BackColor = Color.FromName("Control");
            MidLevelBtn.BackColor = Color.FromName("Control");
            SeniorBtn.BackColor = Color.FromName("Control");
            OtherBtn.BackColor = Color.FromName("Control");

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            QA3 qa3Form = new QA3(selectedOption); 
            this.Hide();
            qa3Form.ShowDialog();
        }

        private void NextBtn_Click_1(object sender, EventArgs e)
        {
            counts[selectedOption]++;

            QA5 qa5Form = new QA5(selectedOption);
            this.Hide();
            qa5Form.ShowDialog();
        }
    }
}
