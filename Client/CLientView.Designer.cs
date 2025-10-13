namespace Client
{
    partial class CLientView
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
            this.UserTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.StatusLb = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserTb
            // 
            this.UserTb.Location = new System.Drawing.Point(15, 25);
            this.UserTb.Name = "UserTb";
            this.UserTb.Size = new System.Drawing.Size(134, 20);
            this.UserTb.TabIndex = 0;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(15, 51);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(134, 20);
            this.PasswordTb.TabIndex = 1;
            // 
            // StatusLb
            // 
            this.StatusLb.AutoSize = true;
            this.StatusLb.Location = new System.Drawing.Point(12, 9);
            this.StatusLb.Name = "StatusLb";
            this.StatusLb.Size = new System.Drawing.Size(37, 13);
            this.StatusLb.TabIndex = 2;
            this.StatusLb.Text = "Status";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(15, 77);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // CLientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 115);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.StatusLb);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UserTb);
            this.Name = "CLientView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserTb;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label StatusLb;
        private System.Windows.Forms.Button LoginBtn;
    }
}

