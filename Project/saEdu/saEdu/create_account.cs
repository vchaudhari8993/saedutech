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
        //comboAcc c;
        //long int_data;
        //DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        //int group_index,acc_index;
        //WebClient client = new WebClient();
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
            try
            {
                //reg_date_from.Text = dateTimePicker1.Value.ToShortDateString();
                grp_dropdown.Hide();
                //string grup_name;

                var httpWebRequest1 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/get_accounttype_from_db/");
                httpWebRequest1.ContentType = "application/json";
                httpWebRequest1.Method = "POST";
                httpWebRequest1.CookieContainer = new CookieContainer();
                httpWebRequest1.CookieContainer.Add(new Uri(GlobalClass.url + "/get_accounttype_from_db/"), new Cookie("sessionid", GlobalClass.session));

                var httpResponse1 = (HttpWebResponse)httpWebRequest1.GetResponse();
                using (var streamReader1 = new StreamReader(httpResponse1.GetResponseStream()))
                {
                    var result1 = streamReader1.ReadToEnd();
                    //MessageBox.Show(result1);
                    JObject obj1 = JObject.Parse(result1);
                    //MessageBox.Show(Convert.ToString(obj1));
                    string str2 = (Convert.ToString(obj1["accTypeList"]));
                    int counter1 = 0;
                    
                    foreach (var ch in str2)
                    {
                        if (ch == '{')
                            counter1++;
                    }
                    if (counter1 > 0)
                    {
                        //MessageBox.Show(Convert.ToString(counter1));
                        JObject j1;
                        for (int i1 = 0; i1 < counter1; i1++)
                        {
                            j1 = JObject.Parse(Convert.ToString((JToken)(obj1["accTypeList"])[i1]));
                            //MessageBox.Show(Convert.ToString((JToken)(j1["id"])));
                            //reg_acc_type.Items.Add(new comboAcc(Convert.ToString((JToken)(j1["id"]))));
                            //grup_name = Convert.ToString((JToken)(obj1["accTypeList"][i1])["choice_name"]);
                            //MessageBox.Show(Convert.ToString((JToken)(obj1["accTypeList"])[i1]));
                            reg_acc_type.Items.Add(new comboAcc(Convert.ToString((JToken)(obj1["accTypeList"])[i1])));
                            //reg_acc_type.Items.Add(grup_name);
                        }
                    }
                }
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/get_groups_from_db/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/get_groups_from_db/"), new Cookie("sessionid", GlobalClass.session));

                try
                {
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        JObject obj1 = JObject.Parse(result);
                        //MessageBox.Show(result);
                        string str2 = (Convert.ToString(obj1["accGroupList"]));
                        //MessageBox.Show(str2);
                        int counter1 = 0;
                        foreach (var ch in str2)
                        {
                            if (ch == '{')
                                counter1++;
                        }
                        if (counter1 > 0)
                        {
                            for (int i1 = 0; i1 < counter1; i1++)
                            {
                                //MessageBox.Show(Convert.ToString((JToken)(obj1["accGroupList"][i1])));
                                listBox1.Items.Add(new groupList(Convert.ToString((JToken)(obj1["accGroupList"])[i1])));
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("No respose from server");
                }
            }
            
            //listBox1.Items.Add();
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
            catch
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
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
            listBox1.Focus();
            grp_dropdown.Show();
            //grp_dropdown.Focus();
            listBox1.Focus();
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            acc_grp.Text = Convert.ToString(listBox1.SelectedItem);
            //group_index = listBox1.SelectedIndex;
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

        

        private void reg_contact_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (/*reg_contact.Text.Length < 10 && */!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && e.KeyChar == (char)Keys.Back*/)
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ////reg_date_from.Text = Convert.ToString(dateTimePicker1.Value.DayOfWeek);
            //reg_date_from.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void reg_date_from_TextChanged(object sender, EventArgs e)
        {
            ////code for calculating year period
            //DateTime start = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            //DateTime end = start.AddMonths(12).AddDays(-1);
            //reg_acc_validity.Text = Convert.ToString(end);
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
            
        }

        private void add_acc_Click(object sender, EventArgs e)
        {
            
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/create_new_user_account/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/create_new_user_account/"), new Cookie("sessionid", GlobalClass.session));
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string jsondata = "{\"accountInfo\":{\"account_name\":\"" + reg_name.Text + "\"," +
                                   "\"alias\":\"" + alias.Text + "\"," +
                                   "\"group\":" + Convert.ToString(((groupList)listBox1.SelectedItem).acc_obj) + "," +
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
                                   "\"accounttype\":" + Convert.ToString(((comboAcc)reg_acc_type.SelectedItem).acc_obj) + "," +
                                   "}}";
                    JObject accountInfo = JObject.Parse(jsondata);
                    //MessageBox.Show(Convert.ToString(accountInfo));
                    streamWriter.Write(accountInfo);
                    streamWriter.Flush();
                    streamWriter.Close();
                    //MessageBox.Show(Convert.ToString(accountInfo));
                }
                try
                {
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        //MessageBox.Show(result);
                        JToken jt = JToken.Parse(result);
                        MessageBox.Show(Convert.ToString(jt["validation"]),"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void reg_contact_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void alt_cont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void openingBal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(openingBal.Text, @"\.\d\d"))
            {
                e.Handled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            select_financial_yr fy = new select_financial_yr();
            fy.Show();
        }

        private void reg_acc_type_SelectedItemChanged(object sender, EventArgs e)
        {
            string value = sender.ToString();
            if (value == "System.Windows.Forms.DomainUpDown, Items.Count: 3, SelectedIndex: 0")
                this.BackColor = Color.Azure;
            else if (value == "System.Windows.Forms.DomainUpDown, Items.Count: 3, SelectedIndex: 1")
                this.BackColor = Color.LightSalmon;
            else
                this.BackColor = Color.Khaki;
            //acc_index = reg_acc_type.SelectedIndex;
        }

        private void acc_grp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void reg_acc_type_Enter(object sender, EventArgs e)
        {
            grp_dropdown.Hide();
            reg_acc_type.Focus();
        }

        private void reg_name_Enter(object sender, EventArgs e)
        {
            select_financial_yr fy = new select_financial_yr();
            fy.Show();
        }
    }
}
