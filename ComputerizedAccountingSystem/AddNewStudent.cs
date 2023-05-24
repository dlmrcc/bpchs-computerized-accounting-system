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
    public partial class AddNewStudent : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public static string schoolyear = MDIParent1.schoolyear;
        string SY = MDIParent1.schoolyear.Substring(0, 4);
        public AddNewStudent()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void AddNewStudent_Load(object sender, EventArgs e)
        {
            Gender.Text = "Male"; 
            Accountno.Text = SY + "-" + Getstuaccono().ToString("d6");  
            cmd.CommandText = "SELECT * FROM yearlevel";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            { 
            YearLevel.Items.Add(reader.GetValue(1).ToString());
            }
            reader.Close();
            connection.Close();

            YearLevel.SelectedIndex = 0; 
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (Lastname.Text != "" || Firstname.Text != "" || Middlename.Text != "")
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

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            if (Lastname.Text != "" || Firstname.Text != "" || Middlename.Text != "")
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

        private void Saves_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select count(*) from studentinformation where lastname='" + Lastname.Text + "' && firstname ='" + Firstname.Text + "' && middlename ='" + Middlename.Text + "'";
            connection.Open();
            int regCount = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

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
            else if (regCount >= 1)
            {

                DialogResult m = MessageBox.Show(" Please Check. The Information you've Enter is already Registered. \n\n Do you want to Continue to Save this Information?", "Student Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (m == DialogResult.Yes)
                {
                    save();
                }
            }
            else
            {
                save();
            }
        } 

        public int Getstuaccono()
        {
            cmd.CommandText = "select stu_id from studentinformation order by stu_id desc limit 1";
            try
            {
                connection.Open();
                int nextsubID = Convert.ToInt32(cmd.ExecuteScalar());
                nextsubID = nextsubID + 1;
                return nextsubID;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return 0;
        }

        void save()
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

            cmd.CommandText = "insert into studentinformation values(0,'" + Accountno.Text + "','"+schoolyear+"','" + lname +
                "','" + fname + "','" + mi + "','" + Gender.Text + "','" + YearLevel.Text + "','" + Section.Text + "')";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            //***********
            SaveBal();
            MessageBox.Show("Name        : " + lname + ", " + fname + " " + mi + "\n"
                           +"Gender      : " + Gender.Text + "\n"
                           +"Year Level : " + YearLevel.Text + "\n"
                           +"Section      : " + Section.Text + "\n\n"
                           +"This Student Information is Succesfully Registered.", "Student Registration.",MessageBoxButtons.OK, MessageBoxIcon.Information);
            studentinformation.ok = true;

            // StudentRegistration.OK = true;


           //// StudentRegistration.AccNo = Accountno.Text;
           // StudentRegistration.Lname = lname;
           // StudentRegistration.Fname = fname;
           // StudentRegistration.MI = mi;
           // StudentRegistration.YearLevel = YearLevel.Text;
           // StudentRegistration.Gender = Gender.Text;
           // StudentRegistration.Section = Section.Text;
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

        private void Lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Firstname.Focus();
            }
            if (e.KeyCode==Keys.CapsLock)
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

        private void Middlename_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (e.KeyChar >= 91 && e.KeyChar <= 96 ||
           e.KeyChar >= 123 && e.KeyChar <= 126|| e.KeyChar >= 33 && e.KeyChar <= 64)
                e.Handled = true;
        }
 
        private void YearLevel_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Section_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {

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
                totalbal = 0;
            }
            finally
            {
                connection.Close();
            }
           
            cmd.CommandText="insert into balance values(0,'"+Accountno.Text +"','"+schoolyear+"','"+YearLevel.Text+"',"+totalbal+",0)";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
