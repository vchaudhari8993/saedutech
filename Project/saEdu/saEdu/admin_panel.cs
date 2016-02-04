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
        string acc_nm;
        int acc_id;
        string amount;
        DataTable transaction_table = new DataTable();

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

            cr_amt1.Enabled = false;
            transaction_type1.SelectedIndex = 0;
            transaction_table.Columns.Add("Date");
            transaction_table.Columns.Add("Transaction Type");
            transaction_table.Columns.Add("Credit/Debit");
            transaction_table.Columns.Add("Account Name");
            transaction_table.Columns.Add("Amount");
            transaction_table.Columns.Add("Description");
            transaction_record.Hide();
            textBox4.Text = Convert.ToString(get_date.Value.DayOfWeek);
            transaction_date.Text = get_date.Value.ToShortDateString();
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
                                    using (var streamReader3 = new StreamReader(httpResponse3.GetResponseStream()))
                                    {
                                        var result3 = streamReader3.ReadToEnd();
                                        //MessageBox.Show(result3);
                                        JObject obj1 = JObject.Parse(result3);
                                        //var data = "";

                                        /*JToken accYr= (JToken)(obj["AccYearsList"][0]);
                                        MessageBox.Show(Convert.ToString(accYr["start_date"]));*/
                                        string str2 = (Convert.ToString(obj1["account_obj_list"]));
                                        //MessageBox.Show(str2);
                                        int counter1 = 0;
                                        //JToken accYr;
                                        foreach (var ch in str2)
                                        {
                                            if (ch == '{')
                                                counter1++;
                                        }
                                        if (counter1 > 0)
                                        {
                                            for (int i1 = 0; i1 < counter; i1++)
                                            {

                                                acc_nm= Convert.ToString((JToken)(obj1["account_obj_list"][i1])["account_name"]);
                                                acc_id= Convert.ToInt32((JToken)(obj1["account_obj_list"][i1])["id"]);
                                                //MessageBox.Show(acc_nm, Convert.ToString(acc_id));
                                                acc_name1.Items.Add(new ComboboxValue(acc_id, acc_nm));
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("No Data found for your account");
                                        }
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
            transaction_description.Text = value;
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
            create_account f6 = new create_account();
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
            create_account f1 = new create_account();
            f1.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(get_date.Value.DayOfWeek);
            transaction_date.Text = get_date.Value.ToShortDateString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
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
            new_user_registration f1 = new new_user_registration();
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
            textBox4.Text = Convert.ToString(get_date.Value.DayOfWeek);
            transaction_date.Text = get_date.Value.ToShortDateString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }
        


       

        private void transaction_type1_Leave(object sender, EventArgs e)
        {
            if (transaction_type1.SelectedIndex == 0)
            {
                cr_amt1.Enabled = false;
                dr_amt1.Enabled = true;
            }
            else
            {
                dr_amt1.Enabled = false;
                cr_amt1.Enabled = true;
            }
        }

        private void add_transaction_Click(object sender, EventArgs e)
        {
            string cr_dr;
            int sum=0;
            if (transaction_type1.SelectedIndex == 0)
            {
                amount = dr_amt1.Text;
                cr_dr = "Debit";
            }
            else
            {
                amount = cr_amt1.Text;
                cr_dr = "Credit";
            }

            transaction_table.Rows.Add(get_date.Value.ToShortDateString(), transaction_type.SelectedItem, cr_dr, acc_name1.SelectedItem, amount, transaction_description.Text);
            for (int i = 0; i < transaction_record.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(transaction_record.Rows[i].Cells[4].Value);
            }
            transaction_table.Rows.Add("", "", "", "", sum, "");
            transaction_record.DataSource = transaction_table;
            transaction_record.Show();

        }

        private void submit_transaction_Click(object sender, EventArgs e)
        {
            string is_debit;
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/transaction_for_account/");
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/transaction_for_account/"), new Cookie("sessionid", GlobalClass.session));
                if (transaction_type1.SelectedIndex == 0)
                {
                    is_debit = "D";
                    amount = dr_amt1.Text;
                }
                else
                {
                    is_debit = "C";
                    amount = cr_amt1.Text;
                }
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"Acc_list\":[{\"account_id\":" + 33/*acc_name1.SelectedIndex*/ + "," +
                                    "\"amount\":" + amount + "," +
                                    "\"transactiontype\":" + transaction_type.SelectedIndex + "," +
                                   "\"transaction_date\":" + Convert.ToInt64((get_date.Value.Date - GlobalClass.origin).TotalMilliseconds) + "," +
                                   "\"description\":\"" + transaction_description.Text + "\"," +
                                   "\"is_debit\":\"" + is_debit + "\"}]}";
                    //JObject Acc_list = JObject.Parse(json);
                    MessageBox.Show(Convert.ToString(json));
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
                    MessageBox.Show(Convert.ToString(jt["validation"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Unable to connect to Server");
            }
        }

        private void transaction_type1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button5_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cr_amt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cr_amt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        
    }
}
