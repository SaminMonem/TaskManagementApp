
namespace TaskManagement1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.NumTasks = new System.Windows.Forms.TextBox();
            this.TStatus = new System.Windows.Forms.ComboBox();
            this.TaskNameList = new System.Windows.Forms.TextBox();
            this.ProjectNameList = new System.Windows.Forms.TextBox();
            this.PStatus = new System.Windows.Forms.ComboBox();
            this.NumProjects = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.EventNameList = new System.Windows.Forms.TextBox();
            this.NumEvents = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.TOpenBtn = new System.Windows.Forms.Button();
            this.POpenBtn = new System.Windows.Forms.Button();
            this.EOpenBtn = new System.Windows.Forms.Button();
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
            this.EDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(115, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 43);
            this.panel2.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(162, 82);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(220, 534);
            this.textBox6.TabIndex = 2;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // NumTasks
            // 
            this.NumTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NumTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumTasks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTasks.Location = new System.Drawing.Point(205, 175);
            this.NumTasks.Name = "NumTasks";
            this.NumTasks.Size = new System.Drawing.Size(141, 27);
            this.NumTasks.TabIndex = 4;
            this.NumTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TStatus
            // 
            this.TStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TStatus.FormattingEnabled = true;
            this.TStatus.Items.AddRange(new object[] {
            "Not Started",
            "In Process",
            "Completed"});
            this.TStatus.Location = new System.Drawing.Point(205, 257);
            this.TStatus.Name = "TStatus";
            this.TStatus.Size = new System.Drawing.Size(141, 21);
            this.TStatus.TabIndex = 5;
            this.TStatus.SelectedIndexChanged += new System.EventHandler(this.TStatus_SelectedIndexChanged);
            // 
            // TaskNameList
            // 
            this.TaskNameList.AllowDrop = true;
            this.TaskNameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TaskNameList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameList.Location = new System.Drawing.Point(176, 339);
            this.TaskNameList.Multiline = true;
            this.TaskNameList.Name = "TaskNameList";
            this.TaskNameList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TaskNameList.Size = new System.Drawing.Size(193, 216);
            this.TaskNameList.TabIndex = 7;
            this.TaskNameList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TaskNameList.TextChanged += new System.EventHandler(this.TaskNameList_TextChanged);
            // 
            // ProjectNameList
            // 
            this.ProjectNameList.AllowDrop = true;
            this.ProjectNameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProjectNameList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameList.Location = new System.Drawing.Point(441, 339);
            this.ProjectNameList.Multiline = true;
            this.ProjectNameList.Name = "ProjectNameList";
            this.ProjectNameList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ProjectNameList.Size = new System.Drawing.Size(193, 216);
            this.ProjectNameList.TabIndex = 15;
            this.ProjectNameList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProjectNameList.TextChanged += new System.EventHandler(this.ProjectNameList_TextChanged);
            // 
            // PStatus
            // 
            this.PStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PStatus.FormattingEnabled = true;
            this.PStatus.Items.AddRange(new object[] {
            "Not Started",
            "In Process",
            "Completed"});
            this.PStatus.Location = new System.Drawing.Point(470, 257);
            this.PStatus.Name = "PStatus";
            this.PStatus.Size = new System.Drawing.Size(141, 21);
            this.PStatus.TabIndex = 13;
            this.PStatus.SelectedIndexChanged += new System.EventHandler(this.PStatus_SelectedIndexChanged);
            // 
            // NumProjects
            // 
            this.NumProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NumProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumProjects.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumProjects.Location = new System.Drawing.Point(470, 175);
            this.NumProjects.Name = "NumProjects";
            this.NumProjects.Size = new System.Drawing.Size(141, 27);
            this.NumProjects.TabIndex = 12;
            this.NumProjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(427, 82);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(220, 534);
            this.textBox19.TabIndex = 10;
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EventNameList
            // 
            this.EventNameList.AllowDrop = true;
            this.EventNameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EventNameList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNameList.Location = new System.Drawing.Point(701, 339);
            this.EventNameList.Multiline = true;
            this.EventNameList.Name = "EventNameList";
            this.EventNameList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EventNameList.Size = new System.Drawing.Size(193, 216);
            this.EventNameList.TabIndex = 23;
            this.EventNameList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EventNameList.TextChanged += new System.EventHandler(this.EventNameList_TextChanged);
            // 
            // NumEvents
            // 
            this.NumEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NumEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumEvents.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumEvents.Location = new System.Drawing.Point(730, 175);
            this.NumEvents.Name = "NumEvents";
            this.NumEvents.Size = new System.Drawing.Size(141, 27);
            this.NumEvents.TabIndex = 20;
            this.NumEvents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox26.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox26.Location = new System.Drawing.Point(687, 82);
            this.textBox26.Multiline = true;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(220, 534);
            this.textBox26.TabIndex = 18;
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TOpenBtn
            // 
            this.TOpenBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.TOpenBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOpenBtn.ForeColor = System.Drawing.Color.White;
            this.TOpenBtn.Location = new System.Drawing.Point(236, 567);
            this.TOpenBtn.Name = "TOpenBtn";
            this.TOpenBtn.Size = new System.Drawing.Size(75, 37);
            this.TOpenBtn.TabIndex = 41;
            this.TOpenBtn.Text = "Open";
            this.TOpenBtn.UseVisualStyleBackColor = false;
            // 
            // POpenBtn
            // 
            this.POpenBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.POpenBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POpenBtn.ForeColor = System.Drawing.Color.White;
            this.POpenBtn.Location = new System.Drawing.Point(500, 567);
            this.POpenBtn.Name = "POpenBtn";
            this.POpenBtn.Size = new System.Drawing.Size(75, 37);
            this.POpenBtn.TabIndex = 42;
            this.POpenBtn.Text = "Open";
            this.POpenBtn.UseVisualStyleBackColor = false;
            // 
            // EOpenBtn
            // 
            this.EOpenBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.EOpenBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EOpenBtn.ForeColor = System.Drawing.Color.White;
            this.EOpenBtn.Location = new System.Drawing.Point(761, 567);
            this.EOpenBtn.Name = "EOpenBtn";
            this.EOpenBtn.Size = new System.Drawing.Size(75, 37);
            this.EOpenBtn.TabIndex = 43;
            this.EOpenBtn.Text = "Open";
            this.EOpenBtn.UseVisualStyleBackColor = false;
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
            this.panel5.Location = new System.Drawing.Point(-1, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(117, 791);
            this.panel5.TabIndex = 50;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.ChartsM);
            this.panel10.Controls.Add(this.pictureBox4);
            this.panel10.Location = new System.Drawing.Point(1, 405);
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
            this.panel9.Location = new System.Drawing.Point(1, 331);
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
            this.panel8.Location = new System.Drawing.Point(1, 258);
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
            this.panel7.Location = new System.Drawing.Point(1, 184);
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
            this.pictureBox11.Location = new System.Drawing.Point(1, 110);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(48, 51);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 25;
            this.pictureBox11.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DashboardM);
            this.panel6.Location = new System.Drawing.Point(2, 110);
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
            // EDate
            // 
            this.EDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EDate.Location = new System.Drawing.Point(730, 257);
            this.EDate.Name = "EDate";
            this.EDate.Size = new System.Drawing.Size(141, 20);
            this.EDate.TabIndex = 51;
            this.EDate.ValueChanged += new System.EventHandler(this.EDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tasks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "Projects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(758, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 54;
            this.label3.Text = "Events";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Number of Tasks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 56;
            this.label5.Text = "Number of Projects:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(733, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "Number of Events:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 58;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(515, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 59;
            this.label8.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(777, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 19);
            this.label9.TabIndex = 60;
            this.label9.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(231, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 61;
            this.label10.Text = "Tasks Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(484, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 19);
            this.label11.TabIndex = 62;
            this.label11.Text = "Projects Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(750, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 19);
            this.label12.TabIndex = 63;
            this.label12.Text = "Events Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(964, 676);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EDate);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.EOpenBtn);
            this.Controls.Add(this.POpenBtn);
            this.Controls.Add(this.TOpenBtn);
            this.Controls.Add(this.EventNameList);
            this.Controls.Add(this.NumEvents);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.ProjectNameList);
            this.Controls.Add(this.PStatus);
            this.Controls.Add(this.NumProjects);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.TaskNameList);
            this.Controls.Add(this.TStatus);
            this.Controls.Add(this.NumTasks);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.Text = "Dhashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox NumTasks;
        private System.Windows.Forms.ComboBox TStatus;
        private System.Windows.Forms.TextBox TaskNameList;
        private System.Windows.Forms.TextBox ProjectNameList;
        private System.Windows.Forms.ComboBox PStatus;
        private System.Windows.Forms.TextBox NumProjects;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox EventNameList;
        private System.Windows.Forms.TextBox NumEvents;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Button TOpenBtn;
        private System.Windows.Forms.Button POpenBtn;
        private System.Windows.Forms.Button EOpenBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label ChartsM;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label CalendarM;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label ProjectsM;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label TasksM;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label DashboardM;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.DateTimePicker EDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}