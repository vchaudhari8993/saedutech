namespace saEdu
{
    partial class create_user
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reg_date_from = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.acc_grp = new System.Windows.Forms.TextBox();
            this.reg_acc_validity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reg_acc_period = new System.Windows.Forms.NumericUpDown();
            this.reg_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_contact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_acc_type = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.grp_dropdown = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_acc_period)).BeginInit();
            this.panel2.SuspendLayout();
            this.grp_dropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Type*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(18, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(212, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name*";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date From*";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // reg_name
            // 
            this.reg_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reg_name.Location = new System.Drawing.Point(176, 13);
            this.reg_name.Name = "reg_name";
            this.reg_name.Size = new System.Drawing.Size(206, 31);
            this.reg_name.TabIndex = 0;
            this.reg_name.Leave += new System.EventHandler(this.reg_name_Leave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.reg_date_from);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.acc_grp);
            this.panel1.Controls.Add(this.reg_acc_validity);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.reg_acc_period);
            this.panel1.Controls.Add(this.reg_email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.reg_contact);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.reg_acc_type);
            this.panel1.Controls.Add(this.reg_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(7, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 422);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(361, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(21, 31);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // reg_date_from
            // 
            this.reg_date_from.Enabled = false;
            this.reg_date_from.Location = new System.Drawing.Point(176, 221);
            this.reg_date_from.Name = "reg_date_from";
            this.reg_date_from.Size = new System.Drawing.Size(169, 31);
            this.reg_date_from.TabIndex = 14;
            this.reg_date_from.TextChanged += new System.EventHandler(this.reg_date_from_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(361, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.Leave += new System.EventHandler(this.button4_Leave);
            // 
            // acc_grp
            // 
            this.acc_grp.Enabled = false;
            this.acc_grp.Location = new System.Drawing.Point(176, 148);
            this.acc_grp.Name = "acc_grp";
            this.acc_grp.Size = new System.Drawing.Size(179, 31);
            this.acc_grp.TabIndex = 12;
            // 
            // reg_acc_validity
            // 
            this.reg_acc_validity.Enabled = false;
            this.reg_acc_validity.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reg_acc_validity.Location = new System.Drawing.Point(176, 297);
            this.reg_acc_validity.Name = "reg_acc_validity";
            this.reg_acc_validity.Size = new System.Drawing.Size(224, 31);
            this.reg_acc_validity.TabIndex = 7;
            this.reg_acc_validity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Valid Until";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Years";
            // 
            // reg_acc_period
            // 
            this.reg_acc_period.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reg_acc_period.Location = new System.Drawing.Point(250, 260);
            this.reg_acc_period.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reg_acc_period.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reg_acc_period.Name = "reg_acc_period";
            this.reg_acc_period.Size = new System.Drawing.Size(47, 31);
            this.reg_acc_period.TabIndex = 6;
            this.reg_acc_period.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reg_acc_period.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.reg_acc_period.Enter += new System.EventHandler(this.reg_acc_period_Enter);
            // 
            // reg_email
            // 
            this.reg_email.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reg_email.Location = new System.Drawing.Point(176, 87);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(206, 31);
            this.reg_email.TabIndex = 2;
            this.reg_email.TextChanged += new System.EventHandler(this.reg_email_TextChanged);
            this.reg_email.Leave += new System.EventHandler(this.reg_email_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "E-mail*";
            // 
            // reg_contact
            // 
            this.reg_contact.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reg_contact.Location = new System.Drawing.Point(176, 50);
            this.reg_contact.Name = "reg_contact";
            this.reg_contact.Size = new System.Drawing.Size(206, 31);
            this.reg_contact.TabIndex = 1;
            this.reg_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reg_contact_KeyPress);
            this.reg_contact.Leave += new System.EventHandler(this.reg_contact_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contact No.*";
            // 
            // reg_acc_type
            // 
            this.reg_acc_type.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reg_acc_type.Items.Add("Personal");
            this.reg_acc_type.Items.Add("Nominal");
            this.reg_acc_type.Items.Add("Real");
            this.reg_acc_type.Location = new System.Drawing.Point(176, 183);
            this.reg_acc_type.Name = "reg_acc_type";
            this.reg_acc_type.Size = new System.Drawing.Size(206, 31);
            this.reg_acc_type.TabIndex = 4;
            this.reg_acc_type.Text = "Select Account Type";
            this.reg_acc_type.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            this.reg_acc_type.Leave += new System.EventHandler(this.reg_acc_type_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Account Period for account";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Account Group*";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 44);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(130, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "New User Account";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(8, 484);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(418, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grp_dropdown
            // 
            this.grp_dropdown.Controls.Add(this.listBox1);
            this.grp_dropdown.Location = new System.Drawing.Point(432, 56);
            this.grp_dropdown.Name = "grp_dropdown";
            this.grp_dropdown.Size = new System.Drawing.Size(228, 436);
            this.grp_dropdown.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "Bank Accounts",
            "Bank OCC A/c",
            "Branch/Division",
            "Capital Acount",
            "Cash-in-Hand",
            "Current Assets",
            "Current liabilities",
            "Deposites (Assets)",
            "Direct Expences",
            "Direct Incomes",
            "Duties & Taxes",
            "Expenses (Direct)",
            "Expences (Indirect)",
            "Fixed Assets",
            "Income (Direct)",
            "Income (Indirect)",
            "Indirect Expences",
            "Indirect Incomes",
            "Investments",
            "Loan & Advances (Assets)",
            "Loans (Liability)",
            "Misc. Expences (Assets)",
            "Provisions",
            "Purchase Accounts",
            "reserve & surplus",
            "Retained Earning",
            "Sales Accounts",
            "Secured Loans",
            "Stock in hand"});
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 403);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Tag = "Enter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Choose Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(176, 334);
            this.password.MaxLength = 20;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(224, 31);
            this.password.TabIndex = 16;
            this.password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // create_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 531);
            this.Controls.Add(this.grp_dropdown);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "create_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_acc_period)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grp_dropdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DomainUpDown reg_acc_type;
        private System.Windows.Forms.TextBox reg_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reg_contact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown reg_acc_period;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox reg_acc_validity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel grp_dropdown;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox acc_grp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox reg_date_from;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label11;
        private System.ServiceProcess.ServiceController serviceController1;

    }
}