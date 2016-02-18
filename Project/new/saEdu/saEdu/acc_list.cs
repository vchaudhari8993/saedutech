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
    public partial class acc_list : Form
    {
        public acc_list()
        {
            InitializeComponent();
        }

        private void acc_list_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DateTime d;

            //bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;

            //AuthenticationManager.Authenticate("",)
            try
            {
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
                }
            }
            catch
            {
                MessageBox.Show("Oops! Something went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            user_option u = new user_option();
            u.Show();
            this.Hide();
        }
    }
}
