namespace Dance_Scheduler_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.signupLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_Password_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_Username_TextBox = new System.Windows.Forms.TextBox();
            this.signupPanel = new System.Windows.Forms.Panel();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.signupBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.signup_Password_TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.signup_Username_TextBox = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.signupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(306, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "STEEZE";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginPanel.Controls.Add(this.signupLink);
            this.loginPanel.Controls.Add(this.label5);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.login_Password_TextBox);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.login_Username_TextBox);
            this.loginPanel.Location = new System.Drawing.Point(95, 178);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Padding = new System.Windows.Forms.Padding(30);
            this.loginPanel.Size = new System.Drawing.Size(605, 205);
            this.loginPanel.TabIndex = 1;
            // 
            // signupLink
            // 
            this.signupLink.AutoSize = true;
            this.signupLink.BackColor = System.Drawing.Color.Transparent;
            this.signupLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLink.LinkColor = System.Drawing.Color.White;
            this.signupLink.Location = new System.Drawing.Point(314, 161);
            this.signupLink.Name = "signupLink";
            this.signupLink.Size = new System.Drawing.Size(48, 15);
            this.signupLink.TabIndex = 7;
            this.signupLink.TabStop = true;
            this.signupLink.Text = "Sign Up";
            this.signupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(238, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "No Account?";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Black;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(250, 126);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(102, 23);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(260, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Log In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(318, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // login_Password_TextBox
            // 
            this.login_Password_TextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Password_TextBox.Location = new System.Drawing.Point(322, 82);
            this.login_Password_TextBox.Name = "login_Password_TextBox";
            this.login_Password_TextBox.PasswordChar = '*';
            this.login_Password_TextBox.Size = new System.Drawing.Size(246, 27);
            this.login_Password_TextBox.TabIndex = 2;
            this.login_Password_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey_Event);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // login_Username_TextBox
            // 
            this.login_Username_TextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Username_TextBox.Location = new System.Drawing.Point(33, 82);
            this.login_Username_TextBox.Name = "login_Username_TextBox";
            this.login_Username_TextBox.Size = new System.Drawing.Size(247, 27);
            this.login_Username_TextBox.TabIndex = 0;
            this.login_Username_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey_Event);
            // 
            // signupPanel
            // 
            this.signupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.signupPanel.Controls.Add(this.loginLink);
            this.signupPanel.Controls.Add(this.label6);
            this.signupPanel.Controls.Add(this.signupBtn);
            this.signupPanel.Controls.Add(this.label7);
            this.signupPanel.Controls.Add(this.label8);
            this.signupPanel.Controls.Add(this.signup_Password_TextBox);
            this.signupPanel.Controls.Add(this.label9);
            this.signupPanel.Controls.Add(this.signup_Username_TextBox);
            this.signupPanel.Enabled = false;
            this.signupPanel.Location = new System.Drawing.Point(95, 178);
            this.signupPanel.Name = "signupPanel";
            this.signupPanel.Padding = new System.Windows.Forms.Padding(30);
            this.signupPanel.Size = new System.Drawing.Size(605, 205);
            this.signupPanel.TabIndex = 8;
            this.signupPanel.Visible = false;
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.BackColor = System.Drawing.Color.Transparent;
            this.loginLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLink.LinkColor = System.Drawing.Color.White;
            this.loginLink.Location = new System.Drawing.Point(350, 163);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(40, 15);
            this.loginLink.TabIndex = 7;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Log In";
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(204, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Already Have an Account?";
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.Black;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(250, 126);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(102, 23);
            this.signupBtn.TabIndex = 5;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(249, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sign Up";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(318, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Password";
            // 
            // signup_Password_TextBox
            // 
            this.signup_Password_TextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_Password_TextBox.Location = new System.Drawing.Point(322, 82);
            this.signup_Password_TextBox.Name = "signup_Password_TextBox";
            this.signup_Password_TextBox.Size = new System.Drawing.Size(246, 27);
            this.signup_Password_TextBox.TabIndex = 2;
            this.signup_Password_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey_Event);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Username";
            // 
            // signup_Username_TextBox
            // 
            this.signup_Username_TextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_Username_TextBox.Location = new System.Drawing.Point(33, 82);
            this.signup_Username_TextBox.Name = "signup_Username_TextBox";
            this.signup_Username_TextBox.Size = new System.Drawing.Size(247, 27);
            this.signup_Username_TextBox.TabIndex = 0;
            this.signup_Username_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey_Event);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dance_Scheduler_System.Properties.Resources.loginbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.signupPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steeze Scheduler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.signupPanel.ResumeLayout(false);
            this.signupPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_Password_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_Username_TextBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel signupLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel signupPanel;
        private System.Windows.Forms.LinkLabel loginLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox signup_Password_TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox signup_Username_TextBox;
    }
}

