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

    public partial class QA2 : Form
    {
        private string selectedOption;

        public QA2(string selectedOption, Dictionary<string, int> counts)
        {
            InitializeComponent();
            this.selectedOption = selectedOption;

            this.OwnBtn.Click += new EventHandler(OptionButton_Click);
            this.GroupBtn.Click += new EventHandler(OptionButton_Click);
           
        }

        public QA2(string selectedOption)
        {
            this.selectedOption = selectedOption;
        }

        private static Dictionary<string, int> counts = new Dictionary<string, int>
        {
            {"For My Own", 0},
            {"For Group", 0},
            
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
            OwnBtn.BackColor = Color.FromName("Control");
            GroupBtn.BackColor = Color.FromName("Control");
           
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            QA1 qa1Form = new QA1();
            this.Hide();
            qa1Form.ShowDialog();
            this.Show();
        }

        private void NextBtn_Click_1(object sender, EventArgs e)
        {
            counts[selectedOption]++;

            QA3 qa3Form = new QA3(selectedOption, counts);
            this.Hide();
            qa3Form.ShowDialog();
        }
    }
}
