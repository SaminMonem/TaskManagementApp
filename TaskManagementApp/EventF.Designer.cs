﻿namespace TaskManagementApp
{
    partial class EventF
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateC = new System.Windows.Forms.TextBox();
            this.EventC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EventSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateC
            // 
            this.DateC.Enabled = false;
            this.DateC.Location = new System.Drawing.Point(49, 68);
            this.DateC.Name = "DateC";
            this.DateC.Size = new System.Drawing.Size(305, 20);
            this.DateC.TabIndex = 0;
            // 
            // EventC
            // 
            this.EventC.Location = new System.Drawing.Point(49, 124);
            this.EventC.Name = "EventC";
            this.EventC.Size = new System.Drawing.Size(305, 20);
            this.EventC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event";
            // 
            // EventSaveBtn
            // 
            this.EventSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EventSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventSaveBtn.Location = new System.Drawing.Point(167, 172);
            this.EventSaveBtn.Name = "EventSaveBtn";
            this.EventSaveBtn.Size = new System.Drawing.Size(75, 31);
            this.EventSaveBtn.TabIndex = 4;
            this.EventSaveBtn.Text = "Save";
            this.EventSaveBtn.UseVisualStyleBackColor = false;
            this.EventSaveBtn.Click += new System.EventHandler(this.EventSaveBtn_Click);
            // 
            // EventF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(408, 224);
            this.Controls.Add(this.EventSaveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventC);
            this.Controls.Add(this.DateC);
            this.Name = "EventF";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.EventF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DateC;
        private System.Windows.Forms.TextBox EventC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EventSaveBtn;
    }
}