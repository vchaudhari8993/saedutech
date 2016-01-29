using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace saEdu
{
    public partial class cr_dr_detail : Form
    {
        public cr_dr_detail()
        {
            InitializeComponent();
        }

        private void cr_dr_detail_Load(object sender, EventArgs e)
        {
            dr_panel.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cr_panel.Hide();
            dr_panel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dr_panel.Hide();
            cr_panel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reports r = new reports();
            r.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user_acc ua = new user_acc();
            ua.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            newUserAcc n = new newUserAcc();
            n.Show();
            this.Hide();
        }
    }
}
