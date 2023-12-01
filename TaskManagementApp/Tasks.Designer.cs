
using System.Windows.Forms;

namespace TaskManagement1
{
    partial class Tasks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.InviteBtn = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddFileBtn = new System.Windows.Forms.Button();
            this.CreateTaskBtn = new System.Windows.Forms.Button();
            this.DeleteTaskBtn = new System.Windows.Forms.Button();
            this.EditTaskBtn = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.ComboBox();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.cat = new System.Windows.Forms.TextBox();
            this.Priority = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.Files = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.Due_Date = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.Timeline = new System.Windows.Forms.TextBox();
            this.Srart_Date = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.Owner = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.TasksListDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.ChartsM = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.CalendarM = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ProjectsM = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TasksM = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DashboardM = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.InviteBtn.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksListDGV)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // InviteBtn
            // 
            this.InviteBtn.BackColor = System.Drawing.Color.White;
            this.InviteBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InviteBtn.Controls.Add(this.button2);
            this.InviteBtn.Controls.Add(this.button1);
            this.InviteBtn.Controls.Add(this.textBox7);
            this.InviteBtn.Location = new System.Drawing.Point(116, 0);
            this.InviteBtn.Name = "InviteBtn";
            this.InviteBtn.Size = new System.Drawing.Size(1308, 43);
            this.InviteBtn.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(112)))), ((int)(((byte)(160)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1081, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "+ Create new";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(112)))), ((int)(((byte)(160)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1191, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "+ Invite";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(7, 6);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 24);
            this.textBox7.TabIndex = 0;
            this.textBox7.Text = "Tasks";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.AddFileBtn);
            this.panel3.Controls.Add(this.CreateTaskBtn);
            this.panel3.Controls.Add(this.DeleteTaskBtn);
            this.panel3.Controls.Add(this.EditTaskBtn);
            this.panel3.Controls.Add(this.Category);
            this.panel3.Controls.Add(this.DueDate);
            this.panel3.Controls.Add(this.StartDate);
            this.panel3.Controls.Add(this.cat);
            this.panel3.Controls.Add(this.Priority);
            this.panel3.Controls.Add(this.Status);
            this.panel3.Controls.Add(this.textBox23);
            this.panel3.Controls.Add(this.Files);
            this.panel3.Controls.Add(this.textBox25);
            this.panel3.Controls.Add(this.Note);
            this.panel3.Controls.Add(this.textBox19);
            this.panel3.Controls.Add(this.textBox15);
            this.panel3.Controls.Add(this.Due_Date);
            this.panel3.Controls.Add(this.textBox13);
            this.panel3.Controls.Add(this.Timeline);
            this.panel3.Controls.Add(this.Srart_Date);
            this.panel3.Controls.Add(this.textBox9);
            this.panel3.Controls.Add(this.Owner);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.TaskName);
            this.panel3.Location = new System.Drawing.Point(135, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 696);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // AddFileBtn
            // 
            this.AddFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFileBtn.ForeColor = System.Drawing.Color.Black;
            this.AddFileBtn.Location = new System.Drawing.Point(335, 550);
            this.AddFileBtn.Name = "AddFileBtn";
            this.AddFileBtn.Size = new System.Drawing.Size(47, 36);
            this.AddFileBtn.TabIndex = 45;
            this.AddFileBtn.Text = "Add";
            this.AddFileBtn.UseVisualStyleBackColor = false;
            this.AddFileBtn.Click += new System.EventHandler(this.AddFileBtn_Click);
            // 
            // CreateTaskBtn
            // 
            this.CreateTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(112)))), ((int)(((byte)(160)))));
            this.CreateTaskBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTaskBtn.ForeColor = System.Drawing.Color.White;
            this.CreateTaskBtn.Location = new System.Drawing.Point(246, 622);
            this.CreateTaskBtn.Name = "CreateTaskBtn";
            this.CreateTaskBtn.Size = new System.Drawing.Size(136, 40);
            this.CreateTaskBtn.TabIndex = 44;
            this.CreateTaskBtn.Text = "Create Task";
            this.CreateTaskBtn.UseVisualStyleBackColor = false;
            this.CreateTaskBtn.Click += new System.EventHandler(this.CreateTaskBtn_Click_1);
            // 
            // DeleteTaskBtn
            // 
            this.DeleteTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(112)))), ((int)(((byte)(160)))));
            this.DeleteTaskBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTaskBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteTaskBtn.Location = new System.Drawing.Point(124, 622);
            this.DeleteTaskBtn.Name = "DeleteTaskBtn";
            this.DeleteTaskBtn.Size = new System.Drawing.Size(96, 40);
            this.DeleteTaskBtn.TabIndex = 43;
            this.DeleteTaskBtn.Text = "Delete Task";
            this.DeleteTaskBtn.UseVisualStyleBackColor = false;
            // 
            // EditTaskBtn
            // 
            this.EditTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(112)))), ((int)(((byte)(160)))));
            this.EditTaskBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTaskBtn.ForeColor = System.Drawing.Color.White;
            this.EditTaskBtn.Location = new System.Drawing.Point(22, 622);
            this.EditTaskBtn.Name = "EditTaskBtn";
            this.EditTaskBtn.Size = new System.Drawing.Size(96, 40);
            this.EditTaskBtn.TabIndex = 42;
            this.EditTaskBtn.Text = "Edit Task";
            this.EditTaskBtn.UseVisualStyleBackColor = false;
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "IT",
            "Education",
            "Marketing",
            "HR",
            "Finance",
            "Design ",
            "Engineering",
            "Sales and CRM",
            "Operation",
            "Construction",
            "Project Management",
            "Other"});
            this.Category.Location = new System.Drawing.Point(222, 256);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(160, 21);
            this.Category.TabIndex = 36;
            // 
            // DueDate
            // 
            this.DueDate.Location = new System.Drawing.Point(222, 186);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(157, 20);
            this.DueDate.TabIndex = 35;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(24, 188);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(157, 20);
            this.StartDate.TabIndex = 34;
            // 
            // cat
            // 
            this.cat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cat.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat.Location = new System.Drawing.Point(222, 236);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(75, 16);
            this.cat.TabIndex = 33;
            this.cat.Text = "Category";
            // 
            // Priority
            // 
            this.Priority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.Priority.FormattingEnabled = true;
            this.Priority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.Priority.Location = new System.Drawing.Point(222, 329);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(160, 21);
            this.Priority.TabIndex = 31;
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Not Started",
            "In Process",
            "Completed"});
            this.Status.Location = new System.Drawing.Point(21, 329);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(160, 21);
            this.Status.TabIndex = 30;
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(21, 532);
            this.textBox23.Name = "textBox23";
            this.textBox23.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox23.Size = new System.Drawing.Size(75, 16);
            this.textBox23.TabIndex = 27;
            this.textBox23.Text = "Files";
            // 
            // Files
            // 
            this.Files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.Files.Location = new System.Drawing.Point(21, 550);
            this.Files.Multiline = true;
            this.Files.Name = "Files";
            this.Files.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Files.Size = new System.Drawing.Size(315, 36);
            this.Files.TabIndex = 26;
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox25.Location = new System.Drawing.Point(21, 387);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(75, 16);
            this.textBox25.TabIndex = 25;
            this.textBox25.Text = "Note";
            // 
            // Note
            // 
            this.Note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.Note.Location = new System.Drawing.Point(21, 405);
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(361, 106);
            this.Note.TabIndex = 24;
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(21, 307);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(75, 16);
            this.textBox19.TabIndex = 23;
            this.textBox19.Text = "Status";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(222, 307);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(75, 16);
            this.textBox15.TabIndex = 21;
            this.textBox15.Text = "Priority";
            // 
            // Due_Date
            // 
            this.Due_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Due_Date.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Due_Date.Location = new System.Drawing.Point(222, 164);
            this.Due_Date.Name = "Due_Date";
            this.Due_Date.Size = new System.Drawing.Size(75, 16);
            this.Due_Date.TabIndex = 19;
            this.Due_Date.Text = "Due Date";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(21, 235);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(75, 16);
            this.textBox13.TabIndex = 17;
            this.textBox13.Text = "Timeline";
            // 
            // Timeline
            // 
            this.Timeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.Timeline.Location = new System.Drawing.Point(21, 255);
            this.Timeline.Multiline = true;
            this.Timeline.Name = "Timeline";
            this.Timeline.Size = new System.Drawing.Size(160, 25);
            this.Timeline.TabIndex = 16;
            // 
            // Srart_Date
            // 
            this.Srart_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Srart_Date.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Srart_Date.Location = new System.Drawing.Point(21, 164);
            this.Srart_Date.Name = "Srart_Date";
            this.Srart_Date.Size = new System.Drawing.Size(75, 16);
            this.Srart_Date.TabIndex = 15;
            this.Srart_Date.Text = "Start Date";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(21, 91);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(75, 16);
            this.textBox9.TabIndex = 13;
            this.textBox9.Text = "Owner";
            // 
            // Owner
            // 
            this.Owner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.Owner.Location = new System.Drawing.Point(21, 109);
            this.Owner.Multiline = true;
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(361, 36);
            this.Owner.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(22, 16);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(280, 16);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "Task Name";
            // 
            // TaskName
            // 
            this.TaskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.TaskName.Location = new System.Drawing.Point(21, 33);
            this.TaskName.Multiline = true;
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(361, 36);
            this.TaskName.TabIndex = 10;
            this.TaskName.TextChanged += new System.EventHandler(this.TaskName_TextChanged);
            // 
            // TasksListDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TasksListDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TasksListDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TasksListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TasksListDGV.ColumnHeadersHeight = 22;
            this.TasksListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TasksListDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TasksListDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TasksListDGV.Location = new System.Drawing.Point(568, 93);
            this.TasksListDGV.Name = "TasksListDGV";
            this.TasksListDGV.RowHeadersVisible = false;
            this.TasksListDGV.Size = new System.Drawing.Size(802, 660);
            this.TasksListDGV.TabIndex = 13;
            this.TasksListDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TasksListDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TasksListDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TasksListDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TasksListDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TasksListDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TasksListDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TasksListDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TasksListDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TasksListDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksListDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TasksListDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TasksListDGV.ThemeStyle.HeaderStyle.Height = 22;
            this.TasksListDGV.ThemeStyle.ReadOnly = false;
            this.TasksListDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TasksListDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TasksListDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksListDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TasksListDGV.ThemeStyle.RowsStyle.Height = 22;
            this.TasksListDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TasksListDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TasksListDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksListDGV_CellContentClick_1);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(568, 58);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(802, 34);
            this.textBox6.TabIndex = 37;
            this.textBox6.Text = "Tasks List";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.pictureBox11);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pictureBox12);
            this.panel5.Location = new System.Drawing.Point(0, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(117, 791);
            this.panel5.TabIndex = 50;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.ChartsM);
            this.panel10.Controls.Add(this.pictureBox4);
            this.panel10.Location = new System.Drawing.Point(-3, 405);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(114, 51);
            this.panel10.TabIndex = 28;
            // 
            // ChartsM
            // 
            this.ChartsM.AutoSize = true;
            this.ChartsM.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartsM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChartsM.Location = new System.Drawing.Point(45, 17);
            this.ChartsM.Name = "ChartsM";
            this.ChartsM.Size = new System.Drawing.Size(42, 15);
            this.ChartsM.TabIndex = 16;
            this.ChartsM.Text = "Charts";
            this.ChartsM.Click += new System.EventHandler(this.ChartsM_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.CalendarM);
            this.panel9.Controls.Add(this.pictureBox5);
            this.panel9.Location = new System.Drawing.Point(-3, 331);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(114, 51);
            this.panel9.TabIndex = 28;
            // 
            // CalendarM
            // 
            this.CalendarM.AutoSize = true;
            this.CalendarM.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CalendarM.Location = new System.Drawing.Point(45, 17);
            this.CalendarM.Name = "CalendarM";
            this.CalendarM.Size = new System.Drawing.Size(55, 15);
            this.CalendarM.TabIndex = 16;
            this.CalendarM.Text = "Calendar";
            this.CalendarM.Click += new System.EventHandler(this.CalendarM_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 49);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.ProjectsM);
            this.panel8.Controls.Add(this.pictureBox6);
            this.panel8.Location = new System.Drawing.Point(-3, 258);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(114, 51);
            this.panel8.TabIndex = 35;
            // 
            // ProjectsM
            // 
            this.ProjectsM.AutoSize = true;
            this.ProjectsM.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProjectsM.Location = new System.Drawing.Point(47, 18);
            this.ProjectsM.Name = "ProjectsM";
            this.ProjectsM.Size = new System.Drawing.Size(51, 15);
            this.ProjectsM.TabIndex = 38;
            this.ProjectsM.Text = "Projects";
            this.ProjectsM.Click += new System.EventHandler(this.ProjectsM_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-5, -13);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(66, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 36;
            this.pictureBox6.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TasksM);
            this.panel7.Controls.Add(this.pictureBox10);
            this.panel7.Location = new System.Drawing.Point(-3, 184);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 51);
            this.panel7.TabIndex = 17;
            // 
            // TasksM
            // 
            this.TasksM.AutoSize = true;
            this.TasksM.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TasksM.Location = new System.Drawing.Point(45, 17);
            this.TasksM.Name = "TasksM";
            this.TasksM.Size = new System.Drawing.Size(34, 15);
            this.TasksM.TabIndex = 16;
            this.TasksM.Text = "Tasks";
            this.TasksM.Click += new System.EventHandler(this.TasksM_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(2, 5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(43, 38);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(-3, 110);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(48, 51);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 25;
            this.pictureBox11.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DashboardM);
            this.panel6.Location = new System.Drawing.Point(-2, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(114, 51);
            this.panel6.TabIndex = 16;
            // 
            // DashboardM
            // 
            this.DashboardM.AutoSize = true;
            this.DashboardM.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DashboardM.Location = new System.Drawing.Point(45, 17);
            this.DashboardM.Name = "DashboardM";
            this.DashboardM.Size = new System.Drawing.Size(65, 15);
            this.DashboardM.TabIndex = 16;
            this.DashboardM.Text = "Dashboard";
            this.DashboardM.Click += new System.EventHandler(this.DashboardM_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(-4, -16);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(120, 120);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 24;
            this.pictureBox12.TabStop = false;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1419, 781);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.TasksListDGV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.InviteBtn);
            this.Name = "Tasks";
            this.Text = "TaskList";
            this.InviteBtn.ResumeLayout(false);
            this.InviteBtn.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksListDGV)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel InviteBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox Owner;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox Timeline;
        private System.Windows.Forms.TextBox Srart_Date;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox Due_Date;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox Files;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox Note;
        //private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        //private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.TextBox cat;
        private System.Windows.Forms.ComboBox Priority;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker DueDate;
        private System.Windows.Forms.ComboBox Category;
        private Guna.UI2.WinForms.Guna2DataGridView TasksListDGV;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button CreateTaskBtn;
        private System.Windows.Forms.Button DeleteTaskBtn;
        private System.Windows.Forms.Button EditTaskBtn;
        private System.Windows.Forms.Button AddFileBtn;
        private Panel panel5;
        private Panel panel10;
        private Label ChartsM;
        private PictureBox pictureBox4;
        private Panel panel9;
        private Label CalendarM;
        private PictureBox pictureBox5;
        private Panel panel8;
        private Label ProjectsM;
        private PictureBox pictureBox6;
        private Panel panel7;
        private Label TasksM;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private Panel panel6;
        private Label DashboardM;
        private PictureBox pictureBox12;
        private Button button2;
    }
}