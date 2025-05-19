namespace StudentAttendanceChecker
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblapplicationtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.Location = new System.Drawing.Point(189, 178);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(131, 22);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username/Email";
            this.lblUsername.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(336, 180);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(177, 20);
            this.usernamebox.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.Location = new System.Drawing.Point(233, 239);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(383, 289);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblapplicationtitle
            // 
            this.lblapplicationtitle.AutoSize = true;
            this.lblapplicationtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblapplicationtitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblapplicationtitle.Location = new System.Drawing.Point(286, 58);
            this.lblapplicationtitle.Name = "lblapplicationtitle";
            this.lblapplicationtitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblapplicationtitle.Size = new System.Drawing.Size(270, 76);
            this.lblapplicationtitle.TabIndex = 5;
            this.lblapplicationtitle.Text = "Checkly";
            this.lblapplicationtitle.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(347, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student Attendance Checker";
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(336, 241);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(177, 20);
            this.passwordbox.TabIndex = 7;
            this.passwordbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.passwordbox_MaskInputRejected);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblapplicationtitle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.lblUsername);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblapplicationtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox passwordbox;
    }
}