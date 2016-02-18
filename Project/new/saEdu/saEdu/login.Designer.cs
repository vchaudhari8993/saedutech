namespace saEdu
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerUser = new System.Windows.Forms.LinkLabel();
            this.login_button = new System.Windows.Forms.Button();
            this.log_pass = new System.Windows.Forms.TextBox();
            this.log_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.registerUser);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.log_pass);
            this.panel1.Controls.Add(this.log_user);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 198);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // registerUser
            // 
            this.registerUser.AutoSize = true;
            this.registerUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.registerUser.Location = new System.Drawing.Point(68, 171);
            this.registerUser.Name = "registerUser";
            this.registerUser.Size = new System.Drawing.Size(210, 18);
            this.registerUser.TabIndex = 3;
            this.registerUser.TabStop = true;
            this.registerUser.Text = "Not have Account? Register Now";
            this.registerUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerUser_LinkClicked);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.White;
            this.login_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.login_button.Location = new System.Drawing.Point(22, 123);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(294, 45);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // log_pass
            // 
            this.log_pass.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_pass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.log_pass.Location = new System.Drawing.Point(122, 63);
            this.log_pass.Name = "log_pass";
            this.log_pass.PasswordChar = '*';
            this.log_pass.Size = new System.Drawing.Size(194, 31);
            this.log_pass.TabIndex = 1;
            // 
            // log_user
            // 
            this.log_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.log_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.log_user.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_user.ForeColor = System.Drawing.Color.RoyalBlue;
            this.log_user.Location = new System.Drawing.Point(122, 14);
            this.log_user.Name = "log_user";
            this.log_user.Size = new System.Drawing.Size(194, 31);
            this.log_user.TabIndex = 0;
            this.log_user.TextChanged += new System.EventHandler(this.log_user_TextChanged);
            this.log_user.Enter += new System.EventHandler(this.log_user_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 52);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(138, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            // 
            // login
            // 
            this.AcceptButton = this.login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 278);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WELCOME";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel registerUser;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox log_pass;
        private System.Windows.Forms.TextBox log_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}