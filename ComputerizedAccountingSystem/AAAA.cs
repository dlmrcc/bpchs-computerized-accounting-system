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
    public partial class AAAA : Form
    {
        public AAAA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDIParent1 j = new MDIParent1();
            j.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MDIParent2 j = new MDIParent2();
            j.ShowDialog();
        }
    }
}
