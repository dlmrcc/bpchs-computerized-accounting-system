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
    public partial class SearchStudent : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public SearchStudent()
        {

            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            textBox1.Focus();

            listView1.Items.Clear();
            cmd.CommandText = "select stu_id, concat(lastname,' ',firstname,' ',middlename), yearlevel from studentinformation where schoolyear ='" + MDIParent1.schoolyear + "'  order by lastname";//;//where schoolyear";// =NULL";
            connection.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem itemx = listView1.Items.Add(reader.GetValue(0).ToString());
                itemx.SubItems.Add(reader.GetValue(1).ToString());
                itemx.SubItems.Add(reader.GetValue(2).ToString());

            }
            reader.Close();
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "select stu_id,concat(lastname,' ',firstname,' ',middlename), yearlevel from studentinformation where schoolyear='"+MDIParent1.schoolyear+"' AND"
              + " lastname LIKE '" + textBox1.Text.Replace("'", "''") + "%' or "
              + "firstname LIKE '" + textBox1.Text.Replace("'", "''") + "%'  or "
              + "middlename LIKE '" + textBox1.Text.Replace("'", "''") + "%' order by lastname";
            connection.Open();
            reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                ListViewItem itemx = listView1.Items.Add(reader.GetValue(0).ToString());
                itemx.SubItems.Add(reader.GetValue(1).ToString());
                itemx.SubItems.Add(reader.GetValue(2).ToString());

            }

            reader.Close();
            connection.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cmd.CommandText = "Select * from studentinformation where stu_id=" + listView1.SelectedItems[0].Text;
            connection.Open();
            reader = cmd.ExecuteReader();

            reader.Read();
            Payment_z.sy= reader.GetValue(2).ToString();
            Payment_z.ln = reader.GetValue(3).ToString();
            Payment_z.mn = reader.GetValue(5).ToString();
            Payment_z.gndr = reader.GetValue(6).ToString();
            Payment_z.fn = reader.GetValue(4).ToString();
            Payment_z.sc = reader.GetValue(8).ToString();
            Payment_z.yl = reader.GetValue(7).ToString();
            Payment_z.id = reader.GetValue(1).ToString();
            reader.Close();
            connection.Close();
            Payment_z.ok = true;
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
