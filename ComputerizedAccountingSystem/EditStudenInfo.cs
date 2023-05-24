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
    public partial class EditStudenInfo : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public static string stuid = "";

        public EditStudenInfo()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditStudenInfo_Load(object sender, EventArgs e)
        {
         //   cmd.CommandText="select count(*) sturec where (schoolyear='"+MDIParent1.schoolyear+"' and yearlevel='"+y
            //label10.Text = MDIParent1.schoolyear;
            YearLevel.Text = "ll";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Saves_Click(object sender, EventArgs e)
        { 
            if (Lastname.Text == "" || Firstname.Text == "")
            {
                MessageBox.Show("Some fields are required to fill.", "Student Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Lastname.Text == "")
                {
                    Lastname.Focus();
                }
                else if (Firstname.Text == "")
                {
                    Firstname.Focus();
                }
            }
           
            else
            {
                update();
            }
            
        }
        void update()
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
            for (int d = 0; d < mi.Length; d++)
            {
                mi = mi.Replace("  ", " ");
            }
            mi = mi.TrimEnd(null);

            cmd.CommandText = "update studentinformation set lastname='" + lname +
                "', firstname='" + fname + "', middlename='" + mi + "', gender='" + Gender.Text + "' where accno='" + Accountno.Text + "'";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            //**********
            SaveBal();
            MessageBox.Show("Name        : " + lname + ", " + fname + " " + mi + "\n"
                           + "Gender      : " + Gender.Text + "\n\n"
                            
                           + "This Student Information is Succesfully Updated.", "Student Registration.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            studentinformation.ok  = true;
            this.Close();
        }

        private void Lastname_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= 91 && e.KeyChar <= 96 ||
           e.KeyChar >= 123 && e.KeyChar <= 126 || e.KeyChar >= 33 && e.KeyChar <= 64)
                e.Handled = true;
        }

        private void Lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Firstname.Focus();
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                e.Handled = true;
            }

        }

        private void Firstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Middlename.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Lastname.Focus();
            }
        }

        private void Middlename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Gender.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Firstname.Focus();
            }
        }

        private void YearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Section.Items.Clear();
                cmd.CommandText = "select sectionname from section where yearlevel ='" + YearLevel.Text + "' && schoolyear='" + MDIParent1.schoolyear +"'";
                connection.Open();
                reader = cmd.ExecuteReader();
                Section.Items.Add("None");
                while (reader.Read())
                {
                    Section.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
                connection.Close();
                Section.Text = "None";
            }
            catch { }
        }
        void SaveBal()
        {
            double totalbal = 0;
            cmd.CommandText = "select sum(amount) from fees where schoolyear='" + MDIParent1.schoolyear + "' and yearlevel='" + YearLevel.Text + "'";
            try
            {
                connection.Open();
                totalbal = Convert.ToDouble(cmd.ExecuteScalar());

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            cmd.CommandText = "insert into balance values(0,'" + Accountno.Text + "','" +MDIParent1.schoolyear + "','" + YearLevel.Text + "'," + totalbal + ",0)";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
