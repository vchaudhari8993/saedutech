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
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
namespace saEdu
{
    public partial class admin_panel : Form
    {
        string acc_nm,value;
        long acc_yr;
        int acc_id;
        string amount;
        string[] acc_year = new string[10];
        string[] accid = new string[10];
        string[] parts;
        int i1, i2;
        long debit_amt = 0;
        long credit_amt = 0;
        int ic = 0;
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
            //DateTime start_date, end_date;
            get_date.Focus();
            transaction_type.Enabled = false;
            transaction_type1.Enabled = false;
            cr_amt1.Enabled = false;
            dr_amt1.Enabled = false;
            submit_transaction.Enabled = false;
            transaction_description.Enabled = false;

            transaction_type.SelectedIndex = 0;
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
            
            //var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/list_of_accounting_years/");
            //try
            //{
            //    httpWebRequest.ContentType = "application/json";
            //    httpWebRequest.Method = "POST";
            //    httpWebRequest.CookieContainer = new CookieContainer();
            //    httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/list_of_accounting_years/"), new Cookie("sessionid", GlobalClass.session));
            //    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //    {
            //        var result = streamReader.ReadToEnd();
            //        //MessageBox.Show(result);
            //        JObject obj = JObject.Parse(result);
            //        //var data = "";

            //        /*JToken accYr= (JToken)(obj["AccYearsList"][0]);
            //        MessageBox.Show(Convert.ToString(accYr["start_date"]));*/
            //        string str1 = (Convert.ToString(obj["AccYearsList"]));
            //        //MessageBox.Show(str1);
            //        int counter = 0;
            //        //JToken accYr;
            //        foreach (var ch in str1)
            //        {
            //            if (ch == '{')
            //                counter++;
            //        }
            //        //MessageBox.Show(Convert.ToString(counter));
            //        if (counter > 0)
            //        {
            //            for (int i = 0; i < counter; i++)
            //            {

            //                start_date = GlobalClass.origin.AddMilliseconds(Int64.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["start_date"])));
            //                //int_data = Int32.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["end_date"]));
            //                end_date = GlobalClass.origin.AddMilliseconds(Int64.Parse(Convert.ToString((JToken)(obj["AccYearsList"][i])["end_date"])));
            //                //d.ToShortDateString();
            //                //MessageBox.Show(start_date.ToShortDateString()+" " + end_date.ToShortDateString());
            //                if (DateTime.Now > start_date && DateTime.Now < end_date)
            //                {
                                var httpWebRequest3 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/show_account_names/");
                                httpWebRequest3.ContentType = "application/json";
                                httpWebRequest3.Method = "POST";
                                httpWebRequest3.CookieContainer = new CookieContainer();
                                httpWebRequest3.CookieContainer.Add(new Uri(GlobalClass.url + "/show_account_names/"), new Cookie("sessionid", GlobalClass.session));
                                //using (var streamWriter = new StreamWriter(httpWebRequest3.GetRequestStream()))
                                //{
                                //    GlobalClass.start_date = Convert.ToInt64((Convert.ToDateTime(start_date) - GlobalClass.origin).TotalMilliseconds);
                                //    GlobalClass.end_date = Convert.ToInt64((Convert.ToDateTime(end_date) - GlobalClass.origin).TotalMilliseconds);
                                //    string json = "{\"start_date\":" + GlobalClass.start_date + "," +
                                //                      "\"end_date\":" + GlobalClass.end_date + "}";
                                //    //MessageBox.Show(json);
                                //    streamWriter.Write(json);
                                //    streamWriter.Flush();
                                //    streamWriter.Close();
                                //}
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
                                            for (int i1 = 0; i1 < counter1; i1++)
                                            {

                                                acc_nm= Convert.ToString((JToken)(obj1["account_obj_list"][i1])["account_name"]);
                                                acc_id= Convert.ToInt32((JToken)(obj1["account_obj_list"][i1])["id"]);
                                                acc_yr=Convert.ToInt32((JToken)(obj1["account_obj_list"][i1])["created_at"]);
                                                //MessageBox.Show(acc_nm+Convert.ToString(acc_id)+Convert.ToString(acc_yr));
                                                //acc_name1.Items.Add(new ComboboxValue(acc_id, acc_nm,acc_yr));
                                                acc_name1.Items.Add(new comboTest(acc_id, acc_nm, acc_yr));
                                          
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
            //                }
            //                else
            //                {
            //                    continue;
            //                }
            //            }
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("error");
            //}
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
            value = sender.ToString();
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
            acc_name1.Enabled = true;
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
            acc_name1.Focus();
        }

