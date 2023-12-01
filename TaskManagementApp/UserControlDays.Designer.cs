namespace TaskManagementApp
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bdays = new System.Windows.Forms.Label();
            this.EventText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bdays
            // 
            this.bdays.AutoSize = true;
            this.bdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdays.Location = new System.Drawing.Point(4, 3);
            this.bdays.Name = "bdays";
            this.bdays.Size = new System.Drawing.Size(24, 18);
            this.bdays.TabIndex = 0;
            this.bdays.Text = "00";
            this.bdays.Click += new System.EventHandler(this.label1_Click);
            // 
            // EventText
            // 
            this.EventText.Location = new System.Drawing.Point(7, 31);
            this.EventText.Name = "EventText";
            this.EventText.Size = new System.Drawing.Size(112, 29);
            this.EventText.TabIndex = 1;
            this.EventText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EventText);
            this.Controls.Add(this.bdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(126, 67);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bdays;
        private System.Windows.Forms.Label EventText;
        private System.Windows.Forms.Timer timer1;
    }
}
