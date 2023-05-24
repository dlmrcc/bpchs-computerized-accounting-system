using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerizedAccountingSystem
{
    public partial class Receipt : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;

        int deltawidth = 0;
        int deltaheigth = 0;

        public Receipt()
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
                AssesBY.
                Items.Add(reader.GetValue(0).ToString().ToUpper());
            }
            reader.Close();
            connection.Close();
        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                name.Visible = true;
                AssesBY.Visible = RECnumber.Visible = dateTimePicker1.Visible = false;
                loadreceipt();
            }
            else if (toolStripComboBox1.SelectedIndex == 1)
            {
                RECnumber.Visible = true;
                AssesBY.Visible = name.Visible = dateTimePicker1.Visible = false;
                loadreceipt();

            }
            else if (toolStripComboBox1.SelectedIndex == 2)
            {
              dateTimePicker1.Visible   = true;
                AssesBY.Visible = name.Visible = RECnumber.Visible = false;
                loadreceipt();

            }
            else if (toolStripComboBox1.SelectedIndex == 3)
            {
                AssesBY.Visible = true;
                 name.Visible = RECnumber.Visible=dateTimePicker1.Visible = false;
                loadreceipt();

            }
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            deltawidth = this.ClientRectangle.Width - listView1.Width; 
            deltaheigth = this.ClientRectangle.Height - listView1.Height;

            toolStripComboBox1.SelectedIndex = 0;
            loadreceipt();
            loadassessed();

        }
        void loadreceipt()
        {
            cmd.CommandText = "select studentreciept.rcpt_id,studentreciept.hist_id,studentinformation.lastname,studentinformation.firstname,studentinformation.middlename, "
             +" studentreciept.recieptno,studentreciept.totalamount,studentreciept.assessedby, "
            +" studentreciept.date from studentinformation join studentreciept  on studentinformation.accno=studentreciept.accno  order by rcpt_id";
            connection.Open();
            reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                if (listView1.Items.Count % 2 == 0)
                {
                    ListViewItem items = listView1.Items.Add(reader.GetValue(0).ToString());
                    items.UseItemStyleForSubItems = false;
                    items.SubItems[0].ForeColor = Color.White;
                    items.SubItems.Add(reader.GetValue(1).ToString());
                    items.SubItems.Add(reader.GetValue(2).ToString() + ", " + reader.GetValue(3).ToString() + " " + reader.GetValue(4).ToString());
                    items.SubItems.Add(reader.GetValue(8).ToString());
                    items.SubItems.Add(reader.GetValue(5).ToString());
                    items.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n"));
                    items.SubItems[5].ForeColor=Color.Red;
                    items.SubItems.Add(reader.GetValue(7).ToString());
                     
                    //  items.SubItems.Add(reader.GetValue(8).ToString());
                }
                else
                {
                    ListViewItem items = listView1.Items.Add(reader.GetValue(0).ToString());
                    items.UseItemStyleForSubItems = false;
                    items.SubItems[0].ForeColor = SystemColors.Control;
                    items.SubItems[0].BackColor = SystemColors.Control;
                    items.SubItems.Add(reader.GetValue(1).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(2).ToString() + ", " + reader.GetValue(3).ToString() + " " + reader.GetValue(4).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(8).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(5).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n")).BackColor = SystemColors.Control; ;
                    items.SubItems[5].ForeColor = Color.Red;
                    items.SubItems.Add(reader.GetValue(7).ToString()).BackColor = SystemColors.Control; ;
                   
                }
            }
            reader.Close();
            connection.Close();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "select studentreciept.rcpt_id,studentreciept.hist_id,studentinformation.lastname,studentinformation.firstname,studentinformation.middlename, "
           + " studentreciept.recieptno,studentreciept.totalamount,studentreciept.assessedby, "
          + " studentreciept.date from studentinformation join studentreciept  on studentinformation.accno=studentreciept.accno  "
            + "where studentinformation.lastname LIKE '" + name.Text.Replace("'", "''") + "%' or "
              + "studentinformation.firstname LIKE '" + name.Text.Replace("'", "''") + "%'  or "
              + "studentinformation.middlename LIKE '" + name.Text.Replace("'", "''") + "%'   order by rcpt_id desc";
            connection.Open();
            reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                if (listView1.Items.Count % 2 == 0)
                {
                    ListViewItem items = listView1.Items.Add(reader.GetValue(0).ToString());
                    items.UseItemStyleForSubItems = false;
                    items.SubItems[0].ForeColor = Color.White;
                    items.SubItems.Add(reader.GetValue(1).ToString());
                    items.SubItems.Add(reader.GetValue(2).ToString() + ", " + reader.GetValue(3).ToString() + " " + reader.GetValue(4).ToString());
                    items.SubItems.Add(reader.GetValue(8).ToString());
                    items.SubItems.Add(reader.GetValue(5).ToString());
                    items.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n"));
                    items.SubItems[5].ForeColor = Color.Red;
                    items.SubItems.Add(reader.GetValue(7).ToString());

                    //  items.SubItems.Add(reader.GetValue(8).ToString());
                }
                else
                {
                    ListViewItem items = listView1.Items.Add(reader.GetValue(0).ToString());
                    items.UseItemStyleForSubItems = false;
                    items.SubItems[0].ForeColor = SystemColors.Control;
                    items.SubItems[0].BackColor = SystemColors.Control;
                    items.SubItems.Add(reader.GetValue(1).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(2).ToString() + ", " + reader.GetValue(3).ToString() + " " + reader.GetValue(4).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(8).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(5).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n")).BackColor = SystemColors.Control; ;
                    items.SubItems[5].ForeColor = Color.Red;
                    items.SubItems.Add(reader.GetValue(7).ToString()).BackColor = SystemColors.Control; ;

                }
            }
            reader.Close();
            connection.Close();
        }

        private void AssesBY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "select studentreciept.rcpt_id,studentreciept.hist_id,studentinformation.lastname,studentinformation.firstname,studentinformation.middlename, "
           + " studentreciept.recieptno,studentreciept.totalamount,studentreciept.assessedby, "
          + " studentreciept.date from studentinformation join studentreciept  on studentinformation.accno=studentreciept.accno  where assessedby='" + AssesBY.Text + "' order by rcpt_id";
            connection.Open();
            reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                if (listView1.Items.Count % 2 == 0)
                {
                    ListViewItem items = listView1.Items.Add(reader.GetValue(0).ToString());
                    items.UseItemStyleForSubItems = false;
                    items.SubItems[0].ForeColor = Color.White;
                    items.SubItems.Add(reader.GetValue(1).ToString());
                    items.SubItems.Add(reader.GetValue(2).ToString() + ", " + reader.GetValue(3).ToString() + " " + reader.GetValue(4).ToString());
                    items.SubItems.Add(reader.GetValue(8).ToString());
                    items.SubItems.Add(reader.GetValue(5).ToString());
                    items.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n"));
                    items.SubItems[5].ForeColor = Color.Red;
                    items.SubItems.Add(reader.GetValue(7).ToString());

                    //  items.SubItems.Add(reader.GetValue(8).ToString());
                }
                else
                {
                    ListViewItem items = listView1.Items.Add(reader.GetValue(0).ToString());
                    items.UseItemStyleForSubItems = false;
                    items.SubItems[0].ForeColor = SystemColors.Control;
                    items.SubItems[0].BackColor = SystemColors.Control;
                    items.SubItems.Add(reader.GetValue(1).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(2).ToString() + ", " + reader.GetValue(3).ToString() + " " + reader.GetValue(4).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(8).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(5).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n")).BackColor = SystemColors.Control; ;
                    items.SubItems[5].ForeColor = Color.Red;
                    items.SubItems.Add(reader.GetValue(7).ToString()).BackColor = SystemColors.Control; ;

                }
            }
            reader.Close();
            connection.Close();
        }

        private void RECnumber_TextChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "select studentreciept.rcpt_id,studentreciept.hist_id,studentinformation.lastname,studentinformation.firstname,studentinformation.middlename, "
            + " studentreciept.recieptno,studentreciept.totalamount,studentreciept.assessedby, "
           + " studentreciept.date from studentinformation join studentreciept  on studentinformation.accno=studentreciept.accno  where recieptno ='"+RECnumber.Text+"' order by rcpt_id";
            connection.Open();
            reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                if (listView1.Items.Count % 2 == 0)
                {
                    ListViewItem items = listView1.Items.Add(reader.GetValue(0).ToString());
                    items.UseItemStyleForSubItems = false;
                    items.SubItems[0].ForeColor = Color.White;
                    items.SubItems.Add(reader.GetValue(1).ToString());
                    items.SubItems.Add(reader.GetValue(2).ToString() + ", " + reader.GetValue(3).ToString() + " " + reader.GetValue(4).ToString());
                    items.SubItems.Add(reader.GetValue(8).ToString());
                    items.SubItems.Add(reader.GetValue(5).ToString());
                    items.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n"));
                    items.SubItems[5].ForeColor = Color.Red;
                    items.SubItems.Add(reader.GetValue(7).ToString());

                    //  items.SubItems.Add(reader.GetValue(8).ToString());
                }
                else
                {
                    ListViewItem items = listView1.Items.Add(reader.GetValue(0).ToString());
                    items.UseItemStyleForSubItems = false;
                    items.SubItems[0].ForeColor = SystemColors.Control;
                    items.SubItems[0].BackColor = SystemColors.Control;
                    items.SubItems.Add(reader.GetValue(1).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(2).ToString() + ", " + reader.GetValue(3).ToString() + " " + reader.GetValue(4).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(8).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(5).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n")).BackColor = SystemColors.Control; ;
                    items.SubItems[5].ForeColor = Color.Red;
                    items.SubItems.Add(reader.GetValue(7).ToString()).BackColor = SystemColors.Control; ;

                }
            }
            reader.Close();
            connection.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "select studentreciept.rcpt_id,studentreciept.hist_id,studentinformation.lastname,studentinformation.firstname,studentinformation.middlename, "
           + " studentreciept.recieptno,studentreciept.totalamount,studentreciept.assessedby, "
          + " studentreciept.date from studentinformation join studentreciept  on studentinformation.accno=studentreciept.accno  where date ='" + dateTimePicker1.Value.ToShortDateString() + "' order by rcpt_id";
            connection.Open();
            reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                if (listView1.Items.Count % 2 == 0)
                {
                    ListViewItem items = listView1.Items.Add(reader.GetValue(0).ToString());
                    items.UseItemStyleForSubItems = false;
                    items.SubItems[0].ForeColor = Color.White;
                    items.SubItems.Add(reader.GetValue(1).ToString());
                    items.SubItems.Add(reader.GetValue(2).ToString() + ", " + reader.GetValue(3).ToString() + " " + reader.GetValue(4).ToString());
                    items.SubItems.Add(reader.GetValue(8).ToString());
                    items.SubItems.Add(reader.GetValue(5).ToString());
                    items.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n"));
                    items.SubItems[5].ForeColor = Color.Red;
                    items.SubItems.Add(reader.GetValue(7).ToString());

                    //  items.SubItems.Add(reader.GetValue(8).ToString());
                }
                else
                {
                    ListViewItem items = listView1.Items.Add(reader.GetValue(0).ToString());
                    items.UseItemStyleForSubItems = false;
                    items.SubItems[0].ForeColor = SystemColors.Control;
                    items.SubItems[0].BackColor = SystemColors.Control;
                    items.SubItems.Add(reader.GetValue(1).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(2).ToString() + ", " + reader.GetValue(3).ToString() + " " + reader.GetValue(4).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(8).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(reader.GetValue(5).ToString()).BackColor = SystemColors.Control; ;
                    items.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n")).BackColor = SystemColors.Control; ;
                    items.SubItems[5].ForeColor = Color.Red;
                    items.SubItems.Add(reader.GetValue(7).ToString()).BackColor = SystemColors.Control; ;

                }
            }
            reader.Close();
            connection.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {

                rrRePrint re = new rrRePrint();
                rrRePrint.recid = listView1.SelectedItems[0].SubItems[0].Text;
                rrRePrint.histid = listView1.SelectedItems[0].SubItems[1].Text;
                rrRePrint.name = listView1.SelectedItems[0].SubItems[2].Text;
                re.ShowDialog();
            }
        }

        private void listView1_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void Receipt_SizeChanged(object sender, EventArgs e)
        {
            listView1.Width = ClientRectangle.Width - deltawidth;
            listView1.Height = ClientRectangle.Height - deltaheigth;
        }
    }
}