        private void add_transaction_Click(object sender, EventArgs e)
        {
            //string hValue = ((comboTest)acc_name1.SelectedItem).data;
            //int ind = ((comboTest)acc_name1.SelectedItem).ID;
            //MessageBox.Show(hValue + " "+Convert.ToString(ind));
            
            string cr_dr;
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

            //MessageBox.Show(Convert.ToString((ComboboxValue)acc_name1.SelectedItem));

            transaction_record.DataSource = transaction_table;
            transaction_record.Show();
            //cr_amt1.Clear();
            //dr_amt1.Clear();
            get_date.Focus();
            long sum = 0;
            long sum1 = 0;
            credit_amt = 0;
            debit_amt = 0;
            //MessageBox.Show(Convert.ToString(sum));
            for (int i = 0; i < transaction_record.Rows.Count; ++i)
            {
                sum = sum1 = 0;
                parts = Convert.ToString(transaction_record.Rows[i].Cells[4].Value).Split('.');
                i1 = int.Parse(parts[0]);
                i2 = int.Parse(parts[1]);
                //MessageBox.Show(Convert.ToString(i1));
                //MessageBox.Show(Convert.ToString(transaction_record.Rows[i].Cells[4].Value) + transaction_record.Rows.Count);
                sum += i1;
                sum1 += i2;
                //MessageBox.Show(Convert.ToString(sum));
                if (Convert.ToString(transaction_record.Rows[i].Cells[2].Value) == "Debit")
                {
                    debit_amt += sum;
                }
                else
                {
                    credit_amt += sum;
                }
                //MessageBox.Show(Convert.ToString(credit_amt) + Convert.ToString(debit_amt));
                
            }

            if (credit_amt == debit_amt)
            {
                submit_transaction.Enabled = true;
                transaction_description.Enabled = true;
                transaction_description.Focus();                
            }
            else
            {
                submit_transaction.Enabled = false;
                get_date.Focus();
                cr_amt1.Clear();
                dr_amt1.Clear();
            }
            MessageBox.Show(Convert.ToString(((comboTest)acc_name1.SelectedItem).year));
            acc_year[ic] =Convert.ToString(((comboTest)acc_name1.SelectedItem).year);
            accid[ic] = Convert.ToString(((comboTest)acc_name1.SelectedItem).ID);
            ic++;
        }

