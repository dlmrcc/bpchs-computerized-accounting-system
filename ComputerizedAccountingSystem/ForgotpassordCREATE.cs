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
    public partial class ForgotpassordCREATE : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        string id = "";
        public ForgotpassordCREATE()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           // label2.PerformLayout();
        }

        private void ForgotpassordCREATE_Load(object sender, EventArgs e)
        {
            id = ForgotPassword.password_id;

        }

        private void retrieve_Click(object sender, EventArgs e)
        {
             if (pas1.Text =="")
             {
                MessageBox.Show("Please Enter Password..", " Create New Password. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            else if (pas1.Text.Length < 6)
            {
                MessageBox.Show("Your Password is very weak.", "Create New Password.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pas1.Focus();
                pas1.SelectAll();
            }
            else if (pas1.Text != Pas2.Text)
            {
                MessageBox.Show("Your password did not match.", " Create New Password. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
             {
                 MessageBox.Show("Successfuly Create your New Password.", " Create New Password. ");
                cmd.CommandText = "update useraccount set password='" + pas1.Text + "' where user_id=" + id;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
               
                this.Close();
            }
        }

        private void pas1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                pas1.PerformLayout();
                e.Handled = true;
            }
        }
    }
}
