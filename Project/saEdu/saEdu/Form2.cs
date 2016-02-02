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

namespace saEdu
{
    public partial class user_acc_detail : Form
    {
        public user_acc_detail()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            acc_detail_opt.DroppedDown = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            user_acc_drop.DroppedDown = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin_panel a = new admin_panel();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void user_acc_detail_Load(object sender, EventArgs e)
        {
            //duration.Text = (GlobalClass.start_date + GlobalClass.end_date);
            /*
            long int_data;
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            DataTable dt = new DataTable();
            DateTime d, d1;
            */
            //code for getting my cash account
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/my_cash_account_balance/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/my_cash_account_balance/"), new Cookie("sessionid", GlobalClass.session));
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"start_date\":" + GlobalClass.start_date + "," +
                                   "\"end_date\":" + GlobalClass.end_date + "}";
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //MessageBox.Show(result);
                    JToken response = JToken.Parse(result);
                    JToken jt = response["cash_balance"];
                    cash_bal.Text = Convert.ToString(jt);

                    /*
                    var data = "";
                    JObject obj = JObject.Parse(result);
                    string str1 = (Convert.ToString(obj["cash_acc_balance_list"]));
                    int counter = 0;
                    foreach (var ch in str1)
                    {
                        if (ch == 's' || ch == 'n')
                            counter++;
                    }
                    for (int i = 0; i < counter; i++)
                    {
                        data = Convert.ToString(obj["AccYearsList"][i]);
                        data = Regex.Match(data, @"\d+").Value;
                        int_data = Int32.Parse(data);
                        d = origin.AddSeconds(int_data);

                        data = Convert.ToString(obj["AccYearsList"][++i]);
                        data = Regex.Match(data, @"\d+").Value;
                        int_data = Int32.Parse(data);
                        d1 = origin.AddSeconds(int_data);

                        dt.Rows.Add(Convert.ToString(d).Substring(0, 9), Convert.ToString(d1).Substring(0, 9));
                        dataGridView1.DataSource = dt;
                    }
                    */
                }
            }
            catch
            {
                MessageBox.Show("Oops! Something went wrong.");
            }

            try
            {
                //code for my bank account data
                var httpWebRequest1 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/my_bank_account_balance/");
                httpWebRequest1.ContentType = "application/json";
                httpWebRequest1.Method = "POST";
                httpWebRequest1.CookieContainer = new CookieContainer();
                httpWebRequest1.CookieContainer.Add(new Uri(GlobalClass.url + "/my_bank_account_balance/"), new Cookie("sessionid", GlobalClass.session));
                using (var streamWriter = new StreamWriter(httpWebRequest1.GetRequestStream()))
                {
                    string json = "{\"start_date\":" + GlobalClass.start_date + "," +
                                   "\"end_date\":" + GlobalClass.end_date + "}";
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse1 = (HttpWebResponse)httpWebRequest1.GetResponse();
                using (var streamReader1 = new StreamReader(httpResponse1.GetResponseStream()))
                {
                    var result1 = streamReader1.ReadToEnd();
                    //MessageBox.Show(result1);
                    JToken response = JToken.Parse(result1);
                    JToken jt = response["bank_balance"];
                    bank_bal.Text = Convert.ToString(jt);

                }
            }
            catch
            {
                MessageBox.Show("Oops! Something went wrong.");
            }
            
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/show_account_names/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/show_account_names/"), new Cookie("sessionid", GlobalClass.session));
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"start_date\":" + GlobalClass.start_date + "," +
                                   "\"end_date\":" + GlobalClass.end_date + "}";
                    //MessageBox.Show(json);
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    MessageBox.Show(result);

                }
            }
            catch
            {
                MessageBox.Show("Oops! Something went wrong.");
            }
            
        }
            

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var httpWebRequest2 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/show_all_debit_transactions/");
                httpWebRequest2.ContentType = "application/json";
                httpWebRequest2.Method = "POST";
                httpWebRequest2.CookieContainer = new CookieContainer();
                httpWebRequest2.CookieContainer.Add(new Uri(GlobalClass.url + "/show_all_debit_transactions/"), new Cookie("sessionid", GlobalClass.session));
                //var httpResponse1 = (HttpWebResponse)httpWebRequest2.GetResponse();
                using (var streamWriter = new StreamWriter(httpWebRequest2.GetRequestStream()))
                {
                    string json = "{\"start_date\":" + GlobalClass.start_date + "," +
                                   "\"end_date\":" + GlobalClass.end_date + "}";
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse2 = (HttpWebResponse)httpWebRequest2.GetResponse();
                using (var streamReader2 = new StreamReader(httpResponse2.GetResponseStream()))
                {
                    var result2 = streamReader2.ReadToEnd();
                    MessageBox.Show(result2);
                }
            }
            catch
            {
                MessageBox.Show("Oops! Something went wrong.");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var httpWebRequest3 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/show_all_credit_transactions/");
                httpWebRequest3.ContentType = "application/json";
                httpWebRequest3.Method = "POST";
                httpWebRequest3.CookieContainer = new CookieContainer();
                httpWebRequest3.CookieContainer.Add(new Uri(GlobalClass.url + "/show_all_credit_transactions/"), new Cookie("sessionid", GlobalClass.session));
                using (var streamWriter = new StreamWriter(httpWebRequest3.GetRequestStream()))
                {
                    string json = "{\"start_date\":" + GlobalClass.start_date + "," +
                                      "\"end_date\":" + GlobalClass.end_date + "}";
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse3 = (HttpWebResponse)httpWebRequest3.GetResponse();
                try
                {
                    using (var streamReader3 = new StreamReader(httpResponse3.GetResponseStream()))
                    {
                        var result3 = streamReader3.ReadToEnd();
                        MessageBox.Show(result3);
                    }
                }
                catch
                {
                    //MessageBox.Show("No responce from server");
                }
            }
            catch
            {
                MessageBox.Show("Oops! Something went wrong.");
            }
        }
        private void roundButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
