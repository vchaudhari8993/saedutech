﻿namespace saEdu
{
    partial class create_account
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.grp_dropdown = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.button4 = new System.Windows.Forms.Button();
            this.acc_grp = new System.Windows.Forms.TextBox();
            this.reg_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_acc_type = new System.Windows.Forms.DomainUpDown();
            this.reg_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_acc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.alias = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.addLine2 = new System.Windows.Forms.TextBox();
            this.addLine1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.reg_contact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.alt_cont = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.openingBal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.grp_dropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 30);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(144, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "NEW ACCOUNT";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(7, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(432, 41);
            this.button3.TabIndex = 18;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grp_dropdown
            // 
            this.grp_dropdown.Controls.Add(this.listBox1);
            this.grp_dropdown.Location = new System.Drawing.Point(445, 42);
            this.grp_dropdown.Name = "grp_dropdown";
            this.grp_dropdown.Size = new System.Drawing.Size(228, 417);
            this.grp_dropdown.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(3, 5);
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
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(418, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 33);
            this.button4.TabIndex = 2;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.Leave += new System.EventHandler(this.button4_Leave);
            // 
            // acc_grp
            // 
            this.acc_grp.Enabled = false;
            this.acc_grp.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc_grp.ForeColor = System.Drawing.Color.Black;
            this.acc_grp.Location = new System.Drawing.Point(186, 120);
            this.acc_grp.Name = "acc_grp";
            this.acc_grp.Size = new System.Drawing.Size(226, 33);
            this.acc_grp.TabIndex = 2;
            this.acc_grp.TextChanged += new System.EventHandler(this.acc_grp_TextChanged);
            // 
            // reg_email
            // 
            this.reg_email.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_email.ForeColor = System.Drawing.Color.Black;
            this.reg_email.Location = new System.Drawing.Point(122, 433);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(317, 33);
            this.reg_email.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(19, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 30;
            this.label5.Text = "E-mail";
            // 
            // reg_acc_type
            // 
            this.reg_acc_type.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_acc_type.ForeColor = System.Drawing.Color.Black;
            this.reg_acc_type.Location = new System.Drawing.Point(186, 159);
            this.reg_acc_type.Name = "reg_acc_type";
            this.reg_acc_type.Size = new System.Drawing.Size(253, 33);
            this.reg_acc_type.TabIndex = 3;
            this.reg_acc_type.Text = "Select Account Type";
            this.reg_acc_type.SelectedItemChanged += new System.EventHandler(this.reg_acc_type_SelectedItemChanged);
            this.reg_acc_type.Enter += new System.EventHandler(this.reg_acc_type_Enter);
            // 
            // reg_name
            // 
            this.reg_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_name.ForeColor = System.Drawing.Color.Black;
            this.reg_name.Location = new System.Drawing.Point(186, 42);
            this.reg_name.Name = "reg_name";
            this.reg_name.Size = new System.Drawing.Size(253, 33);
            this.reg_name.TabIndex = 0;
            this.reg_name.Enter += new System.EventHandler(this.reg_name_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Account Name";
            // 
            // add_acc
            // 
            this.add_acc.BackColor = System.Drawing.Color.White;
            this.add_acc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_acc.Location = new System.Drawing.Point(236, 508);
            this.add_acc.Name = "add_acc";
            this.add_acc.Size = new System.Drawing.Size(203, 42);
            this.add_acc.TabIndex = 17;
            this.add_acc.Text = "Add Account";
            this.add_acc.UseVisualStyleBackColor = false;
            this.add_acc.Click += new System.EventHandler(this.add_acc_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(7, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(22, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 26);
            this.label10.TabIndex = 22;
            this.label10.Text = "Account Group*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(22, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Account Type*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(22, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 26);
            this.label12.TabIndex = 18;
            this.label12.Text = "Alias";
            // 
            // alias
            // 
            this.alias.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alias.ForeColor = System.Drawing.Color.Black;
            this.alias.Location = new System.Drawing.Point(186, 81);
            this.alias.Name = "alias";
            this.alias.Size = new System.Drawing.Size(253, 33);
            this.alias.TabIndex = 1;
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.Black;
            this.firstName.Location = new System.Drawing.Point(127, 239);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(153, 33);
            this.firstName.TabIndex = 5;
            // 
            // pin
            // 
            this.pin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin.ForeColor = System.Drawing.Color.Black;
            this.pin.Location = new System.Drawing.Point(122, 394);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(153, 33);
            this.pin.TabIndex = 11;
            this.pin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pin_KeyPress);
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.Black;
            this.city.Location = new System.Drawing.Point(122, 355);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(153, 33);
            this.city.TabIndex = 9;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.Black;
            this.lastName.Location = new System.Drawing.Point(286, 239);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(153, 33);
            this.lastName.TabIndex = 6;
            // 
            // country
            // 
            this.country.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.ForeColor = System.Drawing.Color.Black;
            this.country.Location = new System.Drawing.Point(286, 394);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(153, 33);
            this.country.TabIndex = 12;
            // 
            // state
            // 
            this.state.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.ForeColor = System.Drawing.Color.Black;
            this.state.Location = new System.Drawing.Point(286, 355);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(153, 33);
            this.state.TabIndex = 10;
            // 
            // addLine2
            // 
            this.addLine2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLine2.ForeColor = System.Drawing.Color.Black;
            this.addLine2.Location = new System.Drawing.Point(122, 316);
            this.addLine2.Name = "addLine2";
            this.addLine2.Size = new System.Drawing.Size(317, 33);
            this.addLine2.TabIndex = 8;
            // 
            // addLine1
            // 
            this.addLine1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLine1.ForeColor = System.Drawing.Color.Black;
            this.addLine1.Location = new System.Drawing.Point(122, 278);
            this.addLine1.Name = "addLine1";
            this.addLine1.Size = new System.Drawing.Size(317, 33);
            this.addLine1.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label13.Location = new System.Drawing.Point(19, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 26);
            this.label13.TabIndex = 50;
            this.label13.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label14.Location = new System.Drawing.Point(22, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 26);
            this.label14.TabIndex = 51;
            this.label14.Text = "Name";
            // 
            // reg_contact
            // 
            this.reg_contact.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_contact.ForeColor = System.Drawing.Color.Black;
            this.reg_contact.Location = new System.Drawing.Point(122, 472);
            this.reg_contact.Name = "reg_contact";
            this.reg_contact.Size = new System.Drawing.Size(153, 33);
            this.reg_contact.TabIndex = 14;
            this.reg_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reg_contact_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(2, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 61;
            this.label4.Text = "Contact No.";
            // 
            // alt_cont
            // 
            this.alt_cont.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alt_cont.ForeColor = System.Drawing.Color.Black;
            this.alt_cont.Location = new System.Drawing.Point(286, 471);
            this.alt_cont.Name = "alt_cont";
            this.alt_cont.Size = new System.Drawing.Size(153, 33);
            this.alt_cont.TabIndex = 15;
            this.alt_cont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alt_cont_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label16.Location = new System.Drawing.Point(181, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 26);
            this.label16.TabIndex = 72;
            this.label16.Text = "₹";
            // 
            // openingBal
            // 
            this.openingBal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openingBal.ForeColor = System.Drawing.Color.Black;
            this.openingBal.Location = new System.Drawing.Point(215, 198);
            this.openingBal.Name = "openingBal";
            this.openingBal.Size = new System.Drawing.Size(224, 33);
            this.openingBal.TabIndex = 4;
            this.openingBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.openingBal_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label17.Location = new System.Drawing.Point(22, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 26);
            this.label17.TabIndex = 70;
            this.label17.Text = "Opening Balance";
            // 
            // create_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 603);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.openingBal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.alt_cont);
            this.Controls.Add(this.reg_contact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.city);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.country);
            this.Controls.Add(this.state);
            this.Controls.Add(this.addLine2);
            this.Controls.Add(this.addLine1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.grp_dropdown);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.alias);
            this.Controls.Add(this.reg_name);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acc_grp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add_acc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reg_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reg_acc_type);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "create_account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a new Account";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grp_dropdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel grp_dropdown;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.TextBox reg_name;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox acc_grp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add_acc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reg_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown reg_acc_type;
        private System.Windows.Forms.TextBox alias;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox alt_cont;
        private System.Windows.Forms.TextBox reg_contact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox addLine2;
        private System.Windows.Forms.TextBox addLine1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox openingBal;
        private System.Windows.Forms.Label label17;
    }
}