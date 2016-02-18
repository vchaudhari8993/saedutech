namespace saEdu
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            shortbtnPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new RoundButton();
            this.btnTranAdd = new RoundButton();
            this.btnGrpAdd = new RoundButton();
            this.btnYrAdd = new RoundButton();
            this.btnAccAdd = new RoundButton();
            userInfoPanel = new System.Windows.Forms.Panel();
            userInfo = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            navPanel = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            btnMyAccDetails = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnEventAcc = new System.Windows.Forms.Button();
            btnMyAcc = new System.Windows.Forms.Button();
            shortbtnPanel.SuspendLayout();
            userInfoPanel.SuspendLayout();
            navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // shortbtnPanel
            // 
            shortbtnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            shortbtnPanel.Controls.Add(this.btnLogout);
            shortbtnPanel.Controls.Add(this.btnTranAdd);
            shortbtnPanel.Controls.Add(this.btnGrpAdd);
            shortbtnPanel.Controls.Add(this.btnYrAdd);
            shortbtnPanel.Controls.Add(this.btnAccAdd);
            shortbtnPanel.Location = new System.Drawing.Point(284, 47);
            shortbtnPanel.Name = "shortbtnPanel";
            shortbtnPanel.Size = new System.Drawing.Size(1067, 44);
            shortbtnPanel.TabIndex = 17;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1000, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(39, 36);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTranAdd
            // 
            this.btnTranAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTranAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranAdd.ForeColor = System.Drawing.Color.White;
            this.btnTranAdd.Location = new System.Drawing.Point(138, 3);
            this.btnTranAdd.Name = "btnTranAdd";
            this.btnTranAdd.Size = new System.Drawing.Size(39, 36);
            this.btnTranAdd.TabIndex = 5;
            this.btnTranAdd.Text = "T+";
            this.btnTranAdd.UseVisualStyleBackColor = false;
            this.btnTranAdd.Click += new System.EventHandler(this.btnTranAdd_Click);
            // 
            // btnGrpAdd
            // 
            this.btnGrpAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGrpAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrpAdd.ForeColor = System.Drawing.Color.White;
            this.btnGrpAdd.Location = new System.Drawing.Point(93, 3);
            this.btnGrpAdd.Name = "btnGrpAdd";
            this.btnGrpAdd.Size = new System.Drawing.Size(39, 36);
            this.btnGrpAdd.TabIndex = 5;
            this.btnGrpAdd.Text = "G+";
            this.btnGrpAdd.UseVisualStyleBackColor = false;
            // 
            // btnYrAdd
            // 
            this.btnYrAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnYrAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYrAdd.ForeColor = System.Drawing.Color.White;
            this.btnYrAdd.Location = new System.Drawing.Point(3, 3);
            this.btnYrAdd.Name = "btnYrAdd";
            this.btnYrAdd.Size = new System.Drawing.Size(39, 36);
            this.btnYrAdd.TabIndex = 3;
            this.btnYrAdd.Text = "Y+";
            this.btnYrAdd.UseVisualStyleBackColor = false;
            this.btnYrAdd.Click += new System.EventHandler(this.btnYrAdd_Click);
            // 
            // btnAccAdd
            // 
            this.btnAccAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAccAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccAdd.ForeColor = System.Drawing.Color.White;
            this.btnAccAdd.Location = new System.Drawing.Point(48, 3);
            this.btnAccAdd.Name = "btnAccAdd";
            this.btnAccAdd.Size = new System.Drawing.Size(39, 36);
            this.btnAccAdd.TabIndex = 4;
            this.btnAccAdd.Text = "A+";
            this.btnAccAdd.UseVisualStyleBackColor = false;
            this.btnAccAdd.Click += new System.EventHandler(this.btnAccAdd_Click);
            // 
            // userInfoPanel
            // 
            userInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            userInfoPanel.Controls.Add(userInfo);
            userInfoPanel.Location = new System.Drawing.Point(284, 3);
            userInfoPanel.Name = "userInfoPanel";
            userInfoPanel.Size = new System.Drawing.Size(1067, 44);
            userInfoPanel.TabIndex = 16;
            // 
            // userInfo
            // 
            userInfo.AutoSize = true;
            userInfo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userInfo.Location = new System.Drawing.Point(14, 14);
            userInfo.Name = "userInfo";
            userInfo.Size = new System.Drawing.Size(0, 26);
            userInfo.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Location = new System.Drawing.Point(3, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(274, 87);
            this.logo.TabIndex = 15;
            // 
            // navPanel
            // 
            navPanel.Controls.Add(this.btnReports);
            navPanel.Controls.Add(btnMyAccDetails);
            navPanel.Controls.Add(this.btnTransaction);
            navPanel.Controls.Add(this.btnEventAcc);
            navPanel.Controls.Add(btnMyAcc);
            navPanel.Location = new System.Drawing.Point(3, 97);
            navPanel.Name = "navPanel";
            navPanel.Size = new System.Drawing.Size(274, 555);
            navPanel.TabIndex = 18;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.White;
            this.btnReports.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnReports.Location = new System.Drawing.Point(5, 409);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(261, 93);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnMyAccDetails
            // 
            btnMyAccDetails.BackColor = System.Drawing.Color.White;
            btnMyAccDetails.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnMyAccDetails.ForeColor = System.Drawing.Color.RoyalBlue;
            btnMyAccDetails.Location = new System.Drawing.Point(5, 310);
            btnMyAccDetails.Name = "btnMyAccDetails";
            btnMyAccDetails.Size = new System.Drawing.Size(261, 93);
            btnMyAccDetails.TabIndex = 2;
            btnMyAccDetails.Text = "MY ACTIVITIES";
            btnMyAccDetails.UseVisualStyleBackColor = false;
            btnMyAccDetails.Click += new System.EventHandler(btnMyAccDetails_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.White;
            this.btnTransaction.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnTransaction.Location = new System.Drawing.Point(5, 211);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(261, 93);
            this.btnTransaction.TabIndex = 3;
            this.btnTransaction.Text = "TRANSACTION";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnEventAcc
            // 
            this.btnEventAcc.BackColor = System.Drawing.Color.White;
            this.btnEventAcc.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventAcc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEventAcc.Location = new System.Drawing.Point(5, 112);
            this.btnEventAcc.Name = "btnEventAcc";
            this.btnEventAcc.Size = new System.Drawing.Size(261, 93);
            this.btnEventAcc.TabIndex = 4;
            this.btnEventAcc.Text = "EVENT ACCOUNTING";
            this.btnEventAcc.UseVisualStyleBackColor = false;
            this.btnEventAcc.Click += new System.EventHandler(this.btnEventAcc_Click);
            // 
            // btnMyAcc
            // 
            btnMyAcc.BackColor = System.Drawing.Color.White;
            btnMyAcc.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnMyAcc.ForeColor = System.Drawing.Color.RoyalBlue;
            btnMyAcc.Location = new System.Drawing.Point(5, 13);
            btnMyAcc.Name = "btnMyAcc";
            btnMyAcc.Size = new System.Drawing.Size(261, 93);
            btnMyAcc.TabIndex = 5;
            btnMyAcc.Text = "MY ACCOUNT";
            btnMyAcc.UseVisualStyleBackColor = false;
            btnMyAcc.Click += new System.EventHandler(btnMyAcc_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 664);
            this.Controls.Add(navPanel);
            this.Controls.Add(shortbtnPanel);
            this.Controls.Add(userInfoPanel);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUDRA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            shortbtnPanel.ResumeLayout(false);
            userInfoPanel.ResumeLayout(false);
            userInfoPanel.PerformLayout();
            navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundButton btnLogout;
        private RoundButton btnTranAdd;
        private RoundButton btnGrpAdd;
        private RoundButton btnYrAdd;
        private RoundButton btnAccAdd;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnMyAccDetails;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnEventAcc;
        public static System.Windows.Forms.Label userInfo;
        public static System.Windows.Forms.Panel shortbtnPanel;
        public static System.Windows.Forms.Panel userInfoPanel;
        public static System.Windows.Forms.Panel navPanel;
        public static System.Windows.Forms.Button btnMyAcc;
    }
}