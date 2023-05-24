using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using MySql.Data.MySqlClient;

namespace ComputerizedAccountingSystem
{
    public partial class xSetUpSection : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;

        string schoolyear = MDIParent1.schoolyear;
        string syid = "";

        public xSetUpSection()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(add.Text=="Add")
            {
                add.ImageIndex=0;
                add.Text = "Save";
                namesection.ReadOnly = false;
                namesection.Focus();
                edit.Enabled = false;
                remove.Enabled = false;
            }
            else if (add.Text == "Save")
            {
                if (namesection.Text == "")
                {
                    MessageBox.Show("Please! Enter the Section Name.", "Section", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    namesection.Focus();
                }
                else
                {
                    add.ImageIndex=2;
                    add.Text = "Add";
                    savesection();
                    namesection.ReadOnly = true;
                    namesection.Text = "";
                    MessageBox.Show("Successfully Add.", "Section", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadsectionname();
                    
                }
            
            }
            else if (add.Text == "Update")
            {
               if (namesection.Text == "")
                {
                    MessageBox.Show("Please Enter the Section NAme.", "Section", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    namesection.Focus();
                }
                else
                {
                   add.ImageIndex=2;
                    add.Text = "Add";
                    updatesection();
                    namesection.ReadOnly = true;
                    namesection.Text = "";
                    MessageBox.Show("Successfully Updated.", "Section", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadsectionname();
                   
                }

            }
        }

        private void xSetUpSection_Load(object sender, EventArgs e)
        {
            if (MDIParent1.usertype == "Cashier")
            {
                add.Enabled =
                    cancel.Enabled =
                    remove.Enabled =
                    edit.Enabled = false;
            }
            loadyearlevelname();
            loadsectionname();
        }

        void savesection()
        {
            string section = namesection.Text;
            section = section.TrimStart(null);
            for (int l = 0; l < section.Length; l++)
            {
                section = section.Replace("  ", " ");
            }
            section = section.TrimEnd(null);
            section = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(section);
            cmd.CommandText = "insert into section values(0,'" + schoolyear + "','" + yl.Text + "','" + section.Replace("'", "''") + "')";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            namesection.ReadOnly = true;
            namesection.Text = "";
        }
        void updatesection()
        {
            string section = namesection.Text;
            section = section.TrimStart(null);
            for (int l = 0; l < section.Length; l++)
            {
                section = section.Replace("  ", " ");
            }
            section = section.TrimEnd(null);
            section = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(section);

            cmd.CommandText = "Update section set sectionname='" + section.Replace("'", "''")+ "', schoolyear='" + schoolyear + "' where sec_id=" + syid;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        void loadyearlevelname()
        {
            cmd.CommandText = "select yearlevelname from yearlevel";
            connection.Open();
            reader = cmd.ExecuteReader();
            yl.Items.Clear();
            while (reader.Read())
            {
                yl.Items.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            connection.Close();
            yl.SelectedIndex = 0;
        }

        void loadsectionname()
        {
            cmd.CommandText = "select sec_id, sectionname from section where schoolyear='" + schoolyear + "' and yearlevel='" + yl.Text + "'";
            connection.Open();
            reader = cmd.ExecuteReader();
            section_listView.Items.Clear();
            while (reader.Read())
            {
              ListViewItem s=  section_listView.Items.Add(reader.GetValue(0).ToString());
              s.SubItems.Add(reader.GetValue(1).ToString());
            }
            reader.Close();
            connection.Close();
        }
         
        private void cancel_Click(object sender, EventArgs e)
        {
            namesection.Text = "";
            namesection.ReadOnly = true;
            add.Text = "Add";
            add.ImageIndex=2;
            edit.Enabled = remove.Enabled = false;

        }

        private void section_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (add.Text == "Save" || add.Text == "Update" || MDIParent1.usertype == "Cashier")
            {
                edit.Enabled =
                    remove.Enabled = false;
            }
            else
            {
                if (section_listView.SelectedItems.Count == 1)
                {
                    edit.Enabled =
                        remove.Enabled = true;
                }
                else
                {
                    edit.Enabled =
                      remove.Enabled = false;
                }
            }
        }

        private void xSetUpSection_SizeChanged(object sender, EventArgs e)
        {
            panel2.Location = new Point((this.ClientRectangle.Width / 2) - (this.panel2.ClientRectangle.Width / 2), 132);
            panel2.Visible = true;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Do you want to Remove the selected Section?", "Section", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (f == DialogResult.Yes)
            {
                edit.Enabled = remove.Enabled = false;
                cmd.CommandText = "delete from section where sec_id=" + section_listView.SelectedItems[0].Text;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                loadsectionname();
            }
        }

        private void yl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "select sec_id, sectionname from section where yearlevel='" + yl.Text + "'and schoolyear='" + schoolyear + "'";
            connection.Open();
            reader = cmd.ExecuteReader();
            section_listView.Items.Clear();
            while (reader.Read())
            {
                ListViewItem subitem = section_listView.Items.Add(reader.GetValue(0).ToString());
                subitem.SubItems.Add(reader.GetValue(1).ToString());
            }
            reader.Close();
            connection.Close();

        }

        private void edit_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select sec_id, sectionname from section where sec_id=" + section_listView.SelectedItems[0].Text;
            connection.Open();
            reader = cmd.ExecuteReader();
            reader.Read();

            namesection.Text = reader.GetValue(1).ToString();
            
            reader.Close();
            connection.Close();

            syid = section_listView.SelectedItems[0].Text;
            add.ImageIndex=4;
            add.Text = "Update";
            namesection.ReadOnly = false;
            edit.Enabled =
            remove.Enabled = false;

        }

        private void namesection_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void namesection_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
