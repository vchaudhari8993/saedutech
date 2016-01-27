using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.Configuration;
using System.Collections;
using System.Web;
using ExtensionMethods;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
//using System.Runtime.Serialization.Json;
namespace saEdu
{
    public partial class user_acc : Form
    {
        public class User
        {
            public bool start_date { get; set; }
            public string end_date { get; set; }
        }
        public user_acc()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboard f3 = new dashboard();
            f3.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void user_view_Load(object sender, EventArgs e)
        {
            //long int_data;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url+"/list_of_accounting_years/");//list_of_accounting_years
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                MessageBox.Show(result);
                var obj = JObject.Parse(result);
                var data = Convert.ToString(obj["AccYearsList"][0]);
                /* Logic for print int (startdate)
                data = Regex.Match(data, @"\d+").Value;
                int_data = Int32.Parse(data);
                MessageBox.Show(Convert.ToString(int_data));
                */
                data = Convert.ToString(obj["AccYearsList"][1]);
                /* Logic for print int (enddate)
                data = Regex.Match(data, @"\d+").Value;
                int_data = Int32.Parse(data);
                MessageBox.Show(Convert.ToString(int_data));
                */

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            user_acc_detail u1 = new user_acc_detail();
            u1.Show();
            this.Hide();
        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            this.user_view_opt.DroppedDown = true;
        }

        private void user_view_opt_DropDown(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void roundButton4_Click_1(object sender, EventArgs e)
        {
            user_view_opt.DroppedDown = true;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cr_dr_detail cr1 = new cr_dr_detail();
            cr1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_next(object sender, EventArgs e)
        {
            user_acc_detail ud = new user_acc_detail();
            ud.Show();
            this.Hide();
        }
    }
}
