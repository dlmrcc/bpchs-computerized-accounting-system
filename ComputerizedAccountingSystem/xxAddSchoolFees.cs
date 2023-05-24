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
    public partial class xxAddSchoolFees : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public static string schoolyear = xFees.schoolyear;
        

        public xxAddSchoolFees()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            if (Save.Text == "Save")
            {
                DialogResult y = MessageBox.Show("Do you want to close?", "Add Fees", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (y == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        void SaveFees()
        {
            string feesnme = feesname.Text;
            feesnme = feesnme.TrimStart(null);
            for (int l = 0; l < feesnme.Length; l++)
            {
                feesnme = feesnme.Replace("  ", " ");
            }
            feesnme = feesnme.TrimEnd(null);
            double total = Convert.ToDouble(amount.Text);
            connection.Open();
            cmd.CommandText = "insert into fees values(0,'"+schoolyear+"','"+xFees.yearlevel+"','" + feesnme + "', " +total+ ")";
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (feesname.Text != "" && amount.Text != "0.00")
            {
                feesname.Text = "";
                amount.Text = "0.00";
            }
            else if(feesname.Text!="")
            {
                feesname.Text = "";
            }
            else if (amount.Text != "0.00")
            {
                amount.Text = "0.00";
            }
            else
            {
                if (Save.Text == "Save")
                {
                    DialogResult y = MessageBox.Show("Do you want to close?", "Add Fees", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (y == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }

            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (feesname.Text == "")
            {
                MessageBox.Show("Please type the Fees Name.");
            }
            else
            {
                SaveFees();
                xFees.ok = true;
                MessageBox.Show("Successfully Saved.");
                this.Close();
            }
        }

        private void amount_Leave(object sender, EventArgs e)
        {
            try
            {
                amount.Text = double.Parse(amount.Text).ToString("n");
            }
            catch
            {
                amount.Text = "0.00";
            }
        }

        private void amount_MouseCaptureChanged(object sender, EventArgs e)
        {
            amount.SelectAll();
        }

        private void feesname_MouseCaptureChanged(object sender, EventArgs e)
        {
            feesname.SelectAll();
        }

     
        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (amount.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else if (e.KeyChar >= 32 && e.KeyChar <= 47 ||
                  e.KeyChar >= 58 && e.KeyChar <= 126)
                e.Handled = true;

        } 
       
    }
}
