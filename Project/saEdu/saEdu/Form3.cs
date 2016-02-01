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

namespace saEdu
{
    public partial class Form3 : Form
    {
        
        WebClient client = new WebClient();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void new_submit_Click(object sender, EventArgs e)
        {
            /*
            NameValueCollection newUserdata = new NameValueCollection();
            newUserdata.Add("userName", new_username.Text);
            newUserdata.Add("password", new_pass.Text);
            newUserdata.Add("confirmPassword", new_conformpass.Text);
            newUserdata.Add("firstName", new_firstname.Text);
            newUserdata.Add("lastName", new_lastname.Text);
            newUserdata.Add("addressLine1", new_add1.Text);
            newUserdata.Add("addressLine2", new_add2.Text);
            newUserdata.Add("city", new_city.Text);
            newUserdata.Add("state", new_state.Text);
            newUserdata.Add("pincode", new_pin.Text);
            newUserdata.Add("country", new_country.Text);
            newUserdata.Add("mobileNo0", new_mob_no.Text);
            newUserdata.Add("mobileNo1", new_conformmob_no.Text);
            newUserdata.Add("email", new_email.Text);
            //string insertuser = Convert.ToString(client.UploadValues("http://192.168.1.114:8080/register_new_user/", "POST", regInfo));
            //client.Headers.Add("application/json", "applicatsion/json");
            //JsonSerializer json = new JsonSerializer();
            
            
            
            string jsondata = JsonConvert.SerializeObject(newUserdata);
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.1.110:8080/register_new_user/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    JObject newUser1 = JObject.Parse(jsondata);
                    string newUserstr = JsonConvert.SerializeObject(newUser1);
                    JObject newUser = JObject.Parse(newUserstr);
                    
                    streamWriter.Write(jsondata);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
                
            }
            catch
            { }
            */

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/register_new_user/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"userName\":\"" + new_username.Text + "\"," +
                               "\"password\":\"" + new_pass.Text + "\"," +
                               "\"confirmPassword\":\"" + new_conformpass.Text + "\"," +
                               "\"firstName\":\"" + new_firstname.Text + "\"," +
                               "\"lastName\":\"" + new_lastname.Text + "\"," +
                               "\"addressLine1\":\"" + new_add1.Text + "\"," +
                               "\"addressLine2\":\"" + new_add2.Text + "\"," +
                               "\"city\":\"" + new_city.Text + "\"," +
                               "\"state\":\"" + new_state.Text + "\"," +
                               "\"pincode\":\"" + new_pin.Text + "\"," +
                               "\"country\":\"" + new_country.Text + "\"," +
                               "\"mobileNo0\":\"" + new_mob_no.Text + "\"," +
                               "\"mobileNo1\":\"" + new_conformmob_no.Text + "\"," +
                               "\"email\":\"" + new_email.Text + "\"}";
                JObject userInfo = JObject.Parse(json);
                //string newUserstr = JsonConvert.SerializeObject(nv);
                //JObject newUser = JObject.Parse(newUserstr);
                //MessageBox.Show(Convert.ToString(newUser.GetType()));
                streamWriter.Write(userInfo);
                streamWriter.Flush();
                streamWriter.Close();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                if (result.Substring(11, 4) == "true")
                {
                    MessageBox.Show("User Registered successfully. Your User name is" + new_username.Text + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show(result.Substring(33), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    CleanForm();
                    new_username.Focus();
                }
            }
        }
        private void CleanForm()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        private void progressBar1_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
