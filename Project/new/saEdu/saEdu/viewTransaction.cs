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
    public partial class viewTransaction : Form
    {
        public viewTransaction()
        {
            InitializeComponent();
        }

        private void viewAll_Click(object sender, EventArgs e)
        {
            show_transaction_details showAllTrans = new show_transaction_details();
            showAllTrans.Location = new Point(620, 150);
            showAllTrans.MdiParent = this.MdiParent;
            showAllTrans.Show();
        }

        private void showAccwise_Click(object sender, EventArgs e)
        {
            select_yr_for_acc selectYrForAcc = new select_yr_for_acc();
            selectYrForAcc.Location = new Point(620, 150);
            selectYrForAcc.MdiParent = this.MdiParent;
            //selectYrForAcc.Location = new Point(200, 100);
            selectYrForAcc.Show();
        }

        private void showYrwise_Click(object sender, EventArgs e)
        {
            select_yr selectYrForTrans = new select_yr();
            selectYrForTrans.Location = new Point(680, 150);
            selectYrForTrans.MdiParent = this.MdiParent;
            selectYrForTrans.Show();
        }

        private void viewTransaction_Load(object sender, EventArgs e)
        {

        }
    }
}
