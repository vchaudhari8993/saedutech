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
using System.Json;

namespace saEdu
{
    public partial class user_acc_detail : Form
    {
        //JToken jt;
        
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
            //int counter = 0;
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //show Account details
            try
            {
                var httpWebRequest3 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/show_account_details/");
                httpWebRequest3.ContentType = "application/json";
                httpWebRequest3.Method = "POST";
                httpWebRequest3.CookieContainer = new CookieContainer();
                httpWebRequest3.CookieContainer.Add(new Uri(GlobalClass.url + "/show_account_details/"), new Cookie("sessionid", GlobalClass.session));
                
                //using (var streamWriter = new StreamWriter(httpWebRequest3.GetRequestStream()))
                //{
                //    string json = "{\"start_date\":" + GlobalClass.start_date + "," +
                //                      "\"end_date\":" + GlobalClass.end_date + "}";
                //    streamWriter.Write(json);
                //    streamWriter.Flush();
                //    streamWriter.Close();
                //}
                var httpResponse3 = (HttpWebResponse)httpWebRequest3.GetResponse();
                try
                {
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Account Name");
                    dt.Columns.Add("Amount");
                    using (var streamReader3 = new StreamReader(httpResponse3.GetResponseStream()))
                    {
                        var result3 = streamReader3.ReadToEnd();
                        //MessageBox.Show(result3);
                        JObject obj = JObject.Parse(result3);

                        
                        //var data = "";

                        /*JToken accYr= (JToken)(obj["AccYearsList"][0]);
                        MessageBox.Show(Convert.ToString(accYr["start_date"]));*/
                        string str1 = (Convert.ToString(obj["accountList"]));
                        //MessageBox.Show(str1);
                        int counter = 0;
                        //JToken accYr;
                        foreach (var ch in str1)
                        {
                            if (ch == '{')
                                counter++;
                        }
                        //MessageBox.Show(Convert.ToString(counter));
                        if (counter > 0)
                        {
                            //MessageBox.Show(Convert.ToString(counter));
                            for (int i = 0; i < counter; i++)
                            {
                                
                                dt.Rows.Add(Convert.ToString((JToken)(obj["accountList"][i])["id"]), Convert.ToString((JToken)(obj["accountList"][i])["account_name"]), Convert.ToString((JToken)(obj["accountList"][i])["amount"]));
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
            create_account c = new create_account();
            c.Show();
            this.Hide();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            admin_panel a = new admin_panel();
            a.Show();
            this.Hide();
        }
    }
}
