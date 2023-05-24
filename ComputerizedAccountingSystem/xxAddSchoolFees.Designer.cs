namespace ComputerizedAccountingSystem
{
    partial class xxAddSchoolFees
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xxAddSchoolFees));
            this.amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.feesname = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tooltipclose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.LogIn_MinimizeBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.SystemColors.Window;
            this.amount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.Red;
            this.amount.Location = new System.Drawing.Point(125, 136);
            this.amount.MaxLength = 20;
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(241, 23);
            this.amount.TabIndex = 253;
            this.amount.Text = "0.00";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_KeyPress);
            this.amount.Leave += new System.EventHandler(this.amount_Leave);
            this.amount.MouseCaptureChanged += new System.EventHandler(this.amount_MouseCaptureChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 254;
            this.label4.Text = "Amount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 245;
            this.label3.Text = "Fees Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feesname
            // 
            this.feesname.BackColor = System.Drawing.SystemColors.Window;
            this.feesname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.feesname.Location = new System.Drawing.Point(125, 113);
            this.feesname.MaxLength = 25;
            this.feesname.Name = "feesname";
            this.feesname.Size = new System.Drawing.Size(241, 23);
            this.feesname.TabIndex = 243;
            this.feesname.MouseCaptureChanged += new System.EventHandler(this.feesname_MouseCaptureChanged);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Cursor = System.Windows.Forms.Cursors.Default;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Enabled = false;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button9.ImageIndex = 7;
            this.button9.Location = new System.Drawing.Point(0, 25);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(393, 190);
            this.button9.TabIndex = 256;
            this.button9.Text = " ";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.ImageIndex = 7;
            this.button2.Location = new System.Drawing.Point(11, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 67);
            this.button2.TabIndex = 258;
            this.button2.Text = " ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save-all.png");
            this.imageList1.Images.SetKeyName(1, "button-cancel-2.png");
            this.imageList1.Images.SetKeyName(2, "button-add.png");
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Save.ImageIndex = 0;
            this.Save.ImageList = this.imageList1;
            this.Save.Location = new System.Drawing.Point(187, 178);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 24);
            this.Save.TabIndex = 247;
            this.Save.Text = "Save";
            this.Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Cancel.ImageIndex = 1;
            this.Cancel.ImageList = this.imageList1;
            this.Cancel.Location = new System.Drawing.Point(287, 178);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 24);
            this.Cancel.TabIndex = 248;
            this.Cancel.Text = "Cancel";
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 81);
            this.panel1.TabIndex = 257;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Add Fees";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AllowDrop = true;
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip2.BackgroundImage = global::ComputerizedAccountingSystem.Properties.Resources.CDDDD;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.tooltipclose,
            this.toolStripButton5,
            this.LogIn_MinimizeBttn,
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(393, 25);
            this.toolStrip2.TabIndex = 255;
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "Adding Fees";
            // 
            // xxAddSchoolFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 215);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feesname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xxAddSchoolFees";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xxAddSchoolFees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ToolStripButton LogIn_MinimizeBttn;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox amount;
        internal System.Windows.Forms.ToolStripButton toolStripButton5;
        internal System.Windows.Forms.ToolStripLabel toolStripLabel3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ToolStripButton tooltipclose;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox feesname;
        internal System.Windows.Forms.Button button9;
        public System.Windows.Forms.ToolStrip toolStrip2;
        internal System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.Button Save;
        internal System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel panel1;
    }
}