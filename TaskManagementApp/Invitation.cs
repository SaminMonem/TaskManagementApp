using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement1
{
    public partial class Invitation : Form
    {
        public Invitation(string selectedOption)
        {
            InitializeComponent();
        }

        public Invitation()
        {
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            Methods TaskForm = new Methods(); ;
            this.Hide();
            TaskForm.ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            QA7 QA7Form = new QA7(); 
            this.Hide();
            QA7Form.ShowDialog();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The invitation email is sent", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The invitation email is sent", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The invitation email is sent", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
