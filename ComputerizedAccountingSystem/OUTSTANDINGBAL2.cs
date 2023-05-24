using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace ComputerizedAccountingSystem
{
    public partial class OUTSTANDINGBAL2 : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;

        int deltawidth = 0;
        int deltaheigth = 0;

        public OUTSTANDINGBAL2()
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

        private void OUTSTANDINGBAL2_SizeChanged(object sender, EventArgs e)
        {
            ListStudent.Width = ClientRectangle.Width - deltawidth;
            ListStudent.Height = ClientRectangle.Height - deltaheigth;

        }

        private void OUTSTANDINGBAL2_Load(object sender, EventArgs e)
        {
            loadbalance();
            deltawidth = this.ClientRectangle.Width - ListStudent.Width;
            deltaheigth = this.ClientRectangle.Height - ListStudent.Height;
        }

        void loadbalance()
        {

            toolStripTextBox2.Focus();

            loadyearlevel();
            yearlevelcombox.SelectedIndex = 0;
            cmd.CommandText = "select studentinformation.lastname,studentinformation.firstname,studentinformation.middlename, "
                + "balance.totalbal from studentinformation join balance on studentinformation.accno=balance.accno where balance.schoolyear='" + MDIParent1.schoolyear + "'"
                + " order by lastname and gender desc";
            connection.Open();
            reader = cmd.ExecuteReader();
            ListStudent.Items.Clear();
            while (reader.Read())
            {
                if (ListStudent.Items.Count % 2 == 0)
                {
                    ListViewItem i = ListStudent.Items.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString()); 
                    i.UseItemStyleForSubItems = false; 
                    i.SubItems.Add(double.Parse(reader.GetValue(3).ToString()).ToString("n"));
                    i.SubItems.Add("");
                    i.SubItems[1].ForeColor = Color.Red;
                }
                else
                {
                    ListViewItem i = ListStudent.Items.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
                    i.UseItemStyleForSubItems = false;
                    i.SubItems[0].BackColor = SystemColors.Control;
                     
                    i.SubItems.Add(double.Parse(reader.GetValue(3).ToString()).ToString("n"));
                    i.SubItems[1].BackColor = SystemColors.Control;
                    i.SubItems.Add("");
                    i.SubItems[1].ForeColor = Color.Red;
                }
            }
            reader.Close();
            connection.Close();
        }

        private void yearlevelcombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripTextBox2.Text = "";
            if (yearlevelcombox.Text == "All")
            {
                cmd.CommandText = "select studentinformation.lastname,studentinformation.firstname,studentinformation.middlename, "
                    + "balance.totalbal from studentinformation join balance on studentinformation.accno=balance.accno where balance.schoolyear='" + MDIParent1.schoolyear + "'"
                    + " order by lastname and gender desc";
                connection.Open();
                reader = cmd.ExecuteReader();
                ListStudent.Items.Clear();
                while (reader.Read())
                {
                    if (ListStudent.Items.Count % 2 == 0)
                    {
                        ListViewItem i = ListStudent.Items.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
                        i.UseItemStyleForSubItems = false;
                        i.SubItems.Add(double.Parse(reader.GetValue(3).ToString()).ToString("n"));
                        i.SubItems.Add("");
                        i.SubItems[1].ForeColor = Color.Red;
                    }
                    else
                    {
                        ListViewItem i = ListStudent.Items.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
                        i.UseItemStyleForSubItems = false;
                        i.SubItems[0].BackColor = SystemColors.Control;

                        i.SubItems.Add(double.Parse(reader.GetValue(3).ToString()).ToString("n"));
                        i.SubItems[1].BackColor = SystemColors.Control;
                        i.SubItems.Add("");
                        i.SubItems[1].ForeColor = Color.Red;
                    }
                }
                reader.Close();
                connection.Close();
            }
            else
            {

                cmd.CommandText = "select studentinformation.lastname,studentinformation.firstname,studentinformation.middlename, "
                    + "balance.totalbal from studentinformation join balance on studentinformation.accno=balance.accno where balance.schoolyear='" + MDIParent1.schoolyear + "'"
                    + " and studentinformation.yearlevel='"+yearlevelcombox.Text+"' order by lastname and gender desc";
                connection.Open();
                reader = cmd.ExecuteReader();
                ListStudent.Items.Clear();
                while (reader.Read())
                {
                    if (ListStudent.Items.Count % 2 == 0)
                    {
                        ListViewItem i = ListStudent.Items.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
                        i.UseItemStyleForSubItems = false;
                        i.SubItems.Add(double.Parse(reader.GetValue(3).ToString()).ToString("n"));
                        i.SubItems.Add("");
                        i.SubItems[1].ForeColor = Color.Red;
                    }
                    else
                    {
                        ListViewItem i = ListStudent.Items.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
                        i.UseItemStyleForSubItems = false;
                        i.SubItems[0].BackColor = SystemColors.Control;

                        i.SubItems.Add(double.Parse(reader.GetValue(3).ToString()).ToString("n"));
                        i.SubItems[1].BackColor = SystemColors.Control;
                        i.SubItems.Add("");
                        i.SubItems[1].ForeColor = Color.Red;
                    }
                }
                reader.Close();
                connection.Close();
            }
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (yearlevelcombox.Text == "All")
            {
                cmd.CommandText = "select studentinformation.lastname,studentinformation.firstname,studentinformation.middlename, "
                   + "balance.totalbal from studentinformation join balance on studentinformation.accno=balance.accno where (balance.schoolyear='" + MDIParent1.schoolyear + "') and"
                   + " ( lastname LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%' or "
             + "firstname LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%'  or "
              + "middlename LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%') order by lastname and gender desc";
                connection.Open();
                reader = cmd.ExecuteReader();
                ListStudent.Items.Clear();
                while (reader.Read())
                {
                    if (ListStudent.Items.Count % 2 == 0)
                    {
                        ListViewItem i = ListStudent.Items.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
                        i.UseItemStyleForSubItems = false;
                        i.SubItems.Add(double.Parse(reader.GetValue(3).ToString()).ToString("n"));
                        i.SubItems.Add("");
                        i.SubItems[1].ForeColor = Color.Red;
                    }
                    else
                    {
                        ListViewItem i = ListStudent.Items.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
                        i.UseItemStyleForSubItems = false;
                        i.SubItems[0].BackColor = SystemColors.Control;

                        i.SubItems.Add(double.Parse(reader.GetValue(3).ToString()).ToString("n"));
                        i.SubItems[1].BackColor = SystemColors.Control;
                        i.SubItems.Add("");
                        i.SubItems[1].ForeColor = Color.Red;
                    }
                }
                reader.Close();
                connection.Close();
            }
            else
            {
                cmd.CommandText = "select studentinformation.lastname,studentinformation.firstname,studentinformation.middlename, "
                   + "balance.totalbal from studentinformation join balance on studentinformation.accno=balance.accno where (balance.schoolyear='" + MDIParent1.schoolyear + "' and studentinformation.yearlevel='"+yearlevelcombox.Text+"') and"
                   + " ( lastname LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%' or "
             + "firstname LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%'  or "
              + "middlename LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%') order by lastname and gender desc";
                connection.Open();
                reader = cmd.ExecuteReader();
                ListStudent.Items.Clear();
                while (reader.Read())
                {
                    if (ListStudent.Items.Count % 2 == 0)
                    {
                        ListViewItem i = ListStudent.Items.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
                        i.UseItemStyleForSubItems = false;
                        i.SubItems.Add(double.Parse(reader.GetValue(3).ToString()).ToString("n"));
                        i.SubItems.Add("");
                        i.SubItems[1].ForeColor = Color.Red;
                    }
                    else
                    {
                        ListViewItem i = ListStudent.Items.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
                        i.UseItemStyleForSubItems = false;
                        i.SubItems[0].BackColor = SystemColors.Control;

                        i.SubItems.Add(double.Parse(reader.GetValue(3).ToString()).ToString("n"));
                        i.SubItems[1].BackColor = SystemColors.Control;
                        i.SubItems.Add("");
                        i.SubItems[1].ForeColor = Color.Red;
                    }
                }
                reader.Close();
                connection.Close();
            }
        }

        private void yearlevelcombox_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
        void print()
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
