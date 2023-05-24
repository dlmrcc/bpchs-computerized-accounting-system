namespace ComputerizedAccountingSystem
{
    partial class ForgotpassordCREATE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotpassordCREATE));
            this.label1 = new System.Windows.Forms.Label();
            this.pas1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pas2 = new System.Windows.Forms.TextBox();
            this.retrieve = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 248;
            this.label1.Text = "New Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pas1
            // 
            this.pas1.BackColor = System.Drawing.SystemColors.Window;
            this.pas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.99F, System.Drawing.FontStyle.Bold);
            this.pas1.Location = new System.Drawing.Point(139, 10);
            this.pas1.MaxLength = 15;
            this.pas1.Name = "pas1";
            this.pas1.Size = new System.Drawing.Size(243, 23);
            this.pas1.TabIndex = 247;
            this.pas1.UseSystemPasswordChar = true;
            this.pas1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pas1_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 284;
            this.label2.Text = "Confirm Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pas2
            // 
            this.Pas2.BackColor = System.Drawing.SystemColors.Window;
            this.Pas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.99F, System.Drawing.FontStyle.Bold);
            this.Pas2.Location = new System.Drawing.Point(139, 33);
            this.Pas2.MaxLength = 15;
            this.Pas2.Name = "Pas2";
            this.Pas2.Size = new System.Drawing.Size(243, 23);
            this.Pas2.TabIndex = 283;
            this.Pas2.UseSystemPasswordChar = true;
            this.Pas2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pas1_KeyPress);
            // 
            // retrieve
            // 
            this.retrieve.BackColor = System.Drawing.Color.WhiteSmoke;
            this.retrieve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.retrieve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retrieve.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.retrieve.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.retrieve.ImageIndex = 0;
            this.retrieve.ImageList = this.imageList1;
            this.retrieve.Location = new System.Drawing.Point(288, 62);
            this.retrieve.Name = "retrieve";
            this.retrieve.Size = new System.Drawing.Size(94, 24);
            this.retrieve.TabIndex = 285;
            this.retrieve.Text = "Save";
            this.retrieve.UseVisualStyleBackColor = true;
            this.retrieve.Click += new System.EventHandler(this.retrieve_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save.png");
            this.imageList1.Images.SetKeyName(1, "save-all.png");
            this.imageList1.Images.SetKeyName(2, "edit-11.png");
            this.imageList1.Images.SetKeyName(3, "edit-delete.png");
            this.imageList1.Images.SetKeyName(4, "button-cancel-2.png");
            this.imageList1.Images.SetKeyName(5, "folder-open-6.png");
            this.imageList1.Images.SetKeyName(6, "sign-up.png");
            // 
            // ForgotpassordCREATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerizedAccountingSystem.Properties.Resources.Capturejjj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 93);
            this.Controls.Add(this.retrieve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pas2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pas1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotpassordCREATE";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Password";
            this.Load += new System.EventHandler(this.ForgotpassordCREATE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox pas1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Pas2;
        internal System.Windows.Forms.Button retrieve;
        private System.Windows.Forms.ImageList imageList1;
    }
}