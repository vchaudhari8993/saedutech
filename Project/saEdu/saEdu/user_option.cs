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
    public partial class user_option : Form
    {
        public user_option()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt=new DataTable();
            
            DateTime d = new DateTime();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/show_account_names/");

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.CookieContainer = new CookieContainer();
            httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/show_account_names/"), new Cookie("sessionid", GlobalClass.session));
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                //MessageBox.Show(result);
                JObject obj = JObject.Parse(result);

                dt.Columns.Add("Created At");
                dt.Columns.Add("Account Name");
                //var data = "";

                /*JToken accYr= (JToken)(obj["AccYearsList"][0]);
                MessageBox.Show(Convert.ToString(accYr["start_date"]));*/
                string str1 = (Convert.ToString(obj["account_obj_list"]));

                int counter = 0;
                //JToken accYr;
                foreach (var ch in str1)
                {
                    if (ch == '{')
                        counter++;
                }
                if (counter > 0)
                {
                    //MessageBox.Show(Convert.ToString(counter));
                    for (int i = 0; i < counter; i++)
                    {

                        //accYr = (JToken)(obj["AccYearsList"][i]);
                        //MessageBox.Show(Convert.ToString(accYr["start_date"]));
                        //MessageBox.Show(Convert.ToString(accYr["end_date"]));
                        ////////////////////////////////////////////////////////////
                        //merged the value insted of variable if error then undo this
                        ////////////////////////////////////////////////////////////
                        //int_data = Int32.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["start_date"]));
                        d = GlobalClass.origin.AddMilliseconds(Int64.Parse(Convert.ToString((JToken)(obj["account_obj_list"][i])["created_at"])));

                        //int_data = Int32.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["end_date"]));


                        //data = Convert.ToString(obj["AccYearsList"][++i]);
                        //data = Regex.Match(data, @"\d+").Value;
                        //int_data = Int32.Parse(data);
                        //d1 = origin.AddSeconds(int_data);

                        dt.Rows.Add(d.ToShortDateString(), Convert.ToString((JToken)(obj["account_obj_list"][i])["account_name"]));
                        dataGridView1.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("No Data found for your account");
                }
                panel2.Show();
                panel1.Hide();
                dataGridView1.Focus();
                //acc_list al = new acc_list();
                //al.Show();
                //this.Hide();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            admin_panel a = new admin_panel();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int ii= dataGridView2.CurrentRow.Index;
            //MessageBox.Show(((comboTest)dataGridView2.Rows[ii].Cells[0]).ID);
            panel1.Show();
            panel2.Hide();
        }

        private void user_option_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            panel2.Hide();
            panel1.Hide();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/show_account_names/");

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.CookieContainer = new CookieContainer();
            httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/show_account_names/"), new Cookie("sessionid", GlobalClass.session));
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                dt1.Columns.Add("Account Name");
                dt1.Columns.Add("ID");
                var result = streamReader.ReadToEnd();
                //MessageBox.Show(result);
                JObject obj = JObject.Parse(result);


                //var data = "";

                /*JToken accYr= (JToken)(obj["AccYearsList"][0]);
                MessageBox.Show(Convert.ToString(accYr["start_date"]));*/
                string str1 = (Convert.ToString(obj["account_obj_list"]));

                int counter = 0;
                //JToken accYr;
                foreach (var ch in str1)
                {
                    if (ch == '{')
                        counter++;
                }
                if (counter > 0)
                {
                    //MessageBox.Show(Convert.ToString(counter));
                    for (int i = 0; i < counter; i++)
                    {

                        //accYr = (JToken)(obj["AccYearsList"][i]);
                        //MessageBox.Show(Convert.ToString(accYr["start_date"]));
                        //MessageBox.Show(Convert.ToString(accYr["end_date"]));
                        ////////////////////////////////////////////////////////////
                        //merged the value insted of variable if error then undo this
                        ////////////////////////////////////////////////////////////
                        //int_data = Int32.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["start_date"]));
                        //d = GlobalClass.origin.AddMilliseconds(Int64.Parse(Convert.ToString((JToken)(obj["account_obj_list"][i])["created_at"])));

                        //int_data = Int32.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["end_date"]));


                        //data = Convert.ToString(obj["AccYearsList"][++i]);
                        //data = Regex.Match(data, @"\d+").Value;
                        //int_data = Int32.Parse(data);
                        //d1 = origin.AddSeconds(int_data);
                        dt1.Rows.Add(new comboTest(Convert.ToInt32((JToken)(obj["account_obj_list"])[i]["id"]), Convert.ToString((JToken)(obj["account_obj_list"])[i]["account_name"]), Convert.ToInt64((JToken)(obj["account_obj_list"])[i]["created_at"])), Convert.ToInt64((JToken)(obj["account_obj_list"])[i]["id"]));
                        //listBox1.Items.Add(new comboTest(Convert.ToInt32((JToken)(obj["account_obj_list"])[i]["id"]), Convert.ToString((JToken)(obj["account_obj_list"])[i]["account_name"]), Convert.ToInt64((JToken)(obj["account_obj_list"])[i]["created_at"])));
                        //listBox1.Items.Add(Convert.ToString((JToken)(obj["account_obj_list"][i])["account_name"]));
                    }
                    dataGridView2.DataSource = dt1;
                    dataGridView2.Columns[1].Visible = false;
                }
                else
                {
                    MessageBox.Show("No Data found for your account");
                }
            }

        }

        private void listBox1_Leave(object sender, EventArgs e)
        {
            panel1.Hide();

            reports.Focus();
        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            GlobalClass.acc_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            edit_acc e1 = new edit_acc();
            //MessageBox.Show(Convert.ToString(GlobalClass.acc_id));
            e1.Show();
            this.Hide();
        }
    }
}
