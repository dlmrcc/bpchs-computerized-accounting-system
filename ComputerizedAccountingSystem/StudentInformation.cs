using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CAS
{
    public partial class StudentInformation : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;

        public static bool ok = false;

        string schoolyear = MDIParent1.schoolyear;
        int deltawidth = 0;
        int deltaheigth = 0;

      
        public StudentInformation()
        {

            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {
            deltawidth = this.ClientRectangle.Width - ListStudent.Width;
            deltaheigth = this.ClientRectangle.Height - ListStudent.Height;

            loadyearlevel();
            loadstudent();
            yearlevelcombox.SelectedIndex = 0;
            studentresult();
        }

        private void StudentInformation_SizeChanged(object sender, EventArgs e)
        {

            ListStudent.Width = ClientRectangle.Width - deltawidth;
            ListStudent.Height = ClientRectangle.Height - deltaheigth;
        }

        private void Addnewstudent_Click(object sender, EventArgs e)
        {

            AddNewStudent addnewstu = new AddNewStudent();
            addnewstu.ShowDialog();
            if (ok)
            {
                yearlevelcombox.SelectedIndex = 0;
                loadstudent();
                studentresult();
                toolStripButton1.Enabled = false;
                ok = false;
            }
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (yearlevelcombox.Text == "All")
            {
                ListStudent.Items.Clear();
                cmd.CommandText = "select * from studentinformation where schoolyear='" + MDIParent1.schoolyear + "' AND"
             + "( lastname LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%' or "
             + "firstname LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%'  or "
              + "middlename LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%') ";
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (ListStudent.Items.Count % 2 == 0)
                    {
                        ListViewItem ii = ListStudent.Items.Add(reader.GetValue(1).ToString());


                        ii.SubItems.Add(reader.GetValue(3).ToString());
                        ii.SubItems.Add(reader.GetValue(4).ToString());
                        ii.SubItems.Add(reader.GetValue(5).ToString());
                        ii.SubItems.Add(reader.GetValue(6).ToString());
                        ii.SubItems.Add(reader.GetValue(7).ToString());
                        ii.SubItems.Add("");

                    }
                    else
                    {
                        ListViewItem ii = ListStudent.Items.Add(reader.GetValue(1).ToString());
                        ii.UseItemStyleForSubItems = false;
                        // d.BackColor = Color.Gainsboro;
                        ii.BackColor = SystemColors.Control;

                        ii.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(4).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(5).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(6).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(7).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(8).ToString()).BackColor = SystemColors.Control;

                        ii.SubItems.Add("").BackColor = SystemColors.Control;

                    }
                }
                reader.Close();
                connection.Close();
            }
            else
            {
                ListStudent.Items.Clear();
                cmd.CommandText = "select * from studentinformation where (yearlevel='" + yearlevelcombox.Text + "'  and schoolyear='" + MDIParent1.schoolyear + "') AND"
            + "( lastname LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%' or "
            + "firstname LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%'  or "
             + "middlename LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%')";
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (ListStudent.Items.Count % 2 == 0)
                    {
                        ListViewItem ii = ListStudent.Items.Add(reader.GetValue(1).ToString());


                        ii.SubItems.Add(reader.GetValue(3).ToString());
                        ii.SubItems.Add(reader.GetValue(4).ToString());
                        ii.SubItems.Add(reader.GetValue(5).ToString());
                        ii.SubItems.Add(reader.GetValue(6).ToString());
                        ii.SubItems.Add(reader.GetValue(7).ToString());
                        ii.SubItems.Add("");

                    }
                    else
                    {
                        ListViewItem ii = ListStudent.Items.Add(reader.GetValue(1).ToString());
                        ii.UseItemStyleForSubItems = false;
                        // d.BackColor = Color.Gainsboro;
                        ii.BackColor = SystemColors.Control;

                        ii.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(4).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(5).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(6).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(7).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(8).ToString()).BackColor = SystemColors.Control;

                        ii.SubItems.Add("").BackColor = SystemColors.Control;

                    }

                }
                reader.Close();
                connection.Close();
            }
        }

        void loadyearlevel()
        {
            yearlevelcombox.Items.Clear();
            cmd.CommandText = "select * from yearlevel";
            connection.Open();
            reader = cmd.ExecuteReader();
            yearlevelcombox.Items.Add("All");
            while (reader.Read())
            {
                yearlevelcombox.Items.Add(reader.GetValue(1).ToString());

            }

            reader.Close();
            connection.Close();
        }

        void loadstudent()
        {
            ListStudent.Items.Clear();
            cmd.CommandText = "select * from studentinformation where schoolyear='" + MDIParent1.schoolyear + "'";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (ListStudent.Items.Count % 2 == 0)
                {
                    ListViewItem ii = ListStudent.Items.Add(reader.GetValue(1).ToString());


                    ii.SubItems.Add(reader.GetValue(3).ToString());
                    ii.SubItems.Add(reader.GetValue(4).ToString());
                    ii.SubItems.Add(reader.GetValue(5).ToString());
                    ii.SubItems.Add(reader.GetValue(6).ToString());
                    ii.SubItems.Add(reader.GetValue(7).ToString());
                    ii.SubItems.Add(reader.GetValue(8).ToString());
                    ii.SubItems.Add("");

                }
                else
                {
                    ListViewItem ii = ListStudent.Items.Add(reader.GetValue(1).ToString());
                    ii.UseItemStyleForSubItems = false;
                    // d.BackColor = Color.Gainsboro;
                    ii.BackColor = SystemColors.Control;

                    ii.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control;
                    ii.SubItems.Add(reader.GetValue(4).ToString()).BackColor = SystemColors.Control;
                    ii.SubItems.Add(reader.GetValue(5).ToString()).BackColor = SystemColors.Control;
                    ii.SubItems.Add(reader.GetValue(6).ToString()).BackColor = SystemColors.Control;
                    ii.SubItems.Add(reader.GetValue(7).ToString()).BackColor = SystemColors.Control;
                    ii.SubItems.Add(reader.GetValue(8).ToString()).BackColor = SystemColors.Control;

                    ii.SubItems.Add("").BackColor = SystemColors.Control;

                }
            }
            reader.Close();
            connection.Close();
        }

        void studentresult()
        {
            cmd.CommandText = "select count(*) from studentinformation where schoolyear='" + schoolyear + "'";
            connection.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            all.Text = reader.GetValue(0).ToString() + " Student(s)";
            // Male.Text = reader.GetValue(0).ToString() + " Male(s)";
            // female.Text = reader.GetValue(1).ToString() + " Females";
            reader.Close();
            connection.Close();

            cmd.CommandText = "select count(*) from studentinformation where gender='female' AND schoolyear='" + schoolyear + "'";
            connection.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            //all.Text = reader.GetValue(0).ToString() + " Student(s)";
            // Male.Text = reader.GetValue(0).ToString() + " Male(s)";
            female.Text = reader.GetValue(0).ToString() + " Female(s)";
            reader.Close();
            connection.Close();

            cmd.CommandText = "select count(*) from studentinformation where GENDER='MALE' and schoolyear='" + schoolyear + "'";
            connection.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            //all.Text = reader.GetValue(0).ToString() + " Student(s)";
            Male.Text = reader.GetValue(0).ToString() + " Male(s)";
            // female.Text = reader.GetValue(1).ToString() + " Females";
            reader.Close();
            connection.Close();


        }

        private void Updateoldstudent_Click(object sender, EventArgs e)
        {
            UpdateOldStudent update = new UpdateOldStudent();
            update.ShowDialog();
            if (ok)
            {
                yearlevelcombox.SelectedIndex = 0;
                loadstudent();
                studentresult();
                toolStripButton1.Enabled = false;
                ok = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //EditStudenInfo.stuid = ListStudent.SelectedItems[0].Text;
            EditStudenInfo editstuinfo = new EditStudenInfo();

            cmd.CommandText = "SELECT * FROM yearlevel";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                editstuinfo.YearLevel.Items.Add(reader.GetValue(1).ToString());
            }
            reader.Close();
            connection.Close();

            editstuinfo.Accountno.Text = ListStudent.SelectedItems[0].Text;
            editstuinfo.Lastname.Text = ListStudent.SelectedItems[0].SubItems[1].Text;
            editstuinfo.Firstname.Text = ListStudent.SelectedItems[0].SubItems[2].Text;
            editstuinfo.Middlename.Text = ListStudent.SelectedItems[0].SubItems[3].Text;
            editstuinfo.Gender.Text = ListStudent.SelectedItems[0].SubItems[4].Text;
            editstuinfo.YearLevel.Text = ListStudent.SelectedItems[0].SubItems[5].Text;
            editstuinfo.Section.Text = ListStudent.SelectedItems[0].SubItems[6].Text;


            cmd.CommandText = "select totalpay from balance where (schoolyear='" + schoolyear + "' and yearlevel='" + ListStudent.SelectedItems[0].SubItems[5].Text + "') and accno='" + ListStudent.SelectedItems[0].SubItems[0].Text + "'";
            connection.Open();
            int c = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            if (c > 0)
            {
                editstuinfo.YearLevel.Enabled = false;
            }
            editstuinfo.ShowDialog();
            if (ok)
            {
                yearlevelcombox.SelectedIndex = 0;
                loadstudent();
                studentresult();
                toolStripButton1.Enabled = false;
                ok = false;
            }

        }

        private void ListStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListStudent.SelectedItems.Count == 1)
            {
                toolStripButton1.Enabled = true;
            }
            else
            {
                toolStripButton1.Enabled = false;
            }
        }

        private void yearlevelcombox_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = false;
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void yearlevelcombox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (yearlevelcombox.Text == "All")
            {
                ListStudent.Items.Clear();
                cmd.CommandText = "select * from studentinformation where schoolyear='" + MDIParent1.schoolyear + "'";
                connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (ListStudent.Items.Count % 2 == 0)
                    {
                        ListViewItem ii = ListStudent.Items.Add(reader.GetValue(1).ToString());


                        ii.SubItems.Add(reader.GetValue(3).ToString());
                        ii.SubItems.Add(reader.GetValue(4).ToString());
                        ii.SubItems.Add(reader.GetValue(5).ToString());
                        ii.SubItems.Add(reader.GetValue(6).ToString());
                        ii.SubItems.Add(reader.GetValue(7).ToString());
                        ii.SubItems.Add(reader.GetValue(8).ToString());
                        ii.SubItems.Add("");

                    }
                    else
                    {
                        ListViewItem ii = ListStudent.Items.Add(reader.GetValue(1).ToString());
                        ii.UseItemStyleForSubItems = false;
                        // d.BackColor = Color.Gainsboro;
                        ii.BackColor = SystemColors.Control;

                        ii.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(4).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(5).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(6).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(7).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(8).ToString()).BackColor = SystemColors.Control;

                        ii.SubItems.Add("").BackColor = SystemColors.Control;

                    }
                }
                reader.Close();
                connection.Close();

                cmd.CommandText = "select count(*) from studentinformation where schoolyear='" + schoolyear + "'";
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                all.Text = reader.GetValue(0).ToString() + " Student(s)";
                reader.Close();
                connection.Close();

                cmd.CommandText = "select count(*) from studentinformation where gender='female' AND schoolyear='" + schoolyear + "'";
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                female.Text = reader.GetValue(0).ToString() + " Female(s)";
                reader.Close();
                connection.Close();

                cmd.CommandText = "select count(*) from studentinformation where GENDER='MALE' and schoolyear='" + schoolyear + "'";
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                Male.Text = reader.GetValue(0).ToString() + " Male(s)";
                reader.Close();
                connection.Close();

            }
            else
            {
                ListStudent.Items.Clear();
                cmd.CommandText = "select * from studentinformation where schoolyear='" + MDIParent1.schoolyear + "' AND yearlevel='" + yearlevelcombox.Text + "'";
                connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (ListStudent.Items.Count % 2 == 0)
                    {
                        ListViewItem ii = ListStudent.Items.Add(reader.GetValue(1).ToString());


                        ii.SubItems.Add(reader.GetValue(3).ToString());
                        ii.SubItems.Add(reader.GetValue(4).ToString());
                        ii.SubItems.Add(reader.GetValue(5).ToString());
                        ii.SubItems.Add(reader.GetValue(6).ToString());
                        ii.SubItems.Add(reader.GetValue(7).ToString());
                        ii.SubItems.Add(reader.GetValue(8).ToString());
                        ii.SubItems.Add("");

                    }
                    else
                    {
                        ListViewItem ii = ListStudent.Items.Add(reader.GetValue(1).ToString());
                        ii.UseItemStyleForSubItems = false;
                        // d.BackColor = Color.Gainsboro;
                        ii.BackColor = SystemColors.Control;

                        ii.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(4).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(5).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(6).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(7).ToString()).BackColor = SystemColors.Control;
                        ii.SubItems.Add(reader.GetValue(8).ToString()).BackColor = SystemColors.Control;

                        ii.SubItems.Add("").BackColor = SystemColors.Control;

                    }
                }
                reader.Close();
                connection.Close();

                cmd.CommandText = "select count(*) from studentinformation where  schoolyear='" + schoolyear + "' and yearlevel='" + yearlevelcombox.Text + "' ";
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                all.Text = reader.GetValue(0).ToString() + " Student(s)";
                // Male.Text = reader.GetValue(0).ToString() + " Male(s)";
                // female.Text = reader.GetValue(1).ToString() + " Females";
                reader.Close();
                connection.Close();

                cmd.CommandText = "select count(*) from studentinformation where gender='female' AND (schoolyear='" + schoolyear + "' and yearlevel='" + yearlevelcombox.Text + "')";
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                //all.Text = reader.GetValue(0).ToString() + " Student(s)";
                // Male.Text = reader.GetValue(0).ToString() + " Male(s)";
                female.Text = reader.GetValue(0).ToString() + " Female(s)";
                reader.Close();
                connection.Close();

                cmd.CommandText = "select count(*) from studentinformation where GENDER='MALE' and (schoolyear='" + schoolyear + "' and yearlevel='" + yearlevelcombox.Text + "')";
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                //all.Text = reader.GetValue(0).ToString() + " Student(s)";
                Male.Text = reader.GetValue(0).ToString() + " Male(s)";
                // female.Text = reader.GetValue(1).ToString() + " Females";
                reader.Close();
                connection.Close();


            }
        }
    }
}
