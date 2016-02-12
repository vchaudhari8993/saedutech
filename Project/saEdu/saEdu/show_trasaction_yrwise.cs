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
    public partial class show_trasaction_yrwise : Form
    {
        public show_trasaction_yrwise()
        {
            InitializeComponent();
        }

        private void show_trasaction_yrwise_Load(object sender, EventArgs e)
        {
            int counter1 = 0;
            int counter2 = 0;
            string s2;
            string is_debit;
            string str2;
            JObject obj1;
            DataTable dt = new DataTable();
            DateTime d = new DateTime();

            dt.Columns.Add("ID");
            dt.Columns.Add("Transaction Type");
            dt.Columns.Add("Date");
            dt.Columns.Add("Account Name");
            dt.Columns.Add("Debit/Credit");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Description");

            var httpWebRequest1 = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/show_all_transactions_of_one_year/");
            httpWebRequest1.ContentType = "application/json";
            httpWebRequest1.Method = "POST";
            httpWebRequest1.CookieContainer = new CookieContainer();
            httpWebRequest1.CookieContainer.Add(new Uri(GlobalClass.url + "/show_all_transactions_of_one_year/"), new Cookie("sessionid", GlobalClass.session));
            using (var streamWriter = new StreamWriter(httpWebRequest1.GetRequestStream()))
            {
                string json = "{\"start_date\":" + GlobalClass.start_date + "}";
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            var httpResponse1 = (HttpWebResponse)httpWebRequest1.GetResponse();
            using (var streamReader1 = new StreamReader(httpResponse1.GetResponseStream()))
            {
                var result1 = streamReader1.ReadToEnd();
                //MessageBox.Show(result1);
                obj1 = JObject.Parse(result1);
                str2 = (Convert.ToString(obj1["transactionList"]));
                foreach (char ch in str2)
                {
                    if (ch == '[')
                        counter1++;
                }
                //counter1 = obj2.Count;
                //MessageBox.Show(Convert.ToString(counter1));
                if (counter1 > 0)
                {
                    for (int i1 = 0; i1 < counter1 - 1; i1++)
                    {
                        s2 = Convert.ToString((JToken)(obj1["transactionList"][i1]["transaction_record_list"]));
                        //MessageBox.Show(s2);
                        counter2 = 0;
                        foreach (char ch in s2)
                        {
                            if (ch == '{')
                                counter2++;
                        }
                        for (int j = 0; j < counter2; j++)
                        {
                            if (Convert.ToString((JToken)(obj1["transactionList"][i1]["transaction_record_list"][j]["is_debit"])) == "True")
                                is_debit = "Debit";
                            else
                                is_debit = "Credit";
                            d = GlobalClass.origin.AddMilliseconds(Int64.Parse(Convert.ToString((JToken)(obj1["transactionList"][i1]["transaction_date"]))));
                            dt.Rows.Add(Convert.ToString((JToken)(obj1["transactionList"][i1]["id"])), Convert.ToString((JToken)(obj1["transactionList"][i1]["transactiontype"])), d.ToShortDateString(), Convert.ToString((JToken)(obj1["transactionList"][i1]["transaction_record_list"][j]["account_name"])), is_debit, Convert.ToString((JToken)(obj1["transactionList"][i1]["transaction_record_list"][j]["amount"])), Convert.ToString((JToken)(obj1["transactionList"][i1]["description"])));
                        }//end of inner for
                    }//end of outer for
                }//end of if
            }//end of using
            show_transaction_grid.DataSource = dt;
            //MessageBox.Show(show_transaction_grid.Rows[0].Cells[1].Value.ToString());
        }
    }
}
