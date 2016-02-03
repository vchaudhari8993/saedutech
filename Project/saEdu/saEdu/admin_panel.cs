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
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DateTime start_date, end_date;

            textBox4.Text = Convert.ToString(dateTimePicker1.Value.DayOfWeek);
            textBox1.Text = dateTimePicker1.Value.ToShortDateString();
            //TextBox1.ForeColor = System.Drawing.Color.Black; 
            
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/list_of_accounting_years/");
            try
            {
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/list_of_accounting_years/"), new Cookie("sessionid", GlobalClass.session));
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //MessageBox.Show(result);
                    JObject obj = JObject.Parse(result);
                    //var data = "";

                    /*JToken accYr= (JToken)(obj["AccYearsList"][0]);
                    MessageBox.Show(Convert.ToString(accYr["start_date"]));*/
                    string str1 = (Convert.ToString(obj["AccYearsList"]));
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
                        for (int i = 0; i < counter; i++)
                        {

                            start_date = GlobalClass.origin.AddMilliseconds(Int64.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["start_date"])));
                            //int_data = Int32.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["end_date"]));
                            end_date = GlobalClass.origin.AddMilliseconds(Int64.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["end_date"])));
                            //d.ToShortDateString();
                            //MessageBox.Show(start_date.ToShortDateString()+" " + end_date.ToShortDateString());
                            if (DateTime.Now > start_date && DateTime.Now < end_date)
                            {
                                var httpWebRequest3 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/show_account_names/");
                                httpWebRequest3.ContentType = "application/json";
                                httpWebRequest3.Method = "POST";
                                httpWebRequest3.CookieContainer = new CookieContainer();
                                httpWebRequest3.CookieContainer.Add(new Uri(GlobalClass.url + "/show_account_names/"), new Cookie("sessionid", GlobalClass.session));
                                using (var streamWriter = new StreamWriter(httpWebRequest3.GetRequestStream()))
                                {
                                    GlobalClass.start_date = Convert.ToInt64((Convert.ToDateTime(start_date) - GlobalClass.origin).TotalMilliseconds);
                                    GlobalClass.end_date = Convert.ToInt64((Convert.ToDateTime(end_date) - GlobalClass.origin).TotalMilliseconds);
                                    string json = "{\"start_date\":" + GlobalClass.start_date + "," +
                                                      "\"end_date\":" + GlobalClass.end_date + "}";
                                    //MessageBox.Show(json);
                                    streamWriter.Write(json);
                                    streamWriter.Flush();
                                    streamWriter.Close();
                                }
                                var httpResponse3 = (HttpWebResponse)httpWebRequest3.GetResponse();
                                try
                                {
                                    //dt.Columns.Add("Created At");
                                    //dt.Columns.Add("Account Name");
                                    using (var streamReader3 = new StreamReader(httpResponse3.GetResponseStream()))
                                    {
                                        var result3 = streamReader3.ReadToEnd();
                                        MessageBox.Show(result3);
                                    }
                                    //data = Convert.ToString(obj["AccYearsList"][++i]);
                                    //data = Regex.Match(data, @"\d+").Value;
                                    //int_data = Int32.Parse(data);
                                    //d1 = origin.AddSeconds(int_data);

                                }
                                catch
                                {
                                    MessageBox.Show("error");
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
                
            



                //call to url to get account id
                /*
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/show_account_names/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/show_account_names/"), new Cookie("sessionid", GlobalClass.session));
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    MessageBox.Show(result);
                }*/

                /*call to url for credit
                var httpWebRequest1 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/credit_transaction_for_cash_account/");
                httpWebRequest1.ContentType = "application/json";
                httpWebRequest1.Method = "POST";
                httpWebRequest1.CookieContainer = new CookieContainer();
                httpWebRequest1.CookieContainer.Add(new Uri(GlobalClass.url + "/credit_transaction_for_cash_account/"), new Cookie("sessionid", GlobalClass.session));
                var httpResponse1 = (HttpWebResponse)httpWebRequest1.GetResponse();
                using (var streamReader1 = new StreamReader(httpResponse1.GetResponseStream()))
                {
                    var result1 = streamReader1.ReadToEnd();
                    MessageBox.Show(result1);
                }
                //call to url for debit
                var httpWebRequest2 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/debit_transaction_for_cash_account/");
                httpWebRequest2.ContentType = "application/json";
                httpWebRequest2.Method = "POST";
                httpWebRequest2.CookieContainer = new CookieContainer();
                httpWebRequest2.CookieContainer.Add(new Uri(GlobalClass.url + "/debit_transaction_for_cash_account/"), new Cookie("sessionid", GlobalClass.session));
                var httpResponse2 = (HttpWebResponse)httpWebRequest2.GetResponse();
                using (var streamReader2 = new StreamReader(httpResponse2.GetResponseStream()))
                {
                    var result2 = streamReader2.ReadToEnd();
                    MessageBox.Show(result2);
                }
                */
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
       
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            string value = sender.ToString();
            if (value == "System.Windows.Forms.DomainUpDown, Items.Count: 4, SelectedIndex: 0")
                this.BackColor = Color.Wheat;
            else if (value == "System.Windows.Forms.DomainUpDown, Items.Count: 4, SelectedIndex: 1")
                this.BackColor = Color.Yellow;
            else if (value == "System.Windows.Forms.DomainUpDown, Items.Count: 4, SelectedIndex: 2")
                this.BackColor = Color.Gainsboro;
            else
                this.BackColor = Color.GhostWhite;
        }

        private void domainUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            string value = sender.ToString();
            textBox7.Text = value;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void backbutton_Click_1(object sender, EventArgs e)
        {
            dashboard f3 = new dashboard();
            f3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_user f6 = new create_user();
            f6.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cr_dr_detail cr = new cr_dr_detail();
            cr.Show();
            this.Hide();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_user f1 = new create_user();
            f1.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(dateTimePicker1.Value.DayOfWeek);
            textBox1.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add_cr_acc.Show();
            button6.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            add_dr_acc.Show();
            button1.Enabled = false;
    }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.admin_opt.DroppedDown = true;
        }

        private void admin_opt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            //create_user f1 = new create_user();
            f1.Show();
            this.Hide();
        }

        private void domainUpDown1_SelectedItemChanged_1(object sender, EventArgs e)
        {
            string value = sender.ToString();
            if (value == "System.Windows.Forms.DomainUpDown, Items.Count: 4, SelectedIndex: 0")
                this.BackColor = Color.Azure;
            else if (value == "System.Windows.Forms.DomainUpDown, Items.Count: 4, SelectedIndex: 1")
                this.BackColor = Color.LightSalmon;
            else if (value == "System.Windows.Forms.DomainUpDown, Items.Count: 4, SelectedIndex: 2")
                this.BackColor = Color.Cyan;
            else
                this.BackColor = Color.Khaki;
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(dateTimePicker1.Value.DayOfWeek);
            textBox1.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}
