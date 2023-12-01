using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement1
{
    public partial class Files : Form
    {
        private string selectedFilePath;
        public Files()
        {
            InitializeComponent();
        }

        private void Files_Load(object sender, EventArgs e)
        {

        }

        private void ChooseFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;

                txtFilePath.Text = selectedFilePath;
            }
        }

        private void OpenFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                Process.Start(new ProcessStartInfo(selectedFilePath) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Please select a file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Tasks Task2Form { get; set; }
        public Project ProjectForm { get; set; }
        private void SaveFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Task2Form != null)
            {
                Task2Form.SetFileName(selectedFilePath); // Assume selectedFileName is the variable holding the file name
            }

            if (ProjectForm != null)
            {
                ProjectForm.SetFileName(selectedFilePath); // Assume selectedFileName is the variable holding the file name
            }


            this.Close(); 
        }

    }
}
