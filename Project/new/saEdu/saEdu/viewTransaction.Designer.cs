namespace saEdu
{
    partial class viewTransaction
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
            this.showAccwise = new System.Windows.Forms.Button();
            this.viewAll = new System.Windows.Forms.Button();
            this.showYrwise = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.showAccwise);
            this.panel1.Controls.Add(this.viewAll);
            this.panel1.Controls.Add(this.showYrwise);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 355);
            this.panel1.TabIndex = 2;
            // 
            // showAccwise
            // 
            this.showAccwise.BackColor = System.Drawing.Color.White;
            this.showAccwise.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAccwise.ForeColor = System.Drawing.Color.RoyalBlue;
            this.showAccwise.Location = new System.Drawing.Point(15, 131);
            this.showAccwise.Name = "showAccwise";
            this.showAccwise.Size = new System.Drawing.Size(298, 95);
            this.showAccwise.TabIndex = 1;
            this.showAccwise.Text = "VIEW TRANSACTIONS ACCOUNTWISE";
            this.showAccwise.UseVisualStyleBackColor = false;
            this.showAccwise.Click += new System.EventHandler(this.showAccwise_Click);
            // 
            // viewAll
            // 
            this.viewAll.BackColor = System.Drawing.Color.White;
            this.viewAll.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAll.ForeColor = System.Drawing.Color.RoyalBlue;
            this.viewAll.Location = new System.Drawing.Point(15, 20);
            this.viewAll.Name = "viewAll";
            this.viewAll.Size = new System.Drawing.Size(298, 95);
            this.viewAll.TabIndex = 0;
            this.viewAll.Text = "VIEW ALL TRANSACTION";
            this.viewAll.UseVisualStyleBackColor = false;
            this.viewAll.Click += new System.EventHandler(this.viewAll_Click);
            // 
            // showYrwise
            // 
            this.showYrwise.BackColor = System.Drawing.Color.White;
            this.showYrwise.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showYrwise.ForeColor = System.Drawing.Color.RoyalBlue;
            this.showYrwise.Location = new System.Drawing.Point(15, 241);
            this.showYrwise.Name = "showYrwise";
            this.showYrwise.Size = new System.Drawing.Size(298, 95);
            this.showYrwise.TabIndex = 2;
            this.showYrwise.Text = "VIEW TRANSACTION YEARWISE";
            this.showYrwise.UseVisualStyleBackColor = false;
            this.showYrwise.Click += new System.EventHandler(this.showYrwise_Click);
            // 
            // viewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 377);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "viewTransaction";
            this.Load += new System.EventHandler(this.viewTransaction_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showAccwise;
        private System.Windows.Forms.Button viewAll;
        private System.Windows.Forms.Button showYrwise;
    }
}