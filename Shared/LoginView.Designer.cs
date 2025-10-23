namespace Shared
{
    partial class LoginView
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.StatusLb = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.UserTb = new System.Windows.Forms.TextBox();
            this.AdminCb = new System.Windows.Forms.CheckBox();
            this.CreateUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(12, 75);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // StatusLb
            // 
            this.StatusLb.AutoSize = true;
            this.StatusLb.Location = new System.Drawing.Point(9, 7);
            this.StatusLb.Name = "StatusLb";
            this.StatusLb.Size = new System.Drawing.Size(37, 13);
            this.StatusLb.TabIndex = 6;
            this.StatusLb.Text = "Status";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(12, 49);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(161, 20);
            this.PasswordTb.TabIndex = 5;
            this.PasswordTb.TextChanged += new System.EventHandler(this.PasswordTb_TextChanged);
            // 
            // UserTb
            // 
            this.UserTb.Location = new System.Drawing.Point(12, 23);
            this.UserTb.Name = "UserTb";
            this.UserTb.Size = new System.Drawing.Size(161, 20);
            this.UserTb.TabIndex = 4;
            this.UserTb.TextChanged += new System.EventHandler(this.UserTb_TextChanged);
            // 
            // AdminCb
            // 
            this.AdminCb.AutoSize = true;
            this.AdminCb.Location = new System.Drawing.Point(118, 7);
            this.AdminCb.Name = "AdminCb";
            this.AdminCb.Size = new System.Drawing.Size(55, 17);
            this.AdminCb.TabIndex = 8;
            this.AdminCb.Text = "Admin";
            this.AdminCb.UseVisualStyleBackColor = true;
            // 
            // CreateUserBtn
            // 
            this.CreateUserBtn.Location = new System.Drawing.Point(98, 75);
            this.CreateUserBtn.Name = "CreateUserBtn";
            this.CreateUserBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateUserBtn.TabIndex = 9;
            this.CreateUserBtn.Text = "Create User";
            this.CreateUserBtn.UseVisualStyleBackColor = true;
            this.CreateUserBtn.Click += new System.EventHandler(this.CreateUserBtn_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 108);
            this.Controls.Add(this.CreateUserBtn);
            this.Controls.Add(this.AdminCb);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.StatusLb);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UserTb);
            this.Name = "LoginView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label StatusLb;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.TextBox UserTb;
        private System.Windows.Forms.CheckBox AdminCb;
        private System.Windows.Forms.Button CreateUserBtn;
    }
}

