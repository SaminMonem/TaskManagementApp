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
    public partial class QA5 : Form
    {
        private string selectedOption;
        public QA5(string selectedOption)
        {
            InitializeComponent();
            this.selectedOption = selectedOption;

            this.Btn1.Click += new EventHandler(OptionButton_Click);
            this.Btn2.Click += new EventHandler(OptionButton_Click);
            this.Btn3.Click += new EventHandler(OptionButton_Click);
            this.Btn4.Click += new EventHandler(OptionButton_Click);
            this.Btn5.Click += new EventHandler(OptionButton_Click);
            this.Btn6.Click += new EventHandler(OptionButton_Click);
        }

        private static Dictionary<string, int> counts = new Dictionary<string, int>
        {
            {"Only me", 0},
            {"2-10", 0},
            {"10-50", 0},
            {"50-100", 0},
            {"100-500", 0},
            {"More than 500", 0},
            
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
            Btn1.BackColor = Color.FromName("Control");
            Btn2.BackColor = Color.FromName("Control");
            Btn3.BackColor = Color.FromName("Control");
            Btn4.BackColor = Color.FromName("Control");
            Btn5.BackColor = Color.FromName("Control");

        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            QA4 qa4Form = new QA4(selectedOption); ;
            this.Hide();
            qa4Form.ShowDialog();
        }

        private void NextBtn_Click_1(object sender, EventArgs e)
        {
            counts[selectedOption]++;

            QA6 qa6Form = new QA6(selectedOption); ;
            this.Hide();
            qa6Form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
