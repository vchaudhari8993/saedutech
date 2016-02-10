namespace saEdu
{
    partial class user_option
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
            this.button1 = new System.Windows.Forms.Button();
            this.show_acc_list = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(34, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD NEW TRANSACTION";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // show_acc_list
            // 
            this.show_acc_list.BackColor = System.Drawing.Color.White;
            this.show_acc_list.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.show_acc_list.ForeColor = System.Drawing.Color.RoyalBlue;
            this.show_acc_list.Location = new System.Drawing.Point(34, 136);
            this.show_acc_list.Name = "show_acc_list";
            this.show_acc_list.Size = new System.Drawing.Size(325, 95);
            this.show_acc_list.TabIndex = 0;
            this.show_acc_list.Text = "SHOW ACCOUNT LIST";
            this.show_acc_list.UseVisualStyleBackColor = false;
            this.show_acc_list.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button3.Location = new System.Drawing.Point(34, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(325, 95);
            this.button3.TabIndex = 0;
            this.button3.Text = "EDIT ACCOUNT LIST";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // reports
            // 
            this.reports.BackColor = System.Drawing.Color.White;
            this.reports.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.reports.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reports.Location = new System.Drawing.Point(34, 338);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(325, 95);
            this.reports.TabIndex = 0;
            this.reports.Text = "REPORTS";
            this.reports.UseVisualStyleBackColor = false;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 436);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(362, 41);
            this.button5.TabIndex = 0;
            this.button5.Text = "BACK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // user_option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 489);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.show_acc_list);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "user_option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button show_acc_list;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button button5;
    }
}