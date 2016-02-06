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
using Newtonsoft.Json.Linq;
using System.Collections.Specialized;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Text.RegularExpressions;
//using System.Web.Http;

namespace saEdu
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            log_user.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CookieContainer httpWeb = new CookieContainer();

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/user_login/");
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url+"/user_login/"),new Cookie("sessionid",""));
            
                //.Set(HttpRequestHeader.Cookie.Equals =
                //httpWebRequest = "{\"COOKIES\":\"{\"sessionid\":\"}";
                //httpWebRequest.CookieContainer.Add(new Cookie("COOKIES", "hello"));

                //Uri target = new Uri("http://192.168.1.107:8080/user_login/");

                //httpWeb.Add(new Cookie("HTTP_COOKIE", "{\"sessionid\"=") { Domain = target.Host });


                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"username\":\"" + log_user.Text + "\"," +
                                   "\"password\":\"" + log_pass.Text + "\"}";
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //MessageBox.Show(result);
                    var sesion = httpResponse.Headers.Get("Set-Cookie");
                    //MessageBox.Show(sesion);

                    GlobalClass.session= sesion.Substring(sesion.IndexOf('=')+1, sesion.IndexOf(';')-sesion.IndexOf('=')-1);
                    //MessageBox.Show(GlobalClass.session);
                    JToken response = JToken.Parse(result);
                    //JToken jt= response["status"];
                    //JToken session = response["session"];
                    //MessageBox.Show(Convert.ToString(jt));
                    if (Convert.ToString(response["status"]).Contains("False"))
                    {
                        MessageBox.Show("Invalid Login! Please try again.", "Login Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        log_user.Clear();
                        log_pass.Clear();
                        log_user.Focus();
                        return;
                    }
                    else
                    {
                        //login l = new login();
                        dashboard f3 = new dashboard();
                        f3.Show();
                        this.Hide();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Unable to connect to Server");         
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void log_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void log_user_Enter(object sender, EventArgs e)
        {
            log_user.Clear();
        }

        private void register_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                CookieContainer httpWeb = new CookieContainer();

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/user_login/");
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/user_login/"), new Cookie("sessionid", ""));
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();

            }
            catch
            {
                MessageBox.Show("Unable to connect");
            }
            */
            new_user_registration f3 = new new_user_registration();
            f3.Show();
            this.Hide();
        }
    }
}
