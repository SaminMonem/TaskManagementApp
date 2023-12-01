namespace TaskManagement1
{
    internal class Tasks2 : Tasks
    {
        private string selectedOption;

        public Tasks2(string selectedOption)
        {
            this.selectedOption = selectedOption;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Tasks2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1433, 781);
            this.Name = "Tasks2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}