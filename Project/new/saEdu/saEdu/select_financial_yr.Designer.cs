namespace saEdu
{
    partial class select_financial_yr
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
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.valid_upto = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.start_month = new System.Windows.Forms.TextBox();
            this.start_date = new System.Windows.Forms.TextBox();
            this.end_date = new System.Windows.Forms.TextBox();
            this.end_month = new System.Windows.Forms.TextBox();
            this.note_panel = new System.Windows.Forms.Panel();
            this.note2 = new System.Windows.Forms.Label();
            this.note1 = new System.Windows.Forms.Label();
            this.note_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(37, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 71;
            this.label3.Text = "Date From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(37, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 26);
            this.label8.TabIndex = 74;
            this.label8.Text = "Valid Until";
            // 
            // valid_upto
            // 
            this.valid_upto.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid_upto.ForeColor = System.Drawing.Color.Black;
            this.valid_upto.Location = new System.Drawing.Point(156, 123);
            this.valid_upto.Name = "valid_upto";
            this.valid_upto.ReadOnly = true;
            this.valid_upto.Size = new System.Drawing.Size(100, 33);
            this.valid_upto.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 33);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // start_month
            // 
            this.start_month.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_month.ForeColor = System.Drawing.Color.Black;
            this.start_month.Location = new System.Drawing.Point(278, 76);
            this.start_month.Name = "start_month";
            this.start_month.ReadOnly = true;
            this.start_month.Size = new System.Drawing.Size(100, 33);
            this.start_month.TabIndex = 1;
            this.start_month.Enter += new System.EventHandler(this.start_month_Enter);
            // 
            // start_date
            // 
            this.start_date.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.ForeColor = System.Drawing.Color.Black;
            this.start_date.Location = new System.Drawing.Point(384, 76);
            this.start_date.Name = "start_date";
            this.start_date.ReadOnly = true;
            this.start_date.Size = new System.Drawing.Size(49, 33);
            this.start_date.TabIndex = 2;
            // 
            // end_date
            // 
            this.end_date.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.ForeColor = System.Drawing.Color.Black;
            this.end_date.Location = new System.Drawing.Point(384, 123);
            this.end_date.Name = "end_date";
            this.end_date.ReadOnly = true;
            this.end_date.Size = new System.Drawing.Size(49, 33);
            this.end_date.TabIndex = 5;
            // 
            // end_month
            // 
            this.end_month.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_month.ForeColor = System.Drawing.Color.Black;
            this.end_month.Location = new System.Drawing.Point(278, 123);
            this.end_month.Name = "end_month";
            this.end_month.ReadOnly = true;
            this.end_month.Size = new System.Drawing.Size(100, 33);
            this.end_month.TabIndex = 4;
            // 
            // note_panel
            // 
            this.note_panel.Controls.Add(this.note2);
            this.note_panel.Controls.Add(this.note1);
            this.note_panel.Location = new System.Drawing.Point(12, 12);
            this.note_panel.Name = "note_panel";
            this.note_panel.Size = new System.Drawing.Size(428, 42);
            this.note_panel.TabIndex = 75;
            // 
            // note2
            // 
            this.note2.AutoSize = true;
            this.note2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note2.ForeColor = System.Drawing.Color.Red;
            this.note2.Location = new System.Drawing.Point(3, 19);
            this.note2.Name = "note2";
            this.note2.Size = new System.Drawing.Size(248, 19);
            this.note2.TabIndex = 18;
            this.note2.Text = "for your account. Please select one";
            // 
            // note1
            // 
            this.note1.AutoSize = true;
            this.note1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note1.ForeColor = System.Drawing.Color.Red;
            this.note1.Location = new System.Drawing.Point(0, 0);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(424, 19);
            this.note1.TabIndex = 19;
            this.note1.Text = "Hey There, It seems that there is no accounting year selected";
            // 
            // select_financial_yr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 165);
            this.Controls.Add(this.note_panel);
            this.Controls.Add(this.start_month);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.end_month);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.valid_upto);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "select_financial_yr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "select_financial_yr";
            this.Load += new System.EventHandler(this.select_financial_yr_Load);
            this.note_panel.ResumeLayout(false);
            this.note_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox valid_upto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox start_month;
        private System.Windows.Forms.TextBox start_date;
        private System.Windows.Forms.TextBox end_date;
        private System.Windows.Forms.TextBox end_month;
        private System.Windows.Forms.Panel note_panel;
        private System.Windows.Forms.Label note2;
        private System.Windows.Forms.Label note1;
    }
}