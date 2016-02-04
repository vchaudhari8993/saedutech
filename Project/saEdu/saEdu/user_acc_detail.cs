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
        JToken jt;
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
            DataTable dt = new DataTable();
            int counter = 0;

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //show Account details
            try
            {
                var httpWebRequest3 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/show_account_details/");
                httpWebRequest3.ContentType = "application/json";
                httpWebRequest3.Method = "POST";
                httpWebRequest3.CookieContainer = new CookieContainer();
                httpWebRequest3.CookieContainer.Add(new Uri(GlobalClass.url + "/show_account_details/"), new Cookie("sessionid", GlobalClass.session));
                
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
                    dt.Columns.Add("Created At");
                    dt.Columns.Add("Account Name");
                    using (var streamReader3 = new StreamReader(httpResponse3.GetResponseStream()))
                    {
                        var result3 = streamReader3.ReadToEnd();
                        MessageBox.Show(result3);
                        jt = JToken.Parse(result3);
                        credit_amt.Text = Convert.ToString(jt["all_credit"]);
                        debit_amt.Text = Convert.ToString(jt["all_debit"]);
                        cash_bal.Text = Convert.ToString(jt["cash_balance"]);
                        bank_bal.Text = Convert.ToString(jt["bank_balance"]);
                        JObject obj = JObject.Parse(result3);
                        string str1 = (Convert.ToString(obj["account_obj_list"]));
                        //MessageBox.Show(str1);

                        
                        foreach (var ch in str1)
                        {
                            if (ch == '{')
                                counter++;
                        }
                        if (counter > 0)
                        {
                            for (int i = 0; i < counter; i++)
                            {

                                //accYr = (JToken)(obj["account_obj_list"][i]);
                                //MessageBox.Show(Convert.ToString(accYr["created_at"]));
                                
                                ////////////////////////////////////////////////////////////
                                //merged the value insted of variable if error then undo this
                                ////////////////////////////////////////////////////////////
                                //int_data = Int32.Parse(Convert.ToString((JToken)(obj["accont_obj_list"][i])["created_at"]));
                                //d = GlobalClass.origin.AddSeconds(Int32.Parse(Convert.ToString((JToken)(obj["account_obj_list"][i])["created_at"])));
                                //int_data = Int32.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["end_date"]));
                                //d1 = GlobalClass.origin.AddSeconds(Int32.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["end_date"])));

                                //data = Convert.ToString(obj["AccYearsList"][++i]);
                                //data = Regex.Match(data, @"\d+").Value;
                                //int_data = Int32.Parse(data);
                                //d1 = origin.AddSeconds(int_data);
                                
                                dt.Rows.Add(Convert.ToString(GlobalClass.origin.AddMilliseconds(Int64.Parse(Convert.ToString((JToken)(obj["account_obj_list"][i])["created_at"])))), Convert.ToString((JToken)(obj["account_obj_list"][i])["account_name"]));
                                dataGridView1.DataSource = dt;
                            }
                        }
                        else
                        {
                            //dt.Rows.Add("No Data found for your account","hello");
                        }
                        
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
            //duration.Text = (GlobalClass.start_date + GlobalClass.end_date);
            /*
            long int_data;
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            DataTable dt = new DataTable();
            DateTime d, d1;
            */

        }
            

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        private void roundButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
