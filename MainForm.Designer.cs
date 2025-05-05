namespace Dance_Scheduler_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.schedule_backBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.schedule_DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.adminBtn = new System.Windows.Forms.Button();
            this.schedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_DataGridView)).BeginInit();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulePanel
            // 
            this.schedulePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.schedulePanel.Controls.Add(this.schedule_backBtn);
            this.schedulePanel.Controls.Add(this.refreshBtn);
            this.schedulePanel.Controls.Add(this.selectBtn);
            this.schedulePanel.Controls.Add(this.schedule_DataGridView);
            this.schedulePanel.Controls.Add(this.label1);
            this.schedulePanel.Location = new System.Drawing.Point(53, 53);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Padding = new System.Windows.Forms.Padding(30);
            this.schedulePanel.Size = new System.Drawing.Size(709, 347);
            this.schedulePanel.TabIndex = 0;
            this.schedulePanel.Visible = false;
            // 
            // schedule_backBtn
            // 
            this.schedule_backBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule_backBtn.Location = new System.Drawing.Point(33, 285);
            this.schedule_backBtn.Name = "schedule_backBtn";
            this.schedule_backBtn.Size = new System.Drawing.Size(112, 30);
            this.schedule_backBtn.TabIndex = 4;
            this.schedule_backBtn.Text = "BACK";
            this.schedule_backBtn.UseVisualStyleBackColor = true;
            this.schedule_backBtn.Click += new System.EventHandler(this.schedule_backBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(564, 45);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(112, 30);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "REFRESH";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBtn.Location = new System.Drawing.Point(564, 284);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(112, 30);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "SELECT";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // schedule_DataGridView
            // 
            this.schedule_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.schedule_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule_DataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.schedule_DataGridView.Location = new System.Drawing.Point(33, 89);
            this.schedule_DataGridView.Name = "schedule_DataGridView";
            this.schedule_DataGridView.Size = new System.Drawing.Size(643, 177);
            this.schedule_DataGridView.TabIndex = 1;
            this.schedule_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedule_DataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Black;
            this.logoutBtn.Location = new System.Drawing.Point(5, 6);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(79, 24);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.Location = new System.Drawing.Point(286, 168);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(137, 46);
            this.bookBtn.TabIndex = 5;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 65);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome to Steeze";
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.Transparent;
            this.homePanel.Controls.Add(this.label2);
            this.homePanel.Controls.Add(this.bookBtn);
            this.homePanel.Location = new System.Drawing.Point(53, 53);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(709, 347);
            this.homePanel.TabIndex = 7;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.Gold;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.Black;
            this.adminBtn.Location = new System.Drawing.Point(708, 6);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(101, 24);
            this.adminBtn.TabIndex = 8;
            this.adminBtn.Text = "Admin Mode";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dance_Scheduler_System.Properties.Resources.bodybackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 453);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.homePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steeze Scheduler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.schedulePanel.ResumeLayout(false);
            this.schedulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_DataGridView)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.DataGridView schedule_DataGridView;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button schedule_backBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button adminBtn;
    }
}