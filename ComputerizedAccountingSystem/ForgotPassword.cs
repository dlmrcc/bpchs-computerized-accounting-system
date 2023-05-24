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
    public partial class ForgotPassword : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public static string password_id = "";


        public ForgotPassword()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void ToolCancel_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
            login.Focus();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == ' ')
            {

                e.Handled = true;
            }
        }
         
        private void retrieve_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "" && secans.Text == "" && secquest.SelectedIndex == -1)
            {
                MessageBox.Show("All field are required to fill", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxUsername.Focus();
            }

            else if (txtboxUsername.Text == "")
            {
                MessageBox.Show("Please enter your Username.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxUsername.Focus();
            }
            else if (secquest.Text == "")
            {

                MessageBox.Show("Please select your Secret Question.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                secquest.Focus();
            }
            else if (secans.Text == "")
            {
                MessageBox.Show("Please enter your Secret Answer.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                secans.Focus();
            }
            else if (secquest.SelectedIndex == -1)
            {
                MessageBox.Show("Please select valid Secret Question.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                secquest.Focus();
            }
            else
            {
                select();
            }
        }

        void select()
        {
            try
            {
                cmd.CommandText = "select * from useraccount where username='" + txtboxUsername.Text + "'";
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();


                if (!reader.HasRows)
                {
                    MessageBox.Show("Denied!.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxUsername.SelectAll();
                }
                else if (reader.HasRows)
                {
                    if (secquest.Text != reader.GetValue(4).ToString())
                    {
                        MessageBox.Show("Please check your Secret Question.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        secquest.Focus();
                    }
                    else if (secans.Text != reader.GetValue(5).ToString())
                    {
                        MessageBox.Show("Please check your Secret Answer.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        secans.SelectAll();
                    }
                    else if (secans.Text == reader.GetValue(5).ToString() && reader.GetValue(6).ToString() == txtboxUsername.Text && reader.GetValue(4).ToString() == secquest.Text)
                    {
                        // //retrievepass re = new retrievepass();
                        //re.pass.Text = reader.GetValue(7).ToString();
                        //re.ShowDialog();
                        ForgotpassordCREATE newpas = new ForgotpassordCREATE();
                        newpas.ShowDialog();
                        password_id = reader.GetValue(0).ToString();
                      
                    }
                }
            }
            catch
            {
            }
            finally
            {
                reader.Close();
                connection.Close();

            }

        }

        private void txtboxUsername_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (txtboxUsername.Text != null)
            {
                txtboxUsername.SelectAll();
            }
        }

        private void secans_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (secans.Text != null)
            {
                secans.SelectAll();
            }
        }

    }
}
