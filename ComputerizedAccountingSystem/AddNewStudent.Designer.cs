namespace ComputerizedAccountingSystem
{
    partial class AddNewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewStudent));
            this.Section = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.YearLevel = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Accountno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Saves = new System.Windows.Forms.Button();
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
            // Section
            // 
            this.Section.BackColor = System.Drawing.SystemColors.Window;
            this.Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Section.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Section.FormattingEnabled = true;
            this.Section.Location = new System.Drawing.Point(122, 295);
            this.Section.MaxLength = 25;
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(240, 24);
            this.Section.TabIndex = 236;
            this.Section.SelectedIndexChanged += new System.EventHandler(this.Section_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save-all.png");
            this.imageList1.Images.SetKeyName(1, "button-cancel-2.png");
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 251;
            this.label5.Text = "Section";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearLevel
            // 
            this.YearLevel.BackColor = System.Drawing.SystemColors.Window;
            this.YearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearLevel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLevel.FormattingEnabled = true;
            this.YearLevel.Location = new System.Drawing.Point(122, 273);
            this.YearLevel.Name = "YearLevel";
            this.YearLevel.Size = new System.Drawing.Size(240, 24);
            this.YearLevel.TabIndex = 235;
            this.YearLevel.SelectedIndexChanged += new System.EventHandler(this.YearLevel_SelectedIndexChanged);
            // 
            // Gender
            // 
            this.Gender.BackColor = System.Drawing.Color.Ivory;
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(122, 250);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(240, 24);
            this.Gender.TabIndex = 234;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 250;
            this.label7.Text = "Year Level";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 23);
            this.label9.TabIndex = 249;
            this.label9.Text = "Gender";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.ImageIndex = 7;
            this.button1.Location = new System.Drawing.Point(9, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 91);
            this.button1.TabIndex = 238;
            this.button1.Text = " ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Accountno
            // 
            this.Accountno.BackColor = System.Drawing.Color.White;
            this.Accountno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Accountno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accountno.Location = new System.Drawing.Point(122, 111);
            this.Accountno.Name = "Accountno";
            this.Accountno.Size = new System.Drawing.Size(240, 23);
            this.Accountno.TabIndex = 247;
            this.Accountno.Text = "2013-000001";
            this.Accountno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 246;
            this.label1.Text = "Account No:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 243;
            this.label3.Text = "Middle Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 242;
            this.label2.Text = "First Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 241;
            this.label8.Text = "Last Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Middlename
            // 
            this.Middlename.BackColor = System.Drawing.SystemColors.Window;
            this.Middlename.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Middlename.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Middlename.Location = new System.Drawing.Point(121, 197);
            this.Middlename.MaxLength = 30;
            this.Middlename.Name = "Middlename";
            this.Middlename.Size = new System.Drawing.Size(241, 23);
            this.Middlename.TabIndex = 233;
            this.Middlename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Middlename_KeyDown);
            this.Middlename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Middlename_KeyPress);
            this.Middlename.Leave += new System.EventHandler(this.Middlename_Leave);
            // 
            // Firstname
            // 
            this.Firstname.BackColor = System.Drawing.SystemColors.Window;
            this.Firstname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Firstname.Location = new System.Drawing.Point(121, 174);
            this.Firstname.MaxLength = 30;
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(241, 23);
            this.Firstname.TabIndex = 232;
            this.Firstname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Firstname_KeyDown);
            this.Firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Middlename_KeyPress);
            this.Firstname.Leave += new System.EventHandler(this.Firstname_Leave);
            // 
            // Lastname
            // 
            this.Lastname.BackColor = System.Drawing.SystemColors.Window;
            this.Lastname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Lastname.Location = new System.Drawing.Point(121, 151);
            this.Lastname.MaxLength = 30;
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(241, 23);
            this.Lastname.TabIndex = 231;
            this.Lastname.TextChanged += new System.EventHandler(this.Lastname_TextChanged);
            this.Lastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lastname_KeyDown);
            this.Lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Middlename_KeyPress);
            this.Lastname.Leave += new System.EventHandler(this.Lastname_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.ImageIndex = 7;
            this.button2.Location = new System.Drawing.Point(9, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(363, 94);
            this.button2.TabIndex = 244;
            this.button2.Text = " ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
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
            this.button9.Size = new System.Drawing.Size(382, 348);
            this.button9.TabIndex = 240;
            this.button9.Text = " ";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Saves
            // 
            this.Saves.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Saves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Saves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Saves.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Saves.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Saves.ImageIndex = 0;
            this.Saves.ImageList = this.imageList1;
            this.Saves.Location = new System.Drawing.Point(178, 337);
            this.Saves.Name = "Saves";
            this.Saves.Size = new System.Drawing.Size(94, 24);
            this.Saves.TabIndex = 252;
            this.Saves.Text = "Save";
            this.Saves.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Saves.UseVisualStyleBackColor = true;
            this.Saves.Click += new System.EventHandler(this.Saves_Click);
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
            this.Cancel.Location = new System.Drawing.Point(278, 337);
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
            this.panel1.Size = new System.Drawing.Size(378, 81);
            this.panel1.TabIndex = 245;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Add New Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ComputerizedAccountingSystem.Properties.Resources.Add_Male_User;
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
            this.toolStrip2.Size = new System.Drawing.Size(382, 25);
            this.toolStrip2.TabIndex = 239;
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
            this.toolStripLabel1.Image = global::ComputerizedAccountingSystem.Properties.Resources.Add_Male_User;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(137, 22);
            this.toolStripLabel1.Text = "Add New Student";
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 373);
            this.Controls.Add(this.Saves);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.YearLevel);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Accountno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Middlename);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewStudent";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewStudent";
            this.Load += new System.EventHandler(this.AddNewStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Section;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox YearLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Accountno;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TextBox Middlename;
        internal System.Windows.Forms.TextBox Firstname;
        internal System.Windows.Forms.TextBox Lastname;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button9;
        internal System.Windows.Forms.Button Saves;
        internal System.Windows.Forms.ToolStripLabel toolStripLabel3;
        public System.Windows.Forms.ToolStripButton tooltipclose;
        internal System.Windows.Forms.ToolStripButton toolStripButton5;
        internal System.Windows.Forms.ToolStripButton LogIn_MinimizeBttn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStrip toolStrip2;
    }
}