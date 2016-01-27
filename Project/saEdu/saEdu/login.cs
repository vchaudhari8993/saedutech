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
using System.Text.RegularExpressions;

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url+"/user_login/");
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "POST";
            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string user = log_user.Text;
                    string pass = log_pass.Text;
                    string json = "{\"username\":\"" + user + "\"," +
                                   "\"password\":\"" + pass + "\"}";
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    if(result.Substring(11,5)=="false")
                    {
                        MessageBox.Show("Invalid Login! Please try again.","Login Error!",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                        log_user.Clear();
                        log_pass.Clear();
                        log_user.Focus();
                        return;
                    }
                    else
                    {
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
    }
}
