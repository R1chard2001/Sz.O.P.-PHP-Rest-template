namespace szop_php_rest_template
{
    partial class UsersForm
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
            this.logoutBTN = new System.Windows.Forms.Button();
            this.refreshBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.idLBL = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.usernameLBL = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutBTN
            // 
            this.logoutBTN.Location = new System.Drawing.Point(12, 375);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(75, 32);
            this.logoutBTN.TabIndex = 0;
            this.logoutBTN.Text = "Logout";
            this.logoutBTN.UseVisualStyleBackColor = true;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
            // 
            // refreshBTN
            // 
            this.refreshBTN.Location = new System.Drawing.Point(416, 375);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(75, 32);
            this.refreshBTN.TabIndex = 1;
            this.refreshBTN.Text = "Refresh";
            this.refreshBTN.UseVisualStyleBackColor = true;
            this.refreshBTN.Click += new System.EventHandler(this.refreshBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.Location = new System.Drawing.Point(551, 375);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(75, 32);
            this.createBTN.TabIndex = 2;
            this.createBTN.Text = "Create";
            this.createBTN.UseVisualStyleBackColor = true;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(632, 375);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(75, 32);
            this.updateBTN.TabIndex = 3;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(713, 375);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(75, 32);
            this.deleteBTN.TabIndex = 4;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // usersDGV
            // 
            this.usersDGV.AllowUserToAddRows = false;
            this.usersDGV.AllowUserToDeleteRows = false;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.Location = new System.Drawing.Point(12, 13);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.ReadOnly = true;
            this.usersDGV.RowHeadersWidth = 51;
            this.usersDGV.RowTemplate.Height = 24;
            this.usersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.usersDGV.Size = new System.Drawing.Size(776, 341);
            this.usersDGV.TabIndex = 5;
            this.usersDGV.SelectionChanged += new System.EventHandler(this.usersDGV_SelectionChanged);
            // 
            // idLBL
            // 
            this.idLBL.AutoSize = true;
            this.idLBL.Location = new System.Drawing.Point(13, 357);
            this.idLBL.Name = "idLBL";
            this.idLBL.Size = new System.Drawing.Size(18, 16);
            this.idLBL.TabIndex = 6;
            this.idLBL.Text = "Id";
            // 
            // idTB
            // 
            this.idTB.BackColor = System.Drawing.SystemColors.Window;
            this.idTB.Location = new System.Drawing.Point(16, 434);
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(71, 22);
            this.idTB.TabIndex = 7;
            // 
            // usernameLBL
            // 
            this.usernameLBL.AutoSize = true;
            this.usernameLBL.Location = new System.Drawing.Point(118, 413);
            this.usernameLBL.Name = "usernameLBL";
            this.usernameLBL.Size = new System.Drawing.Size(70, 16);
            this.usernameLBL.TabIndex = 8;
            this.usernameLBL.Text = "Username";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(121, 433);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(233, 22);
            this.usernameTB.TabIndex = 9;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(393, 434);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(233, 22);
            this.passwordTB.TabIndex = 11;
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.Location = new System.Drawing.Point(390, 414);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(67, 16);
            this.passwordLBL.TabIndex = 10;
            this.passwordLBL.Text = "Password";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.passwordLBL);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.usernameLBL);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.idLBL);
            this.Controls.Add(this.usersDGV);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.logoutBTN);
            this.Name = "UsersForm";
            this.ShowIcon = false;
            this.Text = "Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.Label idLBL;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label usernameLBL;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passwordLBL;
    }
}