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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                    ctrl.BackColor = Color.White;
            }
            shortbtnPanel.Enabled = false;
            navPanel.Enabled = false;
            login login1 = new login();
            login1.MdiParent = this;
            login1.Show();
        }

        private void btnEventAcc_Click(object sender, EventArgs e)
        {
            while (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            admin_panel transactionWindow = new admin_panel();
            transactionWindow.Location = new Point(280, 130);
            transactionWindow.MdiParent = this;
            transactionWindow.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            while(ActiveMdiChild != null)
                ActiveMdiChild.Close();
            viewTransaction viewTrans = new viewTransaction();
            viewTrans.Location = new Point(280, 180);
            viewTrans.MdiParent = this;
            viewTrans.Show();
        }

        private void btnMyAccDetails_Click(object sender, EventArgs e)
        {
            while (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            show_transaction_details showAllTrans = new show_transaction_details();
            showAllTrans.Location = new Point(280, 130);
            showAllTrans.MdiParent = this;
            showAllTrans.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnTranAdd_Click(object sender, EventArgs e)
        {
            while (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            admin_panel addTrans = new admin_panel();
            addTrans.Location = new Point(280, 130);
            addTrans.MdiParent = this;
            addTrans.Show();
        }

        private void btnAccAdd_Click(object sender, EventArgs e)
        {
            while (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            create_account newAcc = new create_account();
            newAcc.Location = new Point(280, 130);
            newAcc.MdiParent = this;
            newAcc.Show();
        }

        private void btnYrAdd_Click(object sender, EventArgs e)
        {
            while (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            select_financial_yr addYr = new select_financial_yr();
            addYr.MdiParent = this;
            addYr.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            while (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            try
            {
                CookieContainer httpWeb = new CookieContainer();

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/logout/");
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.CookieContainer.Add(new Uri(GlobalClass.url + "/logout/"), new Cookie("sessionid", ""));

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    var sesion = httpResponse.Headers.Get("Set-Cookie");

                    GlobalClass.session = sesion.Substring(sesion.IndexOf('=') + 1, sesion.IndexOf(';') - sesion.IndexOf('=') - 1);
                    JToken response = JToken.Parse(result);
                    if (Convert.ToString(response["status"]).Contains("True"))
                    {
                        MessageBox.Show("Logged out.", "Logout!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainForm.navPanel.Enabled = false;
                        mainForm.shortbtnPanel.Enabled = false;
                        login logIn = new login();
                        mainForm.userInfo.Text = "";
                        logIn.MdiParent = this;
                        logIn.Show();
                    }
                    else
                    {
                        MessageBox.Show("Could Not log out");
                    }
                }//end of using
            }//end of outer try
            catch
            {
                MessageBox.Show("Unable to connect to Server");
            }
        }

        private void btnMyAcc_Click(object sender, EventArgs e)
        {
            while (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            user_acc accYrList = new user_acc();
            accYrList.Location = new Point(270, 180);
            accYrList.MdiParent = this;
            accYrList.Show();
        }
    }
}
