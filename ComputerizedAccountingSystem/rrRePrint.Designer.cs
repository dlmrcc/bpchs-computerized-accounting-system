namespace ComputerizedAccountingSystem
{
    partial class rrRePrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rrRePrint));
            this.LParticulars = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.REPRINT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LParticulars
            // 
            this.LParticulars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.LParticulars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LParticulars.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LParticulars.FullRowSelect = true;
            this.LParticulars.GridLines = true;
            this.LParticulars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LParticulars.HideSelection = false;
            this.LParticulars.Location = new System.Drawing.Point(0, 26);
            this.LParticulars.MultiSelect = false;
            this.LParticulars.Name = "LParticulars";
            this.LParticulars.Size = new System.Drawing.Size(344, 291);
            this.LParticulars.TabIndex = 282;
            this.LParticulars.UseCompatibleStateImageBehavior = false;
            this.LParticulars.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Particulars";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Amount";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 139;
            // 
            // toolStrip
            // 
            this.toolStrip.AllowMerge = false;
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip.BackgroundImage")));
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(344, 26);
            this.toolStrip.TabIndex = 281;
            this.toolStrip.Text = "ToolStrip";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Mode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.REPRINT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 39);
            this.panel1.TabIndex = 283;
            // 
            // REPRINT
            // 
            this.REPRINT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.REPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.REPRINT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.REPRINT.Enabled = false;
            this.REPRINT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REPRINT.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.REPRINT.ImageKey = "edit-11.png";
            this.REPRINT.Location = new System.Drawing.Point(238, 7);
            this.REPRINT.Name = "REPRINT";
            this.REPRINT.Size = new System.Drawing.Size(94, 24);
            this.REPRINT.TabIndex = 270;
            this.REPRINT.Text = "Re-Print";
            this.REPRINT.UseVisualStyleBackColor = true;
            this.REPRINT.Click += new System.EventHandler(this.REPRINT_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 271;
            this.label6.Text = "Mode of Payment:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mode
            // 
            this.Mode.BackColor = System.Drawing.Color.Transparent;
            this.Mode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.Location = new System.Drawing.Point(112, 8);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(113, 23);
            this.Mode.TabIndex = 272;
            this.Mode.Text = "Verify Password";
            this.Mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rrRePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 356);
            this.Controls.Add(this.LParticulars);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rrRePrint";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.rrRePrint_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LParticulars;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button REPRINT;
        public System.Windows.Forms.Label Mode;
        public System.Windows.Forms.Label label6;
    }
}