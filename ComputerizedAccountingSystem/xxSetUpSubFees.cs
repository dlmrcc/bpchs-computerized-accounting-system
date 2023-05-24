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
    public partial class xxSetUpSubFees : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public static int getsubid = 0;
        string subid = "";

        public xxSetUpSubFees()
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
         
        public double getnxtsufeesid()
        {            
            //select fees_id from Schoolfees order by fees_id desc limit 1
            cmd.CommandText = "select Count(subfees) from subfees where subfees>" + getsubid + " && subfees<" + getsubid + 1 ;
            try
            {
                connection.Open(); 
                double nextsubID = Convert.ToDouble(cmd.ExecuteScalar());
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

        private void Save_Click(object sender, EventArgs e)
        {
            if (Save.Text == "Add")
            {
                Save.Text = "Save";
                amount.Enabled = feesname.Enabled = true;
                Edit.Enabled = remove.Enabled = false;
                feesname.Focus();
                Save.ImageIndex = 0;
            }
            else if (Save.Text == "*Save")
            {
                string feesnme = feesname.Text;
                feesnme = feesnme.TrimStart(null);

                for (int l = 0; l < feesnme.Length; l++)
                {
                    feesnme = feesnme.Replace("  ", " ");
                }
                feesnme = feesnme.TrimEnd(null);
                string d = getsubid.ToString() + "." + getnxtsufeesid().ToString();
                double i = Convert.ToDouble(d);
                cmd.CommandText = "update subfees set subfeesname='" + feesname.Text.Replace("'", "''") + "' , amount=" + amount.Text + " where subfees='" + subid+"'";
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
             
                Save.Text = "Add";
                Save.ImageIndex = 2;
                amount.Enabled = feesname.Enabled = false;
                amount.Text = feesname.Text = "";
             
                loadsubfees();
                updateTotalpayment();

            }
            else
            {
                if (amount.Text == "" || feesname.Text == "")
                {
                    MessageBox.Show("All field are required to filled.", "Setup Subfees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string feesnme = feesname.Text;
                    feesnme = feesnme.TrimStart(null);

                    for (int l = 0; l < feesnme.Length; l++)
                    {
                        feesnme = feesnme.Replace("  ", " ");
                    }
                    feesnme = feesnme.TrimEnd(null);

                    string d = getsubid.ToString() +"." + getnxtsufeesid().ToString(); 
                    cmd.CommandText = "insert into subfees values(" + d + ",'" + xSetUpSchoolFees.schoolyear + "','" + xSetUpSchoolFees.yearlevel + "','" + feesnme.Replace("'", "''") + "'," + amount.Text + "," + getsubid + ")";
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    //***************************
                    ListViewItem itemxx=Lsubfees.Items.Add(d.ToString());
                    itemxx.SubItems.Add(feesnme);
                    itemxx.SubItems.Add(Convert.ToDouble(amount.Text).ToString("n"));

                   //*********************************************
                  //  dataGridView1.Rows.Add(getnxtsufeesid().ToString(), feesnme, amount.Text);
                    updateTotalpayment();
                    Save.Text = "Add";
                    amount.Enabled = feesname.Enabled = false;
                    amount.Text = feesname.Text = "";
                }
            }
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
 
        }

        private void feesname_Leave(object sender, EventArgs e)
        {
            feesname.Text = CultureInfo.CurrentCulture.TextInfo.ToLower(feesname.Text);
            feesname.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(feesname.Text);

        } 
        private void Edit_Click(object sender, EventArgs e)
        {


            feesname.Text = Lsubfees.SelectedItems[0].SubItems[1].Text;
            amount.Text = Lsubfees.SelectedItems[0].SubItems[2].Text;

            subid = Lsubfees.SelectedItems[0].Text;
          //  add.ImageIndex = 4;
            Save.Text = "*Save";
            Save.ImageIndex = 0;
            //namesection.ReadOnly = false;
            feesname.Enabled = amount.Enabled = true;
            Edit.Enabled =
            remove.Enabled = false;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            DialogResult ee = MessageBox.Show("Do you want to Remove?.", "SetUp Subfees.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == ee)
            {
                cmd.CommandText = "delete from subfees where subfees=" + Lsubfees.SelectedItems[0].Text;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                loadsubfees();
                updateTotalpayment();
                Edit.Enabled = remove.Enabled = false;
            }
            else
            {
                Edit.Enabled = remove.Enabled = true;
            }
        }

        void loadsubfees()
        {
            cmd.CommandText = "select subfees, subfeesname,amount from subfees where Fees_id=" + getsubid; ;
            connection.Open();
            reader = cmd.ExecuteReader();
            Lsubfees.Items.Clear();

            while (reader.Read())
            {
                ListViewItem itmexx = Lsubfees.Items.Add(reader.GetValue(0).ToString());
                itmexx.SubItems.Add(reader.GetValue(1).ToString());
                itmexx.SubItems.Add(reader.GetValue(2).ToString());
            }
            reader.Close();
            connection.Close(); 
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Save.Text = "Add";
            Save.ImageIndex = 2;
            feesname.Text = amount.Text = "";
            feesname.Enabled = amount.Enabled = false;
            Edit.Enabled = remove.Enabled = false;
            Lsubfees.SelectedItems[0].Selected = false;

        }


        void updateTotalpayment()
        {
            double h1 = 0;
            for (int p = 0; p < Lsubfees.Items.Count; p++)
            {
                double o = Convert.ToDouble(Lsubfees.Items[0].SubItems[2].Text);
                h1 = h1 + o;
            }
            cmd.CommandText = "update schoolfees set amount=" + h1+ " where fees_id=" + getsubid;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    

        private void Lsubfees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lsubfees.SelectedItems.Count == 1)
            {
                if (Save.Text == "*Save" || Save.Text == "Save")
                {
                    Edit.Enabled = remove.Enabled = false;
                }
                else
                {
                    Edit.Enabled = remove.Enabled = true;
                }
            }
            else
            {
                Edit.Enabled = remove.Enabled = false;
            }
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            if (amount.Text.Contains("."))
            {
                return;
            }
        }

        private void amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 48 && e.KeyValue <= 57)
            {
                e.SuppressKeyPress = false;
            }
            else
            {
               // e.Handled = false;
            }
        }
         
    }
}
