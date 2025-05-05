namespace Dance_Scheduler_System
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookingsBtn = new System.Windows.Forms.Button();
            this.schedulesBtn = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.users_RefreshBtn = new System.Windows.Forms.Button();
            this.users_UpdateBtm = new System.Windows.Forms.Button();
            this.users_DeleteBtn = new System.Windows.Forms.Button();
            this.users_AddBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.users_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.users_UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.users_DataGrid = new System.Windows.Forms.DataGridView();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.schedules_SlotsTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.schedules_InstructorTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.schedules_TimeTextBox = new System.Windows.Forms.TextBox();
            this.schedules_Day = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.schedules_RefreshBtn = new System.Windows.Forms.Button();
            this.schedules_UpdateBtn = new System.Windows.Forms.Button();
            this.schedules_DeleteBtn = new System.Windows.Forms.Button();
            this.schedules_AddBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.schedules_TypeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.schedules_DataGrid = new System.Windows.Forms.DataGridView();
            this.bookingsPanel = new System.Windows.Forms.Panel();
            this.bookings_ClassBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bookings_PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bookings_EmailTextBox = new System.Windows.Forms.TextBox();
            this.bookings_DateBooked = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.bookings_RefreshBtn = new System.Windows.Forms.Button();
            this.bookings_UpdateBtn = new System.Windows.Forms.Button();
            this.bookings_DeleteBtn = new System.Windows.Forms.Button();
            this.bookings_AddBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.bookings_NameTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bookings_DataGrid = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.users_PermissionTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.usersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_DataGrid)).BeginInit();
            this.schedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedules_DataGrid)).BeginInit();
            this.bookingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookings_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.bookingsBtn);
            this.panel1.Controls.Add(this.schedulesBtn);
            this.panel1.Controls.Add(this.usersBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(219, 651);
            this.panel1.TabIndex = 0;
            // 
            // bookingsBtn
            // 
            this.bookingsBtn.BackColor = System.Drawing.Color.White;
            this.bookingsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsBtn.Location = new System.Drawing.Point(30, 279);
            this.bookingsBtn.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.bookingsBtn.Name = "bookingsBtn";
            this.bookingsBtn.Size = new System.Drawing.Size(159, 39);
            this.bookingsBtn.TabIndex = 3;
            this.bookingsBtn.Text = "Bookings";
            this.bookingsBtn.UseVisualStyleBackColor = false;
            this.bookingsBtn.Click += new System.EventHandler(this.bookingsBtn_Click);
            // 
            // schedulesBtn
            // 
            this.schedulesBtn.BackColor = System.Drawing.Color.White;
            this.schedulesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulesBtn.Location = new System.Drawing.Point(30, 200);
            this.schedulesBtn.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.schedulesBtn.Name = "schedulesBtn";
            this.schedulesBtn.Size = new System.Drawing.Size(159, 39);
            this.schedulesBtn.TabIndex = 2;
            this.schedulesBtn.Text = "Schedules";
            this.schedulesBtn.UseVisualStyleBackColor = false;
            this.schedulesBtn.Click += new System.EventHandler(this.schedulesBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.BackColor = System.Drawing.Color.White;
            this.usersBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBtn.Location = new System.Drawing.Point(30, 121);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(159, 39);
            this.usersBtn.TabIndex = 1;
            this.usersBtn.Text = "Users";
            this.usersBtn.UseVisualStyleBackColor = false;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Mode";
            // 
            // usersPanel
            // 
            this.usersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usersPanel.Controls.Add(this.users_PermissionTextBox);
            this.usersPanel.Controls.Add(this.label5);
            this.usersPanel.Controls.Add(this.users_RefreshBtn);
            this.usersPanel.Controls.Add(this.users_UpdateBtm);
            this.usersPanel.Controls.Add(this.users_DeleteBtn);
            this.usersPanel.Controls.Add(this.users_AddBtn);
            this.usersPanel.Controls.Add(this.label4);
            this.usersPanel.Controls.Add(this.users_PasswordTextBox);
            this.usersPanel.Controls.Add(this.label3);
            this.usersPanel.Controls.Add(this.users_UsernameTextBox);
            this.usersPanel.Controls.Add(this.label2);
            this.usersPanel.Controls.Add(this.users_DataGrid);
            this.usersPanel.Location = new System.Drawing.Point(270, 53);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Padding = new System.Windows.Forms.Padding(30);
            this.usersPanel.Size = new System.Drawing.Size(706, 542);
            this.usersPanel.TabIndex = 1;
            this.usersPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(303, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Permission";
            // 
            // users_RefreshBtn
            // 
            this.users_RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_RefreshBtn.Location = new System.Drawing.Point(582, 450);
            this.users_RefreshBtn.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.users_RefreshBtn.Name = "users_RefreshBtn";
            this.users_RefreshBtn.Size = new System.Drawing.Size(91, 41);
            this.users_RefreshBtn.TabIndex = 10;
            this.users_RefreshBtn.Text = "Refresh";
            this.users_RefreshBtn.UseVisualStyleBackColor = true;
            this.users_RefreshBtn.Click += new System.EventHandler(this.users_RefreshBtn_Click);
            // 
            // users_UpdateBtm
            // 
            this.users_UpdateBtm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_UpdateBtm.Location = new System.Drawing.Point(582, 403);
            this.users_UpdateBtm.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.users_UpdateBtm.Name = "users_UpdateBtm";
            this.users_UpdateBtm.Size = new System.Drawing.Size(91, 41);
            this.users_UpdateBtm.TabIndex = 9;
            this.users_UpdateBtm.Text = "Update";
            this.users_UpdateBtm.UseVisualStyleBackColor = true;
            this.users_UpdateBtm.Click += new System.EventHandler(this.users_UpdateBtm_Click);
            // 
            // users_DeleteBtn
            // 
            this.users_DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_DeleteBtn.Location = new System.Drawing.Point(582, 356);
            this.users_DeleteBtn.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.users_DeleteBtn.Name = "users_DeleteBtn";
            this.users_DeleteBtn.Size = new System.Drawing.Size(91, 41);
            this.users_DeleteBtn.TabIndex = 8;
            this.users_DeleteBtn.Text = "Delete";
            this.users_DeleteBtn.UseVisualStyleBackColor = true;
            this.users_DeleteBtn.Click += new System.EventHandler(this.users_DeleteBtn_Click);
            // 
            // users_AddBtn
            // 
            this.users_AddBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_AddBtn.Location = new System.Drawing.Point(582, 309);
            this.users_AddBtn.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.users_AddBtn.Name = "users_AddBtn";
            this.users_AddBtn.Size = new System.Drawing.Size(91, 41);
            this.users_AddBtn.TabIndex = 7;
            this.users_AddBtn.Text = "Add";
            this.users_AddBtn.UseVisualStyleBackColor = true;
            this.users_AddBtn.Click += new System.EventHandler(this.users_AddBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // users_PasswordTextBox
            // 
            this.users_PasswordTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_PasswordTextBox.Location = new System.Drawing.Point(33, 202);
            this.users_PasswordTextBox.Name = "users_PasswordTextBox";
            this.users_PasswordTextBox.Size = new System.Drawing.Size(252, 27);
            this.users_PasswordTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // users_UsernameTextBox
            // 
            this.users_UsernameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_UsernameTextBox.Location = new System.Drawing.Point(33, 138);
            this.users_UsernameTextBox.Name = "users_UsernameTextBox";
            this.users_UsernameTextBox.Size = new System.Drawing.Size(252, 27);
            this.users_UsernameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Users";
            // 
            // users_DataGrid
            // 
            this.users_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_DataGrid.Location = new System.Drawing.Point(33, 291);
            this.users_DataGrid.Name = "users_DataGrid";
            this.users_DataGrid.Size = new System.Drawing.Size(526, 218);
            this.users_DataGrid.TabIndex = 0;
            this.users_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_DataGrid_CellClick);
            // 
            // schedulePanel
            // 
            this.schedulePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.schedulePanel.Controls.Add(this.schedules_SlotsTextBox);
            this.schedulePanel.Controls.Add(this.label11);
            this.schedulePanel.Controls.Add(this.schedules_InstructorTextBox);
            this.schedulePanel.Controls.Add(this.label10);
            this.schedulePanel.Controls.Add(this.schedules_TimeTextBox);
            this.schedulePanel.Controls.Add(this.schedules_Day);
            this.schedulePanel.Controls.Add(this.label6);
            this.schedulePanel.Controls.Add(this.schedules_RefreshBtn);
            this.schedulePanel.Controls.Add(this.schedules_UpdateBtn);
            this.schedulePanel.Controls.Add(this.schedules_DeleteBtn);
            this.schedulePanel.Controls.Add(this.schedules_AddBtn);
            this.schedulePanel.Controls.Add(this.label7);
            this.schedulePanel.Controls.Add(this.schedules_TypeTextBox);
            this.schedulePanel.Controls.Add(this.label8);
            this.schedulePanel.Controls.Add(this.label9);
            this.schedulePanel.Controls.Add(this.schedules_DataGrid);
            this.schedulePanel.Location = new System.Drawing.Point(270, 53);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Padding = new System.Windows.Forms.Padding(30);
            this.schedulePanel.Size = new System.Drawing.Size(706, 542);
            this.schedulePanel.TabIndex = 14;
            this.schedulePanel.Visible = false;
            // 
            // schedules_SlotsTextBox
            // 
            this.schedules_SlotsTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedules_SlotsTextBox.Location = new System.Drawing.Point(307, 171);
            this.schedules_SlotsTextBox.Name = "schedules_SlotsTextBox";
            this.schedules_SlotsTextBox.Size = new System.Drawing.Size(252, 27);
            this.schedules_SlotsTextBox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(303, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Slots";
            // 
            // schedules_InstructorTextBox
            // 
            this.schedules_InstructorTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedules_InstructorTextBox.Location = new System.Drawing.Point(307, 105);
            this.schedules_InstructorTextBox.Name = "schedules_InstructorTextBox";
            this.schedules_InstructorTextBox.Size = new System.Drawing.Size(252, 27);
            this.schedules_InstructorTextBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(303, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Instructor";
            // 
            // schedules_TimeTextBox
            // 
            this.schedules_TimeTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedules_TimeTextBox.Location = new System.Drawing.Point(33, 236);
            this.schedules_TimeTextBox.Name = "schedules_TimeTextBox";
            this.schedules_TimeTextBox.Size = new System.Drawing.Size(252, 27);
            this.schedules_TimeTextBox.TabIndex = 15;
            // 
            // schedules_Day
            // 
            this.schedules_Day.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedules_Day.Location = new System.Drawing.Point(33, 105);
            this.schedules_Day.Name = "schedules_Day";
            this.schedules_Day.Size = new System.Drawing.Size(252, 27);
            this.schedules_Day.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Time";
            // 
            // schedules_RefreshBtn
            // 
            this.schedules_RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedules_RefreshBtn.Location = new System.Drawing.Point(599, 242);
            this.schedules_RefreshBtn.Margin = new System.Windows.Forms.Padding(5);
            this.schedules_RefreshBtn.Name = "schedules_RefreshBtn";
            this.schedules_RefreshBtn.Size = new System.Drawing.Size(74, 41);
            this.schedules_RefreshBtn.TabIndex = 10;
            this.schedules_RefreshBtn.Text = "Refresh";
            this.schedules_RefreshBtn.UseVisualStyleBackColor = true;
            this.schedules_RefreshBtn.Click += new System.EventHandler(this.schedules_RefreshBtn_Click);
            // 
            // schedules_UpdateBtn
            // 
            this.schedules_UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedules_UpdateBtn.Location = new System.Drawing.Point(515, 242);
            this.schedules_UpdateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.schedules_UpdateBtn.Name = "schedules_UpdateBtn";
            this.schedules_UpdateBtn.Size = new System.Drawing.Size(74, 41);
            this.schedules_UpdateBtn.TabIndex = 9;
            this.schedules_UpdateBtn.Text = "Update";
            this.schedules_UpdateBtn.UseVisualStyleBackColor = true;
            this.schedules_UpdateBtn.Click += new System.EventHandler(this.schedules_UpdateBtn_Click);
            // 
            // schedules_DeleteBtn
            // 
            this.schedules_DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedules_DeleteBtn.Location = new System.Drawing.Point(431, 242);
            this.schedules_DeleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.schedules_DeleteBtn.Name = "schedules_DeleteBtn";
            this.schedules_DeleteBtn.Size = new System.Drawing.Size(74, 41);
            this.schedules_DeleteBtn.TabIndex = 8;
            this.schedules_DeleteBtn.Text = "Delete";
            this.schedules_DeleteBtn.UseVisualStyleBackColor = true;
            this.schedules_DeleteBtn.Click += new System.EventHandler(this.schedules_DeleteBtn_Click);
            // 
            // schedules_AddBtn
            // 
            this.schedules_AddBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedules_AddBtn.Location = new System.Drawing.Point(347, 242);
            this.schedules_AddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.schedules_AddBtn.Name = "schedules_AddBtn";
            this.schedules_AddBtn.Size = new System.Drawing.Size(74, 41);
            this.schedules_AddBtn.TabIndex = 7;
            this.schedules_AddBtn.Text = "Add";
            this.schedules_AddBtn.UseVisualStyleBackColor = true;
            this.schedules_AddBtn.Click += new System.EventHandler(this.schedules_AddBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type";
            // 
            // schedules_TypeTextBox
            // 
            this.schedules_TypeTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedules_TypeTextBox.Location = new System.Drawing.Point(33, 172);
            this.schedules_TypeTextBox.Name = "schedules_TypeTextBox";
            this.schedules_TypeTextBox.Size = new System.Drawing.Size(252, 27);
            this.schedules_TypeTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Day";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 37);
            this.label9.TabIndex = 1;
            this.label9.Text = "Schedules";
            // 
            // schedules_DataGrid
            // 
            this.schedules_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedules_DataGrid.Location = new System.Drawing.Point(33, 291);
            this.schedules_DataGrid.Name = "schedules_DataGrid";
            this.schedules_DataGrid.Size = new System.Drawing.Size(640, 218);
            this.schedules_DataGrid.TabIndex = 0;
            this.schedules_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedules_DataGrid_CellClick);
            // 
            // bookingsPanel
            // 
            this.bookingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookingsPanel.Controls.Add(this.bookings_ClassBox);
            this.bookingsPanel.Controls.Add(this.label12);
            this.bookingsPanel.Controls.Add(this.bookings_PhoneNumberTextBox);
            this.bookingsPanel.Controls.Add(this.label13);
            this.bookingsPanel.Controls.Add(this.bookings_EmailTextBox);
            this.bookingsPanel.Controls.Add(this.bookings_DateBooked);
            this.bookingsPanel.Controls.Add(this.label14);
            this.bookingsPanel.Controls.Add(this.bookings_RefreshBtn);
            this.bookingsPanel.Controls.Add(this.bookings_UpdateBtn);
            this.bookingsPanel.Controls.Add(this.bookings_DeleteBtn);
            this.bookingsPanel.Controls.Add(this.bookings_AddBtn);
            this.bookingsPanel.Controls.Add(this.label15);
            this.bookingsPanel.Controls.Add(this.bookings_NameTextBox);
            this.bookingsPanel.Controls.Add(this.label16);
            this.bookingsPanel.Controls.Add(this.label17);
            this.bookingsPanel.Controls.Add(this.bookings_DataGrid);
            this.bookingsPanel.Location = new System.Drawing.Point(270, 53);
            this.bookingsPanel.Name = "bookingsPanel";
            this.bookingsPanel.Padding = new System.Windows.Forms.Padding(30);
            this.bookingsPanel.Size = new System.Drawing.Size(706, 542);
            this.bookingsPanel.TabIndex = 15;
            this.bookingsPanel.Visible = false;
            // 
            // bookings_ClassBox
            // 
            this.bookings_ClassBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings_ClassBox.FormattingEnabled = true;
            this.bookings_ClassBox.Location = new System.Drawing.Point(315, 105);
            this.bookings_ClassBox.Name = "bookings_ClassBox";
            this.bookings_ClassBox.Size = new System.Drawing.Size(252, 26);
            this.bookings_ClassBox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(311, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "Class";
            // 
            // bookings_PhoneNumberTextBox
            // 
            this.bookings_PhoneNumberTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings_PhoneNumberTextBox.Location = new System.Drawing.Point(33, 235);
            this.bookings_PhoneNumberTextBox.Name = "bookings_PhoneNumberTextBox";
            this.bookings_PhoneNumberTextBox.Size = new System.Drawing.Size(252, 27);
            this.bookings_PhoneNumberTextBox.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(29, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 21);
            this.label13.TabIndex = 16;
            this.label13.Text = "Phone Number";
            // 
            // bookings_EmailTextBox
            // 
            this.bookings_EmailTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings_EmailTextBox.Location = new System.Drawing.Point(33, 171);
            this.bookings_EmailTextBox.Name = "bookings_EmailTextBox";
            this.bookings_EmailTextBox.Size = new System.Drawing.Size(252, 27);
            this.bookings_EmailTextBox.TabIndex = 15;
            // 
            // bookings_DateBooked
            // 
            this.bookings_DateBooked.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings_DateBooked.Location = new System.Drawing.Point(315, 171);
            this.bookings_DateBooked.Name = "bookings_DateBooked";
            this.bookings_DateBooked.Size = new System.Drawing.Size(252, 27);
            this.bookings_DateBooked.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(29, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 21);
            this.label14.TabIndex = 12;
            this.label14.Text = "Email";
            // 
            // bookings_RefreshBtn
            // 
            this.bookings_RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings_RefreshBtn.Location = new System.Drawing.Point(599, 242);
            this.bookings_RefreshBtn.Margin = new System.Windows.Forms.Padding(5);
            this.bookings_RefreshBtn.Name = "bookings_RefreshBtn";
            this.bookings_RefreshBtn.Size = new System.Drawing.Size(74, 41);
            this.bookings_RefreshBtn.TabIndex = 10;
            this.bookings_RefreshBtn.Text = "Refresh";
            this.bookings_RefreshBtn.UseVisualStyleBackColor = true;
            this.bookings_RefreshBtn.Click += new System.EventHandler(this.bookings_RefreshBtn_Click);
            // 
            // bookings_UpdateBtn
            // 
            this.bookings_UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings_UpdateBtn.Location = new System.Drawing.Point(515, 242);
            this.bookings_UpdateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.bookings_UpdateBtn.Name = "bookings_UpdateBtn";
            this.bookings_UpdateBtn.Size = new System.Drawing.Size(74, 41);
            this.bookings_UpdateBtn.TabIndex = 9;
            this.bookings_UpdateBtn.Text = "Update";
            this.bookings_UpdateBtn.UseVisualStyleBackColor = true;
            this.bookings_UpdateBtn.Click += new System.EventHandler(this.bookings_UpdateBtn_Click);
            // 
            // bookings_DeleteBtn
            // 
            this.bookings_DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings_DeleteBtn.Location = new System.Drawing.Point(431, 242);
            this.bookings_DeleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.bookings_DeleteBtn.Name = "bookings_DeleteBtn";
            this.bookings_DeleteBtn.Size = new System.Drawing.Size(74, 41);
            this.bookings_DeleteBtn.TabIndex = 8;
            this.bookings_DeleteBtn.Text = "Delete";
            this.bookings_DeleteBtn.UseVisualStyleBackColor = true;
            this.bookings_DeleteBtn.Click += new System.EventHandler(this.bookings_DeleteBtn_Click);
            // 
            // bookings_AddBtn
            // 
            this.bookings_AddBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings_AddBtn.Location = new System.Drawing.Point(347, 242);
            this.bookings_AddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.bookings_AddBtn.Name = "bookings_AddBtn";
            this.bookings_AddBtn.Size = new System.Drawing.Size(74, 41);
            this.bookings_AddBtn.TabIndex = 7;
            this.bookings_AddBtn.Text = "Add";
            this.bookings_AddBtn.UseVisualStyleBackColor = true;
            this.bookings_AddBtn.Click += new System.EventHandler(this.bookings_AddBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(29, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 21);
            this.label15.TabIndex = 6;
            this.label15.Text = "Name";
            // 
            // bookings_NameTextBox
            // 
            this.bookings_NameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings_NameTextBox.Location = new System.Drawing.Point(33, 105);
            this.bookings_NameTextBox.Name = "bookings_NameTextBox";
            this.bookings_NameTextBox.Size = new System.Drawing.Size(252, 27);
            this.bookings_NameTextBox.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(311, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 21);
            this.label16.TabIndex = 4;
            this.label16.Text = "Date Booked";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(26, 33);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 37);
            this.label17.TabIndex = 1;
            this.label17.Text = "Bookings";
            // 
            // bookings_DataGrid
            // 
            this.bookings_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookings_DataGrid.Location = new System.Drawing.Point(33, 291);
            this.bookings_DataGrid.Name = "bookings_DataGrid";
            this.bookings_DataGrid.Size = new System.Drawing.Size(640, 218);
            this.bookings_DataGrid.TabIndex = 0;
            this.bookings_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookings_DataGrid_CellClick);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(30, 562);
            this.backBtn.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(159, 39);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // users_PermissionTextBox
            // 
            this.users_PermissionTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_PermissionTextBox.Location = new System.Drawing.Point(307, 137);
            this.users_PermissionTextBox.Name = "users_PermissionTextBox";
            this.users_PermissionTextBox.Size = new System.Drawing.Size(252, 27);
            this.users_PermissionTextBox.TabIndex = 14;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dance_Scheduler_System.Properties.Resources.bodybackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookingsPanel);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.usersPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steeze Admin Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.usersPanel.ResumeLayout(false);
            this.usersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_DataGrid)).EndInit();
            this.schedulePanel.ResumeLayout(false);
            this.schedulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedules_DataGrid)).EndInit();
            this.bookingsPanel.ResumeLayout(false);
            this.bookingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookings_DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bookingsBtn;
        private System.Windows.Forms.Button schedulesBtn;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Panel usersPanel;
        private System.Windows.Forms.DataGridView users_DataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox users_UsernameTextBox;
        private System.Windows.Forms.Button users_RefreshBtn;
        private System.Windows.Forms.Button users_UpdateBtm;
        private System.Windows.Forms.Button users_DeleteBtn;
        private System.Windows.Forms.Button users_AddBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox users_PasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button schedules_RefreshBtn;
        private System.Windows.Forms.Button schedules_UpdateBtn;
        private System.Windows.Forms.Button schedules_DeleteBtn;
        private System.Windows.Forms.Button schedules_AddBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox schedules_TypeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView schedules_DataGrid;
        private System.Windows.Forms.TextBox schedules_TimeTextBox;
        private System.Windows.Forms.DateTimePicker schedules_Day;
        private System.Windows.Forms.TextBox schedules_SlotsTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox schedules_InstructorTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel bookingsPanel;
        private System.Windows.Forms.ComboBox bookings_ClassBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox bookings_PhoneNumberTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox bookings_EmailTextBox;
        private System.Windows.Forms.DateTimePicker bookings_DateBooked;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bookings_RefreshBtn;
        private System.Windows.Forms.Button bookings_UpdateBtn;
        private System.Windows.Forms.Button bookings_DeleteBtn;
        private System.Windows.Forms.Button bookings_AddBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox bookings_NameTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView bookings_DataGrid;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox users_PermissionTextBox;
    }
}