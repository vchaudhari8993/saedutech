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
    public partial class newUserAcc : Form
    {
        public newUserAcc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newUserAcc_Load(object sender, EventArgs e)
        {
            var httpWebRequest1 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/get_groups_from_db/");
            httpWebRequest1.ContentType = "application/json";
            httpWebRequest1.Method = "POST";
            try
            {
                var httpResponse1 = (HttpWebResponse)httpWebRequest1.GetResponse();
                using (var streamReader1 = new StreamReader(httpResponse1.GetResponseStream()))
                {
                    var result = streamReader1.ReadToEnd();
                    MessageBox.Show(result);
                    JObject obj = JObject.Parse(result);
                    
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/create_new_user_account/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string jsondata = "{\"username\":\"" + textBox1.Text + "\"," +
                                "\"account_name\":\"" + newAccName.Text + "\"," +
                               "\"alias\":\"" + aliasAcc.Text + "\"," +
                               "\"group\":\"" + grpName.Text + "\"," +
                               "\"firstName\":\"" + firstName.Text + "\"," +
                               "\"lastName\":\"" + lastName.Text + "\"," +
                               "\"addressLine1\":\"" + addLine1.Text + "\"," +
                               "\"addressLine2\":\"" + addLine2.Text + "\"," +
                               "\"city\":\"" + city.Text + "\"," +
                               "\"state\":\"" + state.Text + "\"," +
                               "\"country\":\"" + country.Text + "\"," +
                               "\"pincode\":\"" + pin.Text + "\"," +
                               "\"email\":\"" + email.Text + "\"," +
                               "\"mobileNo0\":\"" + mobNo.Text + "\"," +
                               "\"mobileNo1\":\"" + altMobNo.Text + "\"," +
                               "\"openingBalance\":\"" + openingBal.Text +"\"}";
                JObject newUser = JObject.Parse(jsondata);
                
                streamWriter.Write(newUser);
                streamWriter.Flush();
                streamWriter.Close();
                MessageBox.Show(Convert.ToString(newUser));
            }
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
