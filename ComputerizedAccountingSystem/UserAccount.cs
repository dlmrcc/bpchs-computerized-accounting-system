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
    public partial class UserAccount : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;

        public UserAccount()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            User_listView.Items.Clear();
            cmd.CommandText = "select user_id, Lastname,Firstname, Middlename, username, usertype, userstatus from useraccount";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem itemx = User_listView.Items.Add(reader.GetValue(0).ToString());
                itemx.SubItems.Add(reader.GetValue(4).ToString());
                itemx.SubItems.Add(reader.GetValue(2).ToString() + " " + reader.GetValue(3) + " " + reader.GetValue(1));
                itemx.SubItems.Add(reader.GetValue(5).ToString());
                itemx.SubItems.Add(reader.GetValue(6).ToString());
            }
            reader.Close();
            connection.Close();
        }

        private void create_save_Click(object sender, EventArgs e)
        {
            if (create_save.Text == "Create")
            {
                create_save.Text = "Save";
                create_save.ImageIndex = 1;

                Lastname.Enabled =
                Firstname.Enabled =
                Middlename.Enabled =
                SecQues.Enabled =
                SecrtAns.Enabled =
                Username.Enabled =
                Password.Enabled =
                verifypassword.Enabled =
                userstatus.Enabled =
                usertype.Enabled = true;

                Edit.Enabled =
               Changeuserrights.Enabled = false;

                SecQues.SelectedIndex = 1;
                userstatus.SelectedIndex = 1;
                usertype.SelectedIndex = 1;  
            }
            else if (create_save.Text == "Save")
            {
                connection.Open();
                cmd.CommandText = "select username from useraccount where username='" + Username.Text + "'";
                adapter = new MySqlDataAdapter(cmd);
                DataTable usertable = new DataTable();
                adapter.Fill(usertable);
                connection.Close();

                int userCount = Convert.ToInt32(usertable.Rows.Count);

                if (userCount > 0)
                {
                    MessageBox.Show("Username is already exist.", "Create Account  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Username.Focus();
                    Username.SelectAll();
                }

                else if (Lastname.Text == "" ||
                            Firstname.Text == "" ||
                            SecQues.Text == "" ||
                            SecrtAns.Text == "" ||
                            Username.Text == "" ||
                            Password.Text == "" ||
                            verifypassword.Text == "" ||
                            usertype.Text == "" ||
                            userstatus.Text == "")
                {
                    MessageBox.Show("Some field are required to be fill.", " Create Account ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //textboxfucos();
                }
                else if (Username.Text.Length < 6)
                {
                    MessageBox.Show("Your Username is very short.", " Create Account  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Username.Focus();
                    Username.SelectAll();
                }

                else if (Password.Text != verifypassword.Text)
                {
                    MessageBox.Show("Your password did not match.", " Create Account ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Password.Text.Length < 6)
                {
                    MessageBox.Show("Your Password is very weak.", "Create Account  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Password.Focus();
                    Password.SelectAll();
                }
                else
                {


                    SaveNewAccount();
                    create_save.ImageIndex = 0;
                    MessageBox.Show("New Account sucessfully Created", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Lastname.Text = "";
                    Firstname.Text = "";
                    Middlename.Text = "";
                    SecQues.SelectedText = "";
                    SecrtAns.Text = "";
                    Username.Text = "";
                    Password.Text = "";
                    verifypassword.Text = "";
                    usertype.Text = "";
                    userstatus.Text = "";

                    Lastname.Enabled =
                         Firstname.Enabled =
                         Middlename.Enabled =
                         SecQues.Enabled =
                         SecrtAns.Enabled =
                         Username.Enabled =
                         Password.Enabled =
                         verifypassword.Enabled =
                         userstatus.Enabled =
                         usertype.Enabled = false;

                    create_save.Text = "Create";
                    UserAccount_Load(sender, e);

                    Edit.Enabled =
                    Changeuserrights.Enabled = false;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (create_save.Text == "Save" || create_save.Text == "Update")
            {
                DialogResult k = MessageBox.Show("Do you want to Cancel?", "UserAccount", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (k == DialogResult.Yes)
                {

                    Lastname.Text = "";
                    Firstname.Text = "";
                    Middlename.Text = "";
                    SecQues.Text = "";
                    SecrtAns.Text = "";
                    Username.Text = "";
                    Password.Text = "";
                    verifypassword.Text = "";
                    usertype.Text = "";
                    userstatus.Text = "";

                    Lastname.Enabled =
                         Firstname.Enabled =
                         Middlename.Enabled =
                         SecQues.Enabled =
                         SecrtAns.Enabled =
                         Username.Enabled =
                         Password.Enabled =
                         verifypassword.Enabled =
                         userstatus.Enabled =
                         usertype.Enabled = false;

                    create_save.Text = "Create";
                }
            }
        }

        void SaveNewAccount()
        {
            string lname = Lastname.Text;
            lname = lname.TrimStart(null);
            for (int l = 0; l < lname.Length; l++)
            {
                lname = lname.Replace("  ", " ");
            }
            lname = lname.TrimEnd(null);

            string fname = Firstname.Text;
            fname = fname.TrimStart(null);
            for (int f = 0; f < fname.Length; f++)
            {
                fname = fname.Replace("  ", " ");
            }
            fname = fname.TrimEnd(null);

            string mi = Middlename.Text;
            mi = mi.TrimStart(null);
            for (int m = 0; m < mi.Length; m++)
            {
                mi = mi.Replace("  ", " ");
            }
            mi = mi.TrimEnd(null);


            cmd.CommandText = "insert into useraccount values(0,'" + lname + "','" + fname + "','" + mi + "','" + SecQues.Text + "','" + SecrtAns.Text + "','" + Username.Text + "','" + Password.Text + "','" + usertype.Text + "','" + userstatus.Text + "')";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        
        private void Lastname_Leave(object sender, EventArgs e)
        {
            Lastname.Text = CultureInfo.CurrentCulture.TextInfo.ToLower(Lastname.Text);
            Lastname.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Lastname.Text);
        }

        private void Firstname_Leave(object sender, EventArgs e)
        {
            Firstname.Text = CultureInfo.CurrentCulture.TextInfo.ToLower(Firstname.Text);
            Firstname.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Firstname.Text);
        }

        private void Middlename_Leave(object sender, EventArgs e)
        {
            Middlename.Text = CultureInfo.CurrentCulture.TextInfo.ToLower(Middlename.Text);
            Middlename.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Middlename.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void Changeuserrights_Click(object sender, EventArgs e)
        {

        }

        private void User_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Text = e.KeyCode.ToString();
        }

        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '!')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '@')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '#')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '$')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '%')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '^')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '&')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '*')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '(')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ')')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '+')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '=')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '[')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ']')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '}')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '{')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ':')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ';')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '"')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '?')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '/')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '>')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '<')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\\')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '|')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '`')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '~')
            {
                e.Handled = true;
            }
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '!')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '@')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '#')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '$')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '%')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '^')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '&')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '*')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '(')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ')')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '+')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '=')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '[')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ']')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '}')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '{')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ':')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ';')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '"')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '?')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '/')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '>')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '<')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\\')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '|')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '`')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '~')
            {
                e.Handled = true;
            }
        }
    }
}
