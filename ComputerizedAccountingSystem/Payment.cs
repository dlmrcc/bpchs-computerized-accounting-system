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
    public partial class Payment : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        double totalpayent = 0;
       // ListViewItem itemxx;

         public static string schoolyear = "";

        public Payment()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        public static string id;
        public static string ln;
        public static string fn;
        public static string mn;
        public static string yl;
        public static string sc;
        public static string gndr;
        public static bool ok;

        //string schoolyear="2012-2013";

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Lhistory.Items.Clear();
                cmd.CommandText = "select * from stupaymenthist where accno='" + accno.Text + "' order by ph_id asc";
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
                loadpaymenthist();
            }

        }
        private void toolsearch_Click(object sender, EventArgs e)
        {
            textBoxenteramount.Text = "";
            SearchStudent searcstu = new SearchStudent();
            searcstu.ShowDialog();
            if (ok)
            {
                accno.Text = id;
                lastname.Text = ln;
                firstname.Text = fn;
                middlename.Text = mn;
                yearlevel.Text = yl;
                section.Text = sc;
                gender.Text = gndr;
                comboBox1.Text = "Cash";
                //8***************************
                saveRecord.Enabled =
                    AddotherPayment.Visible =
                    checkBox1.Enabled =
                    Cancel.Enabled =
                    textBoxenteramount.Enabled =
                    textBoxtotalpayment.Enabled =
                    textBoxchanges.Enabled = true;

                loadfees();
                Loadsubfees();
                //totalBalance();

              //  toolStrip1.Enabled = false;
                loadRecords();
                loadbalance();
                loadpaymenthist();

                //********************
                saveRecord.Enabled = false;


                ok = false;
            }
        }

        void loadfees()
        {
            Lfees.Items.Clear();
            cmd.CommandText = "Select Fees_id,feesname,amount,feestype from schoolfees where (yearlevel='" + yearlevel.Text + "' && schoolyear='" + schoolyear + "') and amount!=0";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(3).ToString() == "w_sub")//|| reader.GetValue(3).ToString() == "")
                {
                    ListViewItem itemx = Lfees.Items.Add(reader.GetValue(0).ToString());
                    itemx.SubItems.Add(reader.GetValue(1).ToString());
                    itemx.SubItems.Add("");
                    itemx.SubItems.Add("");
                    itemx.SubItems.Add("");
                    itemx.SubItems.Add(reader.GetValue(3).ToString());

                    //*****************************************************

                    // ListViewItem itemxxx = Listview1.Items.Add(reader.GetValue(0).ToString());
                  //  itemxxx.SubItems.Add(reader.GetValue(1).ToString());
                   // itemxxx.SubItems.Add(Double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                  //  itemxx.SubItems.Add(Double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    // itemxx.SubItems.Add("");
                    //itemxx.SubItems.Add(reader.GetValue(3).ToString());
                }
                else
                {
                    ListViewItem itemx = Lfees.Items.Add(reader.GetValue(0).ToString());
                    itemx.SubItems.Add(reader.GetValue(1).ToString());
                    itemx.SubItems.Add("");
                    itemx.SubItems.Add(Double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    itemx.SubItems.Add(Double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    itemx.SubItems.Add(reader.GetValue(3).ToString());

                    //**********************************************************
                   // ListViewItem itemxx;
                    // itemxx = Listview1.Items.Add(reader.GetValue(0).ToString());
                   // itemxx.SubItems.Add(reader.GetValue(1).ToString());
                    // itemxx.SubItems.Add(Double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    // itemxx.SubItems.Add(Double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                     //itemxx.SubItems.Add("");
                     //itemxx.SubItems.Add(reader.GetValue(3).ToString());
                }
            }
            reader.Close();
            connection.Close();
        }
        void Loadsubfees()
        {
            
            for (int y = 0; y < Lfees.Items.Count; y++)
            {
                if (Lfees.Items[y].SubItems[5].Text == "w_sub")
                {
                    cmd.CommandText = "Select fees_id,subfeesname,amount from subfees where fees_id=" + Lfees.Items[y].Text + " and amount !=0 order by subfees";
                    connection.Open();
                    reader = cmd.ExecuteReader();
                    int t = 1;
                    while (reader.Read())
                    {
                        ListViewItem items = Lfees.Items.Insert(t + y++, reader.GetValue(0).ToString());
                        items.SubItems.Add("");
                        items.SubItems.Add(reader.GetValue(1).ToString());
                        items.SubItems.Add(Double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                        items.SubItems.Add(Double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    }
                    reader.Close();
                    connection.Close();

                }

            }
        }
        void loadRecords()
        {
            connection.Open();
            cmd.CommandText = "select * from studentRecords where stu_id='" + id + "' and yearlevel='" + yl + "'";
            reader = cmd.ExecuteReader();
            Listview1.Items.Clear();
            while (reader.Read())
            {
                 ListViewItem itemxx = Listview1.Items.Add(reader.GetValue(3).ToString());
                    itemxx.SubItems.Add(reader.GetValue(4).ToString());
                    itemxx.SubItems.Add(double.Parse(reader.GetValue(5).ToString()).ToString("n"));
                    itemxx.SubItems.Add(double.Parse(reader.GetValue(6).ToString()).ToString("n"));
                    itemxx.SubItems.Add("");


                    for (int g = 0; g < Listview1.Items.Count; g++)
                    {
                        if (Listview1.Items[g].SubItems[3].Text == "0.00")
                        {
                            Listview1.Items[g].SubItems[3].Text = "-";
                        }
                    }
            }
            reader.Close();
            connection.Close();

        }
        void loadbalance()
        {
            connection.Open();
            cmd.CommandText = "select * from totalbalanceandtotalamountpaidandtotalaschoolfees where accno='" + id + "' and schoolyear='" + schoolyear + "'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                double totalsclfs = Convert.ToDouble(reader.GetValue(3).ToString());
                double baln = Convert.ToDouble(reader.GetValue(2).ToString());
                ttlschlfees.Text = totalsclfs.ToString("n");
                bal.Text = baln.ToString("n");
            }
            reader.Close();
            connection.Close();
        }
   
        void loadpaymenthist()
        {
            Lhistory.Items.Clear();
            cmd.CommandText = "select * from stupaymenthist where schoolyear='" + MDIParent1.schoolyear + "' and accno='" + accno.Text + "' order by ph_id asc";
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

        void updateSaveRecord()
        {
            
            for (int i = 0; i < Listview1.Items.Count; i++)
            {
                try
                {
                    cmd.CommandText = "update  studentrecords set balance=" + double.Parse(Listview1.Items[i].SubItems[3].Text.Replace('-', '0')) + " where (schoolyear='" + schoolyear + "' and yearlevel='" + yearlevel.Text + "') and (stu_id='" + accno.Text + "' and fees_id='" + int.Parse(Listview1.Items[i].Text) + "')";
                    //  cmd.CommandText = "Insert into studentrecords values('" + AccountNo.Text + "','" + schoolyear + "','" + yearlevel.Text + "','" + Listview1.Items[i].SubItems[0].Text + "','" + Listview1.Items[i].SubItems[1].Text + "'," + double.Parse(Listview1.Items[i].SubItems[2].Text) + "," + double.Parse(Listview1.Items[i].SubItems[3].Text.Replace('-', '0')) + ")";
                    connection.Open();
                    // cmd.CommandText = "insert into studentrecords values ('" + AccountNo.Text + "','" + schoolyear + "','" + yearlevel.Text + "')";//,'" + Listview1.Items[i].SubItems[0].Text + "','" + Listview1.Items[i].SubItems[1].Text+"',"+ Listview1.Items[i].SubItems[2].Text + ")";//" + Listview1.Items[i].SubItems[3].Text.Replace('-', '0') + ")";
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        void updatebalance()
        {  
            double ttlpaid = Convert.ToDouble(textBoxtotalpayment.Text);
            connection.Open();
            cmd.CommandText = "update totalbalanceandtotalamountpaidandtotalaschoolfees set totalbalance=" + double.Parse(bal.Text) + " where schoolyear='" + schoolyear + "' and accno='" + accno.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        void StudentPaymentHist()
        {
            double ttlpaid = Convert.ToDouble(textBoxtotalpayment.Text);
            cmd.CommandText = "insert into stupaymenthist values(0,'" + accno.Text + "','" + schoolyear + "','" + DateTime.Now.ToShortDateString() + "','" + MDIParent1.name + "'," + ttlpaid + ",'" + comboBox1.Text + "')";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
//*********************************************************************************************************************************************
      
        //*******************************************************************************************************************************************

        private void saveRecord_Click(object sender, EventArgs e)
        {
            if (saveRecord.Text == "Pay")
            {
                if (textBoxenteramount.Text == "")
                {
                    
                           saveRecord.Text = "Save";                   
                }
                else
                {
                   
                    double amountpaid = Convert.ToDouble(textBoxenteramount.Text);
                    for (int t = 0; t < Listview1.Items.Count; t++)
                    {
                        if (Listview1.Items[t].SubItems[3].Text!="-")
                        {
                            if (amountpaid >= double.Parse(Listview1.Items[t].SubItems[3].Text))
                            {
                                Listview1.Items[t].SubItems[4].Text = double.Parse(Listview1.Items[t].SubItems[3].Text).ToString("n");
                                amountpaid = amountpaid - Convert.ToDouble(Listview1.Items[t].SubItems[3].Text);
                                Listview1.Items[t].SubItems[3].Text = "-";
                            }
                            else if (amountpaid <= double.Parse(Listview1.Items[t].SubItems[3].Text))
                             {
                                 double r = Convert.ToDouble(Listview1.Items[t].SubItems[3].Text);
                                Listview1.Items[t].SubItems[4].Text = amountpaid.ToString("n");
                                Listview1.Items[t].SubItems[3].Text = ((r - amountpaid).ToString("n"));
                                // dataGridView2.Rows[t].Cells[3].Value = (Convert.ToDouble(dataGridView2.Rows[t].Cells[2].Value) - amountpaid).ToString();
                                break;
                            }
                        }
                    }
                    textBoxtotalpayment.Text = (Convert.ToDouble(textBoxtotalpayment.Text) + Convert.ToDouble(textBoxenteramount.Text)).ToString("n");
                    bal.Text = (Convert.ToDouble(bal.Text) - Convert.ToDouble(textBoxtotalpayment.Text)).ToString("n");
                    textBoxenteramount.Text = "";
                    textBoxenteramount.Focus();
                    saveRecord.Text = "Save";
                    Cancel.Text = "*Back";
                    saveRecord.Enabled = true; 
                }
            }
            else if (saveRecord.Text.Equals("Save"))
            {
                if (textBoxtotalpayment.Text == "00.00")
                {
                    //SaveRecord();
                   // savetotalbalance();
                    DialogResult o = MessageBox.Show("Succesfully saved.", "Student Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //enabledALL();
                }
                else
                {
                    updateSaveRecord();
                    updatebalance();
                    StudentPaymentHist();
                    particularREc();
                    loadRecords();
                    StudentPaymentHist();
                    saveRecord.Text = "Pay";
                    saveRecord.Enabled = false;
                    Cancel.Text = "Cancel";
                    printss();
                   
                   // SaveRecord();
                    //savetotalbalance();
                    // PaymentHist();
                    // PaymentHist();
                   // StudentPaymentHist();
                   // particularREc();
                  //  printss();
                }
            }
        }
 
        private void textBoxenteramount_TextChanged(object sender, EventArgs e)
        {
           // textBoxenteramount.SelectionStart = textBoxenteramount.Text.Length;
           // textBoxenteramount.Text = textBoxenteramount.Text + textBoxenteramount.Text;
           // textBoxenteramount.Text = double.Parse(textBoxenteramount.Text).ToString("n");
           // textBoxenteramount.SelectionStart = textBoxenteramount.Text.Length;

            if (priority.Checked == true)
            {
                if (saveRecord.Text == "Pay")
                {
                    if (textBoxenteramount.Text == "")
                    {
                          toolsearch.Enabled = true;
                    }
                    else if (saveRecord.Text == "Save" || textBoxenteramount.Text != "")
                    {
                      toolsearch.Enabled = false;
                    }
                    try
                    {

                        if (Convert.ToDouble(textBoxenteramount.Text) > Convert.ToDouble(bal.Text))
                        {
                            textBoxenteramount.Text = Convert.ToDouble(bal.Text).ToString();
                            textBoxenteramount.SelectionStart = textBoxenteramount.Text.Length;
                        }
                    }
                    catch { }


                    if ((textBoxenteramount.Text != "" && textBoxenteramount.Text != "0") || double.Parse(textBoxtotalpayment.Text)!=0)
                    {
                        saveRecord.Enabled = true;
                    }
                    else if (textBoxenteramount.Text == "" || textBoxenteramount.Text == "0")
                    {
                        saveRecord.Enabled = false;
                        textBoxenteramount.Text = "";
                         
                    }
                    Cancel.Text = "Clear(*)";
                }
                else
                {
                    saveRecord.Enabled = true;
                    try
                    {
                        if (Convert.ToDouble(textBoxenteramount.Text) > Convert.ToDouble(textBoxtotalpayment.Text))
                        {
                            textBoxchanges.Text = (Convert.ToDouble(textBoxenteramount.Text) - Convert.ToDouble(textBoxtotalpayment.Text)).ToString("n");
                        }
                        else if (Convert.ToDouble(textBoxenteramount.Text) < Convert.ToDouble(textBoxtotalpayment.Text))
                        {
                            textBoxchanges.Text = "";
                        }
                    }
                    catch { }
                }

            } 
        }

        private void Lhistory_DoubleClick(object sender, EventArgs e)
        {
            zzParticulars.d = Lhistory.SelectedItems[0].Text;
            zzParticulars par = new zzParticulars();
            par.ShowDialog();

        }

        private void textBoxtotalpayment_TextChanged(object sender, EventArgs e)
        {
            saveRecord.Enabled = true;
        }

        private void AddotherPayment_Click(object sender, EventArgs e)
        {

            Studentotherpayment stuad = new Studentotherpayment();
            stuad.ShowDialog();
            if (Studentotherpayment.s)
            {
                Studentotherpayment.s = false;
                ListViewItem i = Listview1.Items.Add("");
                i.SubItems.Add(Studentotherpayment.descrp);
                i.SubItems.Add(Studentotherpayment.amounts);
                i.SubItems.Add("");
                i.SubItems.Add(Studentotherpayment.amounts);

            }
            double n = double.Parse(textBoxtotalpayment.Text);
            double ee = double.Parse(Studentotherpayment.amounts);
            textBoxtotalpayment.Text = (ee + n).ToString("n");
        }

        private void textBoxenteramount_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBoxenteramount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (saveRecord.Text == "Pay")
            {
                if (textBoxenteramount.Text == "")
                {
                    if (e.KeyChar == '0')
                    {
                        e.Handled = true;
                    }
                }
                if (bal.Text == "0.00")
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar >= 32 && e.KeyChar <= 47 ||
                 e.KeyChar >= 58 && e.KeyChar <= 126)
                e.Handled = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (saveRecord.Text == "Pay")
            {
                if (textBoxenteramount.Text == "")
                {
                    DialogResult o = MessageBox.Show("Do you want to cancel?", "Student Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (o == DialogResult.Yes)
                    {
                        //SaveRecord();
                        //savetotalbalance();
                        //enabledALL();
                    }
                }
                else if (Cancel.Text == "Clear(*)")
                {
                    textBoxenteramount.Text = "";
                    Cancel.Text = "Cancel";
                }
            }
            else if (saveRecord.Text == "Save")
            {
                textBoxchanges.Text = "";
                textBoxenteramount.Text = textBoxtotalpayment.Text;
                bal.Text = (double.Parse(bal.Text) + double.Parse(textBoxtotalpayment.Text)).ToString("n");
                textBoxtotalpayment.Text = "0.00";
                Cancel.Text = "Clear(*)";
                saveRecord.Text = "Pay";
                saveRecord.Enabled = true;
                toolsearch.Enabled = true;
               // toolother.Enabled = true;
                bal.Text = (double.Parse(bal.Text) + double.Parse(textBoxtotalpayment.Text)).ToString("n");
                for (int y = 0; y < Listview1.Items.Count; y++)
                {
                    if (Listview1.Items[y].SubItems[3].Text == "-" && Listview1.Items[y].SubItems[4].Text != "")
                    {
                        Listview1.Items[y].SubItems[3].Text = Listview1.Items[y].SubItems[4].Text;
                    }
                    else
                    {
                        try
                        {
                            double i = double.Parse(Listview1.Items[y].SubItems[3].Text) + double.Parse(Listview1.Items[y].SubItems[4].Text);
                            Listview1.Items[y].SubItems[3].Text = i.ToString("n");
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }
        //*****************************************************************************************************************************
        //*****************************************************************************************
        int nextsubID = 0;
        string recNumber = "";
        string wor_amount = "";
        int recNo = 0;

        string number = "";
        string word = "";
        int s = 0;
        string textBox4 = "";

        void particularREc()
        {
            cmd.CommandText = "select PH_id from stupaymenthist order by PH_id desc limit 1";
            connection.Open();
            nextsubID = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            int p = 0;
            for (int o = 0; o < Listview1.Items.Count; o++)
            {

                if (o == 0 || p == 8)
                {
                    cmd.CommandText = "insert into Studentreciept values(0,'" + accno.Text + "','" + schoolyear + "','"
                        + "-',0,'" + MDIParent1.name + "','-','" + DateTime.Now.ToShortDateString() + "','Pending'," + nextsubID + ")";
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    if (Listview1.Items[o].SubItems[4].Text != "")
                    {
                        cmd.CommandText = "select rcpt_id from studentreciept order by rcpt_id desc limit 1";
                        connection.Open();
                        int nextsubIDs = Convert.ToInt32(cmd.ExecuteScalar());
                        connection.Close();


                        cmd.CommandText = "insert into particularreciept values(0,'" + Listview1.Items[o].SubItems[1].Text + "'," + double.Parse(Listview1.Items[o].SubItems[4].Text) + "," + nextsubID + "," + nextsubIDs + ")";
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        p = p + 1;

                    }
                }
                else
                {
                    if (Listview1.Items[o].SubItems[4].Text != "")
                    {
                        cmd.CommandText = "select rcpt_id from studentreciept order by rcpt_id desc limit 1";
                        connection.Open();
                        int nextsubIDs = Convert.ToInt32(cmd.ExecuteScalar());
                        connection.Close();


                        cmd.CommandText = "insert into particularreciept values(0,'" + Listview1.Items[o].SubItems[1].Text + "'," + double.Parse(Listview1.Items[o].SubItems[4].Text) + "," + nextsubID + "," + nextsubIDs + ")";
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        p = p + 1;
                    }

                }
            }

        }

        private void PrintRec_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 260;
            int startY = 200;
            int OffsetS = 40;

            //***************************************
            //****************************************8

            //*************************REcept number***********
            cmd.CommandText = "select rcpt_id from studentreciept where process !='pending' order by rcpt_id desc limit 1";
            connection.Open();
            int d = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            recNumber = (d).ToString("d10");

            startX = 300;
            startY = 200;
            graphics.DrawString("R.N:" + recNumber, new Font("Courier New", 10),
            new SolidBrush(Color.Black), 400, 180);
           

            //*************************************************

            ////////***********************date
            ////////***********************date
            startX = 260;
            startY = 200;
            int Offset = 40;
            graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Courier New", 10),
            new SolidBrush(Color.Black), 390, 212);
            //***************************************************

            //***********name
            string lname = lastname.Text;
            string fname = firstname.Text;
            string mi = "";
            try
            {
                mi = middlename.Text.Substring(1, 1).ToUpper();
            }
            catch
            {
            }

            startX = 260;
            startY = 200;

            graphics.DrawString(lname + ", " + fname + " " + mi, new Font("Courier New", 12),
            new SolidBrush(Color.Black), 270, 265);
            


            //*******************************end name

            cmd.CommandText = "select rcpt_id from studentreciept where process='pending' && HIST_Id=" + nextsubID + " order by rcpt_id asc limit 1";
            connection.Open();
            recNo = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            cmd.CommandText = "select  hist_id from studentreciept where process='pending' && HIST_Id=" + nextsubID + " order by rcpt_id asc limit 1";
            connection.Open();
            int recNos = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            cmd.CommandText = "select count(particular) from particularreciept where recpt_id=" + recNo; ;
            connection.Open();
            int zz = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            //**************particular and amount

            for (int nn = 0; nn <= zz; nn++)
            {

                cmd.CommandText = "select * from particularreciept where recpt_id=" + recNo + " order by Pr_id";
                connection.Open();
                reader = cmd.ExecuteReader();

                int UU = 15;
                while (reader.Read())
                {

                    startX = 220;
                    startY = 315;
                    graphics.DrawString(reader.GetValue(1).ToString(), new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + UU);


                    startX = 480;
                    startY = 315;
                    graphics.DrawString(double.Parse(reader.GetValue(2).ToString()).ToString("n"), new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + UU);
                    UU = UU + 20;

                }
                reader.Close();
                connection.Close();
                //********************************

                //**************amount
                cmd.CommandText = "select sum(amount) from particularreciept where recpt_id=" + recNo; ;
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                string totalamount = reader.GetValue(0).ToString();
                reader.Close();
                connection.Close();



                startX = 500;
                startY = 400;              //500//
                graphics.DrawString(double.Parse(totalamount).ToString("n"), new Font("Courier New", 9),
                new SolidBrush(Color.Black), 490, 510);
                UU = UU + 20;
                //******************end amount

                //***converttoamount

                number = totalamount.ToString();
                if (number.Length == 6)//780,454
                {
                    s = 0;
                    hundred();
                    s = s + 1;
                    teens();
                    s = s + 1;

                    word = word + "Thousand ";
                    s = 3;
                    hundred();
                    s = s + 1;
                    teens();
                    // s = 5;


                    textBox4 = word;
                    word = "";
                }
                else if (number.Length == 5)//12,303
                {
                    s = 0;
                    tenthousand();
                    word = word + "Thousand ";
                    s = 2;
                    hundred();
                    s = s + 1;
                    teens();
                    // s = s + 1;
                    //ones();
                    textBox4 = word;
                    word = "";
                }
                else if (number.Length == 4)//1,123
                {
                    s = 0;
                    thousand();
                    s = s + 1;
                    hundred();
                    s = s + 1;
                    teens();
                    // s = 3;
                    //ones();
                    textBox4 = word;
                    word = "";
                }
                else if (number.Length == 3)//900,
                {
                    s = 0;
                    hundred();
                    s = s + 1;
                    teens();
                    // s =2;
                    // ones();
                    textBox4 = word;
                    word = "";
                }
                else if (number.Length == 2)//78
                {
                    s = 0;
                    teens();
                    textBox4 = word;
                    word = "";
                }
                else if (number.Length == 1)
                {

                    s = 0;
                    ones();
                    textBox4 = word;
                    word = "";
                }
                wor_amount = textBox4 + " Pesos only.";
                startX = 200;
                startY = 300;
                // string word1 = textBox4.Substring(0, 25);
                try
                {
                    graphics.DrawString(textBox4.Substring(0, 27), new Font("Courier New", 10),
                  new SolidBrush(Color.Black), 350, 540);

                    graphics.DrawString(textBox4.Substring(27) + " Pesos only.", new Font("Courier New", 10),
                    new SolidBrush(Color.Black), 225, 560);
                    UU = UU + 20;
                }
                catch
                {
                    graphics.DrawString(textBox4 + " Pesos only.", new Font("Courier New", 10),
                    new SolidBrush(Color.Black), 350, 540);
                }

            }
            //********************cashier name
            startX = 300;
            startY = 600;

            graphics.DrawString(MDIParent1.name, new Font("Courier New", 10),
                 new SolidBrush(Color.Black), 370, 700);
            //**********************************
        }

        void update()
        {
            cmd.CommandText = "update studentreciept set recieptNo='" + recNumber + "',process='Printed', wordamount='" + wor_amount + "' where rcpt_id=" + recNo;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        void printss()
        {
            cmd.CommandText = "select Count(rcpt_id) from studentreciept where hist_id=" + nextsubID;
            connection.Open();
            int kk = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            for (int xx = 0; xx < kk; xx++)
            {
                try
                {
                    printDialog1.Document = PrintRec;
                    PrintRec.Print();
                    update();
                }
                catch
                {
                    printDialog1.Document = PrintRec;
                    printDialog1.ShowDialog();
                    PrintRec.Print();

                    update();
                }
            }
           // enabledALL();
        }

        //88888888888888888888888888888888888888888888888

        void tenthousand()
        {
            if (number.Substring(s, 2).ToString() == "10")
            {
                word = word + "Ten ";

            }
            else if (number.Substring(s, 2).ToString() == "11")
            {
                word = word + "Eleven ";

            }
            else if (number.Substring(s, 2).ToString() == "12")
            {
                word = word + "Twelve ";

            }
            else if (number.Substring(s, 2).ToString() == "13")
            {
                word = word + "Thirteen ";

            }
            else if (number.Substring(s, 2).ToString() == "14")
            {
                word = word + "Fourteen ";

            }
            else if (number.Substring(s, 2).ToString() == "15")
            {
                word = word + "Fifthteen ";

            }
            else if (number.Substring(s, 2).ToString() == "16")
            {
                word = word + "Sixteen ";

            }
            else if (number.Substring(s, 2).ToString() == "17")
            {
                word = word + "Seventeen ";

            }
            else if (number.Substring(s, 2).ToString() == "18")
            {
                word = word + "Eigthteen ";

            }
            else if (number.Substring(s, 2).ToString() == "19")
            {
                word = word + "Nineteen ";

            }
            else if (number.Substring(s, 1).ToString() == "2")
            {
                word = word + "Twenty ";
                s = s + 1;
                ones();

            }
            else if (number.Substring(s, 1).ToString() == "3")
            {
                word = word + "Thirty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "4")
            {
                word = word + "Fourty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "5")
            {
                word = word + "Fifty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "6")
            {
                word = word + "Sixty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "7")
            {
                word = word + "Seventy ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "8")
            {
                word = word + "Eighty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "9")
            {
                word = word + "Ninety ";
                s = s + 1;
                ones();
            }
        }
        void teensthousand()
        {
            if (number.Substring(s, 2).ToString() == "10")
            {
                word = word + "Ten ";
                s = s + 1;

            }
            else if (number.Substring(s, 2).ToString() == "11")
            {
                word = word + "Eleven ";
                s = s + 1;
            }
            else if (number.Substring(s, 2).ToString() == "12")
            {
                word = word + "Twelve ";
                s = s + 1;
            }
            else if (number.Substring(s, 2).ToString() == "13")
            {
                word = word + "Thirteen ";
                s = s + 1;
            }
            else if (number.Substring(s, 2).ToString() == "14")
            {
                word = word + "Fourteen ";
                s = s + 1;
            }
            else if (number.Substring(s, 2).ToString() == "15")
            {
                word = word + "Fifthteen ";
                s = s + 1;
            }
            else if (number.Substring(s, 2).ToString() == "16")
            {
                word = word + "Sixteen ";
                s = s + 1;
            }
            else if (number.Substring(s, 2).ToString() == "17")
            {
                word = word + "Seventeen ";
                s = s + 1;
            }
            else if (number.Substring(s, 2).ToString() == "18")
            {
                word = word + "Eigthteen ";
                s = s + 1;
            }
            else if (number.Substring(s, 2).ToString() == "19")
            {
                word = word + "Nineteen ";
                s = s + 1;
            }
            else if (number.Substring(s, 1).ToString() == "2")
            {
                word = word + "Twenty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "3")
            {
                word = word + "Thirty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "4")
            {
                word = word + "Fourty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "5")
            {
                word = word + "Fifty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "6")
            {
                word = word + "Sixty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "7")
            {
                word = word + "Seventy ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "8")
            {
                word = word + "Eighty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "9")
            {
                word = word + "Ninety ";
                s = s + 1;
                ones();
            }
        }
        void thousand()
        {
            if (number.Substring(s, 1).ToString() == "1")
            {
                word = word + "One Thousand ";
            }
            else if (number.Substring(s, 1).ToString() == "2")
            {
                word = word + "Two Thousand ";
            }
            else if (number.Substring(s, 1).ToString() == "3")
            {
                word = word + "Three Thousand ";
            }
            else if (number.Substring(s, 1).ToString() == "4")
            {
                word = word + "Four Thousand ";
            }
            else if (number.Substring(s, 1).ToString() == "5")
            {
                word = word + "Five Thousand ";
            }
            else if (number.Substring(s, 1).ToString() == "6")
            {
                word = word + "Six Thousand ";
            }
            else if (number.Substring(s, 1).ToString() == "7")
            {
                word = word + "Seven Thousand ";
            }
            else if (number.Substring(s, 1).ToString() == "8")
            {
                word = word + "Eight Thousand ";
            }
            else if (number.Substring(s, 1).ToString() == "9")
            {
                word = word + "Nine Thousand ";
            }

        }
        void hundred()
        {
            if (number.Substring(s, 1).ToString() == "1")
            {
                word = word + "One Hundred ";
            }
            else if (number.Substring(s, 1).ToString() == "2")
            {
                word = word + "Two Hundred ";
            }
            else if (number.Substring(s, 1).ToString() == "3")
            {
                word = word + "Three Hundred ";
            }
            else if (number.Substring(s, 1).ToString() == "4")
            {
                word = word + "Four Hundred ";
            }
            else if (number.Substring(s, 1).ToString() == "5")
            {
                word = word + "Five Hundred ";
            }
            else if (number.Substring(s, 1).ToString() == "6")
            {
                word = word + "Six Hundred ";
            }
            else if (number.Substring(s, 1).ToString() == "7")
            {
                word = word + "Seven Hundred ";
            }
            else if (number.Substring(s, 1).ToString() == "8")
            {
                word = word + "Eight Hundred ";
            }
            else if (number.Substring(s, 1).ToString() == "9")
            {
                word = word + "Nine Hundred ";
            }

        }
        void teens()
        {
            if (number.Substring(s, 2).ToString() == "10")
            {
                word = word + "Ten ";


            }
            else if (number.Substring(s, 2).ToString() == "11")
            {
                word = word + "Eleven ";

            }
            else if (number.Substring(s, 2).ToString() == "12")
            {
                word = word + "Twelve ";

            }
            else if (number.Substring(s, 2).ToString() == "13")
            {
                word = word + "Thirteen ";

            }
            else if (number.Substring(s, 2).ToString() == "14")
            {
                word = word + "Fourteen ";

            }
            else if (number.Substring(s, 2).ToString() == "15")
            {
                word = word + "Fifthteen ";

            }
            else if (number.Substring(s, 2).ToString() == "16")
            {
                word = word + "Sixteen ";

            }
            else if (number.Substring(s, 2).ToString() == "17")
            {
                word = word + "Seventeen ";

            }
            else if (number.Substring(s, 2).ToString() == "18")
            {
                word = word + "Eigthteen ";

            }
            else if (number.Substring(s, 2).ToString() == "19")
            {
                word = word + "Nineteen ";

            }
            else if (number.Substring(s, 1).ToString() == "2")
            {
                word = word + "Twenty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "3")
            {
                word = word + "Thirty ";
                s = 2;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "4")
            {
                word = word + "Fourty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "5")
            {
                word = word + "Fifty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "6")
            {
                word = word + "Sixty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "7")
            {
                word = word + "Seventy ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "8")
            {
                word = word + "Eighty ";
                s = s + 1;
                ones();
            }
            else if (number.Substring(s, 1).ToString() == "9")
            {
                word = word + "Ninety ";
                s = s + 1;
                ones();
            }
            else
            {
                s = s + 1;
                ones();
            }
        }
        void ones()
        {
            if (number.Substring(s, 1).ToString() == "1")
            {
                word = word + "One ";
            }
            else if (number.Substring(s, 1).ToString() == "2")
            {
                word = word + "Two ";
            }
            else if (number.Substring(s, 1).ToString() == "3")
            {
                word = word + "Three ";
            }
            else if (number.Substring(s, 1).ToString() == "4")
            {
                word = word + "Four ";
            }
            else if (number.Substring(s, 1).ToString() == "5")
            {
                word = word + "Five ";
            }
            else if (number.Substring(s, 1).ToString() == "6")
            {
                word = word + "Six ";
            }
            else if (number.Substring(s, 1).ToString() == "7")
            {
                word = word + "Seven ";
            }
            else if (number.Substring(s, 1).ToString() == "8")
            {
                word = word + "Eight ";
            }
            else if (number.Substring(s, 1).ToString() == "9")
            {
                word = word + "Nine ";
            }
        }

        private void Listview1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            DialogResult l = MessageBox.Show("Do you want to close this?", "Student Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (l == DialogResult.Yes)
            {
                MDIParent1.ppp = true; 
                this.Hide();
               
             
            }
        }

        private void Lhistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lhistory_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            
        }
        ////////////////////77777777777777777777777777777777777777
 
    }
}
