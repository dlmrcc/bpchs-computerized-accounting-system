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
    public partial class UpdateOldStudent : Form
    {
        MySqlCommand cmd;
        MySqlConnection connection;
        MySqlDataReader reader;

        public static string schoolyear = MDIParent1.schoolyear;
       // string sy = "2013-2014";

        public UpdateOldStudent()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void backtosearch_Click(object sender, EventArgs e)
        {
            searchpanel.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchpanel.Visible = false;
        }

        private void UpdateOldStudent_Load(object sender, EventArgs e)
        {
            cmd.CommandText = "select AccNo,concat(lastname,' ',firstname,' ',middlename), yearlevel from studentinformation where schoolyear!='" +schoolyear + "' order by lastname";
            connection.Open();
            reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                ListViewItem itemx = listView1.Items.Add(reader.GetValue(0).ToString());
                itemx.SubItems.Add(reader.GetValue(1).ToString());
                itemx.SubItems.Add(reader.GetValue(2).ToString());

            }

            reader.Close();
            connection.Close();

            cmd.CommandText = "SELECT * FROM yearlevel";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                YearLevel.Items.Add(reader.GetValue(1).ToString());
            }
            reader.Close();
            connection.Close(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "select AccNo,concat(lastname,' ',firstname,' ',middlename), yearlevel from studentinformation where schoolyear!='" + schoolyear+ "' AND ( "
               + "lastname LIKE '" + textBox1.Text.Replace("'", "''") + "%' or "
               + "firstname LIKE '" + textBox1.Text.Replace("'", "''") + "%'  or "
               + "middlename LIKE '" + textBox1.Text.Replace("'", "''") + "%') order by lastname";
            connection.Open();
            reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                ListViewItem itemx = listView1.Items.Add(reader.GetValue(0).ToString());
                itemx.SubItems.Add(reader.GetValue(1).ToString());
                itemx.SubItems.Add(reader.GetValue(2).ToString());

            }

            reader.Close();
            connection.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                cmd.CommandText = "select * from studentinformation where AccNo ='" + listView1.SelectedItems[0].Text + "'";
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                acountno.Text = reader.GetValue(1).ToString();
                lastname.Text = reader.GetValue(3).ToString();
                frstname.Text=reader.GetValue(4).ToString();
                middlename.Text=reader.GetValue(5).ToString();
                gender.Text=reader.GetValue(6).ToString();
                YearLevel.Text=reader.GetValue(7).ToString();
                Section.Text=reader.GetValue(8).ToString();
                reader.Close();
                connection.Close();
               // yearlevelremove();
                try
                {
                    YearLevel.SelectedIndex = YearLevel.SelectedIndex + 1;
                }
                catch
                {
                    YearLevel.SelectedIndex = YearLevel.Items.Count - 1;
                }
                searchpanel.Visible = false;
               // textBox1.Visible = label1.Visible = button5.Visible = listView1.Visible= false;

            }
        }

        void yearlevelremove()
        {
            for (int y = 0; y <= YearLevel.SelectedIndex; y++)
            {
                YearLevel.Items.RemoveAt(y);
            }
        }

        private void yearlevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Section.Items.Clear();
                cmd.CommandText = "select sectionname from section where yearlevel ='" + YearLevel.Text + "' && schoolyear='" + schoolyear + "'";
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            if (lastname.Text != "" || frstname.Text != "" || middlename.Text != "")
            {
                DialogResult k = MessageBox.Show("Do you want to Cancel? ", "Add New Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (k == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (lastname.Text != "" || frstname.Text != "" || middlename.Text != "")
            {
                DialogResult k = MessageBox.Show("Do you want to Close? ", "Add New Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (k == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
         
        void update()
        {
            string lname = lastname.Text;
            lname = lname.TrimStart(null);
            for (int l = 0; l < lname.Length; l++)
            {
                lname = lname.Replace("  ", " ");
            }
            lname = lname.TrimEnd(null);

            string fname = frstname.Text;
            fname = fname.TrimStart(null);
            for (int f = 0; f < fname.Length; f++)
            {
                fname = fname.Replace("  ", " ");
            }
            fname = fname.TrimEnd(null);

            string mi = middlename.Text;
            mi = mi.TrimStart(null);
            for (int d = 0; d < mi.Length; d++)
            {
                mi = mi.Replace("  ", " ");
            }
            mi = mi.TrimEnd(null);

            cmd.CommandText = "update studentinformation set schoolyear='" + MDIParent1.schoolyear + "', lastname='" + lname + "', firstname='" + fname + "'"
                + ", middlename='" +mi + "', gender='" + gender.Text + "', yearlevel='" + YearLevel.Text + "', section='" + Section.Text + "'"
                + " where accno='" + acountno.Text + "'";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            SaveBal();


            MessageBox.Show("Name        : " + lname + ", " + fname + " " + mi + "\n"
                           + "Gender      : " + gender.Text + "\n"
                           + "Year Level : " + YearLevel.Text + "\n"
                           + "Section      : " + Section.Text + "\n\n"
                           + "This Student Information is Succesfully Updated.", "Student Registration.", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // StudentRegistration.OK = true;
            studentinformation.ok = true;
          //  StudentRegistration.AccNo = acountno.Text;
          //  StudentRegistration.Lname = lname;
          //  StudentRegistration.Fname = fname;
          //  StudentRegistration.MI = mi;
           // StudentRegistration.YearLevel = YearLevel.Text;
           // StudentRegistration.Gender = gender.Text;
          //  StudentRegistration.Section = Section.Text;
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select count(*) from studentinformation where lastname='" + lastname.Text + "' && firstname ='" + frstname.Text + "' && middlename ='" +middlename.Text + "'";
            connection.Open();
            int regCount = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            if (lastname.Text == "" || frstname.Text == "")
            {
                MessageBox.Show("Some fields are required to fill.", "Student Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (lastname.Text == "")
                {
                    lastname.Focus();
                }
                else if (frstname.Text == "")
                {
                    frstname.Focus();
                }
            } 
            else
            {
                update();
            }
        }

        private void frstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void middlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 91 && e.KeyChar <= 96 ||
        e.KeyChar >= 123 && e.KeyChar <= 126 || e.KeyChar >= 33 && e.KeyChar <= 64)
                e.Handled = true;
        }

        private void lastname_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                frstname.Focus();
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                e.Handled = true;
            }
        }

        private void frstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
               middlename.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                lastname.Focus();
            }
        }

        private void middlename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                gender.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                frstname.Focus();
            }
        }

        private void middlename_Leave(object sender, EventArgs e)
        {
            middlename.Text = CultureInfo.CurrentCulture.TextInfo.ToLower(middlename.Text);
            middlename.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(middlename.Text);
        }

        private void frstname_Leave(object sender, EventArgs e)
        {
            frstname.Text = CultureInfo.CurrentCulture.TextInfo.ToLower(frstname.Text);
            frstname.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(frstname.Text);
        }

        private void lastname_Leave(object sender, EventArgs e)
        {
            lastname.Text = CultureInfo.CurrentCulture.TextInfo.ToLower(lastname.Text);
            lastname.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lastname.Text);
        }
        void SaveBal()
        {
            double totalbal = 0;
            cmd.CommandText = "select sum(amount) from fees where schoolyear='" + schoolyear + "' and yearlevel='" + YearLevel.Text + "'";
            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                totalbal = Convert.ToDouble(reader.GetValue(0).ToString());

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            cmd.CommandText = "insert into balance values(0,'" + acountno.Text+ "','" + schoolyear + "','" + YearLevel.Text + "'," + totalbal + ",0)";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
