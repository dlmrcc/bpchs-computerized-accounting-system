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
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prbar1.Value += 1;

            if (prbar1.Value < 30)
            {
                label1.Text = "Initializing...";
                //**
             
                //**
                

            }
            else if (prbar1.Value > 30 && prbar1.Value < 33)
            {
                label1.Text = "Connecting to server...";
                timer1.Interval = 500;
                cmd.CommandText = "select * from fees";

                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                connection.Close();

                cmd.CommandText = "select * from studentinformation";

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

            }
            else if (prbar1.Value > 33 && prbar1.Value < 90)
            {
                label1.Text = "Reading database...";
                timer1.Interval = 10;
            }

            else if (prbar1.Value > 90 && prbar1.Value < 99)
            {
                label1.Text = "Please wait...";
                timer1.Interval = 100;
            }

            else if (prbar1.Value > 99)
            {
                timer1.Enabled = false;
                LogIn login = new LogIn();
                
                login.Show();
                this.Hide();
                login.Focus();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void prbar1_Click(object sender, EventArgs e)
        {

        } 
    }
}
