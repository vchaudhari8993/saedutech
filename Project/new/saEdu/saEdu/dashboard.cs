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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_acc obj = new user_acc();
            obj.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            admin_panel obj = new admin_panel();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reports f7 = new reports();
            f7.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            create_account ca = new create_account();
            ca.Show();
            this.Hide();
            //Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            user_acc obj = new user_acc();
            obj.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            admin_panel obj = new admin_panel();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            show_transaction_details st = new show_transaction_details();
            st.Show();
            this.Hide();
        }
    }
}
