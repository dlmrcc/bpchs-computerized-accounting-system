using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerizedAccountingSystem
{
    public partial class ChooseSchoolYear : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        ListViewItem xitem;

        public ChooseSchoolYear()
        {

            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ChooseSY_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Do you want to change the SCHOOL YEAR?", "Change School Year", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (m == DialogResult.Yes)
            {
                cmd.CommandText = "Update chooseschoolyear set schoolywar='" + sy_listView.SelectedItems[0].Text + "'";
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MDIParent1.schoolyear = sy_listView.SelectedItems[0].Text;
            }
        }

        private void sy_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MDIParent1.usertype == "Cashier")
            {
                ChooseSY.Enabled = false;
            }
            else
            {
                if (sy_listView.SelectedIndices.Count == 1)
                {
                    ChooseSY.Enabled = true;
                }
            }
        }

        private void ChooseSchoolYear_Load(object sender, EventArgs e)
        {
            if (MDIParent1.usertype == "Cashier")
            {
                ChooseSY.Enabled = false;
            }
        }

        private void ChooseSchoolYear_SizeChanged(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.ClientRectangle.Width / 2) - (this.panel1.ClientSize.Width / 2), 156);
            panel1.Visible = true;
        }
    }
}
