namespace ComputerizedAccountingSystem
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.secquest = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.secans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.ToolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolCancel = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.retrieve = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ToolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "update-misc.png");
            // 
            // secquest
            // 
            this.secquest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.99F, System.Drawing.FontStyle.Bold);
            this.secquest.FormattingEnabled = true;
            this.secquest.Items.AddRange(new object[] {
            "What is your favorate food?",
            "What is your favorate pet?",
            "What is your name?",
            "What is your Lastname?",
            "What is Love?",
            "What is the name of your boss?.",
            "What is your favorate drinks?",
            "What is your favarate hangout?"});
            this.secquest.Location = new System.Drawing.Point(159, 136);
            this.secquest.Name = "secquest";
            this.secquest.Size = new System.Drawing.Size(242, 24);
            this.secquest.TabIndex = 250;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 249;
            this.label3.Text = "Secret Answer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secans
            // 
            this.secans.BackColor = System.Drawing.SystemColors.Window;
            this.secans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.99F, System.Drawing.FontStyle.Bold);
            this.secans.Location = new System.Drawing.Point(158, 160);
            this.secans.MaxLength = 50;
            this.secans.Name = "secans";
            this.secans.Size = new System.Drawing.Size(243, 23);
            this.secans.TabIndex = 248;
            this.secans.MouseCaptureChanged += new System.EventHandler(this.secans_MouseCaptureChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 247;
            this.label2.Text = "Secret Question";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 246;
            this.label1.Text = "User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.99F, System.Drawing.FontStyle.Bold);
            this.txtboxUsername.Location = new System.Drawing.Point(158, 114);
            this.txtboxUsername.MaxLength = 15;
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(243, 23);
            this.txtboxUsername.TabIndex = 245;
            this.txtboxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxUsername_KeyPress);
            this.txtboxUsername.MouseCaptureChanged += new System.EventHandler(this.txtboxUsername_MouseCaptureChanged);
            // 
            // ToolStrip4
            // 
            this.ToolStrip4.AutoSize = false;
            this.ToolStrip4.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStrip4.GripMargin = new System.Windows.Forms.Padding(0);
            this.ToolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton1,
            this.ToolCancel,
            this.ToolStripButton2,
            this.ToolStripButton3,
            this.toolStripLabel2,
            this.toolStripButton5,
            this.toolStripLabel1});
            this.ToolStrip4.Location = new System.Drawing.Point(-29, 2);
            this.ToolStrip4.Name = "ToolStrip4";
            this.ToolStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip4.Size = new System.Drawing.Size(494, 22);
            this.ToolStrip4.TabIndex = 244;
            this.ToolStrip4.Text = "ToolStrip4";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 19);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 19);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // ToolCancel
            // 
            this.ToolCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolCancel.Image = ((System.Drawing.Image)(resources.GetObject("ToolCancel.Image")));
            this.ToolCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolCancel.Name = "ToolCancel";
            this.ToolCancel.Size = new System.Drawing.Size(23, 19);
            this.ToolCancel.Text = "Close";
            this.ToolCancel.Click += new System.EventHandler(this.ToolCancel_Click);
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton2.Enabled = false;
            this.ToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton2.Image")));
            this.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(23, 19);
            this.ToolStripButton2.Text = "Restore down";
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton3.Image")));
            this.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(23, 19);
            this.ToolStripButton3.Text = "Minimize";
            this.ToolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 19);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 19);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = global::ComputerizedAccountingSystem.Properties.Resources.Untitled_1;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(150, 19);
            this.toolStripLabel1.Text = "FORGOT PASSWORD";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::ComputerizedAccountingSystem.Properties.Resources.forgotpassword;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(136, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 30);
            this.pictureBox2.TabIndex = 252;
            this.pictureBox2.TabStop = false;
            // 
            // retrieve
            // 
            this.retrieve.BackColor = System.Drawing.Color.WhiteSmoke;
            this.retrieve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.retrieve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retrieve.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.retrieve.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.retrieve.ImageIndex = 0;
            this.retrieve.ImageList = this.imageList2;
            this.retrieve.Location = new System.Drawing.Point(304, 189);
            this.retrieve.Name = "retrieve";
            this.retrieve.Size = new System.Drawing.Size(94, 24);
            this.retrieve.TabIndex = 251;
            this.retrieve.Text = "  Retrieve";
            this.retrieve.UseVisualStyleBackColor = true;
            this.retrieve.Click += new System.EventHandler(this.retrieve_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ComputerizedAccountingSystem.Properties.Resources.Untitled_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 76);
            this.pictureBox1.TabIndex = 253;
            this.pictureBox1.TabStop = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerizedAccountingSystem.Properties.Resources.LOGIN3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 235);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.retrieve);
            this.Controls.Add(this.secquest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.ToolStrip4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.secans);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.ToolStrip4.ResumeLayout(false);
            this.ToolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Button retrieve;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ComboBox secquest;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox secans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtboxUsername;
        internal System.Windows.Forms.ToolStrip ToolStrip4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        internal System.Windows.Forms.ToolStripButton ToolCancel;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}