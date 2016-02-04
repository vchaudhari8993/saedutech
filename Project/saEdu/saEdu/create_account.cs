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
//using System.Web.Script.Serialization.JavaScriptSerializer;


namespace saEdu
{
    public partial class create_account : Form
    {
        long int_data;
        DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        int group_index,acc_index;
        WebClient client = new WebClient();
        public create_account()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            admin_panel f5 = new admin_panel();
            f5.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            reg_date_from.Text = dateTimePicker1.Value.ToShortDateString();
            grp_dropdown.Hide();
            //reg_combo_day.Text= System.DateTime.DaysInMonth(reg_combo_year,reg_combo_mon.SelectedIndex)

            /*
            reg_name.Focus();
            for (int i = 2015; i < 2055; i++)
            {
                reg_combo_year.Items.Add(i.ToString());
            }
            if (reg_combo_mon.Text == "February")  //if(cmbMonth.SelectedIndex.Equals(specify index))
            {
                for (int i = 0; i < 29; i++)
                {
                    reg_combo_day.Items.Add(i.ToString());
                }
            }
            else
            {
                for (int i = 1; i < 32; i++)
                {
                    reg_combo_day.Items.Add(i.ToString());
                }
            }
            reg_combo_day.SelectedIndex = 0;
            reg_combo_mon.SelectedIndex = 0;
            reg_combo_year.SelectedIndex = 0;*/
            /*comboBox1.FormatString = "dd";
            //comboBox2.FormatString = "MONTH";
            //comboBox3.FormatString = "yyyy";
            DateTime now = DateTime.Now;
            List<DateTime> dates = new List<DateTime>();
            dates.Add(now);
            //dates.Add(now.AddMonths(6));
            //dates.Add(now.AddMonths(1));
            //dates.Add(now.AddYears(1));
            comboBox1.DataSource = dates;
            //comboBox2.DataSource = dates;
            comboBox3.DataSource = dates;
            */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            string value = sender.ToString();
            if (value == "System.Windows.Forms.DomainUpDown, Items.Count: 3, SelectedIndex: 0")
                this.BackColor = Color.Azure;
            else if (value == "System.Windows.Forms.DomainUpDown, Items.Count: 3, SelectedIndex: 1")
                this.BackColor = Color.LightSalmon;
            else
                this.BackColor = Color.Khaki;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            /*int dd = Convert.ToInt32(reg_combo_day.Text);
            int mon = reg_combo_mon.SelectedIndex;
            //string mon = reg_combo_mon.Text;
            int year = Convert.ToInt32(reg_combo_year.Text);
            DateTime start = new DateTime(year, ++mon, dd);
            DateTime end = start.AddMonths(12).AddDays(-1);
            reg_acc_validity.Text = Convert.ToString(end);
            */
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grp_dropdown.Show();
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            grp_dropdown.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            acc_grp.Text = Convert.ToString(listBox1.SelectedItem);
            group_index = listBox1.SelectedIndex;
            //MessageBox.Show(Convert.ToString(group_index));
            //acc_grp.Text = sender.ToString();
            //reg_name.Text = sender.ToString();
        }

        private void reg_name_Leave(object sender, EventArgs e)
        {
            if (reg_name.Text == "")
            {
                errorProvider1.SetError(reg_name, "Please enter User Name");
                reg_name.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void reg_contact_Leave(object sender, EventArgs e)
        {
            
            if (reg_contact.Text == "")
            {
                errorProvider1.SetError(reg_contact, "Please enter Contact No.");
                reg_contact.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
            
        }

        private void reg_email_Leave(object sender, EventArgs e)
        {
            int n = reg_email.Text.IndexOf("@");
            if (reg_email.Text == ""||n == -1)
            {
                errorProvider1.SetError(reg_email, "Please enter valid email");
                reg_email.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void reg_acc_type_Leave(object sender, EventArgs e)
        {
            
        }

        private void reg_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_acc_period_Enter(object sender, EventArgs e)
        {

        }

        private void reg_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //reg_date_from.Text = Convert.ToString(dateTimePicker1.Value.DayOfWeek);
            reg_date_from.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void reg_date_from_TextChanged(object sender, EventArgs e)
        {
            //code for calculating year period
            DateTime start = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            DateTime end = start.AddMonths(12).AddDays(-1);
            reg_acc_validity.Text = Convert.ToString(end);
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            /*
            NameValueCollection regInfo = new NameValueCollection();
            regInfo.Add("username", reg_name.Text);
            regInfo.Add("contact_no", reg_contact.Text);
            regInfo.Add("email", reg_email.Text);
            regInfo.Add("group", acc_grp.Text);
            regInfo.Add("accounttype", reg_acc_type.Text);
            regInfo.Add("start_date", reg_date_from.Text);
            regInfo.Add("end_date", reg_acc_validity.Text);
            regInfo.Add("password", password.Text);
            string insertuser = Convert.ToString(client.UploadValues("http://192.168.1.123:8000/register_user_and_account/", "POST", regInfo));
            client.Headers.Add("application/json", "application/json");
            */
        }

        private void add_acc_Click(object sender, EventArgs e)
        {
            int_data = Convert.ToInt64((Convert.ToDateTime(reg_date_from.Text) - GlobalClass.origin).TotalMilliseconds);
            GlobalClass.start_date = int_data;
            int_data = Convert.ToInt64((Convert.ToDateTime(reg_acc_validity.Text) - GlobalClass.origin).TotalMilliseconds);
            GlobalClass.end_date = int_data;
            //MessageBox.Show(Convert.ToString(GlobalClass.start_date) + Convert.ToString(GlobalClass.end_date));
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/create_new_user_account/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/create_new_user_account/"), new Cookie("sessionid", GlobalClass.session));
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string jsondata = "{\"account_name\":\"" + reg_name.Text + "\"," +
                                   "\"alias\":\"" + alias.Text + "\"," +
                                   "\"group\":" + group_index + "," +
                                   "\"firstName\":\"" + firstName.Text + "\"," +
                                   "\"lastName\":\"" + lastName.Text + "\"," +
                                   "\"addressLine1\":\"" + addLine1.Text + "\"," +
                                   "\"addressLine2\":\"" + addLine2.Text + "\"," +
                                   "\"city\":\"" + city.Text + "\"," +
                                   "\"state\":\"" + state.Text + "\"," +
                                   "\"country\":\"" + country.Text + "\"," +
                                   "\"pincode\":" + pin.Text + "," +
                                   "\"email\":\"" + reg_email.Text + "\"," +
                                   "\"mobileNo0\":" + reg_contact.Text + "," +
                                   "\"mobileNo1\":" + alt_cont.Text + "," +
                                   "\"openingBalance\":" + openingBal.Text + "," +
                                   "\"accounttype\":" + acc_index + "," +
                                   "\"start_date\":" + GlobalClass.start_date + "," +
                                   "\"end_date\":" + GlobalClass.end_date + "," +
                                   "\"duration\":" + reg_acc_period.Text + "}";
                    MessageBox.Show(jsondata);
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
                        MessageBox.Show(result);
                        JToken jt = JToken.Parse(result);
                        MessageBox.Show(Convert.ToString(jt["validation"]));
                    }
                }
                catch
                {
                    MessageBox.Show("Sorry Could not add account");
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void reg_acc_validity_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_acc_period_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reg_acc_type_SelectedItemChanged(object sender, EventArgs e)
        {
            acc_index= reg_acc_type.SelectedIndex;
        }
    }
}
