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
    public partial class CopyFeesLoader : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader; 

        string sy = "";
         
        int i = 0;

        public CopyFeesLoader()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        void selectschoolyear()
        {
            cmd.CommandText = "select schoolyear from fees order by schoolyear desc limit 1";
            connection.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            sy = reader.GetValue(0).ToString();
            reader.Close();
            connection.Close();
        }

        private void CopyFeesLoader_Load(object sender, EventArgs e)
        {
            label1.Text = "Please wait.......";
            string yl = xFees.yearlevel;
            xFees h = new xFees(); 
            selectschoolyear();
           
                cmd.CommandText = "select * from fees where  schoolyear='" + sy + "' order by fees_id";
                connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    ListViewItem u = listView1.Items.Add(reader.GetValue(2).ToString());
                    u.SubItems.Add(reader.GetValue(3).ToString());
                    u.SubItems.Add(double.Parse(reader.GetValue(4).ToString()).ToString("n"));
                }
                reader.Close();
                connection.Close();
               
                copy();
                this.Close();
        }
        void copy()
           {
               for (int y = 0; y < listView1.Items.Count; y++)
               {
                  
                   cmd.CommandText = "insert into fees values(0,'" + MDIParent1.schoolyear + "','" + listView1.Items[y].Text + "','" + listView1.Items[y].SubItems[1].Text + "'," + double.Parse(listView1.Items[y].SubItems[2].Text )+ ")";
                   connection.Open();
                   cmd.ExecuteNonQuery();
                   connection.Close(); 
               }

           } 
              
    }
}
