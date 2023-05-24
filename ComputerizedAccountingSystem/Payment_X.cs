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
    public partial class Payment_X : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public static string schoolyear = "";

        public Payment_X()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }
        public static string sy;

        public static string id;
        public static string ln;
        public static string fn;
        public static string mn;
        public static string yl;
        public static string sc;
        public static string gndr;
        public static bool ok;

      
        private void toolsearch_Click(object sender, EventArgs e)
        {
           // textBoxenteramount.Text = "";
            SearchStudent searcstu = new SearchStudent();
            searcstu.ShowDialog();
            if (ok)
            {
              //  accno.Text = id;
                lastname.Text = ln;
                firstname.Text = fn;
                middlename.Text = mn;
                yearlevel.Text = yl;
                section.Text = sc;
                gender.Text = gndr;

                checkBox1.Enabled = true; 
                loadpayhist(); 
                 loadfees();
                 loadtotalfees();
                 totalbalstudent();
                ok = false;
            }
        }

        private void Payment_X_Load(object sender, EventArgs e)
        {
           // label1.Text = schoolyear;
        }
        void loadfees()
        {
            Lfees.Items.Clear();
            cmd.CommandText = "select * from fees where amount!=0 and (yearlevel='" + yearlevel.Text + "' and schoolyear='" + sy+ "') order by fees_id ";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem it = Lfees.Items.Add(reader.GetValue(0).ToString());
                it.SubItems.Add(reader.GetValue(3).ToString());
                it.SubItems.Add(double.Parse(reader.GetValue(4).ToString()).ToString("n"));
            }
            reader.Close();
            connection.Close();
        }

        void loadpayhist()
        {
            Lhistory.Items.Clear();
            cmd.CommandText = "select * from stupaymenthist where schoolyear='" + MDIParent1.schoolyear + "' and accno='"+id+ "' order by ph_id asc";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem itemxx = Lhistory.Items.Add(reader.GetValue(0).ToString());
                itemxx.SubItems.Add(reader.GetValue(3).ToString());
                itemxx.SubItems.Add(reader.GetValue(4).ToString());
                itemxx.SubItems.Add(double.Parse(reader.GetValue(5).ToString()).ToString("n"));
                itemxx.SubItems.Add(reader.GetValue(6).ToString());
            }
            reader.Close();
            connection.Close();
        }

        void loadtotalfees()
        {

            cmd.CommandText = "select sum(amount) from fees where yearlevel='" + yearlevel.Text + "' and schoolyear='" + sy + "' ";
            connection.Open();
            double total = Convert.ToDouble(cmd.ExecuteScalar());
            connection.Close();

            if (total == 0)
            {
                MessageBox.Show("There is no Fees for this Yearlevel. Please setup first the School fees of this Yearlevel.");
            }
            else{
                ttlschlfees.Text=total.ToString("n");
            }

        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Lhistory.Items.Clear();
                cmd.CommandText = "select * from stupaymenthist where accno='" +id+ "' order by ph_id asc";
                connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itemxx = Lhistory.Items.Add(reader.GetValue(0).ToString());
                    itemxx.SubItems.Add(reader.GetValue(3).ToString());
                    itemxx.SubItems.Add(reader.GetValue(4).ToString());
                    itemxx.SubItems.Add(double.Parse(reader.GetValue(5).ToString()).ToString("n"));
                    itemxx.SubItems.Add(reader.GetValue(6).ToString());
                }
                reader.Close();
                connection.Close();
            }
            else
            {
                loadpayhist();
            }
        }

        private void Lhistory_DoubleClick(object sender, EventArgs e)
        {
              zzParticulars.d = Lhistory.SelectedItems[0].Text;
            zzParticulars par = new zzParticulars();
            par.ShowDialog();
        }
        void totalbalstudent()
        {
            try
            {
                cmd.CommandText = "select sum(totalbal) from balance where accno='" + id + "' and (yearlevel='" + yearlevel.Text + "' and schoolyear='" + sy + "') ";
                connection.Open();
                double totalbal = Convert.ToDouble(cmd.ExecuteScalar());
                bal.Text = totalbal.ToString("n");

            }
            catch
            {
                bal.Text = ttlschlfees.Text;
            }
            finally
            {
                connection.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void middlename_Click(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void firstname_Click(object sender, EventArgs e)
        {

        }

        private void section_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lastname_Click(object sender, EventArgs e)
        {

        }

        private void yearlevel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_MinimizeBttn_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ttlschlfees_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void bal_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Lfees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Lhistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Listview1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddotherPayment_Click(object sender, EventArgs e)
        {

        }

        private void priority_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void accno_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }

        private void saveRecord_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBoxchanges_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxenteramount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtotalpayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
                SearchStudent ne = new SearchStudent();
                ne.ShowDialog();
            
        }

        private void Payment_X_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();
            if (e.KeyCode == Keys.F9)
            {
                timer1_Tick(sender, e);
            }
        }

        private void toolStrip1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F9)
            {
                SearchStudent ne = new SearchStudent();
                ne.ShowDialog();
            }
        }


        //**************************************************************************************************
    }
}
