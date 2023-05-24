namespace ComputerizedAccountingSystem
{
    partial class PaymentHist
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentHist));
            this.SearchtoolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.name = new System.Windows.Forms.ToolStripTextBox();
            this.mode = new System.Windows.Forms.ToolStripComboBox();
            this.Assessed = new System.Windows.Forms.ToolStripComboBox();
            this.tlPrint = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tooltipclose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.LogIn_MinimizeBttn = new System.Windows.Forms.ToolStripButton();
            this.SearchtoolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchtoolStrip
            // 
            this.SearchtoolStrip.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SearchtoolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SearchtoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripComboBox1,
            this.toolStripLabel4,
            this.name,
            this.mode,
            this.Assessed,
            this.tlPrint});
            this.SearchtoolStrip.Location = new System.Drawing.Point(0, 100);
            this.SearchtoolStrip.Name = "SearchtoolStrip";
            this.SearchtoolStrip.Size = new System.Drawing.Size(1160, 25);
            this.SearchtoolStrip.TabIndex = 294;
            this.SearchtoolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripLabel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(90, 22);
            this.toolStripLabel2.Text = " Search by:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Name",
            "Date",
            "Assessed By:",
            "Mode of Payment"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(12, 22);
            this.toolStripLabel4.Text = " ";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(180, 25);
            this.name.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode.Items.AddRange(new object[] {
            "Cash",
            "Check"});
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(121, 25);
            this.mode.Visible = false;
            this.mode.SelectedIndexChanged += new System.EventHandler(this.mode_SelectedIndexChanged);
            // 
            // Assessed
            // 
            this.Assessed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Assessed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Assessed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assessed.Name = "Assessed";
            this.Assessed.Size = new System.Drawing.Size(150, 25);
            this.Assessed.Visible = false;
            this.Assessed.SelectedIndexChanged += new System.EventHandler(this.Assessed_SelectedIndexChanged);
            // 
            // tlPrint
            // 
            this.tlPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlPrint.Image = ((System.Drawing.Image)(resources.GetObject("tlPrint.Image")));
            this.tlPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlPrint.Name = "tlPrint";
            this.tlPrint.Size = new System.Drawing.Size(54, 22);
            this.tlPrint.Text = "Print";
            this.tlPrint.Click += new System.EventHandler(this.tlPrint_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 128);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1154, 529);
            this.listView1.TabIndex = 296;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SizeChanged += new System.EventHandler(this.listView1_SizeChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " ";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date Assessed";
            this.columnHeader3.Width = 222;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mode of Payment";
            this.columnHeader9.Width = 260;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Amount Paid";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 110;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Assessed By:";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 270;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.ImageIndex = 7;
            this.button1.Location = new System.Drawing.Point(0, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1160, 535);
            this.button1.TabIndex = 295;
            this.button1.Text = " ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 75);
            this.panel1.TabIndex = 293;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(-957, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2911, 13);
            this.label6.TabIndex = 163;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // toolStrip2
            // 
            this.toolStrip2.AllowDrop = true;
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip2.BackgroundImage = global::ComputerizedAccountingSystem.Properties.Resources.CDDDD;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.tooltipclose,
            this.toolStripButton5,
            this.LogIn_MinimizeBttn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(1160, 25);
            this.toolStrip2.TabIndex = 224;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(0, 22);
            // 
            // tooltipclose
            // 
            this.tooltipclose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tooltipclose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooltipclose.Image = ((System.Drawing.Image)(resources.GetObject("tooltipclose.Image")));
            this.tooltipclose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tooltipclose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooltipclose.Name = "tooltipclose";
            this.tooltipclose.Size = new System.Drawing.Size(23, 22);
            this.tooltipclose.Text = "Close";
            this.tooltipclose.Click += new System.EventHandler(this.tooltipclose_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Restore down";
            // 
            // LogIn_MinimizeBttn
            // 
            this.LogIn_MinimizeBttn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LogIn_MinimizeBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogIn_MinimizeBttn.Enabled = false;
            this.LogIn_MinimizeBttn.Image = ((System.Drawing.Image)(resources.GetObject("LogIn_MinimizeBttn.Image")));
            this.LogIn_MinimizeBttn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LogIn_MinimizeBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogIn_MinimizeBttn.Name = "LogIn_MinimizeBttn";
            this.LogIn_MinimizeBttn.Size = new System.Drawing.Size(23, 22);
            this.LogIn_MinimizeBttn.Text = "Minimize";
            // 
            // PaymentHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchtoolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "PaymentHist";
            this.Size = new System.Drawing.Size(1160, 660);
            this.Load += new System.EventHandler(this.PaymentHist_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PaymentHist_Scroll);
            this.SizeChanged += new System.EventHandler(this.PaymentHist_SizeChanged);
            this.StyleChanged += new System.EventHandler(this.PaymentHist_StyleChanged);
            this.SearchtoolStrip.ResumeLayout(false);
            this.SearchtoolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStrip2;
        internal System.Windows.Forms.ToolStripLabel toolStripLabel3;
        public System.Windows.Forms.ToolStripButton tooltipclose;
        internal System.Windows.Forms.ToolStripButton toolStripButton5;
        internal System.Windows.Forms.ToolStripButton LogIn_MinimizeBttn;
        private System.Windows.Forms.ToolStrip SearchtoolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox mode;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ToolStripComboBox Assessed;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton tlPrint;
        internal System.Windows.Forms.Button button1;
    }
}
