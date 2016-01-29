namespace saEdu
{
    partial class newUserAcc
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
            this.label1 = new System.Windows.Forms.Label();
            this.newAccName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.aliasAcc = new System.Windows.Forms.TextBox();
            this.grpName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addLine1 = new System.Windows.Forms.TextBox();
            this.addLine2 = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mobNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.altMobNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.openingBal = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Account Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // newAccName
            // 
            this.newAccName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccName.Location = new System.Drawing.Point(230, 28);
            this.newAccName.Name = "newAccName";
            this.newAccName.Size = new System.Drawing.Size(317, 33);
            this.newAccName.TabIndex = 0;
            this.newAccName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(55, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(492, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "ADD USER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alies for Account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // aliasAcc
            // 
            this.aliasAcc.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aliasAcc.Location = new System.Drawing.Point(230, 66);
            this.aliasAcc.Name = "aliasAcc";
            this.aliasAcc.Size = new System.Drawing.Size(317, 33);
            this.aliasAcc.TabIndex = 1;
            this.aliasAcc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpName
            // 
            this.grpName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpName.FormattingEnabled = true;
            this.grpName.Location = new System.Drawing.Point(230, 104);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(121, 34);
            this.grpName.TabIndex = 2;
            this.grpName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Group Name*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Personal Information";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // addLine1
            // 
            this.addLine1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLine1.Location = new System.Drawing.Point(230, 227);
            this.addLine1.Name = "addLine1";
            this.addLine1.Size = new System.Drawing.Size(317, 33);
            this.addLine1.TabIndex = 5;
            this.addLine1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addLine2
            // 
            this.addLine2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLine2.Location = new System.Drawing.Point(230, 265);
            this.addLine2.Name = "addLine2";
            this.addLine2.Size = new System.Drawing.Size(317, 33);
            this.addLine2.TabIndex = 6;
            this.addLine2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // state
            // 
            this.state.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.Location = new System.Drawing.Point(394, 304);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(153, 33);
            this.state.TabIndex = 8;
            this.state.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(230, 304);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(153, 33);
            this.city.TabIndex = 7;
            this.city.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(394, 188);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(153, 33);
            this.lastName.TabIndex = 4;
            this.lastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(230, 188);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(153, 33);
            this.firstName.TabIndex = 3;
            this.firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(230, 382);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(317, 33);
            this.email.TabIndex = 11;
            this.email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mobile No.";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // mobNo
            // 
            this.mobNo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobNo.Location = new System.Drawing.Point(230, 421);
            this.mobNo.Name = "mobNo";
            this.mobNo.Size = new System.Drawing.Size(317, 33);
            this.mobNo.TabIndex = 12;
            this.mobNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Alternate Mobile No.";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // altMobNo
            // 
            this.altMobNo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altMobNo.Location = new System.Drawing.Point(230, 460);
            this.altMobNo.Name = "altMobNo";
            this.altMobNo.Size = new System.Drawing.Size(317, 33);
            this.altMobNo.TabIndex = 13;
            this.altMobNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Opening Balance";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // openingBal
            // 
            this.openingBal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openingBal.Location = new System.Drawing.Point(256, 499);
            this.openingBal.Name = "openingBal";
            this.openingBal.Size = new System.Drawing.Size(291, 33);
            this.openingBal.TabIndex = 14;
            this.openingBal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // country
            // 
            this.country.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.Location = new System.Drawing.Point(394, 343);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(153, 33);
            this.country.TabIndex = 10;
            this.country.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pin
            // 
            this.pin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin.Location = new System.Drawing.Point(230, 343);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(153, 33);
            this.pin.TabIndex = 9;
            this.pin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(226, 504);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "₹";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "UserName";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // newUserAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 579);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aliasAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.city);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.country);
            this.Controls.Add(this.state);
            this.Controls.Add(this.addLine2);
            this.Controls.Add(this.openingBal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.altMobNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mobNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addLine1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newAccName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "newUserAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User Account";
            this.Load += new System.EventHandler(this.newUserAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newAccName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aliasAcc;
        private System.Windows.Forms.ComboBox grpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addLine1;
        private System.Windows.Forms.TextBox addLine2;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mobNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox altMobNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox openingBal;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
    }
}