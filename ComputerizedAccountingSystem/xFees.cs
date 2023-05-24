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
    public partial class xFees : UserControl
    {
        int y = 0;
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public static bool ok=false;
        public static string schoolyear = MDIParent1.schoolyear;
        public static string yearlevel = "";

        bool i = false;

        int deltawidth = 0;
        int deltaheigth = 0;

        public xFees()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }
 
        void loadYearlevel()
        {
            cmd.CommandText = "Select yearlevelname from yearlevel";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                toolStripYearlevel.Items.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            connection.Close(); 
        } 
        void loadfees()
        {
            LSchoolfees.Items.Clear();
            cmd.CommandText = "select * from fees where yearlevel='" + toolStripYearlevel.Text + "' and schoolyear='" + toolStripComboBox1.Text + "' order by fees_id ";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem it = LSchoolfees.Items.Add(reader.GetValue(0).ToString());
                it.SubItems.Add(reader.GetValue(3).ToString());
                it.SubItems.Add(double.Parse(reader.GetValue(4).ToString()).ToString("n"));
            }
            reader.Close();
            connection.Close();
            //LSchoolfees.SelectedItems[0].Selected = true;
        }
        void loadtalschoofees()
        {
            try
            {
                cmd.CommandText = "select sum(amount) from fees where yearlevel='" + toolStripYearlevel.Text + "' and schoolyear='" + toolStripComboBox1.Text + "'";
                connection.Open();
                double totals = Convert.ToDouble(cmd.ExecuteScalar()); 
                total.Text = totals.ToString("N"); 
            }
            catch
            {
                   yearlevel = toolStripYearlevel.Text;
                   CopyFeesLoader cop = new CopyFeesLoader();
                  // cop.ShowDialog(); 
            }
            finally
            {
                connection.Close();
                 
            }
        }
        private void tooltipclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void xFees_Load(object sender, EventArgs e)
        { 
            deltawidth = this.ClientRectangle.Width - LSchoolfees.Width;
            deltaheigth = this.ClientRectangle.Height - LSchoolfees.Height; 
            toolStripComboBox1.Items.Add(schoolyear);
            toolStripComboBox1.Items.Add("2015-2016");
            toolStripComboBox1.SelectedIndex = 0;
             
            loadYearlevel();
            toolStripYearlevel.SelectedIndex = 0;
            loadfees();
           
        }
         
        private void Edit_Click(object sender, EventArgs e)
        {
            xxEditSchoolFees edit = new xxEditSchoolFees();
            xxEditSchoolFees.id = LSchoolfees.SelectedItems[0].SubItems[0].Text;
            edit.feesname.Text = LSchoolfees.SelectedItems[0].SubItems[1].Text;
            edit.amount.Text = LSchoolfees.SelectedItems[0].SubItems[2].Text;
            edit.ShowDialog();
            if (ok)
            {
                Edit.Enabled = false;
                loadfees();
                loadtalschoofees();

            }
        }

        private void toolStripYearlevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearlevel = toolStripYearlevel.Text; 
            loadtalschoofees(); 
            loadfees();

            if (toolStripComboBox1.Text != schoolyear)
            {
                Edit.Enabled = addfees.Enabled = false;
            }
            else
            {
             //   Edit.Enabled = 
                    addfees.Enabled = true;
            }
        }

        private void LSchoolfees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text != schoolyear)
            {
                Edit.Enabled = addfees.Enabled = false; 
            }
            else
            {
                Edit.Enabled = addfees.Enabled = true;
            }
            if (LSchoolfees.SelectedItems.Count == 1 && toolStripComboBox1.Text == schoolyear)
            {
                Edit.Enabled = true;
            }
            else
            {
                Edit.Enabled = false;

            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            i = true;
            Edit.Enabled = false;
        }

        
        private void xFees_SizeChanged(object sender, EventArgs e)
        {
            LSchoolfees.Width = ClientRectangle.Width - deltawidth;
            LSchoolfees.Height = ClientRectangle.Height - deltaheigth;
        }

        private void addfees_Click(object sender, EventArgs e)
        {
            Edit.Enabled = false;
            xxAddSchoolFees add = new xxAddSchoolFees();
            add.ShowDialog();
            if (ok)
            {
                loadfees();
                loadtalschoofees();
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text != schoolyear)
            {
                Edit.Enabled = addfees.Enabled = false;
            }
            else
            {
               // Edit.Enabled = 
                    addfees.Enabled = true;
            }
            if (i)
            {

                loadtalschoofees();
                loadfees();
         
            }
        }

        private void LSchoolfees_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            LSchoolfees.Columns[0].Width = 0;
        }
    }
}
