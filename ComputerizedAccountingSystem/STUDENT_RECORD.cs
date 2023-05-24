using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedAccountingSystem
{
    public partial class STUDENT_RECORD : UserControl
    {
        public STUDENT_RECORD()
        {
            InitializeComponent();
        }

        private void tooltipclose_Click(object sender, EventArgs e)
        {
            MDIParent1 m = new MDIParent1();
            m.s(sender, e);
        }
    }
}
