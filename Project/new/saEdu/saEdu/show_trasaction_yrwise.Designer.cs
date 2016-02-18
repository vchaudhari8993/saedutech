namespace saEdu
{
    partial class show_trasaction_yrwise
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.show_transaction_grid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.show_transaction_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // show_transaction_grid
            // 
            this.show_transaction_grid.AllowUserToAddRows = false;
            this.show_transaction_grid.AllowUserToDeleteRows = false;
            this.show_transaction_grid.AllowUserToResizeColumns = false;
            this.show_transaction_grid.AllowUserToResizeRows = false;
            this.show_transaction_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.show_transaction_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.show_transaction_grid.BackgroundColor = System.Drawing.Color.White;
            this.show_transaction_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.show_transaction_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.show_transaction_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_transaction_grid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.show_transaction_grid.DefaultCellStyle = dataGridViewCellStyle10;
            this.show_transaction_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.show_transaction_grid.Location = new System.Drawing.Point(12, 48);
            this.show_transaction_grid.Name = "show_transaction_grid";
            this.show_transaction_grid.ReadOnly = true;
            this.show_transaction_grid.RowHeadersVisible = false;
            this.show_transaction_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.show_transaction_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.show_transaction_grid.Size = new System.Drawing.Size(628, 362);
            this.show_transaction_grid.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button3.Location = new System.Drawing.Point(194, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 41);
            this.button3.TabIndex = 20;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // show_trasaction_yrwise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 475);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.show_transaction_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "show_trasaction_yrwise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "show_trasaction_yrwise";
            this.Load += new System.EventHandler(this.show_trasaction_yrwise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_transaction_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView show_transaction_grid;
        private System.Windows.Forms.Button button3;
    }
}