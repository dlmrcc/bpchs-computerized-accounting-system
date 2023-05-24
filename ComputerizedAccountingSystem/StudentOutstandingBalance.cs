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
    public partial class StudentOutstandingBalance : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;

        public StudentOutstandingBalance()
        { 
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        void loadyearlevel()
        {
            yearlevelcombox.Items.Clear();
            cmd.CommandText = "select * from yearlevel";
            connection.Open();
            reader = cmd.ExecuteReader();
            yearlevelcombox.Items.Add("All");
            while (reader.Read())
            {
                yearlevelcombox.Items.Add(reader.GetValue(1).ToString());

            }

            reader.Close();
            connection.Close();
        }

        private void StudentOutstandingBalance_Load(object sender, EventArgs e)
        {
           
            toolStripTextBox2.Focus();
             
            loadyearlevel();
            loadtotalfee();
            yearlevelcombox.SelectedIndex = 0;
            cmd.CommandText = "select studentinformation.accno,studentinformation.lastname,studentinformation.firstname,studentinformation.middlename, studentinformation.yearlevel,"
                + "balance.totalbal from studentinformation join balance on studentinformation.accno=balance.accno where balance.schoolyear='" + MDIParent1.schoolyear + "'"
                + " and balance.totalbal!=0 order by lastname";
            connection.Open();
            reader = cmd.ExecuteReader(); 
            listView1.Items.Clear();
            while (reader.Read())
            {
                if (listView1.Items.Count % 2 == 0)
                {
                    ListViewItem i = listView1.Items.Add(reader.GetValue(0).ToString());
                    i.UseItemStyleForSubItems = false;
                    i.SubItems[0].ForeColor = SystemColors.Window;
                    i.SubItems.Add(reader.GetValue(1).ToString() + ", " + reader.GetValue(2).ToString() + " " + reader.GetValue(3).ToString());
                    i.SubItems.Add(reader.GetValue(4).ToString());
                    i.SubItems.Add(double.Parse(reader.GetValue(5).ToString()).ToString("n"));
                    i.SubItems.Add("");
                    i.SubItems[3].ForeColor = Color.Red;
                }
                else
                {
                    ListViewItem i = listView1.Items.Add(reader.GetValue(0).ToString());
                    i.UseItemStyleForSubItems = false;
                    i.BackColor = SystemColors.Control;
                     i.SubItems[0].ForeColor = SystemColors.Control;
                     i.SubItems.Add(reader.GetValue(1).ToString() + ", " + reader.GetValue(2).ToString() + " " + reader.GetValue(3).ToString()).BackColor = SystemColors.Control; ;
                     i.SubItems.Add(reader.GetValue(4).ToString()).BackColor = SystemColors.Control; ;
                    i.SubItems.Add(double.Parse(reader.GetValue(5).ToString()).ToString("n")).BackColor = SystemColors.Control; ;
                    i.SubItems.Add("").BackColor = SystemColors.Control;
                    i.SubItems[3].ForeColor = Color.Red;
                }
            }
            reader.Close();
            connection.Close();
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearlevelcombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (listView1.Columns[0].Width != 0)
            {
                listView1.Columns[0].Width = 0;
            }
            if (listView1.Columns[1].Width != 368)
            {
                listView1.Columns[1].Width = 368;
            }
             if (listView1.Columns[2].Width != 282)
            {
                listView1.Columns[2].Width = 282;
            }
        }

        void loadtotalfee()
        {
            for (int g = 0; g < yearlevelcombox.Items.Count; g++)
            {
                if (g>= 1)
                {
                    cmd.CommandText = "select sum(amount),yearlevel from fees where schoolyear='" + MDIParent1.schoolyear + "' and yearlevel='" + yearlevelcombox.Items[g] + "'";
                    connection.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    ListViewItem i = listView2.Items.Add(reader.GetValue(0).ToString());
                   i.SubItems.Add(reader.GetValue(1).ToString());
                    reader.Close();
                    connection.Close();
                }
            }
        }
    }
}
