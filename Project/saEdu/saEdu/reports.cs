using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace saEdu
{
    public partial class reports : Form
    {
        public OleDbConnection database;
        OleDbCommand oleDbCmd = new OleDbCommand();
        public reports()
        {
            database = new OleDbConnection(GlobalClass.database);
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cr_dr_detail cr = new cr_dr_detail();
            cr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reports_Load(object sender, EventArgs e)
        {
            database.Open();
            oleDbCmd.Connection = database;
            string q = "select * from emp";
            oleDbCmd.CommandText = q;
            OleDbDataAdapter da = new OleDbDataAdapter(oleDbCmd);
            DataTable dt = new DataTable();
            //dt.AcceptChanges();
            dt.DefaultView.AllowEdit = false;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            database.Close();
        }
    }
}
