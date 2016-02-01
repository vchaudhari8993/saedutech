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
using System.Web.ClientServices;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
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
            long int_data;
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            DataTable dt = new DataTable();
            DateTime d,d1;

            //bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            
            //AuthenticationManager.Authenticate("",)
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/list_of_accounting_years/");

                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/list_of_accounting_years/"), new Cookie("sessionid", GlobalClass.session));
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //MessageBox.Show(result);
                    JObject obj = JObject.Parse(result);
                    dt.Columns.Add("Start Date");
                    dt.Columns.Add("End Date");
                    //var data = "";

                    /*JToken accYr= (JToken)(obj["AccYearsList"][0]);
                    MessageBox.Show(Convert.ToString(accYr["start_date"]));*/
                    string str1 = (Convert.ToString(obj["AccYearsList"]));
                    //MessageBox.Show(str1);
                    int counter = 0;
                    JToken accYr;
                    foreach (var ch in str1)
                    {
                        if (ch == 's')
                            counter++;
                    }
                    
                    for (int i = 0; i < counter; i++)
                    {

                        accYr = (JToken)(obj["AccYearsList"][i]);
                        //MessageBox.Show(Convert.ToString(accYr["start_date"]));
                        //MessageBox.Show(Convert.ToString(accYr["end_date"]));
                        
                        int_data = Int32.Parse(Convert.ToString(accYr["start_date"]));
                        d = origin.AddSeconds(int_data);
                        int_data = Int32.Parse(Convert.ToString(accYr["end_date"]));
                        d1 = origin.AddSeconds(int_data);

                        //data = Convert.ToString(obj["AccYearsList"][++i]);
                        //data = Regex.Match(data, @"\d+").Value;
                        //int_data = Int32.Parse(data);
                        //d1 = origin.AddSeconds(int_data);

                        dt.Rows.Add(Convert.ToString(d).Substring(0, 9), Convert.ToString(d1).Substring(0, 9));
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Oops! Something went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void roundButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
