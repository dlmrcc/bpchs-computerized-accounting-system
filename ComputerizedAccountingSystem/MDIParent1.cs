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
    public partial class MDIParent1 : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;

        public static bool ppp = false;


        int deltawidth = 0;
        int deltaheigth = 0;

        public static string schoolyear = "2022-2023";
        public MDIParent1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server='localhost';database='ComputerizedAccountingSystem'; username='root';password='psu'");
            cmd = connection.CreateCommand();
            cmd.Connection = connection;
        }

        public static string username = "";
        public static string password = "";
        public static string usertype = "Cashier";
        public static string name = "Delamrcaca";

        public void Log_InHistory()
        {
            string qry = username ;
            string DateIn = DateTime.Now.ToShortDateString();
            string TimeIn = DateTime.Now.ToShortTimeString();
            string DateOut = "Activate";
            string TimeOut = "Activate";
            cmd.CommandText = "insert into loginhist values(0,'" + qry + "','" + DateIn + "','" + TimeIn + "','" + DateOut + "','" + TimeOut + "')";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        void selectschoolyear()
        {
            cmd.CommandText = "select * from chooseschoolyear";
            connection.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                schoolyear = reader.GetValue(0).ToString();
                schoolyear1.Text = reader.GetValue(0).ToString();
            }
            reader.Close();
            connection.Close();
        }

        public void s(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            StudentOutstandingBalance outs = new StudentOutstandingBalance();
            MainPanel.Controls.Add(outs);
            outs.Dock = DockStyle.Fill;
            outs.Show();
        }
        
        private void studentLIstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            StudentList stu_list = new StudentList();
            MainPanel.Controls.Add(stu_list);
            stu_list.Dock = DockStyle.Fill;
            stu_list.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Payment payment = new Payment();
            Payment.schoolyear = schoolyear;
            MainPanel.Controls.Add(payment);
            payment.Dock = DockStyle.Fill;
            payment.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            StudentRegistration studentreg = new StudentRegistration();
            MainPanel.Controls.Add(studentreg);
            studentreg.Dock = DockStyle.Fill;
            studentreg.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            StudentRecord sturec = new StudentRecord();
            MainPanel.Controls.Add(sturec);
            sturec.Dock = DockStyle.Fill;
            sturec.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            StudentOutstandingBalance outs = new StudentOutstandingBalance();
            MainPanel.Controls.Add(outs);
            outs.Dock = DockStyle.Fill;
            outs.Show();
            
            Log_InHistory();
           //selectschoolyear();
            
           
            toolStripStatusLabel1.Text = name.ToUpper();
            toolStripStatusLabel2.Text = usertype;
          

        }

        private void studentInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
          //  MainPanel.Controls.Clear();
            studentinformation stuinfo = new studentinformation();
            MainPanel.Controls.Add(stuinfo);
            stuinfo.Dock = DockStyle.Fill;
            stuinfo.Show();
          //  BringToFront();
            stuinfo.BringToFront();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            xSetUpSection section = new xSetUpSection();
            MainPanel.Controls.Add(section);
            section.Dock = DockStyle.Fill;
            section.Show();
        }

        private void schoolFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MainPanel.Controls.Clear();
            xSetUpSchoolFees setupschoolfees = new xSetUpSchoolFees();
            MainPanel.Controls.Add(setupschoolfees);
            setupschoolfees.Dock = DockStyle.Fill;
            setupschoolfees.Show();
        }

        private void studentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MainPanel.Controls.Clear();
            StudentRecord sturec = new StudentRecord();
            MainPanel.Controls.Add(sturec);
            sturec.Dock = DockStyle.Fill;
            sturec.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            UserAccount uacc = new UserAccount();
            MainPanel.Controls.Add( uacc);
            uacc.Dock = DockStyle.Fill;
            uacc.Show();
        }

        private void paymentHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            PaymentHist ph = new PaymentHist();
            MainPanel.Controls.Add(ph);
           ph.Dock = DockStyle.Fill;
            ph.Show();
        }

        private void MDIParent1_SizeChanged(object sender, EventArgs e)
        { 
             
        }

       

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            RePrintReciept rp = new RePrintReciept();
            MainPanel.Controls.Add(rp);
           rp.Dock = DockStyle.Fill;
           rp.Show();
        }

        private void setupSchoolYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            ChooseSchoolYear cs = new ChooseSchoolYear();
            MainPanel.Controls.Add(cs);
            cs.Dock = DockStyle.Fill;
            cs.Show();

        }

        private void logInHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            LogInhistory login = new LogInhistory();
            login.ShowDialog();
        }

        private void MDIParent1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            selectschoolyear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            int o=0;
           // toolStripStatusLabel2.Text = (o + 1).ToString();
            if (ppp)
            {
                MainPanel.Controls.Clear();
                StudentOutstandingBalance outs = new StudentOutstandingBalance();
                MainPanel.Controls.Add(outs);
                outs.Dock = DockStyle.Fill;
                outs.Show();
                ppp = false;
                
            }
        }

        private void setupSchoolfeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xFees fees = new xFees();
            MainPanel.Controls.Add(fees);
            fees.Dock = DockStyle.Fill;
            fees.Show();
            //  BringToFront();
            fees.BringToFront();
        }

        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            Payment_X p = new Payment_X();
            Payment_X.schoolyear = schoolyear;
            MainPanel.Controls.Add(p);
            p.Dock = DockStyle.Fill;
            p.Show();
            //  BringToFront();
           p.BringToFront();
           p.Focus();
        }

        private void MDIParent1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2)
            {
                Payment_X p = new Payment_X();
                MainPanel.Controls.Add(p);
                p.Dock = DockStyle.Fill;
                p.Show();
                //  BringToFront();
                p.BringToFront();
                p.Focus();
                
            }

            Payment_z n = new Payment_z();
            if (n.Visible==true)
            {
                if (e.KeyCode==Keys.F2)
                {
                    SearchStudent ne = new SearchStudent();
                    ne.ShowDialog();
                }
                
            }

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Payment_z p = new Payment_z();
          //  Payment_z.schoolyear = schoolyear;
            MainPanel.Controls.Add(p);
            p.Dock = DockStyle.Fill;
            p.Show();
            //  BringToFront();
            p.BringToFront();
            p.Focus();
        }

        private void MDIParent1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Payment_z n = new Payment_z();
            if (n.Visible==true)
            {
                if (e.KeyChar == 'M')
                {
                    this.Close();
                }

            }

        }

        private void outstandingBalnceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            OUTSTANDINGBAL2 os = new OUTSTANDINGBAL2();
            MainPanel.Controls.Add(os);
            os.Dock = DockStyle.Fill;
            os.Show();
        }

        private void receiptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Receipt rec = new Receipt();
            MainPanel.Controls.Add(rec);
           rec.Dock = DockStyle.Fill;
            rec.Show();
        }
 
    }
}
