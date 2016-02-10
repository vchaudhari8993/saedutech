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
    public partial class user_option : Form
    {
        public user_option()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acc_list al = new acc_list();
            al.Show();
            this.Hide();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            user_acc_detail uad = new user_acc_detail();
            uad.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            user_acc ua = new user_acc();
            ua.Show();
            this.Hide();
        }
    }
}
