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
    public partial class StudentRecord : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        ListViewItem xitem;

        public static string schoolyear = "";

        public StudentRecord()
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

        void loadyearlevel()
        {
            toolstrpyearlevel.Items.Clear();
            cmd.CommandText = "select * from yearlevel";
            connection.Open();
            reader = cmd.ExecuteReader();
            toolstrpyearlevel.Items.Add("All");
            while (reader.Read())
            {
                toolstrpyearlevel.Items.Add(reader.GetValue(1).ToString());
            }
            toolstrpyearlevel.Items.Add("Other Record");
            // toolstrpyearlevel.SelectedIndex = 0;
            reader.Close();
            connection.Close();
            toolstrpyearlevel.SelectedIndex = 0;

        }

        private void StudentRecord_Load(object sender, EventArgs e)
        {
            loadyearlevel();
        }

        private void toolstrpyearlevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolstrpyearlevel.Text == "All")
            {
                Lstudent.Items.Clear();
                cmd.CommandText = "select accno, concat(lastname,' ',firstname,' ',middlename) from studentinformation order by lastname";
                connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem xxitem = Lstudent.Items.Add(reader.GetValue(0).ToString());
                    xxitem.SubItems.Add(reader.GetValue(1).ToString());
                }
                reader.Close();
                connection.Close();
            }
            else if (toolstrpyearlevel.Text == "Other Record")
            {
                Lstudent.Items.Clear();
                cmd.CommandText = "select accno, concat(lastname,' ',firstname,' ',middlename) from studentinformation where schoolyear!='" + MDIParent1.schoolyear + "'  order by lastname";
                connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem xxitem = Lstudent.Items.Add(reader.GetValue(0).ToString());
                    xxitem.SubItems.Add(reader.GetValue(1).ToString());
                }
                reader.Close();
                connection.Close();
            }
            else
            {
                Lstudent.Items.Clear();
                cmd.CommandText = "select accno, concat(lastname,' ',firstname,' ',middlename) from studentinformation where yearlevel='" + toolstrpyearlevel.Text + "' && schoolyear='" + MDIParent1.schoolyear + "' order by lastname";
                connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem xxitem = Lstudent.Items.Add(reader.GetValue(0).ToString());
                    xxitem.SubItems.Add(reader.GetValue(1).ToString());
                }
                reader.Close();
                connection.Close();
            }

        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (toolstrpyearlevel.Text == "All")
            {
                cmd.CommandText = "select accno,concat(lastname,' ',firstname,' ',middlename) from studentinformation where "
                    + " lastname LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%' or "
                    + "firstname LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%'  or "
                    + "middlename LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%' order by lastname";
                connection.Open();
                reader = cmd.ExecuteReader();
                Lstudent.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem xxitem = Lstudent.Items.Add(reader.GetValue(0).ToString());
                    xxitem.SubItems.Add(reader.GetValue(1).ToString());

                }

                reader.Close();
                connection.Close();
            }
            else
            {

                cmd.CommandText = "select accno,concat(lastname,' ',firstname,' ',middlename) from studentinformation where yearlevel='" + toolstrpyearlevel.Text + "' AND"
                  + " lastname LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%' or "
                  + "firstname LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%'  or "
                  + "middlename LIKE '" + toolStripTextBox2.Text.Replace("'", "''") + "%' order by lastname";
                connection.Open();
                reader = cmd.ExecuteReader();
                Lstudent.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem xxitem = Lstudent.Items.Add(reader.GetValue(0).ToString());
                    xxitem.SubItems.Add(reader.GetValue(1).ToString());

                }

                reader.Close();
                connection.Close();
            }
        }

        private void Lstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Name.Text = Lstudent.SelectedItems[0].Text;
            // accNo.Text = Lstudent.Items[0].Text;
            //   loadyearlevel1();
            // .loadrecords();
        }

        private void Lstudentrecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem l = Lstudent.Items.Insert(0, "kkk");
            l.SubItems.Add("saj");
        }

        void LoadstudentStudent()
        {
            cmd.CommandText = "select * from studentrecords where stu_id='" + Lstudent.SelectedItems[0].Text + "'";
            connection.Open();
            reader = cmd.ExecuteReader();



        }

        void LoadYearlevelandSchoolyear()
        {
            cmd.CommandText = "select  from studentrecords where stu_id='" + Lstudent.SelectedItems[0].Text + "'";
            connection.Open();
            reader = cmd.ExecuteReader();



        }

        private void toolStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Lstudent_DoubleClick(object sender, EventArgs e)
        {
            PYMNT.Enabled = PRNT.Enabled = true;
            Name.Text = Lstudent.Items[0].SubItems[1].Text;
            accNo.Text = Lstudent.Items[0].Text;
            ///loadyearlevel1();
            loadrecords();

        }

        private void toolStripYearlevel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripYearlevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "select * from studentrecords where Yearlevel='" + toolstrpyearlevel.Text
                    + "' and stu_id='" + accNo.Text + "'";
                connection.Open();
                reader = cmd.ExecuteReader();
                Lstudentrecord.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem it = Lstudentrecord.Items.Add(reader.GetValue(3).ToString());
                    it.SubItems.Add(reader.GetValue(4).ToString());
                    it.SubItems.Add(double.Parse(reader.GetValue(5).ToString()).ToString("n"));
                    it.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n"));
                    // toolStripYearlevel.Text = reader.GetValue(2).ToString();
                }
                reader.Read();

                reader.Close();
                connection.Close();

                double o = 0;
                double oo = 0;
                for (int i = 0; i < Lstudentrecord.Items.Count; i++)
                {
                    double p = double.Parse(Lstudentrecord.Items[i].SubItems[2].Text);
                    double pp = double.Parse(Lstudentrecord.Items[i].SubItems[3].Text);
                    oo = oo + pp;
                    o = o + p;


                }
                bal.Text = oo.ToString("n");
                total.Text = o.ToString("n");
            }
            catch
            {
                MessageBox.Show("No Students Records Found");

            }
        }



        void loadrecords()
        {

            cmd.CommandText = "select * from studentrecords where schoolyear='" + MDIParent1.schoolyear
                + "' and stu_id='" + Lstudent.SelectedItems[0].Text + "'";
            connection.Open();
            reader = cmd.ExecuteReader();
            Lstudentrecord.Items.Clear();
            while (reader.Read())
            {
                ListViewItem it = Lstudentrecord.Items.Add(reader.GetValue(3).ToString());
                it.SubItems.Add(reader.GetValue(4).ToString());
                it.SubItems.Add(double.Parse(reader.GetValue(5).ToString()).ToString("n"));
                it.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n"));
                toolStripYearlevel.Text = reader.GetValue(2).ToString();
            }
            reader.Read();

            reader.Close();
            connection.Close();

            double o = 0;
            double oo = 0;
            for (int i = 0; i < Lstudentrecord.Items.Count; i++)
            {
                double p = double.Parse(Lstudentrecord.Items[i].SubItems[2].Text);
                double pp = double.Parse(Lstudentrecord.Items[i].SubItems[3].Text);
                oo = oo + pp;
                o = o + p;


            }
            bal.Text = oo.ToString("n");
            total.Text = o.ToString("n");
        }
        void loadyearlevel1()
        {

            cmd.CommandText = "select * from yearlevel";
            connection.Open();
            reader = cmd.ExecuteReader();
            toolStripYearlevel.Items.Clear();
            while (reader.Read())
            {
                toolStripYearlevel.Items.Add(reader.GetValue(1).ToString());
            }

            reader.Close();
            connection.Close();
            toolStripYearlevel.SelectedIndex = 0;
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        } 

        private void pay_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "Select * from studentinformation where accno=" + accNo.Text;
            connection.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Payment.ln = reader.GetValue(3).ToString();
                Payment.mn = reader.GetValue(5).ToString();
                Payment.gndr = reader.GetValue(6).ToString();
                Payment.fn = reader.GetValue(4).ToString();
                Payment.sc = reader.GetValue(8).ToString();
                Payment.yl = reader.GetValue(7).ToString();
                Payment.id = reader.GetValue(1).ToString();
            }
            reader.Close();
            connection.Close();
            this.SendToBack();
            Payment.ok = true;
            
            MDIParent1 u = new MDIParent1();
           u.MainPanel.Controls.Clear();
            Payment payment = new Payment();
           // Payment.schoolyear = schoolyear;
            u.MainPanel.Controls.Add(payment);
            payment.Dock = DockStyle.Fill;
            payment.Show();
            
        }

        private void print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            cmd.CommandText = "select * from studentinformation where accno='" + accNo.Text + "'";
            connection.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            string accno = reader.GetValue(1).ToString();
            string sc = reader.GetValue(2).ToString();
            string lastname = reader.GetValue(3).ToString();
            string fname = reader.GetValue(4).ToString();
            string mi = reader.GetValue(5).ToString();
            string gender = reader.GetValue(6).ToString();
            string yl = reader.GetValue(7).ToString();
            string sec = reader.GetValue(8).ToString();
            reader.Close();
            connection.Close();



            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 375, 750, 375);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 90, 750, 90);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 93, 750, 93);

            string strDisplay = "BROOKES POINT CHRISTIAN HIGH SCHOOL";

            System.Drawing.Font fntString = new Font("Times New Roman", 15,
            FontStyle.Bold);
            e.Graphics.DrawString(strDisplay, fntString,
            Brushes.Black, 200, 100);

            strDisplay = "Brookes Point Palawan";
            fntString = new System.Drawing.Font("Times New Roman", 15,
            FontStyle.Regular);

            e.Graphics.DrawString(strDisplay, fntString,
            Brushes.Black, 320, 120);

            e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 150, 750, 150);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 153, 750, 153);


            strDisplay = "STATEMENT OF ACCOUNT";
            fntString = new System.Drawing.Font("Times New Roman", 15,
            FontStyle.Bold);
            e.Graphics.DrawString(strDisplay, fntString,
            Brushes.Black, 250, 170);

            fntString = new System.Drawing.Font("Times New Roman", 12,
            FontStyle.Bold);
            e.Graphics.DrawString("Account No. ", fntString,
            Brushes.Black, 100, 230);
            fntString = new System.Drawing.Font("Times New Roman", 12,
            FontStyle.Regular);
            e.Graphics.DrawString(accno, fntString,
            Brushes.Black, 190, 230);
            //e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 240, 380, 240);

            fntString = new System.Drawing.Font("Times New Roman", 12,
            FontStyle.Bold);
            e.Graphics.DrawString("Date ", fntString,
            Brushes.Black, 500, 230);
            fntString = new System.Drawing.Font("Times New Roman", 12,
            FontStyle.Regular);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fntString,
            Brushes.Black, 560, 230);
            // e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 240, 720, 240);

            //name
            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Name      ", fntString,
            Brushes.Black, 100, 280);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(lastname + ", " + fname+ " " + mi + " ", fntString,
            Brushes.Black, 180, 280);


            //yearlevel
            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Year Level ", fntString,
            Brushes.Black, 100, 310);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(yl, fntString,
            Brushes.Black, 190, 310);

            // gender
            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Gender    ", fntString,
            Brushes.Black, 100, 330);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(gender, fntString,
            Brushes.Black, 190, 330);

            //schoolyear
            fntString = new System.Drawing.Font("Times New Roman", 12,
           FontStyle.Bold);
            e.Graphics.DrawString("School Year ", fntString,
            Brushes.Black, 500, 310);
            fntString = new System.Drawing.Font("Times New Roman", 12,
            FontStyle.Regular);
            e.Graphics.DrawString(sc, fntString,
            Brushes.Black, 600, 310);

            //section
            fntString = new System.Drawing.Font("Times New Roman", 12,
           FontStyle.Bold);
            e.Graphics.DrawString("Section     ", fntString,
            Brushes.Black, 500, 330);
            fntString = new System.Drawing.Font("Times New Roman", 12,
            FontStyle.Regular);
            e.Graphics.DrawString(sec, fntString,
            Brushes.Black, 600, 330);

            //********************************************************

            fntString = new System.Drawing.Font("Times New Roman", 12,
          FontStyle.Bold);                                   //
            e.Graphics.DrawString("                          Particular                       Amount                       Balance ", fntString,
            Brushes.Black, 100, 380);

            int r = 420;
            for (int u = 0; u < Lstudentrecord.Items.Count; u++)
            {
               
                fntString = new System.Drawing.Font("Times New Roman", 12,
                   FontStyle.Regular);
                e.Graphics.DrawString(Lstudentrecord.Items[u].SubItems[1].Text + "\n", fntString,
                Brushes.Black, 230, r);

                fntString = new System.Drawing.Font("Times New Roman", 12,
       FontStyle.Regular);
                e.Graphics.DrawString(Lstudentrecord.Items[u].SubItems[2].Text + "\n", fntString,
                Brushes.Black, 390, r);

                fntString = new System.Drawing.Font("Times New Roman", 12,
       FontStyle.Regular);
                e.Graphics.DrawString(Lstudentrecord.Items[u].SubItems[3].Text + "\n", fntString,
                Brushes.Black, 550, r);

                r = r + 30;
            }

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, r, 750, r);

            fntString = new System.Drawing.Font("Times New Roman", 12,
                    FontStyle.Bold);
            e.Graphics.DrawString("Total", fntString,
            Brushes.Black, 230, r + 10);

            fntString = new System.Drawing.Font("Times New Roman", 12,
            FontStyle.Bold);

            e.Graphics.DrawString(total.Text, fntString,
            Brushes.Black, 390, r + 10);
 

            fntString = new System.Drawing.Font("Times New Roman", 12,
            FontStyle.Bold);
            e.Graphics.DrawString(bal.Text, fntString,
            Brushes.Black, 550, r + 10);
            r = r + 30;

            //*******************************cahier name
            fntString = new System.Drawing.Font("Times New Roman", 12);
       
            e.Graphics.DrawString(MDIParent1.name, fntString,
            Brushes.Black, 570, 920);

            fntString = new System.Drawing.Font("Times New Roman", 12,
          FontStyle.Bold);
            e.Graphics.DrawString("Cashier", fntString,
            Brushes.Black, 600, 950);
        }
          
         
    }
}
