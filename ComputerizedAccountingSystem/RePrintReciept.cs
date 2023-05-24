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
    public partial class RePrintReciept : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;

        public RePrintReciept()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RePrintReciept_Load(object sender, EventArgs e)
        {
           // loadprintedrec();
            //loadunPrintRec();
        }

        void loadprintedrec()
        {
            cmd.CommandText = "select studentinformation.lastname,studentinformation.firstname,studentinformation.middlename,"
            + " studentreciept.rcpt_id, studentreciept.recieptno,studentreciept.totalamount,studentreciept.assessedby,"
             + "studentreciept.date from studentinformation join studentreciept  on studentinformation.accno=studentreciept.accno  where studentreciept.process='Printed' order by rcpt_id";
            connection.Open();
            reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                ListViewItem items = listView1.Items.Add(reader.GetValue(3).ToString());
                items.SubItems.Add(reader.GetValue(0).ToString()+", "+reader.GetValue(1).ToString()+" "+reader.GetValue(2).ToString());
                items.SubItems.Add(reader.GetValue(4).ToString());
                items.SubItems.Add(reader.GetValue(5).ToString());
                items.SubItems.Add(reader.GetValue(6).ToString());
                items.SubItems.Add(reader.GetValue(7).ToString());
              //  items.SubItems.Add(reader.GetValue(8).ToString());
            }
            reader.Close();
            connection.Close();
        }

        void loadunPrintRec()
        {
            cmd.CommandText = "select studentinformation.lastname,studentinformation.firstname,studentinformation.middlename,"
                + " studentreciept.rcpt_id, studentreciept.recieptno,studentreciept.totalamount,studentreciept.assessedby,"
                 + "studentreciept.date from studentinformation join studentreciept  on studentinformation.accno=studentreciept.accno  where studentreciept.process='pending' order by rcpt_id";
            connection.Open();
            reader = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (reader.Read())
            {
                ListViewItem items = listView2.Items.Add(reader.GetValue(3).ToString());
                items.SubItems.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
                items.SubItems.Add(reader.GetValue(4).ToString());
                items.SubItems.Add(reader.GetValue(5).ToString());
                items.SubItems.Add(reader.GetValue(6).ToString());
                items.SubItems.Add(reader.GetValue(7).ToString());
               // items.SubItems.Add(reader.GetValue(8).ToString());
            }
            reader.Close();
            connection.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
