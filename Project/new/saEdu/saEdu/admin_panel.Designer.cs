namespace saEdu
{
    partial class admin_panel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.transaction_date = new System.Windows.Forms.TextBox();
            this.transaction_type = new System.Windows.Forms.DomainUpDown();
            this.get_date = new System.Windows.Forms.DateTimePicker();
            this.transaction_description = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.submit_transaction = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.transaction_record = new System.Windows.Forms.DataGridView();
            this.add_transaction = new System.Windows.Forms.Button();
            this.acc_name1 = new System.Windows.Forms.ComboBox();
            this.transaction_type1 = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cr_amt1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dr_amt1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_record)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Add New Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(206, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADD A TRANSACTION";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(5, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(590, 40);
            this.panel7.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBox4.Location = new System.Drawing.Point(144, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 31);
            this.textBox4.TabIndex = 20;
            // 
            // transaction_date
            // 
            this.transaction_date.Enabled = false;
            this.transaction_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_date.ForeColor = System.Drawing.Color.RoyalBlue;
            this.transaction_date.Location = new System.Drawing.Point(9, 49);
            this.transaction_date.Name = "transaction_date";
            this.transaction_date.Size = new System.Drawing.Size(129, 31);
            this.transaction_date.TabIndex = 3;
            // 
            // transaction_type
            // 
            this.transaction_type.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_type.ForeColor = System.Drawing.Color.RoyalBlue;
            this.transaction_type.Items.Add("Receipt");
            this.transaction_type.Items.Add("Payment");
            this.transaction_type.Items.Add("Sale");
            this.transaction_type.Items.Add("Contra");
            this.transaction_type.Location = new System.Drawing.Point(360, 49);
            this.transaction_type.Name = "transaction_type";
            this.transaction_type.Size = new System.Drawing.Size(228, 31);
            this.transaction_type.TabIndex = 1;
            this.transaction_type.Text = "Select Transaction Type";
            this.transaction_type.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged_1);
            this.transaction_type.Leave += new System.EventHandler(this.transaction_type_Leave);
            // 
            // get_date
            // 
            this.get_date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_date.Location = new System.Drawing.Point(261, 49);
            this.get_date.Name = "get_date";
            this.get_date.Size = new System.Drawing.Size(19, 31);
            this.get_date.TabIndex = 0;
            this.get_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            this.get_date.Leave += new System.EventHandler(this.get_date_Leave);
            // 
            // transaction_description
            // 
            this.transaction_description.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_description.Location = new System.Drawing.Point(9, 189);
            this.transaction_description.Multiline = true;
            this.transaction_description.Name = "transaction_description";
            this.transaction_description.Size = new System.Drawing.Size(585, 64);
            this.transaction_description.TabIndex = 7;
            this.transaction_description.Leave += new System.EventHandler(this.transaction_description_Leave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button5.Location = new System.Drawing.Point(303, 493);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(294, 41);
            this.button5.TabIndex = 10;
            this.button5.Text = "Next";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button5_KeyPress);
            // 
            // submit_transaction
            // 
            this.submit_transaction.BackColor = System.Drawing.Color.White;
            this.submit_transaction.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_transaction.ForeColor = System.Drawing.Color.RoyalBlue;
            this.submit_transaction.Location = new System.Drawing.Point(12, 446);
            this.submit_transaction.Name = "submit_transaction";
            this.submit_transaction.Size = new System.Drawing.Size(586, 41);
            this.submit_transaction.TabIndex = 8;
            this.submit_transaction.Text = "SUBMIT";
            this.submit_transaction.UseVisualStyleBackColor = false;
            this.submit_transaction.Click += new System.EventHandler(this.submit_transaction_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button3.Location = new System.Drawing.Point(12, 493);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(245, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Description";
            // 
            // transaction_record
            // 
            this.transaction_record.AllowUserToAddRows = false;
            this.transaction_record.AllowUserToDeleteRows = false;
            this.transaction_record.AllowUserToResizeColumns = false;
            this.transaction_record.AllowUserToResizeRows = false;
            this.transaction_record.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.transaction_record.BackgroundColor = System.Drawing.Color.White;
            this.transaction_record.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transaction_record.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transaction_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaction_record.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transaction_record.DefaultCellStyle = dataGridViewCellStyle2;
            this.transaction_record.Location = new System.Drawing.Point(9, 259);
            this.transaction_record.Name = "transaction_record";
            this.transaction_record.ReadOnly = true;
            this.transaction_record.RowHeadersVisible = false;
            this.transaction_record.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.transaction_record.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transaction_record.Size = new System.Drawing.Size(585, 181);
            this.transaction_record.TabIndex = 42;
            // 
            // add_transaction
            // 
            this.add_transaction.BackColor = System.Drawing.Color.White;
            this.add_transaction.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_transaction.ForeColor = System.Drawing.Color.RoyalBlue;
            this.add_transaction.Location = new System.Drawing.Point(9, 119);
            this.add_transaction.Name = "add_transaction";
            this.add_transaction.Size = new System.Drawing.Size(579, 41);
            this.add_transaction.TabIndex = 6;
            this.add_transaction.Text = "Add Entry";
            this.add_transaction.UseVisualStyleBackColor = false;
            this.add_transaction.Click += new System.EventHandler(this.add_transaction_Click);
            // 
            // acc_name1
            // 
            this.acc_name1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc_name1.FormattingEnabled = true;
            this.acc_name1.Location = new System.Drawing.Point(47, 86);
            this.acc_name1.Name = "acc_name1";
            this.acc_name1.Size = new System.Drawing.Size(233, 27);
            this.acc_name1.TabIndex = 3;
            this.acc_name1.Leave += new System.EventHandler(this.acc_name1_Leave);
            // 
            // transaction_type1
            // 
            this.transaction_type1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_type1.Items.Add("+");
            this.transaction_type1.Items.Add("-");
            this.transaction_type1.Location = new System.Drawing.Point(9, 84);
            this.transaction_type1.Name = "transaction_type1";
            this.transaction_type1.Size = new System.Drawing.Size(32, 31);
            this.transaction_type1.TabIndex = 2;
            this.transaction_type1.SelectedItemChanged += new System.EventHandler(this.transaction_type1_SelectedItemChanged);
            this.transaction_type1.Leave += new System.EventHandler(this.transaction_type1_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 26);
            this.label8.TabIndex = 59;
            this.label8.Text = "-";
            // 
            // cr_amt1
            // 
            this.cr_amt1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cr_amt1.Location = new System.Drawing.Point(360, 84);
            this.cr_amt1.Multiline = true;
            this.cr_amt1.Name = "cr_amt1";
            this.cr_amt1.Size = new System.Drawing.Size(97, 29);
            this.cr_amt1.TabIndex = 4;
            this.cr_amt1.TextChanged += new System.EventHandler(this.cr_amt1_TextChanged);
            this.cr_amt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cr_amt1_KeyPress);
            this.cr_amt1.Leave += new System.EventHandler(this.cr_amt1_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(468, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 26);
            this.label11.TabIndex = 60;
            this.label11.Text = "+";
            // 
            // dr_amt1
            // 
            this.dr_amt1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_amt1.Location = new System.Drawing.Point(491, 84);
            this.dr_amt1.Multiline = true;
            this.dr_amt1.Name = "dr_amt1";
            this.dr_amt1.Size = new System.Drawing.Size(97, 29);
            this.dr_amt1.TabIndex = 5;
            this.dr_amt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dr_amt1_KeyPress);
            this.dr_amt1.Leave += new System.EventHandler(this.dr_amt1_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(602, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 453);
            this.panel1.TabIndex = 61;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(249, 301);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(866, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_transaction);
            this.Controls.Add(this.acc_name1);
            this.Controls.Add(this.transaction_type1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cr_amt1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dr_amt1);
            this.Controls.Add(this.transaction_record);
            this.Controls.Add(this.transaction_description);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.submit_transaction);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.transaction_date);
            this.Controls.Add(this.transaction_type);
            this.Controls.Add(this.get_date);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MAIN DASHBOARD";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyDown);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_record)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox transaction_date;
        private System.Windows.Forms.DomainUpDown transaction_type;
        private System.Windows.Forms.DateTimePicker get_date;
        private System.Windows.Forms.TextBox transaction_description;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button submit_transaction;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView transaction_record;
        private System.Windows.Forms.Button add_transaction;
        private System.Windows.Forms.ComboBox acc_name1;
        private System.Windows.Forms.DomainUpDown transaction_type1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cr_amt1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dr_amt1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}