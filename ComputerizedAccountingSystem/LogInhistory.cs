using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using System.Drawing.Printing;
using MySql.Data.MySqlClient;
using System.IO;

namespace ComputerizedAccountingSystem
{
    public partial class LogInhistory : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public LogInhistory()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }


        private void LogInhistory_Load(object sender, EventArgs e)
        {
            string oo = DateTime.Now.ToShortDateString();
            
            listView1.Items.Clear();
            cmd.CommandText = "select * from Loginhist where datein='" + oo + "' order by idhist asc";
            connection.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (listView1.Items.Count % 2 == 0)
                {
                    ListViewItem ii = listView1.Items.Add(reader.GetValue(1).ToString());
                    ii.SubItems.Add(reader.GetValue(2).ToString());
                    ii.SubItems.Add(reader.GetValue(3).ToString());
                    ii.SubItems.Add(reader.GetValue(4).ToString());
                    ii.SubItems.Add(reader.GetValue(5).ToString());
                    ii.SubItems.Add("");
                }
                else
                {
                    ListViewItem ii = listView1.Items.Add(reader.GetValue(1).ToString());
                    ii.UseItemStyleForSubItems = false;
                    ii.BackColor = SystemColors.Control;
                    ii.SubItems.Add(reader.GetValue(2).ToString()).BackColor = SystemColors.Control; ;
                    ii.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control; ;
                    ii.SubItems.Add(reader.GetValue(4).ToString()).BackColor = SystemColors.Control; ;
                    ii.SubItems.Add(reader.GetValue(5).ToString()).BackColor = SystemColors.Control; ;
                    ii.SubItems.Add("").BackColor = SystemColors.Control; ;
                }
            }
            reader.Close();
            connection.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string uu = Convert.ToDateTime(dateTimePicker1.Value).ToShortDateString();
            listView1.Items.Clear();
            cmd.CommandText = "select * from Loginhist where datein='" + uu + "' order by idhist asc";
            connection.Open();
            //DataTable n = new DataTable();
           
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (listView1.Items.Count % 2 == 0)
                {
                    ListViewItem ii = listView1.Items.Add(reader.GetValue(1).ToString());
                    ii.SubItems.Add(reader.GetValue(2).ToString());
                    ii.SubItems.Add(reader.GetValue(3).ToString());
                    ii.SubItems.Add(reader.GetValue(4).ToString());
                    ii.SubItems.Add(reader.GetValue(5).ToString());
                    ii.SubItems.Add("");
                }
                else
                {
                    ListViewItem ii = listView1.Items.Add(reader.GetValue(1).ToString());
                    ii.UseItemStyleForSubItems = false;
                    ii.BackColor = SystemColors.Control;
                    ii.SubItems.Add(reader.GetValue(2).ToString()).BackColor = SystemColors.Control; ;
                    ii.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control; ;
                    ii.SubItems.Add(reader.GetValue(4).ToString()).BackColor = SystemColors.Control; ;
                    ii.SubItems.Add(reader.GetValue(5).ToString()).BackColor = SystemColors.Control; ;
                    ii.SubItems.Add("").BackColor = SystemColors.Control; ;
                }
            }
            reader.Close();
            connection.Close();

        }

        private void listView1_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            try
            {
                if (listView1.Columns[0].Width != 150)
                {
                    listView1.Columns[0].Width = 150;
                }
                if (listView1.Columns[1].Width != 140)
                {

                    listView1.Columns[1].Width = 140;
                }
                if (listView1.Columns[2].Width != 140)
                {

                    listView1.Columns[2].Width = 140;
                }
                if (listView1.Columns[3].Width != 140)
                {

                    listView1.Columns[3].Width = 140;
                }
                if (listView1.Columns[4].Width != 140)
                {

                    listView1.Columns[4].Width = 140;
                }
            }
            catch { }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
           
        }
    }
}