        private void submit_transaction_Click(object sender, EventArgs e)
        {
            //string is_debit;
            //ic = 0;
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/transaction_for_account/");
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/transaction_for_account/"), new Cookie("sessionid", GlobalClass.session));
                if (transaction_type1.SelectedIndex == 0)
                {
                    //is_debit = "D";
                    amount = dr_amt1.Text;
                }
                else
                {
                    //is_debit = "C";
                    amount = cr_amt1.Text;
                }
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    int i;
                    string jsonStr = "{\"data\":{\"Acc_list\":[";
                    for(i=0;i<transaction_record.Rows.Count-1;i++)
                    {
                        jsonStr=jsonStr + "{\"is_debit\":\"" + Convert.ToString(transaction_record.Rows[i].Cells[2].Value).Substring(0,1) + "\",\"amount\":" + transaction_record.Rows[i].Cells[4].Value + ",\"account\":{\"created_at\":\"" + acc_year[i] + "\"" +
                            ",\"id\":" + accid[i] + ",\"account_name\":\"" + transaction_record.Rows[i].Cells[3].Value + "\"}},";
                    }
                    jsonStr=jsonStr + "{\"is_debit\":\"" + Convert.ToString(transaction_record.Rows[i].Cells[2].Value).Substring(0, 1) + "\",\"amount\":" + transaction_record.Rows[i].Cells[4].Value + ",\"account\":{\"created_at\":\"" + ((comboTest)acc_name1.SelectedItem).year + "\"" +
              ",\"id\":" + ((comboTest)acc_name1.SelectedItem).ID + ",\"account_name\":\"" + transaction_record.Rows[i].Cells[3].Value + "\"}}"+
              "],\"transaction_date\":" + Convert.ToInt64((Convert.ToDateTime(get_date.Value.Date.ToString()) - GlobalClass.origin).TotalMilliseconds) + ",\"description\":\"" + transaction_description.Text + "\",\"transactiontype\":" + transaction_type.SelectedIndex + "}}";
                    MessageBox.Show(Convert.ToString(jsonStr));
                    streamWriter.Write(jsonStr);
                    streamWriter.Flush();
                    streamWriter.Close();

                    
                    //string json = "{\"Acc_list\":[{\"account_id\":" + 33 /*(new ComboboxValue(acc_id, acc_nm));acc_name1.SelectedIndex*/ + "," +
                    //                "\"amount\":" + amount + "," +
                    //                "\"transactiontype\":" + transaction_type.SelectedIndex + "," +
                    //               "\"is_debit\":\"" + is_debit + "\"}]" +
                    //",\"description\":\"" + transaction_description.Text + "\"," +
                    //"\"transaction_date\":" + Convert.ToInt64((get_date.Value.Date - GlobalClass.origin).TotalMilliseconds) + "}";
                    
                    //JObject Acc_list = JObject.Parse(json);
                    //MessageBox.Show(Convert.ToString(json));
                    //streamWriter.Write(json);
                    //streamWriter.Flush();
                    //streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //MessageBox.Show(result);
                    JToken jt = JToken.Parse(result);
                    MessageBox.Show(Convert.ToString(jt["validation"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    transaction_table.Clear();
                    transaction_record.DataSource = transaction_table;
                    debit_amt = credit_amt = 0;
                }
            }
            catch
            {
                MessageBox.Show("Unable to connect to Server");
            }
            //string ss = null;
            //ss= Convert.ToString(sum1);
            //transaction_table.Rows.Add("", "", "", "Total", Convert.ToString(sum) + '.' + ss.Substring(0, 1), "");
            //MessageBox.Show(Convert.ToString(sum)+'.'+ss);
            ////transaction_table.Rows.Add("", "", "", "Total", sum+'.'+ss.Substring(0,1), "");

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
            if (Regex.IsMatch(cr_amt1.Text, @"\.\d\d"))
            {
                e.Handled = true;
            }
        }

        private void cr_amt1_Leave(object sender, EventArgs e)
        {
            if (cr_amt1.Text.Contains('.'))
            { }
            else
            {
                cr_amt1.Text = cr_amt1.Text + ".00";
            }
        }

        private void get_date_Leave(object sender, EventArgs e)
        {
            transaction_type.Enabled = true;
            transaction_type.Focus();
        }

        private void transaction_type_Leave(object sender, EventArgs e)
        {
            transaction_type1.Enabled = true;
            transaction_type1.Focus();
        }

        private void acc_name1_Leave(object sender, EventArgs e)
        {

        }

        private void transaction_description_Leave(object sender, EventArgs e)
        {
            submit_transaction.Focus();
        }

        private void dr_amt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(dr_amt1.Text, @"\.\d\d"))
            {
                e.Handled = true;
            }
        }

        private void dr_amt1_Leave(object sender, EventArgs e)
        {
            //string amt = dr_amt1.Text;
            if (dr_amt1.Text.Contains('.'))
            { }
            else
            {
                dr_amt1.Text = dr_amt1.Text + ".00";
            }
        }
    }
}
