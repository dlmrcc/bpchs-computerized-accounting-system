using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace ComputerizedAccountingSystem
{
    public partial class rrRePrint : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;

        
        public static string recid = "";
        public static string histid = "";

        public static string name = "";

        public rrRePrint()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void rrRePrint_Load(object sender, EventArgs e)
        {
            if (MDIParent1.usertype != "Cashier")
            {
                REPRINT.Enabled = false;
            }
            cmd.CommandText = "select particular,amount from particularreciept where Recpt_id=" + recid + " order by pr_id";
            connection.Open();
            reader = cmd.ExecuteReader();
           
            while (reader.Read())
            {
                if (LParticulars.Items.Count % 2 == 0)
                {
                    ListViewItem l = LParticulars.Items.Add(reader.GetValue(0).ToString());
                    l.UseItemStyleForSubItems = false;
                    //   l.SubItems.Add(reader.GetValue(2).ToString());
                    l.SubItems.Add(double.Parse(reader.GetValue(1).ToString()).ToString("n"));
                    l.SubItems[1].ForeColor = Color.Red;
                }
                else
                {
                    ListViewItem l = LParticulars.Items.Add(reader.GetValue(0).ToString());
                    l.UseItemStyleForSubItems = false;
                    l.SubItems[0].BackColor = SystemColors.Control;
                    //   l.SubItems.Add(reader.GetValue(2).ToString());
                    l.SubItems.Add(double.Parse(reader.GetValue(1).ToString()).ToString("n")).BackColor=SystemColors.Control;
                    l.SubItems[1].ForeColor = Color.Red;
                }
            }
            reader.Close();
            connection.Close();


            cmd.CommandText = "select modeofpayment from stupaymenthist where ph_id=" + histid;
            connection.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            Mode.Text = reader.GetValue(0).ToString();
            reader.Close();
            connection.Close();

        }

        private void REPRINT_Click(object sender, EventArgs e)
        {

        }
    }
}
