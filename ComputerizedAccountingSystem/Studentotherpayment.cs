using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedAccountingSystem
{
    public partial class Studentotherpayment : Form
    {
        public static string descrp= "";

        public static string amounts = "";
        public static bool s = false;

        public Studentotherpayment()
        {
            InitializeComponent();
        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            descrp = desc.Text;
            amounts = (double.Parse(amount.Text)).ToString("n");
            s=true;
            this.Close();

        }

        private void desc_TextChanged(object sender, EventArgs e)
        {

        }
         
    }
}
