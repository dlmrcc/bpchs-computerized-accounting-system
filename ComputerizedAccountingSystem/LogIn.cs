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
    public partial class LogIn : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public LogIn()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "" && textboxPassword.Text == "")
            {
                MessageBox.Show("Please enter your Username and Password.", "Log-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxUsername.Focus();
            }
            else if (txtboxUsername.Text == "")
            {
                MessageBox.Show("Please enter your Username.", "Log-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxUsername.Focus();
            }
            else if (textboxPassword.Text == "")
            {
                MessageBox.Show("Please enter your Password.", "Log-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textboxPassword.Focus();
            }

            else if (txtboxUsername.Text.Contains("'"))
            {
                MessageBox.Show("Invalid Username.", "Log-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxUsername.Focus();
                txtboxUsername.SelectAll();
            }
            else
            {
                Login();
            }
        }

        private void txtboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void ToolCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            this.Hide();
            forgot.ShowDialog();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtboxUsername_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (txtboxUsername.Text != null)
            {
                txtboxUsername.SelectAll();
            }
        }

        private void textboxPassword_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (textboxPassword.Text != null)
            {
                textboxPassword.SelectAll();
            }
        }
        public void Login()
        {
            try
            {
                cmd.CommandText = "Select username, password, userstatus, usertype,concat(lastname,', ',firstname,' ',middlename) from UserAccount where username='" + txtboxUsername.Text + "'";
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Access denied.", "Log-In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxUsername.Focus();
                    txtboxUsername.SelectAll();
                }
                else if (reader.HasRows)
                {

                    if (txtboxUsername.Text != reader.GetValue(0).ToString() && textboxPassword.Text == reader.GetValue(1).ToString())
                    {
                        MessageBox.Show("Username is incorrect.", "Log-In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtboxUsername.Focus();
                        txtboxUsername.SelectAll();
                    }

                    else if (txtboxUsername.Text == reader.GetValue(0).ToString() && textboxPassword.Text != reader.GetValue(1).ToString())
                    {
                        MessageBox.Show("Password is incorrect.", "Log-In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textboxPassword.Focus();
                        textboxPassword.SelectAll();
                    }

                    else if (txtboxUsername.Text == reader.GetValue(0).ToString() && textboxPassword.Text.Contains("'"))
                    {
                        MessageBox.Show("Password is incorrect.", "Log-In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textboxPassword.Focus();
                        textboxPassword.SelectAll();
                    }
                    else if (reader.GetValue(2).ToString() == "Inactive")
                    {
                        MessageBox.Show("YOUR ACCOUNT IS INACTIVE.\n Please Contact your Administrator for inquires.", "Log-In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else if (txtboxUsername.Text == reader.GetValue(0).ToString() && textboxPassword.Text == reader.GetValue(1).ToString() && reader.GetValue(2).ToString() == "Active")
                    {
                         
                        MDIParent1.username = reader.GetValue(0).ToString();
                        MDIParent1.password = reader.GetValue(1).ToString();
                        MDIParent1.usertype = reader.GetValue(3).ToString();
                        MDIParent1.name = reader.GetValue(4).ToString().ToUpper();
                        this.Hide();
                        MDIParent1 main = new MDIParent1();
                        main.Show();
                        main.Focus();
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

            txtboxUsername.Text = "aldren";
            textboxPassword.Text = "delmarcaca";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
