namespace ComputerizedAccountingSystem
{
    partial class Form1
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
            this.Schoolname = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.prbar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Schoolname
            // 
            this.Schoolname.BackColor = System.Drawing.Color.Transparent;
            this.Schoolname.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schoolname.Location = new System.Drawing.Point(21, 68);
            this.Schoolname.Name = "Schoolname";
            this.Schoolname.Size = new System.Drawing.Size(393, 117);
            this.Schoolname.TabIndex = 13;
            this.Schoolname.Text = "Brooke\'s Point Christian High School";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "dfdsdfs";
            // 
            // prbar1
            // 
            this.prbar1.Location = new System.Drawing.Point(107, 255);
            this.prbar1.Name = "prbar1";
            this.prbar1.Size = new System.Drawing.Size(246, 15);
            this.prbar1.Step = 1;
            this.prbar1.TabIndex = 11;
            this.prbar1.Click += new System.EventHandler(this.prbar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerizedAccountingSystem.Properties.Resources.splcren;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(457, 342);
            this.ControlBox = false;
            this.Controls.Add(this.Schoolname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prbar1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Schoolname;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ProgressBar prbar1;
    }
}

