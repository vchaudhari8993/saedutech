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
    public partial class edit_acc : Form
    {
        public edit_acc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Focus();
            grp_dropdown.Show();
            //grp_dropdown.Focus();
            listBox1.Focus();
        }

        private void edit_acc_Load(object sender, EventArgs e)
        {
            grp_dropdown.Hide();
            try
            {
                //reg_date_from.Text = dateTimePicker1.Value.ToShortDateString();
                
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
                try
                {
                    //reg_date_from.Text = dateTimePicker1.Value.ToShortDateString();
                    
                    //string grup_name;

                    var httpWebRequest3 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/get_account_details/");
                    httpWebRequest3.ContentType = "application/json";
                    httpWebRequest3.Method = "POST";
                    httpWebRequest3.CookieContainer = new CookieContainer();
                    httpWebRequest3.CookieContainer.Add(new Uri(GlobalClass.url + "/get_account_details/"), new Cookie("sessionid", GlobalClass.session));
                    using (var streamWriter = new StreamWriter(httpWebRequest3.GetRequestStream()))
                    {
                        string json = "{\"account_id\":" + GlobalClass.acc_id + "}";
                        streamWriter.Write(json);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }

                    var httpResponse3 = (HttpWebResponse)httpWebRequest3.GetResponse();
                    using (var streamReader3 = new StreamReader(httpResponse3.GetResponseStream()))
                    {
                        var result3 = streamReader3.ReadToEnd();
                        //MessageBox.Show(result3);
                        JObject obj1 = JObject.Parse(result3);
                        //MessageBox.Show(Convert.ToString(obj1));
                        //string str2 = (Convert.ToString(obj1["accountInfo"]));
                        //int counter1 = 0;
                        //MessageBox.Show(str2);
                        reg_name.Text = Convert.ToString(obj1["accountInfo"]["account_name"]);
                        alias.Text = Convert.ToString(obj1["accountInfo"]["alias"]);
                        //MessageBox.Show(Convert.ToString(obj1["accountInfo"]["acount_name"]) + Convert.ToString(obj1["accountInfo"]["alias"]));
                        openingBal.Text = Convert.ToString(obj1["accountInfo"]["openingBalance"]);
                        firstName.Text = Convert.ToString(obj1["accountInfo"]["firstName"]);
                        lastName.Text = Convert.ToString(obj1["accountInfo"]["lastName"]);
                        addLine1.Text = Convert.ToString(obj1["accountInfo"]["addressLine1"]);
                        addLine2.Text = Convert.ToString(obj1["accountInfo"]["addressLine2"]);
                        city.Text = Convert.ToString(obj1["accountInfo"]["city"]);
                        state.Text = Convert.ToString(obj1["accountInfo"]["state"]);
                        country.Text = Convert.ToString(obj1["accountInfo"]["country"]);
                        reg_contact.Text = Convert.ToString(obj1["accountInfo"]["mobileNo0"]);
                        alt_cont.Text = Convert.ToString(obj1["accountInfo"]["mobileNo1"]);
                        reg_email.Text = Convert.ToString(obj1["accountInfo"]["email"]);
                        acc_grp.Text = Convert.ToString(obj1["accountInfo"]["group"]["choice_name"]);
                        reg_acc_type.Text = Convert.ToString(obj1["accountInfo"]["accounttype"]["choice_name"]);
                        pin.Text = Convert.ToString(obj1["accountInfo"]["pincode"]);
                        //foreach (var ch in str2)
                        //{
                        //    if (ch == '{')
                        //        counter1++;
                        //}
                        //MessageBox.Show(Convert.ToString(counter1));
                        //if (counter1 > 0)
                        //{
                        //    //MessageBox.Show(Convert.ToString(counter1));
                        //    JObject j1;
                        //    for (int i1 = 0; i1 < counter1; i1++)
                        //    {
                        //        j1 = JObject.Parse(Convert.ToString((JToken)(obj1["accTypeList"])[i1]));
                        //        //MessageBox.Show(Convert.ToString((JToken)(j1["id"])));
                        //        //reg_acc_type.Items.Add(new comboAcc(Convert.ToString((JToken)(j1["id"]))));
                        //        //grup_name = Convert.ToString((JToken)(obj1["accTypeList"][i1])["choice_name"]);
                        //        //MessageBox.Show(Convert.ToString((JToken)(obj1["accTypeList"])[i1]));
                        //        reg_acc_type.Items.Add(new comboAcc(Convert.ToString((JToken)(obj1["accTypeList"])[i1])));
                        //        //reg_acc_type.Items.Add(grup_name);
                        //    }
                        //}
                    }

                }
                catch { }
            }
            catch { }
            for (int i = 0; i < reg_acc_type.Items.Count; i++)
            {
                if (reg_acc_type.Text == reg_acc_type.Items[i].ToString())
                    reg_acc_type.SelectedIndex = i;
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (acc_grp.Text == listBox1.Items[i].ToString())
                    listBox1.SelectedIndex = i;
            }
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            //grp_dropdown.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            acc_grp.Text = Convert.ToString(listBox1.SelectedItem);
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

        private void pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void reg_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (/*reg_contact.Text.Length < 10 && */!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && e.KeyChar == (char)Keys.Back*/)
            {
                e.Handled = true;
            }
        }

        private void reg_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            int n = reg_email.Text.IndexOf("@");
            if (reg_email.Text == "" || n == -1)
            {
                errorProvider1.SetError(reg_email, "Please enter valid email");
                reg_email.Focus();
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

        private void reg_acc_type_Enter(object sender, EventArgs e)
        {
            grp_dropdown.Hide();
            reg_acc_type.Focus();
        }

        private void add_acc_Click(object sender, EventArgs e)
        {

            try
            {

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/save_edit_account/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/save_edit_account/"), new Cookie("sessionid", GlobalClass.session));
            //MessageBox.Show(Convert.ToString(((groupList)listBox1.SelectedItem).acc_obj));
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
                                   "\"accounttype\":" + Convert.ToString(((comboAcc)reg_acc_type.SelectedItem).acc_obj) + "}," +
                                   "\"account_id\":"+GlobalClass.acc_id+"}";                    
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
                        MessageBox.Show(Convert.ToString(jt["validation"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
