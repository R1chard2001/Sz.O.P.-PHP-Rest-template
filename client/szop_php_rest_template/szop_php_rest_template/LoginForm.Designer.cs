namespace szop_php_rest_template
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
            this.usernameLBL = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLBL = new System.Windows.Forms.Label();
            this.loginBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLBL
            // 
            this.usernameLBL.AutoSize = true;
            this.usernameLBL.Location = new System.Drawing.Point(12, 9);
            this.usernameLBL.Name = "usernameLBL";
            this.usernameLBL.Size = new System.Drawing.Size(70, 16);
            this.usernameLBL.TabIndex = 0;
            this.usernameLBL.Text = "Username";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(12, 37);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(299, 22);
            this.usernameTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(12, 109);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(299, 22);
            this.passwordTB.TabIndex = 3;
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.Location = new System.Drawing.Point(12, 81);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(70, 16);
            this.passwordLBL.TabIndex = 2;
            this.passwordLBL.Text = "Username";
            // 
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(109, 148);
            this.loginBTN.MaximumSize = new System.Drawing.Size(100, 39);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(100, 39);
            this.loginBTN.TabIndex = 4;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 199);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.passwordLBL);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.usernameLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLBL;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passwordLBL;
        private System.Windows.Forms.Button loginBTN;
    }
}

