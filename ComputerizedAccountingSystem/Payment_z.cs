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
    public partial class Payment_z : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        double currentbal = 0;
       
        public Payment_z()
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

        private void saveRecord_Click(object sender, EventArgs e)
        {

        }

        private void toolsearch_Click(object sender, EventArgs e)
        {
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

                checkBox1.Enabled = true;
                loadpayhist();
                loadfees();
                loadtotalfees();
                loadtotalbal();

                //*******************
                Add.Enabled=EnAm.Enabled=button1.Enabled=textBox1.Enabled=comboBox1.Enabled=comboBox2.Enabled=true;
                comboBox2.Text = "Cash";
                //selectfees();
             //   totalbalstudent();
                select2();
                ok = false;
            }
        }
        void loadfees()
        {
            Lfees.Items.Clear();
            cmd.CommandText = "select * from fees where amount!=0 and (yearlevel='" + yearlevel.Text + "' and schoolyear='" + sy + "') order by fees_id ";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (Lfees.Items.Count % 2 == 0)
                {
                    ListViewItem it = Lfees.Items.Add(reader.GetValue(0).ToString());
                    it.UseItemStyleForSubItems = false; 
                    it.SubItems[0].ForeColor = Color.White;
                    //it.SubItems[1].Font.Bold = true;
                    it.SubItems.Add(reader.GetValue(3).ToString());
                    it.SubItems.Add(double.Parse(reader.GetValue(4).ToString()).ToString("n")).ForeColor = Color.Red;
                    it.SubItems.Add(double.Parse(reader.GetValue(4).ToString()).ToString("n")).ForeColor = Color.Red;
                    it.SubItems.Add("");
                }
                else
                { 

                   ListViewItem it = Lfees.Items.Add(reader.GetValue(0).ToString());
                   it.UseItemStyleForSubItems = false; 
                   it.BackColor = SystemColors.Control;
                   it.SubItems[0].ForeColor = SystemColors.Control;
                   it.SubItems.Add(reader.GetValue(3).ToString());
                   it.SubItems[1].BackColor = SystemColors.Control;  
                   it.SubItems.Add(double.Parse(reader.GetValue(4).ToString()).ToString("n"))
                       .ForeColor = Color.Red;
                   it.SubItems[2].BackColor = SystemColors.Control;  
                   it.SubItems.Add(double.Parse(reader.GetValue(4).ToString()).ToString("n"))
                       .ForeColor = Color.Red;
                   it.SubItems[3].BackColor = SystemColors.Control;  
                   it.SubItems.Add("").BackColor = SystemColors.Control;
                }
            }
            reader.Close();
            connection.Close();

            cmd.CommandText = "select count(*) from sturec where (yearlevel='" + yearlevel.Text + "' and schoolyear='" + sy + "' ) and accno='" + accno.Text + "' ";

            connection.Open();
            int h = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
                  //*****************************

                //***********************************
                if (h != 0)
                {
                    for (int op = 0; op < Lfees.Items.Count; op++)
                    {

                        cmd.CommandText = "select * from sturec where (yearlevel='" + yearlevel.Text + "' and schoolyear='" + sy + "' ) and (accno='" + accno.Text + "' and fees_id=" + int.Parse(Lfees.Items[op].SubItems[0].Text) + ")";
                        connection.Open();
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string g = Lfees.Items[op].SubItems[2].Text;
                            double gg = double.Parse(g);
                            Lfees.Items[op].SubItems[3].Text = (gg - double.Parse(reader.GetValue(5).ToString())).ToString("n");
                            //Lfees.Items[o].SubItems[3].Text = double.Parse(reader.GetValue(5).ToString()).ToString("n");
                        }

                        reader.Close();
                        connection.Close();

                    }
            }
        }
        //payment history>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        private void Lhistory_DoubleClick(object sender, EventArgs e)
        {
            zzParticulars.d = Lhistory.SelectedItems[0].Text;
            zzParticulars par = new zzParticulars();
            par.ShowDialog();
        }


        private void Lhistory_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            Lhistory.Columns[0].Width = 0;
        } 

        void loadpayhist()
        {
            Lhistory.Items.Clear();
            cmd.CommandText = "select * from stupaymenthist where schoolyear='" + MDIParent1.schoolyear + "' and accno='" + id + "' order by ph_id asc";
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (Lhistory.Items.Count % 2 == 0)
                {
                    ListViewItem itemxx = Lhistory.Items.Add(reader.GetValue(0).ToString());
                    itemxx.UseItemStyleForSubItems = false;
                    itemxx.SubItems[0].ForeColor = Color.White;
                    itemxx.SubItems.Add(reader.GetValue(3).ToString());
                    itemxx.SubItems.Add(reader.GetValue(4).ToString());
                    itemxx.SubItems.Add(double.Parse(reader.GetValue(5).ToString()).ToString("n"));
                    itemxx.SubItems[3].ForeColor = Color.Red;
                    itemxx.SubItems.Add(reader.GetValue(6).ToString());
                    itemxx.SubItems.Add("");
                }
                else
                {

                    ListViewItem itemxx = Lhistory.Items.Add(reader.GetValue(0).ToString());
                         itemxx.UseItemStyleForSubItems = false;
                      itemxx.SubItems[0].BackColor = SystemColors.Control; ;
                    
                    itemxx.SubItems[0].ForeColor = SystemColors.Control;
                    itemxx.SubItems.Add(reader.GetValue(3).ToString()).BackColor = SystemColors.Control; ;
                    itemxx.SubItems.Add(reader.GetValue(4).ToString()).BackColor = SystemColors.Control; ;
                    itemxx.SubItems.Add(double.Parse(reader.GetValue(5).ToString()).ToString("n")).BackColor = SystemColors.Control; ;
                    itemxx.SubItems[3].ForeColor = Color.Red;
                    itemxx.SubItems.Add(reader.GetValue(6).ToString()).BackColor = SystemColors.Control;
                    itemxx.SubItems.Add("").BackColor = SystemColors.Control;
                }
            }
            reader.Close();
            connection.Close();
        }


        //end payment history.............................
        //...................::::::::::::::::::::::::::::::::::::::::::::
        void loadtotalfees()
        {
            try
            {
                cmd.CommandText = "select sum(amount) from fees where yearlevel='" + yearlevel.Text + "' and schoolyear='" + sy + "' ";
                connection.Open();
                double total = Convert.ToDouble(cmd.ExecuteScalar());
               // connection.Close();
                ttlschlfees.Text = total.ToString("n");
            }
            catch
            {
                MessageBox.Show("There is no Fees for this Yearlevel. Please setup first the School fees of this Yearlevel.");
                comboBox1.Enabled =
                    button1.Enabled = 
                    comboBox2.Enabled = 
                    Add.Enabled = 
                    Remove.Enabled = 
                    Edit.Enabled = 
                    textBox1.Enabled =  
                    EnAm.Enabled = false;
                ttlschlfees.Text = "0.00";
            }
            finally
            {
                connection.Close();
            }

        }


        void loadtotalbal()
        {
            cmd.CommandText = "select count(*) from balance where (yearlevel='" + yearlevel.Text + "' and schoolyear='" + sy + "') and accno='" + accno.Text + "'";
            connection.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            if (count > 0)
            {
                cmd.CommandText = "select totalpay from balance where (yearlevel='" + yearlevel.Text + "' and schoolyear='" + sy + "') and accno='" + accno.Text + "'";
                connection.Open();
               reader=cmd.ExecuteReader();
                reader.Read();
                double totalpay=double.Parse(reader.GetValue(0).ToString());
                connection.Close();

                double totalschoolfees = double.Parse(ttlschlfees.Text);
                bal.Text = (totalschoolfees - totalpay).ToString("n");
            }
            else
            {
                bal.Text = ttlschlfees.Text;
            }
        }
        

        /////*************************************************************************

        void select2()
        {
            comboBox1.Items.Clear();
            for (int p = 0; p < Lfees.Items.Count; p++)
            {
                if (double.Parse(Lfees.Items[p].SubItems[3].Text) != 0)
                {
                    comboBox1.Items.Add(Lfees.Items[p].SubItems[1].Text
                        + "                                            "
                    + "                                                 " + Lfees.Items[p].SubItems[0].Text);
                }

            }
            if (comboBox1.Items.Count == 0)
            {
                //comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                Feesbal.Text = "0.00";
                EnAm.Text = "0.00";
                Add.Enabled =
                    EnAm.Enabled =
                    comboBox1.Enabled = false;
            }
            else
            {

                comboBox1.SelectedIndex = 0;
            }
        }
        //enter   amount......_____________________________________________-
        //___________________________________________________________________-
        //__________________________________________________________________
        private void EnAm_TextChanged(object sender, EventArgs e)
        {
            if (EnAm.Text == "")
            {
                EnAm.Text = "0.00";
            }

            if (double.Parse(Feesbal.Text) < double.Parse(EnAm.Text))
            {
                EnAm.Text = double.Parse(Feesbal.Text).ToString("n");
            }
           
        }

        private void EnAm_Leave(object sender, EventArgs e)
        {
            double o = double.Parse(EnAm.Text);
            EnAm.Text = o.ToString("n");
        }

        private void EnAm_MouseCaptureChanged(object sender, EventArgs e)
        {
            EnAm.SelectAll();
        }

        private void EnAm_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '.')
            {
                if (EnAm.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else if (e.KeyChar >= 32 && e.KeyChar <= 47 ||
                  e.KeyChar >= 58 && e.KeyChar <= 126)
                e.Handled = true;

        }

        //***************************
        //**************************************8

        private void Add_Click(object sender, EventArgs e)
        {
            if (Add.Text == "Add")
            {
                toolsearch.Enabled = false;
                double o = double.Parse(EnAm.Text);
                EnAm.Text = o.ToString("n");
                //*******************************
                string g = comboBox1.Text.Substring(comboBox1.Text.Length - 5, 5).Trim(' ');
                //***********************
                //************************
                //***************************
                string feesnme = comboBox1.Text.Substring(0, 45);
                feesnme = feesnme.TrimStart(null);
                for (int l = 0; l < feesnme.Length; l++)
                {
                    feesnme = feesnme.Replace("  ", " ");
                }

                //*****************************************
                if (Listview1.Items.Count != 0)
                {
                    bool ok = false;
                    for (int x = 0; x < Listview1.Items.Count; x++)
                    {
                        if (double.Parse(g) == double.Parse(Listview1.Items[x].SubItems[0].Text))
                        {
                            ok = true;
                        }

                    }
                    if (ok)
                    {
                        for (int x = 0; x < Listview1.Items.Count; x++)
                        {
                            if (double.Parse(g) == double.Parse(Listview1.Items[x].SubItems[0].Text))
                            {
                                double ng = double.Parse(Listview1.Items[x].SubItems[2].Text);
                                Listview1.Items[x].SubItems[2].Text = (ng + double.Parse(EnAm.Text)).ToString("n");
                                ok = false;
                            }

                        }
                    }
                    else
                    {
                        ListViewItem oo = Listview1.Items.Add(g);
                        oo.SubItems.Add(feesnme);
                        oo.SubItems.Add(double.Parse(EnAm.Text).ToString("n"));
                    }

                }
                else if (Listview1.Items.Count == 0)
                {
                    ListViewItem ro = Listview1.Items.Add(g);
                    ro.SubItems.Add(feesnme);
                    ro.SubItems.Add(double.Parse(EnAm.Text).ToString("n"));
                }
                //************************************
                double h = double.Parse(Feesbal.Text);
                Feesbal.Text = (h - double.Parse(EnAm.Text)).ToString("n");
                EnAm.Text = Feesbal.Text;
                if (double.Parse(Feesbal.Text) == 0)
                {

                    if (comboBox1.Items.Count == 1)
                    {
                        comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                        Feesbal.Text = "0.00";
                        EnAm.Text = "0.00";
                        Add.Enabled =
                            EnAm.Enabled =
                            comboBox1.Enabled = false;
                    }
                    else if (comboBox1.Items.Count > 0)
                    {
                        comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                        comboBox1.SelectedIndex = 0;
                    }

                }
                else
                {

                }
                totalPAYMENT();
            }
            else if (Add.Text =="Change")
            {
                for (int i = 0; i < Listview1.Items.Count; i++)
                {

                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Listview1.Items.Count == 0)
            {
                string g = comboBox1.Text.Substring(comboBox1.Text.Length - 5, 5).Trim(' ');
                for (int y = 0; y < Lfees.Items.Count; y++)
                {
                    if (int.Parse(Lfees.Items[y].SubItems[0].Text) == int.Parse(g))
                    {
                        Feesbal.Text = Lfees.Items[y].SubItems[3].Text;
                        EnAm.Text = Lfees.Items[y].SubItems[3].Text;
                      //  currentbal = double.Parse(Feesbal.Text);
                        // label1.Text = currentbal.ToString();
                    }
                }

            }
            else
            {
                string g = comboBox1.Text.Substring(comboBox1.Text.Length - 5, 5).Trim(' ');
                for (int y = 0; y < Lfees.Items.Count; y++)
                {
                    if (int.Parse(Lfees.Items[y].SubItems[0].Text) == int.Parse(g))
                    {
                        Feesbal.Text = Lfees.Items[y].SubItems[3].Text;
                        EnAm.Text = Lfees.Items[y].SubItems[3].Text; 
                    }
                }

                for (int h = 0; h < Listview1.Items.Count; h++)
                {

                    if (int.Parse(Listview1.Items[h].SubItems[0].Text)== int.Parse(g))
                    {
                        double bal2 = double.Parse(Listview1.Items[h].SubItems[2].Text);
                        double bal1 = double.Parse(Feesbal.Text);

                        Feesbal.Text = (bal1 - bal2).ToString("n");
                        EnAm.Text = double.Parse(Feesbal.Text).ToString("n"); 
                    }
                }

            }
            EnAm.SelectAll();
        }

      


        void totalPAYMENT()
        {
            double total=0;
            for (int t = 0; t < Listview1.Items.Count; t++)
            {
                double subtotal = double.Parse(Listview1.Items[t].SubItems[2].Text);
                total = total + subtotal;
            }
            totalpay.Text = total.ToString("n");
        }


        //edit and remove

        private void Remove_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

           
            for (int p = 0; p < Lfees.Items.Count; p++)
            {
               if(int.Parse(Listview1.SelectedItems[0].Text)==int.Parse(Lfees.Items[p].SubItems[0].Text))
               {
                   comboBox1.Text = "";
                   comboBox1.Text=(Lfees.Items[p].SubItems[1].Text
                        + "                                            "
                    + "                                                 " + Lfees.Items[p].SubItems[0].Text);
                   Feesbal.Text = Lfees.Items[p].SubItems[3].Text;
                   EnAm.Text = Listview1.SelectedItems[0].SubItems[2].Text;
                   Add.Text = "Change";
               }
            }
             
        }

        //************************************
        //*****************************************************
        //*********************************************
        private void Listview1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Listview1.SelectedItems.Count==1)
            {
                Remove.Enabled=true;
                Edit.Enabled = true;
            }
            else if (Listview1.SelectedItems.Count >= 1)
            {
                Remove.Enabled = true;
                Edit.Enabled = false;
            }
            else
            {
                Remove.Enabled =
                Edit.Enabled = false;
            }
        } 

        //save the record ***************************************************
        //**********************************************************************
        //***********************************************************************

        void saveRecord()
        {
            for(int e=0;e<Listview1.Items.Count;e++)
            {

                cmd.CommandText = "select count(*) from sturec where fees_id=" + Listview1.Items[e].SubItems[0].Text + " and accno='" + accno.Text + "'";
                connection.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();

                if (count > 0)
                {
                    cmd.CommandText = "update sturec set bal=bal+" + Convert.ToDouble(Listview1.Items[e].SubItems[2].Text) 
                        +" where fees_id=" + Listview1.Items[e].SubItems[0].Text + " and accno='" + accno.Text + "'";

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    cmd.CommandText = "insert into sturec values(0,'" + accno.Text + "','"+sy+"',"
                        + "'" + yearlevel.Text + "'," + Convert.ToDouble(Listview1.Items[e].SubItems[0].Text)
                        + "," + Convert.ToDouble(Listview1.Items[e].SubItems[2].Text)+")";
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

            }
            saveBALANCE();
           
        }

        void saveBALANCE()
        {
            cmd.CommandText = "select count(*) from balance where (schoolyear='" + sy + "' and yearlevel='" + yearlevel.Text + "') and accno='" + accno.Text + "'";
            connection.Open();
            int o = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            if (o != 0)
            {
                cmd.CommandText = "update balance set totalbal=totalbal-" + double.Parse(totalpay.Text) 
                    +", totalpay=totalpay+"+double.Parse(totalpay.Text)
                    +" where (schoolyear='" + sy + "' and yearlevel='" + yearlevel.Text + "') and accno='" + accno.Text + "'";
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                cmd.CommandText = "insert into balance values(0,'" + accno.Text + "','" + sy + "','" + yearlevel.Text + "', " + Convert.ToDouble(ttlschlfees.Text) + "-"+ double.Parse(totalpay.Text) + ","+double.Parse(totalpay.Text)+")";
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        void savepaymenthist()
        {
            string mode = "";
            if (comboBox2.SelectedIndex == 1)
            {
                mode = comboBox2.Text + " ( " + textBox2.Text + " )";
            }
            else
            {
                mode = comboBox2.Text;
            }
            double ttlpaid = Convert.ToDouble(totalpay.Text);
            cmd.CommandText = "insert into stupaymenthist values(0,'" + accno.Text + "','" + sy + "','" + DateTime.Now.ToShortDateString() + "','" + MDIParent1.name + "'," + ttlpaid + ",'" +mode+ "')";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //********************

        int nextsubID = 0;
        
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
                    cmd.CommandText = "insert into Studentreciept values(0,'" + accno.Text + "','" +MDIParent1.schoolyear + "','"
                        + "-',"+double.Parse(totalpay.Text)+",'" + MDIParent1.name + "','" + DateTime.Now.ToShortDateString() + "'," + nextsubID + ")";
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                   
                        cmd.CommandText = "select rcpt_id from studentreciept order by rcpt_id desc limit 1";
                        connection.Open();
                        int nextsubIDs = Convert.ToInt32(cmd.ExecuteScalar());
                        connection.Close();


                        cmd.CommandText = "insert into particularreciept values(0,'" + Listview1.Items[o].SubItems[1].Text + "'," + double.Parse(Listview1.Items[o].SubItems[2].Text) + "," + nextsubID + "," + nextsubIDs + ")";
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        p = p + 1;

                   
                }
                else
                { 
                        cmd.CommandText = "select rcpt_id from studentreciept order by rcpt_id desc limit 1";
                        connection.Open();
                        int nextsubIDs = Convert.ToInt32(cmd.ExecuteScalar());
                        connection.Close();


                        cmd.CommandText = "insert into particularreciept values(0,'" + Listview1.Items[o].SubItems[1].Text + "'," + double.Parse(Listview1.Items[o].SubItems[2].Text) + "," + nextsubID + "," + nextsubIDs + ")";
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        p = p + 1;
                    }

                }
            }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "Save")
            {
                if (totalpay.Text == "0.00")
                {
                    MessageBox.Show("Please Add First a Fees to Pay.");

                }
                else
                {
                    Add.Enabled = 
                        comboBox2.Enabled = 
                        Edit.Enabled =
                        Remove.Enabled = 
                        EnAm.Enabled = false;
                    Feesbal.Text = "0.00";
                    EnAm.Text = "0.00";
                    saveRecord();
                    savepaymenthist();
                    particularREc();
                    Cancel.Enabled = false;
                    button1.Text = "Print";
                }
            }
            else if (button1.Text == "Print")
            {
                toolsearch.Enabled = true;
                Add.Enabled = 
                    comboBox2.Enabled =
                    Edit.Enabled = 
                    Remove.Enabled =
                    Cancel.Enabled= 
                    EnAm.Enabled = true;
                button1.Text = "Save";
                loadfees();
                loadtotalfees();
                loadtotalbal();
                loadpayhist();
                Listview1.Items.Clear();
                totalpay.Text = "0.00";
            }
        }

        //**************************************************
        //******************************************************
        

        private void Payment_z_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F19)
            {
                SearchStudent ne = new SearchStudent();
                ne.ShowDialog();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                label1.Visible = textBox2.Visible = true;
            }
            else
            {
                label1.Visible = textBox2.Visible = false;
                textBox2.Text = "";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (Listview1.Items.Count > 0)
            {
                DialogResult h = MessageBox.Show("Do you want to Cancel the Payment Process?.", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (h == DialogResult.Yes)
                {
                    toolsearch.Enabled = true;
                    Listview1.Items.Clear();
                    select2();
                    comboBox1.Enabled = EnAm.Enabled = Add.Enabled = true;

                    Chnge.Text = totalpay.Text = textBox1.Text = "0.00";
                    Add.Text = "Add";
                    Edit.Enabled = Remove.Enabled = false;
                }
            }
            else
            {
                toolsearch.Enabled = true;
                Listview1.Items.Clear();
               /// select2();
                comboBox1.Enabled = EnAm.Enabled = Add.Enabled = true;

                Chnge.Text = totalpay.Text = textBox1.Text = "0.00";
                Add.Text = "Add";
                Edit.Enabled = Remove.Enabled = false;
            }
        }
        //enter PAymnt.....................
        //"""""""""""""""""""""""""""""""""""""""""""""""""""
        //""""""""""""""""""""""""""""""""""""""""""""""""""""
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (totalpay.Text == "0.00")
            {
                textBox1.Text = "0.00";
            }
            else
            {
                double l = Convert.ToDouble(totalpay.Text);
                if (l < double.Parse(textBox1.Text))
                {
                    Chnge.Text = ( double.Parse(textBox1.Text)-l).ToString("n");
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (EnAm.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else if (e.KeyChar >= 32 && e.KeyChar <= 47 ||
                  e.KeyChar >= 58 && e.KeyChar <= 126)
                e.Handled = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = (double.Parse(textBox1.Text)).ToString("n");
        }

        private void textBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        } 

        //end na ng ito/////
    }
}
