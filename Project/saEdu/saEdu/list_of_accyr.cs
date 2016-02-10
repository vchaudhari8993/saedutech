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
using System.Json;
namespace saEdu
{

    public partial class user_acc : Form
    {
        //long int_data;
        //DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        public class User
        {
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
                    JObject obj = JObject.Parse(result);
                    dt.Columns.Add("Start Date");
                    dt.Columns.Add("End Date");
                    //var data = "";

                    /*JToken accYr= (JToken)(obj["AccYearsList"][0]);
                    MessageBox.Show(Convert.ToString(accYr["start_date"]));*/
                    string str1 = (Convert.ToString(obj["AccYearsList"]));
                    //MessageBox.Show(str1);
                    int counter = 0;
                    //JToken accYr;
                    foreach (var ch in str1)
                    {
                        if (ch == '{')
                            counter++;
                    }
                    if(counter>0)
                    {
                        for (int i = 0; i < counter; i++)
                        {

                            //accYr = (JToken)(obj["AccYearsList"][i]);
                            //MessageBox.Show(Convert.ToString(accYr["start_date"]));
                            //MessageBox.Show(Convert.ToString(accYr["end_date"]));
                            ////////////////////////////////////////////////////////////
                            //merged the value insted of variable if error then undo this
                            ////////////////////////////////////////////////////////////
                            //int_data = Int32.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["start_date"]));
                            d = GlobalClass.origin.AddMilliseconds(Int64.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["start_date"])));
                            //int_data = Int32.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["end_date"]));
                            d1 = GlobalClass.origin.AddMilliseconds(Int64.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["end_date"])));
                            
                            //data = Convert.ToString(obj["AccYearsList"][++i]);
                            //data = Regex.Match(data, @"\d+").Value;
                            //int_data = Int32.Parse(data);
                            //d1 = origin.AddSeconds(int_data);

                            dt.Rows.Add(d.ToShortDateString(), d1.ToShortDateString());
                            dataGridView1.DataSource = dt;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Data found for your account");
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
            cr_dr_detail u = new cr_dr_detail();
            u.Show();
            this.Hide();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            create_account c = new create_account();
            c.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var dataIndexNo = dataGridView1.Rows[e.RowIndex].Index.ToString();
            //string cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //string cellValue1 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //Convert.ToDateTime(cellValue);

            //var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            /////////////////////////////////////////////////////
            //edited below code if goves error undo it
            //int_data= Convert.ToInt64((Convert.ToDateTime(cellValue) - GlobalClass.origin).TotalSeconds);
            GlobalClass.start_date = Convert.ToInt64((Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) - GlobalClass.origin).TotalMilliseconds);
            //int_data = Convert.ToInt64((Convert.ToDateTime(cellValue1) - GlobalClass.origin).TotalSeconds);
            GlobalClass.end_date = Convert.ToInt64((Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) - GlobalClass.origin).TotalMilliseconds);
            user_option uo = new user_option();
            uo.Show();
            this.Hide();
            //MessageBox.Show(Convert.ToString(GlobalClass.start_date) + " " + Convert.ToString(GlobalClass.end_date));
            //MessageBox.Show(Convert.ToString(int_data));
            //MessageBox.Show("the row data is: "+ cellValue+" "+cellValue1);
            //"The row index = " + dataIndexNo.ToString() + " and 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
