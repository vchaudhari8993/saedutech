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
    public partial class select_financial_yr : Form
    {
        public select_financial_yr()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.ShowUpDown = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void select_financial_yr_Load(object sender, EventArgs e)
        {
            create_account c = new create_account();
            dateTimePicker1.Focus();
            this.Activate();
            c.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            valid_upto.Text = Convert.ToString(Convert.ToInt32(dateTimePicker1.Text) + 1);
            start_month.Text = "April";
            start_date.Text = "1";
            end_month.Text = "March";
            end_date.Text = "31";
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {

        }

        private void start_month_Enter(object sender, EventArgs e)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/add_acc_validity_date/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/add_acc_validity_date/"), new Cookie("sessionid", GlobalClass.session));

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"start_year\":" + dateTimePicker1.Text + "}";//"}]}
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //MessageBox.Show(result);
                    JToken jt = JToken.Parse(result);
                    if (Convert.ToString(jt["status"]) == "False")
                    {
                        MessageBox.Show(Convert.ToString(jt["validation"]), "Please Select Again", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        start_date.Text = start_month.Text = end_date.Text = end_month.Text = "";
                        dateTimePicker1.Focus();
                    }
                    else
                    {
                        MessageBox.Show(Convert.ToString(jt["validation"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        mainForm.shortbtnPanel.Enabled = true;
                        mainForm.navPanel.Enabled = true;
                    }
                    //if (result.Substring(11, 4) == "true")
                    //{
                    //    MessageBox.Show("User Registered successfully. Your User name is" + " " + new_username.Text + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    return;
                    //}
                    //else
                    //{
                    //    MessageBox.Show(result.Substring(33), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    //    //CleanForm();
                    //    //new_username.Focus();
                    //}
                }

            }
            catch
            {
                MessageBox.Show("No responce from server");
            }
        }
    }
}
