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
    public partial class StudentRegistration : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        int r;
       
        public static string schoolyear = MDIParent1.schoolyear;

        public StudentRegistration()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }
        public static bool OK=false;

        public static string AccNo = "";
        public static string Lname = "";
        public static string Fname = "";
        public static string MI = "";
        public static string Gender = "";
        public static string YearLevel = "";
        public static string Section = "";

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Addnewstudent_Click(object sender, EventArgs e)
        {
            AddNewStudent addnewstu = new AddNewStudent();
            addnewstu.ShowDialog();
            if (OK)
            {
                    

                loadName();
                
                loadfees();
                Loadsubfees();
                 
                //*************************
                Addnewstudent.Enabled = false;
                Updateoldstudent.Enabled = false;
                saveRecord.Enabled = false;
                Cancel.Enabled =
                AddotherPayment.Enabled =
                comboBox1.Enabled =
                textBoxchanges.Enabled =
                textBoxenteramount.Enabled =
                priority.Enabled =
                textBoxtotalpayment.Enabled = true;
                comboBox1.Text = "Cash";
                loadsum();
                //*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*
                OK = false;
            }
        }

        private void Updateoldstudent_Click(object sender, EventArgs e)
        {
            UpdateOldStudent updateoldstu = new UpdateOldStudent();
            updateoldstu.ShowDialog();

            if (OK)
            {


                loadName();
                loadfees();
                Loadsubfees();
                 
                //*************************
                Addnewstudent.Enabled = false;
                Updateoldstudent.Enabled = false;
                saveRecord.Enabled = false;
                Cancel.Enabled =
                AddotherPayment.Enabled =
                comboBox1.Enabled =
                textBoxchanges.Enabled =
                textBoxenteramount.Enabled =
                priority.Enabled =
                textBoxtotalpayment.Enabled = true;
                loadsum();
                comboBox1.Text = "Cash";

                //*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*
                OK = false;
            }
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        { 
        }
        void loadsum()
        {
            try
            {
                cmd.CommandText = "select sum(amount) from schoolfees where schoolyear ='" + schoolyear + "' and yearlevel='" + yearlevel.Text + "'";
                connection.Open();
                ttlschlfees.Text = Convert.ToDouble(cmd.ExecuteScalar()).ToString("n");
                bal.Text = Convert.ToDouble(cmd.ExecuteScalar()).ToString("n");
                reader.Close();
               
            }
            catch
            {
                MessageBox.Show("There is No Schoolfees for this Yearlevel. \n Please! Set Up first to Continue.");
                Addnewstudent.Enabled = true;
                Updateoldstudent.Enabled = true;
                saveRecord.Enabled = false;
                Cancel.Enabled =
                AddotherPayment.Enabled =
                comboBox1.Enabled =
                textBoxchanges.Enabled =
                textBoxenteramount.Enabled =
                priority.Enabled =
                textBoxtotalpayment.Enabled = false;

            }
            finally
            {
                connection.Close();
            }
        }
        void loadfees()
        {

            cmd.CommandText = "Select Fees_id,feesname,amount,feestype from schoolfees where (yearlevel='" + yearlevel.Text+ "' && schoolyear='" +schoolyear+ "') and amount!=0";
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

                    ListViewItem itemxx = Listview1.Items.Add(reader.GetValue(0).ToString());
                    itemxx.SubItems.Add(reader.GetValue(1).ToString());
                    itemxx.SubItems.Add(Double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    itemxx.SubItems.Add(Double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    itemxx.SubItems.Add("");
                    itemxx.SubItems.Add(reader.GetValue(3).ToString());
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
                    ListViewItem itemxx = Listview1.Items.Add(reader.GetValue(0).ToString());
                    itemxx.SubItems.Add(reader.GetValue(1).ToString());
                    itemxx.SubItems.Add(Double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    itemxx.SubItems.Add(Double.Parse(reader.GetValue(2).ToString()).ToString("n"));
                    itemxx.SubItems.Add("");
                    itemxx.SubItems.Add(reader.GetValue(3).ToString());
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

        void loadName()
        {

            AccountNo.Text = AccNo;
            lastname.Text = Lname;
            firstname.Text = Fname;
            middlename.Text = MI;
            yearlevel.Text = YearLevel;
            gender.Text = Gender;
            section.Text = Section;
        }

        private void saveRecord_Click(object sender, EventArgs e)
        {
            if (saveRecord.Text.Equals("Pay"))
            {
                
                if (priority.Checked == true)
                {
                    if (textBoxenteramount.Text == "")
                    {
                        DialogResult o = MessageBox.Show("Do you want to save this information without any payment?", "Student Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (o == DialogResult.Yes)
                        {
                            saveRecord.Text = "Save";
                        }
                    }
                    else
                    {
                        double amountpaid = Convert.ToDouble(textBoxenteramount.Text);
                        for (int t = 0; t <Listview1.Items.Count; t++)
                        {
                            if (amountpaid >= double.Parse(Listview1.Items[t].SubItems[2].Text))
                            {
                                Listview1.Items[t].SubItems[3].Text= "-";
                                Listview1.Items[t].SubItems[4].Text = Listview1.Items[t].SubItems[2].Text;
                                amountpaid = amountpaid - Convert.ToDouble(Listview1.Items[t].SubItems[2].Text);
                            }
                            else if (amountpaid <= double.Parse(Listview1.Items[t].SubItems[2].Text))
                            {
                                Listview1.Items[t].SubItems[3].Text = (Convert.ToDouble(Listview1.Items[t].SubItems[2].Text) - amountpaid).ToString("n");
                                Listview1.Items[t].SubItems[4].Text = ((double.Parse(Listview1.Items[t].SubItems[2].Text) -double.Parse(Listview1.Items[t].SubItems[3].Text)).ToString("n"));
                               // dataGridView2.Rows[t].Cells[3].Value = (Convert.ToDouble(dataGridView2.Rows[t].Cells[2].Value) - amountpaid).ToString();
                                break;
                            }
                        }
                        //computetable();
                        textBoxtotalpayment.Text = (Convert.ToDouble(textBoxtotalpayment.Text) + Convert.ToDouble(textBoxenteramount.Text)).ToString("n");
                        bal.Text = (Convert.ToDouble(ttlschlfees.Text) - Convert.ToDouble(textBoxtotalpayment.Text)).ToString("n");
                        textBoxenteramount.Text = "";
                        textBoxenteramount.Focus();
                        saveRecord.Text = "Save";
                        Cancel.Text = "*Back";
                        saveRecord.Enabled = true;
                      
                    }
                }
                else
                {
                    //saveRecord.Text = "Save";
                }
            }
            else if (saveRecord.Text.Equals("Save"))
            {
                if (textBoxtotalpayment.Text=="00.00")
                {
                    SaveRecord();
                    savetotalbalance();
                    DialogResult o = MessageBox.Show("Succesfully saved.", "Student Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enabledALL();
                }
                else
                {
                    SaveRecord();
                    savetotalbalance();
                   // PaymentHist();
                   // PaymentHist();
                    StudentPaymentHist();
                    particularREc();
                    printss();
                }
            }
        }

        private void textBoxenteramount_TextChanged(object sender, EventArgs e)
        {
            if (priority.Checked == true)
            {
                if (saveRecord.Text == "Pay")
                {
                    if (textBoxenteramount.Text != "")
                    {
                        saveRecord.Enabled = true;
                    }
                    else if(textBoxenteramount.Text == ""||textBoxenteramount.Text == "0")
                    {
                        textBoxenteramount.Text = "";
                        saveRecord.Enabled = false;
                    }
                    try
                    {
                        
                        if (Convert.ToDouble(textBoxenteramount.Text) > Convert.ToDouble(ttlschlfees.Text))
                        {
                            textBoxenteramount.Text = Convert.ToDouble(ttlschlfees.Text).ToString();
                        }
                    }
                    catch { }
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

        void computetable()
        {
            for (int x = 0; x < Listview1.Items.Count; x++)
            {
                for (int y = 0; y < Lfees.Items.Count; y++)
                {
                    if (Listview1.Items[x].SubItems[0].Text == Lfees.Items[y].SubItems[0].Text)
                    {
                        if (Lfees.Items[y].SubItems[4].Text == "w_sub")
                        {
                            double r = Convert.ToDouble(Lfees.Items[y].SubItems[0].Text);
                            for (int z = 0; z < Lfees.Items.Count; z++)
                            {
                                if (Convert.ToDouble(Lfees.Items[z].SubItems[0].Text) > r)
                                {
                                    if (Listview1.Items[x].SubItems[3].Text == "-")
                                    {
                                        Lfees.Items[z].SubItems[4].Text= "-";
                                        Lfees.Items[z].SubItems[5].Text = Lfees.Items[z].SubItems[3].Text;
                                    }
                                   //double o=Convert.ToDouble(dataGridView2.Rows[x].Cells[2].value)-
                                }
                            }
                        }
                        else if (Lfees.Items[y].SubItems[4].Text == "wo_su")
                        {
                            Lfees.Items[y].SubItems[4].Text = Listview1.Items[x].SubItems[3].Text;
                        }
                    }
                }
            }
        }

        void SaveRecord()
        {
           // Lfees.Items[0].SubItems[0].Text;
           // Listview1.Items[0].SubItems[0].Text
            for (int i = 0; i < Listview1.Items.Count; i++)
           {
               try
               {
                   cmd.CommandText = "Insert into studentrecords values('" + AccountNo.Text + "','" + schoolyear + "','" + yearlevel.Text + "','" + Listview1.Items[i].SubItems[0].Text + "','" + Listview1.Items[i].SubItems[1].Text + "'," + double.Parse(Listview1.Items[i].SubItems[2].Text) + "," + double.Parse(Listview1.Items[i].SubItems[3].Text.Replace('-', '0')) + ")";
                   connection.Open();
                   // cmd.CommandText = "insert into studentrecords values ('" + AccountNo.Text + "','" + schoolyear + "','" + yearlevel.Text + "')";//,'" + Listview1.Items[i].SubItems[0].Text + "','" + Listview1.Items[i].SubItems[1].Text+"',"+ Listview1.Items[i].SubItems[2].Text + ")";//" + Listview1.Items[i].SubItems[3].Text.Replace('-', '0') + ")";
                   cmd.ExecuteNonQuery();
                   
               }
               catch { }
               finally
               {
                   connection.Close();
               }
           }
          
        }
        void savetotalbalance()
        { 
                double ttlschlfs = Convert.ToDouble(ttlschlfees.Text);
                double ttlpayment = Convert.ToDouble(textBoxtotalpayment.Text);
            
                double totalbal = 0;
                for (int u = 0; u < Listview1.Items.Count; u++)
                {
                    double bal = Convert.ToDouble(Listview1.Items[u].SubItems[3].Text.Replace('-', '0'));
                    totalbal = totalbal + bal;
                }
                connection.Open();
                cmd.CommandText = "insert into totalbalanceandtotalamountpaidandtotalaschoolfees values('" + AccountNo.Text + "','" + schoolyear + "'," + totalbal + "," + ttlschlfs + "," + ttlpayment + ")";
                cmd.ExecuteNonQuery();
                connection.Close();
            
        }
        void enabledALL()
        {
            Listview1.Items.Clear();
            Lfees.Items.Clear();
            saveRecord.Text = "Pay";
            lastname.Text =
            firstname.Text =
            middlename.Text =
            yearlevel.Text =
            section.Text =
            AccountNo.Text =
            gender.Text = "";
            Cancel.Text = "Cancel";
            textBoxtotalpayment.Text = "00.00";
            bal.Text = "00.00";
            ttlschlfees.Text = "00.00";
           saveRecord.Enabled =
                Cancel.Enabled =
                AddotherPayment.Enabled =
                comboBox1.Enabled =
                textBoxchanges.Enabled =
                textBoxenteramount.Enabled =
                priority.Enabled=
                textBoxtotalpayment.Enabled = false;
            Addnewstudent.Enabled = true;
            Updateoldstudent.Enabled = true;
        }

        void ParticularReciept()
        {

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
                        SaveRecord();
                        savetotalbalance();
                        enabledALL();
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
                bal.Text =(double.Parse(bal.Text) + double.Parse(textBoxtotalpayment.Text)).ToString("n");
                textBoxtotalpayment.Text = "0.00";
                Cancel.Text = "Clear(*)";
                saveRecord.Text = "Pay";
                saveRecord.Enabled = true;
                
                for(int y=0;y<Listview1.Items.Count;y++)
                {
                    if (Listview1.Items[y].SubItems[3].Text == "-")
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

        private void AddotherPayment_Click(object sender, EventArgs e)
        {
            Studentotherpayment stuad = new Studentotherpayment();
            stuad.ShowDialog();
            if (Studentotherpayment.s)
            {
                Studentotherpayment.s  = false;
              ListViewItem i=  Listview1.Items.Add("");
              i.SubItems.Add(Studentotherpayment.descrp);
              i.SubItems.Add(Studentotherpayment.amounts);
              i.SubItems.Add("");
              i.SubItems.Add(Studentotherpayment.amounts);

            }
            double n=double.Parse(textBoxtotalpayment.Text);
            double ee=double.Parse(Studentotherpayment.amounts);
            textBoxtotalpayment.Text = (ee + n).ToString("n");
            
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }



        //***********************************start dito
        //*************************************************************
        //*****************************************************************
        string number = "";
        string word = "";
        int s = 0;
       string textBox4 = "";

          void StudentPaymentHist()
          {   
            double ttlpaid = Convert.ToDouble(textBoxtotalpayment.Text);
            cmd.CommandText = "insert into stupaymenthist values(0,'" + AccountNo.Text + "','" + schoolyear + "','" + DateTime.Now.ToShortDateString() + "','" + MDIParent1.name + "'," + ttlpaid + ",'" + comboBox1.Text + "')";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

          public int GetTuPaymentHist()
          {
              cmd.CommandText = "select PH_id from stupaymenthist order by PH_id desc limit 1";
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

        //******************************************************
        //******************************************************

          int nextsubID =0;
          string recNumber = "";
          string wor_amount = "";
          int recNo = 0;
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
                     cmd.CommandText= "insert into Studentreciept values(0,'" + AccountNo.Text+ "','" + schoolyear + "','"
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
              graphics.DrawString("R.N:"+recNumber, new Font("Courier New", 10),
              new SolidBrush(Color.Black),400 , 180);
           
              //*************************************************

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
                    mi = middlename.Text.Substring(0, 1).ToUpper();
              }
              catch
              {
              }
            
               startX = 260;
               //startY = 200;
              
              graphics.DrawString(lname + ", " + fname + " " + mi, new Font("Courier New", 12),
              new SolidBrush(Color.Black), 270, 265  );
            


              //*******************************end name

                  cmd.CommandText = "select rcpt_id from studentreciept where process='pending' && HIST_Id="+nextsubID+" order by rcpt_id asc limit 1";
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
                              startY = 320;
                              graphics.DrawString(reader.GetValue(1).ToString(), new Font("Courier New", 10),
                              new SolidBrush(Color.Black), startX, startY + UU);


                              startX = 480;
                              startY = 320;
                              graphics.DrawString(double.Parse(reader.GetValue(2).ToString()).ToString("n"), new Font("Courier New", 10),
                              new SolidBrush(Color.Black), startX, startY + UU);
                              UU = UU + 20;
 
                      }
                      reader.Close();
                      connection.Close();
                      //********************************

                      //**************totalamount
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
                      new SolidBrush(Color.Black), 490,510);
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
                          textBox4  = word;
                          word = "";
                      }
                      else if (number.Length == 2)//78
                      {
                          s = 0;
                          teens();
                          textBox4  = word;
                          word = "";
                      }
                      else if (number.Length == 1)
                      {

                          s = 0;
                          ones();
                          textBox4  = word;
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
                  startX = 240;
                  startY = 200;
                  
                  graphics.DrawString(MDIParent1.name, new Font("Courier New", 10),
                  new SolidBrush(Color.Black), 370,700  );
              //**********************************
                  
          }

          void update()
          {
              cmd.CommandText = "update studentreciept set recieptNo='"+recNumber+"',process='Printed', wordamount='"+wor_amount+"' where rcpt_id=" + recNo;
              connection.Open();
              cmd.ExecuteNonQuery();
              connection.Close();
              
          }
        //***************************
          void printss()
          { 
              cmd.CommandText = "select Count(rcpt_id) from studentreciept where hist_id="+nextsubID;
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
              enabledALL();
          }

        //*********************************
        //**********************************

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

          private void priority_CheckedChanged(object sender, EventArgs e)
          {

          }

          private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
        //*****************************end

    }
}
