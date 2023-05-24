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
    public partial class zzParticulars : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public static string d="";

        public zzParticulars()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void zzParticulars_Load(object sender, EventArgs e)
        {
            cmd.CommandText = "Select * from particularreciept where hist_id =" + d + " order by pR_id asc";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (LParticulars.Items.Count % 2 == 0)
                {
                    ListViewItem l = LParticulars.Items.Add(reader.GetValue(1).ToString());
                    l.UseItemStyleForSubItems = false;
                    //   l.SubItems.Add(reader.GetValue(2).ToString());
                    l.SubItems.Add(double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    l.SubItems[1].ForeColor = Color.Red;
                }
                else
                {
                    ListViewItem l = LParticulars.Items.Add(reader.GetValue(1).ToString());
                    l.UseItemStyleForSubItems = false;
                    l.SubItems[0].BackColor = SystemColors.Control;
                    //   l.SubItems.Add(reader.GetValue(2).ToString());
                    l.SubItems.Add(double.Parse(reader.GetValue(2).ToString()).ToString("n")).BackColor=SystemColors.Control;
                    l.SubItems[1].ForeColor = Color.Red;
                }
            }
            reader.Close();
            connection.Close();
        }
    }
}
