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

            textBox4.Text = Convert.ToString(dateTimePicker1.Value.DayOfWeek);
            textBox1.Text = dateTimePicker1.Value.ToShortDateString();
            //TextBox1.ForeColor = System.Drawing.Color.Black; 
            add_cr_acc.Hide();
            add_dr_acc.Hide();
            /*call to url
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(GlobalClass.url + "/add_debit_amount/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                MessageBox.Show(result);
            }*/
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
