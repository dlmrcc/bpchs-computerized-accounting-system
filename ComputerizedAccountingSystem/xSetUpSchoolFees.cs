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
    public partial class xSetUpSchoolFees : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public static string schoolyear = MDIParent1.schoolyear;
        public static string yearlevel = "";

        int deltawidth = 0;
        int deltaheigth = 0;

        public xSetUpSchoolFees()
        {

            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        private void Addnewstudent_Click(object sender, EventArgs e)
        {
            xxAddSchoolFees addfees = new xxAddSchoolFees();
            addfees.ShowDialog(); 

            //*******************************************
            Remove.Enabled = false;
            Setup.Enabled = false;
            Edit.Enabled = false; ;
            //******************************************************&&

            LSchoolfees.Items.Clear();
            yearlevelscoolfees();
            yearlevelsubfees();
            loadtotalpayment();
        }
 
        private void xSetUpSchoolFees_Load(object sender, EventArgs e)
        {
            deltawidth = this.ClientRectangle.Width - LSchoolfees.Width;
            deltaheigth = this.ClientRectangle.Height - LSchoolfees.Height;

            //*********************************

            Remove.Enabled = false;
            Setup.Enabled = false;
            Edit.Enabled = false; 
            //**************************************

            toolStripComboBox1.Items.Add(schoolyear);
            toolStripComboBox1.SelectedIndex = 0;
            loadYearlevel(); 
            toolStripYearlevel.SelectedIndex = 0;
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

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void toolStripYearlevel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripYearlevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearlevel = toolStripYearlevel.Text;
            LSchoolfees.Items.Clear();
            yearlevelscoolfees();
            yearlevelsubfees();
            loadtotalpayment();
        }

        void yearlevelscoolfees()
        {
            cmd.CommandText = "Select Fees_id,feesname,amount,feestype from schoolfees where yearlevel='"+toolStripYearlevel.Text+"' && schoolyear='"+toolStripComboBox1.Text+"'";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(3).ToString() == "w_sub")
                {
                  ListViewItem itemx=  LSchoolfees.Items.Add(reader.GetValue(0).ToString());
                  itemx.SubItems.Add(reader.GetValue(1).ToString());
                  itemx.SubItems.Add("");
                  itemx.SubItems.Add("");
                  itemx.SubItems.Add(reader.GetValue(3).ToString());
                   /// dataGridView1.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), null, null,reader.GetValue(3).ToString());
                }
                else
                {
                    ListViewItem itemx = LSchoolfees.Items.Add(reader.GetValue(0).ToString());
                    itemx.SubItems.Add(reader.GetValue(1).ToString());
                    itemx.SubItems.Add("");
                    itemx.SubItems.Add(Convert.ToDouble(reader.GetValue(2).ToString()).ToString("n"));
                    itemx.SubItems.Add(reader.GetValue(3).ToString());
                  //  dataGridView1.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), null, Convert.ToDouble(reader.GetValue(2).ToString()).ToString("n"), reader.GetValue(3).ToString());
                }
            }
            reader.Close();
            connection.Close();
        }

        void yearlevelsubfees()
        {
            for (int y = 0; y < LSchoolfees.Items.Count; y++)
            {
                if (LSchoolfees.Items[y].SubItems[4].Text== "w_sub")
                {
                    cmd.CommandText = "Select fees_id,subfeesname,amount from subfees where fees_id=" + LSchoolfees.Items[y].SubItems[0].Text + " order by subfees";
                    connection.Open();
                    reader = cmd.ExecuteReader();
                    int t = 1;
                    while (reader.Read())
                    {
                        ListViewItem itemx = LSchoolfees.Items.Insert(t+y++,reader.GetValue(0).ToString());
                        itemx.SubItems.Add("");
                        itemx.SubItems.Add(reader.GetValue(1).ToString());
                        itemx.SubItems.Add(Convert.ToDouble(reader.GetValue(2).ToString()).ToString("n"));
                        itemx.SubItems.Add("");
                       // dataGridView1.Rows.Insert(t + y++,reader.GetValue(0).ToString(), null, reader.GetValue(1).ToString(),Convert.ToDouble(reader.GetValue(2).ToString()).ToString("n"), "");
                    }
                    reader.Close();
                    connection.Close();
                  
                }

            }
        }

        void loadtotalpayment()
        {
            try
            {
                cmd.CommandText = "Select Sum(amount) from schoolfees where yearlevel='" + toolStripYearlevel.Text + "' && schoolyear='" + toolStripComboBox1.Text + "'";
                connection.Open();
                total.Text = Convert.ToDouble(cmd.ExecuteScalar()).ToString("n");
                reader.Close();
                
            }
            catch
            {
                total.Text = "00.00";
                MessageBox.Show("Empty School Fees for this Year Level."); 
            }
            finally
            {
                connection.Close();
            }
        }

        private void xSetUpSchoolFees_SizeChanged(object sender, EventArgs e)
        {
            LSchoolfees.Width = ClientRectangle.Width - deltawidth;
            LSchoolfees.Height = ClientRectangle.Height - deltaheigth;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LSchoolfees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LSchoolfees.SelectedItems.Count == 1)
            {
                if (LSchoolfees.SelectedItems[0].SubItems[4].Text == "wo_sub")
                {
                    Remove.Enabled = true;
                    Setup.Enabled = false;
                    Edit.Enabled = true;
                }
                else if (LSchoolfees.SelectedItems[0].SubItems[4].Text == "")
                {
                    Remove.Enabled = false;
                    Setup.Enabled = false;
                    Edit.Enabled = false; ;
                }
                else if (LSchoolfees.SelectedItems[0].SubItems[4].Text == "w_sub")
                {
                    Remove.Enabled =true;
                    Setup.Enabled = true; ;
                    Edit.Enabled = true ;
                }

            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            //if (LSchoolfees.SelectedItems[0].SubItems[4].Text == "wo_sub")
           // {
              // DialogResult x= MessageBox.Show("Do you want to delete this School Fees?", "Delete School Fees", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
              // if (x == DialogResult.Yes)
              // {
                //   cmd.CommandText = "delete from schoolfees where fees_id=" + LSchoolfees.SelectedItems[0].Text;
                //   connection.Open();
                 //  cmd.ExecuteNonQuery();
                  // connection.Close();
                   //*****************************************

                  // Remove.Enabled = false;
                   //Setup.Enabled = false;
                   //Edit.Enabled = false; ;
                   //******************************************************&&

                 //  LSchoolfees.Items.Clear();
                  // yearlevelscoolfees();
                   //yearlevelsubfees();
                  // loadtotalpayment();
              // }
            }
          //  else if (LSchoolfees.SelectedItems[0].SubItems[4].Text == "w_sub")
         //   {
                DialogResult x = MessageBox.Show("Do you want to delete this School Fees with the Sub Fees?", "Delete School Fees", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
              //  if (x == DialogResult.Yes)
              //  {
                  //  cmd.CommandText = "delete from schoolfees where fees_id=" + LSchoolfees.SelectedItems[0].Text;
                 //   connection.Open();
                 //   cmd.ExecuteNonQuery();
                   // connection.Close();
                    //*******************************************
                   // cmd.CommandText = "delete from subfees where fees_id=" + LSchoolfees.SelectedItems[0].Text;
                   // connection.Open();
                    //cmd.ExecuteNonQuery();
                   /// connection.Close();

                    //*****************************************

                   // Remove.Enabled = false;
                   // Setup.Enabled = false;
                    //Edit.Enabled = false; ;
                    //******************************************************&&

                 //   LSchoolfees.Items.Clear();
                  //  yearlevelscoolfees();
                    //yearlevelsubfees();
                    //loadtotalpayment();
        //        }
           // }
    //    }

      // private void Edit_Click(object sender, EventArgs e)
       // {

         //   if (LSchoolfees.SelectedItems[0].SubItems[4].Text == "wo_sub")
         //   {
             //   xxAddSchoolFees add = new xxAddSchoolFees();
             //   add.Save.Text = "*Save";
              //  add.ShowDialog();
       //     }
        //   else if (LSchoolfees.SelectedItems[0].SubItems[4].Text == "w_sub")
           // {
          //  }
         
    //    }
//
       // private void Setup_Click(object sender, EventArgs e)
      //  {
       //     //if (LSchoolfees.SelectedItems[0].SubItems[4].Text == "w_sub")
            //{ 
               // xxSetUpSubFees setup = new xxSetUpSubFees();
               // xxSetUpSubFees.getsubid = int.Parse(LSchoolfees.SelectedItems[0].Text);
               // setup.Feesnames.Text = (LSchoolfees.SelectedItems[0].SubItems[1].Text);
              //  setup.ShowDialog();
            //}
        }
    }
//}
