using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerizedAccountingSystem
{
    public partial class PaymentHist : UserControl
    {

        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;

        int deltawidth = 0;
        int deltaheigth = 0;

        public PaymentHist()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }
        void loadassessed()
        {
            cmd.CommandText = "select concat(lastname,', ',firstname,' ',middlename) from useraccount where usertype='Cashier'";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Assessed.Items.Add(reader.GetValue(0).ToString().ToUpper());
            }
            reader.Close();
            connection.Close();
        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                name.Text = "";
                name.Visible = true;
                mode.Visible = false;
                Assessed.Visible = false;
                loadpaymenthist();
                

            }
            else if (toolStripComboBox1.SelectedIndex == 1)
            {
                paymenthistselectdate n = new paymenthistselectdate();
                n.ShowDialog();
                loadpaymenthist();

            }
            else if (toolStripComboBox1.SelectedIndex == 2)
            {
                name.Visible = false;
                mode.Visible = false;
                Assessed.Visible = true;
                loadpaymenthist();
            }
            else if (toolStripComboBox1.SelectedIndex == 3)
            {
                mode.Text = "";
                name.Visible = false;
                mode.Visible = true;
                Assessed.Visible = false;

                loadpaymenthist();
            }

        }

        void loadpaymenthist()
        {
            cmd.CommandText = "SELECT stupaymenthist.dateassessed,stupaymenthist.assssedby,stupaymenthist.totalamount,stupaymenthist.modeofpayment,studentinformation.lastname,"
                                   + "studentinformation.firstname,studentinformation.middlename,stupaymenthist.ph_id "
                                   + "from studentinformation join stupaymenthist on stupaymenthist.accno=studentinformation.accno order by ph_id desc";

            connection.Open();
            reader = cmd.ExecuteReader();
            //   data2.Rows.Clear();
            listView1.Items.Clear();
            while (reader.Read())
            {
                if (listView1.Items.Count % 2 == 0)
                {

                    ListViewItem i = listView1.Items.Add(reader.GetValue(7).ToString());
                    i.UseItemStyleForSubItems = false;
                    i.SubItems[0].ForeColor = Color.White;
                    i.SubItems.Add(reader.GetValue(4).ToString() + ", " + reader.GetValue(5).ToString() + " " + reader.GetValue(6).ToString());
                    i.SubItems.Add(reader.GetValue(0).ToString());
                    i.SubItems.Add(reader.GetValue(3).ToString());
                    i.SubItems.Add(double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    i.SubItems[4].ForeColor = Color.Red;
                    i.SubItems.Add(reader.GetValue(1).ToString());
                }
                else
                {

                    ListViewItem i = listView1.Items.Add(reader.GetValue(7).ToString());
                    i.UseItemStyleForSubItems = false;
                    i.SubItems[0].BackColor = SystemColors.Control;
                    i.SubItems[0].ForeColor = SystemColors.Control;
                    i.SubItems.Add(reader.GetValue(4).ToString() + ", " + reader.GetValue(5).ToString() + " " + reader.GetValue(6).ToString()).BackColor = SystemColors.Control; ;
                    i.SubItems.Add(reader.GetValue(0).ToString()).BackColor = SystemColors.Control; ;
                    i.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control; ;
                    i.SubItems.Add(double.Parse(reader.GetValue(2).ToString()).ToString("n")).BackColor = SystemColors.Control;
                    i.SubItems[4].ForeColor = Color.Red;
                    i.SubItems.Add(reader.GetValue(1).ToString()).BackColor = SystemColors.Control; ;
                }
            }
            reader.Close();

            connection.Close();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            cmd.CommandText = "SELECT stupaymenthist.dateassessed,stupaymenthist.assssedby,stupaymenthist.totalamount,stupaymenthist.modeofpayment,studentinformation.lastname,"
                                     + "studentinformation.firstname,studentinformation.middlename,stupaymenthist.ph_id "
                                         + "from studentinformation join stupaymenthist on stupaymenthist.accno=studentinformation.accno where"
             + " studentinformation.lastname LIKE '" + name.Text.Replace("'", "''") + "%' or "
              + "studentinformation.firstname LIKE '" + name.Text.Replace("'", "''") + "%'  or "
              + "studentinformation.middlename LIKE '" + name.Text.Replace("'", "''") + "%'   order by ph_id desc";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (listView1.Items.Count % 2 == 0)
                {

                    ListViewItem i = listView1.Items.Add(reader.GetValue(7).ToString());
                    i.UseItemStyleForSubItems = false;
                    i.SubItems[0].ForeColor = Color.White;
                    i.SubItems.Add(reader.GetValue(4).ToString() + ", " + reader.GetValue(5).ToString() + " " + reader.GetValue(6).ToString());
                    i.SubItems.Add(reader.GetValue(0).ToString());
                    i.SubItems.Add(reader.GetValue(3).ToString());
                    i.SubItems.Add(double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    i.SubItems[4].ForeColor = Color.Red;
                    i.SubItems.Add(reader.GetValue(1).ToString());
                }
                else
                {

                    ListViewItem i = listView1.Items.Add(reader.GetValue(7).ToString());
                    i.UseItemStyleForSubItems = false;
                    i.SubItems[0].BackColor = SystemColors.Control;
                    i.SubItems[0].ForeColor = SystemColors.Control;
                    i.SubItems.Add(reader.GetValue(4).ToString() + ", " + reader.GetValue(5).ToString() + " " + reader.GetValue(6).ToString()).BackColor = SystemColors.Control; ;
                    i.SubItems.Add(reader.GetValue(0).ToString()).BackColor = SystemColors.Control; ;
                    i.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control; ;
                    i.SubItems.Add(double.Parse(reader.GetValue(2).ToString()).ToString("n")).BackColor = SystemColors.Control;
                    i.SubItems[4].ForeColor = Color.Red;
                    i.SubItems.Add(reader.GetValue(1).ToString()).BackColor = SystemColors.Control; ;
                }
            }
            reader.Close();

            connection.Close();
        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            zzParticulars.d = listView1.SelectedItems[0].Text;
            zzParticulars par = new zzParticulars();
            par.ShowDialog();
        }

        private void mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode.SelectedIndex == 0)
            {
                cmd.CommandText = "SELECT stupaymenthist.dateassessed,stupaymenthist.assssedby,stupaymenthist.totalamount,stupaymenthist.modeofpayment,studentinformation.lastname,"
                                   + "studentinformation.firstname,studentinformation.middlename,stupaymenthist.ph_id "
                                       + "from studentinformation join stupaymenthist on stupaymenthist.accno=studentinformation.accno where"
          + " modeofpayment='cash' order by ph_id desc";
                connection.Open();
                reader = cmd.ExecuteReader();
                //   data2.Rows.Clear();
                listView1.Items.Clear();
                while (reader.Read())
                {
                    if (listView1.Items.Count % 2 == 0)
                    {

                        ListViewItem i = listView1.Items.Add(reader.GetValue(7).ToString());
                        i.UseItemStyleForSubItems = false;
                        i.SubItems[0].ForeColor = Color.White;
                        i.SubItems.Add(reader.GetValue(4).ToString() + ", " + reader.GetValue(5).ToString() + " " + reader.GetValue(6).ToString());
                        i.SubItems.Add(reader.GetValue(0).ToString());
                        i.SubItems.Add(reader.GetValue(3).ToString());
                        i.SubItems.Add(double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                        i.SubItems[4].ForeColor = Color.Red;
                        i.SubItems.Add(reader.GetValue(1).ToString());
                    }
                    else
                    {

                        ListViewItem i = listView1.Items.Add(reader.GetValue(7).ToString());
                        i.UseItemStyleForSubItems = false;
                        i.SubItems[0].BackColor = SystemColors.Control;
                        i.SubItems[0].ForeColor = SystemColors.Control;
                        i.SubItems.Add(reader.GetValue(4).ToString() + ", " + reader.GetValue(5).ToString() + " " + reader.GetValue(6).ToString()).BackColor = SystemColors.Control; ;
                        i.SubItems.Add(reader.GetValue(0).ToString()).BackColor = SystemColors.Control; ;
                        i.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control; ;
                        i.SubItems.Add(double.Parse(reader.GetValue(2).ToString()).ToString("n")).BackColor = SystemColors.Control;
                        i.SubItems[4].ForeColor = Color.Red;
                        i.SubItems.Add(reader.GetValue(1).ToString()).BackColor = SystemColors.Control; ;
                    }
                }
                reader.Close();

                connection.Close();
            }
            else
            {
                cmd.CommandText = "SELECT stupaymenthist.dateassessed,stupaymenthist.assssedby,stupaymenthist.totalamount,stupaymenthist.modeofpayment,studentinformation.lastname,"
                                  + "studentinformation.firstname,studentinformation.middlename,stupaymenthist.ph_id "
                                      + "from studentinformation join stupaymenthist on stupaymenthist.accno=studentinformation.accno where"
         + " modeofpayment !='cash' order by ph_id desc";
                connection.Open();
                reader = cmd.ExecuteReader();
                //   data2.Rows.Clear();
                listView1.Items.Clear();
                while (reader.Read())
                {
                    if (listView1.Items.Count % 2 == 0)
                    {

                        ListViewItem i = listView1.Items.Add(reader.GetValue(7).ToString());
                        i.UseItemStyleForSubItems = false;
                        i.SubItems[0].ForeColor = Color.White;
                        i.SubItems.Add(reader.GetValue(4).ToString() + ", " + reader.GetValue(5).ToString() + " " + reader.GetValue(6).ToString());
                        i.SubItems.Add(reader.GetValue(0).ToString());
                        i.SubItems.Add(reader.GetValue(3).ToString());
                        i.SubItems.Add(double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                        i.SubItems[4].ForeColor = Color.Red;
                        i.SubItems.Add(reader.GetValue(1).ToString());
                    }
                    else
                    {

                        ListViewItem i = listView1.Items.Add(reader.GetValue(7).ToString());
                        i.UseItemStyleForSubItems = false;
                        i.SubItems[0].BackColor = SystemColors.Control;
                        i.SubItems[0].ForeColor = SystemColors.Control;
                        i.SubItems.Add(reader.GetValue(4).ToString() + ", " + reader.GetValue(5).ToString() + " " + reader.GetValue(6).ToString()).BackColor = SystemColors.Control; ;
                        i.SubItems.Add(reader.GetValue(0).ToString()).BackColor = SystemColors.Control; ;
                        i.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control; ;
                        i.SubItems.Add(double.Parse(reader.GetValue(2).ToString()).ToString("n")).BackColor = SystemColors.Control;
                        i.SubItems[4].ForeColor = Color.Red;
                        i.SubItems.Add(reader.GetValue(1).ToString()).BackColor = SystemColors.Control; ;
                    }
                }
                reader.Close();

                connection.Close();
            }
        }

      

        private void PaymentHist_StyleChanged(object sender, EventArgs e)
        {

            
        }

        private void PaymentHist_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void PaymentHist_SizeChanged(object sender, EventArgs e)
        {
            listView1.Width = ClientRectangle.Width - deltawidth;
            listView1.Height = ClientRectangle.Height - deltaheigth;
        }

        private void Assessed_SelectedIndexChanged(object sender, EventArgs e)
        {
            string k = Assessed.Text;
            cmd.CommandText = "SELECT stupaymenthist.dateassessed,stupaymenthist.assssedby,stupaymenthist.totalamount,stupaymenthist.modeofpayment,studentinformation.lastname,"
                                    + "studentinformation.firstname,studentinformation.middlename,stupaymenthist.ph_id "
                                        + "from studentinformation join stupaymenthist on stupaymenthist.accno=studentinformation.accno where assssedby='" + k + "'  order by ph_id desc";
            connection.Open();
            listView1.Items.Clear();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (listView1.Items.Count % 2 == 0)
                {

                    ListViewItem i = listView1.Items.Add(reader.GetValue(7).ToString());
                    i.UseItemStyleForSubItems = false;
                    i.SubItems[0].ForeColor = Color.White;
                    i.SubItems.Add(reader.GetValue(4).ToString() + ", " + reader.GetValue(5).ToString() + " " + reader.GetValue(6).ToString());
                    i.SubItems.Add(reader.GetValue(0).ToString());
                    i.SubItems.Add(reader.GetValue(3).ToString());
                    i.SubItems.Add(double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    i.SubItems[4].ForeColor = Color.Red;
                    i.SubItems.Add(reader.GetValue(1).ToString());
                }
                else
                {

                    ListViewItem i = listView1.Items.Add(reader.GetValue(7).ToString());
                    i.UseItemStyleForSubItems = false;
                    i.SubItems[0].BackColor = SystemColors.Control;
                    i.SubItems[0].ForeColor = SystemColors.Control;
                    i.SubItems.Add(reader.GetValue(4).ToString() + ", " + reader.GetValue(5).ToString() + " " + reader.GetValue(6).ToString()).BackColor = SystemColors.Control; ;
                    i.SubItems.Add(reader.GetValue(0).ToString()).BackColor = SystemColors.Control; ;
                    i.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control; ;
                    i.SubItems.Add(double.Parse(reader.GetValue(2).ToString()).ToString("n")).BackColor = SystemColors.Control;
                    i.SubItems[4].ForeColor = Color.Red;
                    i.SubItems.Add(reader.GetValue(1).ToString()).BackColor = SystemColors.Control; ;
                }
            }
            reader.Close();

            connection.Close();
        }

        private void PaymentHist_Load(object sender, EventArgs e)
        {
            if (MDIParent1.usertype != "Cashier")
            {
                tlPrint.Enabled = false;
            }
            toolStripComboBox1.SelectedIndex = 0;
            listView1.Columns[0].Width = 0; 
            deltawidth = this.ClientRectangle.Width - listView1.Width;
            deltaheigth = this.ClientRectangle.Height - listView1.Height;
            loadassessed();
            loadpaymenthist();
        }

        private void listView1_SizeChanged(object sender, EventArgs e)
        { 
        }

        private void tlPrint_Click(object sender, EventArgs e)
        {

        }

        
    }
}
