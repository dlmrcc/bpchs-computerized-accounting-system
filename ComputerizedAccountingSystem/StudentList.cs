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
    public partial class StudentList : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;

        int deltawidth = 0;
        int deltaheigth = 0;

        public StudentList()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            deltawidth = this.ClientRectangle.Width - dtStudentList.Width;
            deltaheigth = this.ClientRectangle.Height - dtStudentList.Height;

            connection.Open();
            cmd.CommandText = "select concat(lastname,' ',firstname,' ',middlename) from studentinformation";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dtStudentList.Rows.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            connection.Close();
            loadyearlevel();

        }
        void loadyearlevel()
        {
            connection.Open();
            cmd.CommandText = "select YearLevelName from Yearlevel";
            reader = cmd.ExecuteReader();
            toolStripComboBox1.Items.Add("All");
            while (reader.Read())
            {
                toolStripComboBox1.Items.Add(reader.GetValue(0).ToString());
            }
            toolStripComboBox1.SelectedIndex = 0;
            reader.Close();
            connection.Close();
        }
        void searchstudent()
        {
            if (toolStripComboBox1.Text == "All")
            {
                cmd.CommandText = "select concat(lastname,' ',firstname,' ',middlename) from studentinformation where"
                 + " lastname LIKE '" + toolStripTextBox1.Text.Replace("'", "''") + "%' or "
                 + "firstname LIKE '" + toolStripTextBox1.Text.Replace("'", "''") + "%'  or "
                 + "middlename LIKE '" + toolStripTextBox1.Text.Replace("'", "''") + "%' order by lastname";
                connection.Open();
                reader = cmd.ExecuteReader();
                dtStudentList.Rows.Clear();
                while (reader.Read())
                {
                    dtStudentList.Rows.Add(reader.GetValue(0).ToString());
                }

                reader.Close();
                connection.Close();
            }
            else
            {

                cmd.CommandText = "select concat(lastname,' ',firstname,' ',middlename) from studentinformation where (schoolyear='2012-2013' AND yearlevel='" + toolStripComboBox1 + "') and"
                  + " lastname LIKE '" + toolStripTextBox1.Text.Replace("'", "''") + "%' or "
                  + "firstname LIKE '" + toolStripTextBox1.Text.Replace("'", "''") + "%'  or "
                  + "middlename LIKE '" + toolStripTextBox1.Text.Replace("'", "''") + "%' order by lastname";
                connection.Open();
                reader = cmd.ExecuteReader();
                dtStudentList.Rows.Clear();
                while (reader.Read())
                {
                    dtStudentList.Rows.Add(reader.GetValue(0).ToString());
                }

                reader.Close();
                connection.Close();
            }
        }
          
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            searchstudent();
        }
         
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            MDIParent1.ppp = true;
            this.Hide();
             
        }

        private void StudentList_SizeChanged(object sender, EventArgs e)
        {
           dtStudentList.Width= ClientRectangle.Width - deltawidth;
           dtStudentList.Height = ClientRectangle.Height - deltaheigth;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
