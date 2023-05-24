namespace ComputerizedAccountingSystem
{
    partial class UserAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            this.Password = new System.Windows.Forms.TextBox();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.userstatus = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.usertype = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SecrtAns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.verifypassword = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.User_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.beta_button = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SecQues = new System.Windows.Forms.ComboBox();
            this.Edit = new System.Windows.Forms.Button();
            this.Changeuserrights = new System.Windows.Forms.Button();
            this.create_save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tooltipclose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.LogIn_MinimizeBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.yearlevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerizedaccountingsystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearlevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerizedaccountingsystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Window;
            this.Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Password.Enabled = false;
            this.Password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Password.Location = new System.Drawing.Point(163, 379);
            this.Password.MaxLength = 15;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '@';
            this.Password.Size = new System.Drawing.Size(270, 23);
            this.Password.TabIndex = 249;
            this.Password.UseSystemPasswordChar = true;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // Middlename
            // 
            this.Middlename.BackColor = System.Drawing.SystemColors.Window;
            this.Middlename.Enabled = false;
            this.Middlename.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Middlename.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Middlename.Location = new System.Drawing.Point(163, 234);
            this.Middlename.MaxLength = 45;
            this.Middlename.Name = "Middlename";
            this.Middlename.Size = new System.Drawing.Size(270, 23);
            this.Middlename.TabIndex = 244;
            this.Middlename.Leave += new System.EventHandler(this.Middlename_Leave);
            // 
            // userstatus
            // 
            this.userstatus.BackColor = System.Drawing.SystemColors.Window;
            this.userstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userstatus.Enabled = false;
            this.userstatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userstatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.userstatus.Location = new System.Drawing.Point(163, 473);
            this.userstatus.Name = "userstatus";
            this.userstatus.Size = new System.Drawing.Size(270, 24);
            this.userstatus.TabIndex = 264;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 473);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 23);
            this.label12.TabIndex = 263;
            this.label12.Text = "User Status";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usertype
            // 
            this.usertype.BackColor = System.Drawing.SystemColors.Window;
            this.usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usertype.Enabled = false;
            this.usertype.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype.Items.AddRange(new object[] {
            "Cashier",
            "Assistant"});
            this.usertype.Location = new System.Drawing.Point(163, 450);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(270, 24);
            this.usertype.TabIndex = 262;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 23);
            this.label11.TabIndex = 261;
            this.label11.Text = "User Type";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.ImageIndex = 7;
            this.button1.Location = new System.Drawing.Point(28, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(418, 66);
            this.button1.TabIndex = 260;
            this.button1.Text = " ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(98, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(347, 16);
            this.label10.TabIndex = 258;
            this.label10.Text = " ___________________________________________________";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.Window;
            this.Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Username.Enabled = false;
            this.Username.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Username.Location = new System.Drawing.Point(163, 356);
            this.Username.MaxLength = 15;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(270, 23);
            this.Username.TabIndex = 253;
            this.Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_KeyDown);
            this.Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_KeyPress);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 252;
            this.label7.Text = "User Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 250;
            this.label6.Text = "Verify Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 248;
            this.label5.Text = "Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecrtAns
            // 
            this.SecrtAns.BackColor = System.Drawing.SystemColors.Window;
            this.SecrtAns.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.SecrtAns.Enabled = false;
            this.SecrtAns.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecrtAns.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SecrtAns.Location = new System.Drawing.Point(163, 307);
            this.SecrtAns.MaxLength = 15;
            this.SecrtAns.Name = "SecrtAns";
            this.SecrtAns.Size = new System.Drawing.Size(270, 23);
            this.SecrtAns.TabIndex = 247;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 246;
            this.label4.Text = "Secret Answer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 245;
            this.label1.Text = "Secret Question";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 243;
            this.label3.Text = "Middle Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Firstname
            // 
            this.Firstname.BackColor = System.Drawing.SystemColors.Window;
            this.Firstname.Enabled = false;
            this.Firstname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Firstname.Location = new System.Drawing.Point(163, 211);
            this.Firstname.MaxLength = 45;
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(270, 23);
            this.Firstname.TabIndex = 242;
            this.Firstname.Leave += new System.EventHandler(this.Firstname_Leave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 241;
            this.label2.Text = "First Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lastname
            // 
            this.Lastname.BackColor = System.Drawing.SystemColors.Window;
            this.Lastname.Enabled = false;
            this.Lastname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Lastname.Location = new System.Drawing.Point(163, 188);
            this.Lastname.MaxLength = 45;
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(270, 23);
            this.Lastname.TabIndex = 240;
            this.Lastname.Leave += new System.EventHandler(this.Lastname_Leave);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 23);
            this.label8.TabIndex = 239;
            this.label8.Text = "Last Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button2.Location = new System.Drawing.Point(28, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(418, 94);
            this.button2.TabIndex = 254;
            this.button2.Text = " ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button5.ImageIndex = 7;
            this.button5.Location = new System.Drawing.Point(28, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(418, 64);
            this.button5.TabIndex = 255;
            this.button5.Text = " ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // verifypassword
            // 
            this.verifypassword.BackColor = System.Drawing.SystemColors.Window;
            this.verifypassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.verifypassword.Enabled = false;
            this.verifypassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifypassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.verifypassword.Location = new System.Drawing.Point(163, 402);
            this.verifypassword.MaxLength = 15;
            this.verifypassword.Name = "verifypassword";
            this.verifypassword.PasswordChar = '@';
            this.verifypassword.Size = new System.Drawing.Size(270, 23);
            this.verifypassword.TabIndex = 251;
            this.verifypassword.UseSystemPasswordChar = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Cursor = System.Windows.Forms.Cursors.Default;
            this.button9.Enabled = false;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button9.ImageIndex = 7;
            this.button9.Location = new System.Drawing.Point(20, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(435, 440);
            this.button9.TabIndex = 236;
            this.button9.Text = " ";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
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
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(495, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(587, 23);
            this.label13.TabIndex = 268;
            this.label13.Text = "List of User";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // User_listView
            // 
            this.User_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.User_listView.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_listView.FullRowSelect = true;
            this.User_listView.GridLines = true;
            this.User_listView.Location = new System.Drawing.Point(495, 148);
            this.User_listView.MultiSelect = false;
            this.User_listView.Name = "User_listView";
            this.User_listView.Size = new System.Drawing.Size(587, 359);
            this.User_listView.TabIndex = 266;
            this.User_listView.UseCompatibleStateImageBehavior = false;
            this.User_listView.View = System.Windows.Forms.View.Details;
            this.User_listView.SelectedIndexChanged += new System.EventHandler(this.User_listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "User type";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "User status";
            this.columnHeader5.Width = 161;
            // 
            // beta_button
            // 
            this.beta_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.beta_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beta_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.beta_button.Enabled = false;
            this.beta_button.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beta_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.beta_button.ImageIndex = 7;
            this.beta_button.Location = new System.Drawing.Point(476, 109);
            this.beta_button.Name = "beta_button";
            this.beta_button.Size = new System.Drawing.Size(621, 440);
            this.beta_button.TabIndex = 265;
            this.beta_button.Text = " ";
            this.beta_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.beta_button.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Menu;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button6.ImageIndex = 7;
            this.button6.Location = new System.Drawing.Point(28, 346);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(418, 89);
            this.button6.TabIndex = 270;
            this.button6.Text = " ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // SecQues
            // 
            this.SecQues.BackColor = System.Drawing.SystemColors.Window;
            this.SecQues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecQues.Enabled = false;
            this.SecQues.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecQues.Items.AddRange(new object[] {
            "What is your favorate food?",
            "What is your favorate pet?",
            "What is your name?",
            "What is your Lastname?",
            "What is Love?",
            "What is the name of your boss?.",
            "What is your favorate drinks?",
            "What is your favarate hangout?"});
            this.SecQues.Location = new System.Drawing.Point(163, 284);
            this.SecQues.Name = "SecQues";
            this.SecQues.Size = new System.Drawing.Size(270, 24);
            this.SecQues.TabIndex = 271;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.Enabled = false;
            this.Edit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Edit.ImageKey = "edit-11.png";
            this.Edit.ImageList = this.imageList1;
            this.Edit.Location = new System.Drawing.Point(831, 513);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 24);
            this.Edit.TabIndex = 269;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Changeuserrights
            // 
            this.Changeuserrights.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Changeuserrights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Changeuserrights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Changeuserrights.Enabled = false;
            this.Changeuserrights.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changeuserrights.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Changeuserrights.ImageKey = "sign-up.png";
            this.Changeuserrights.ImageList = this.imageList1;
            this.Changeuserrights.Location = new System.Drawing.Point(931, 513);
            this.Changeuserrights.Name = "Changeuserrights";
            this.Changeuserrights.Size = new System.Drawing.Size(151, 24);
            this.Changeuserrights.TabIndex = 267;
            this.Changeuserrights.Text = "Change User Rights";
            this.Changeuserrights.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Changeuserrights.UseVisualStyleBackColor = true;
            this.Changeuserrights.Click += new System.EventHandler(this.Changeuserrights_Click);
            // 
            // create_save
            // 
            this.create_save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.create_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.create_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_save.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.create_save.ImageIndex = 0;
            this.create_save.ImageList = this.imageList1;
            this.create_save.Location = new System.Drawing.Point(252, 513);
            this.create_save.Name = "create_save";
            this.create_save.Size = new System.Drawing.Size(94, 24);
            this.create_save.TabIndex = 238;
            this.create_save.Text = "Create";
            this.create_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.create_save.UseVisualStyleBackColor = true;
            this.create_save.Click += new System.EventHandler(this.create_save_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cancel.ImageKey = "button-cancel-2.png";
            this.cancel.ImageList = this.imageList1;
            this.cancel.Location = new System.Drawing.Point(352, 513);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 24);
            this.cancel.TabIndex = 237;
            this.cancel.Text = "Cancel";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 104);
            this.panel1.TabIndex = 235;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::ComputerizedAccountingSystem.Properties.Resources.Useraccount;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(126, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 42);
            this.pictureBox2.TabIndex = 229;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ComputerizedAccountingSystem.Properties.Resources.Login_Icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 73);
            this.pictureBox1.TabIndex = 228;
            this.pictureBox1.TabStop = false;
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
            this.LogIn_MinimizeBttn,
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(1120, 25);
            this.toolStrip2.TabIndex = 234;
            this.toolStrip2.Text = "User Accounts";
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
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 22);
            this.toolStripLabel1.Text = "User Accounts";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::ComputerizedAccountingSystem.Properties.Resources.Login_Icon;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(34, 114);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 56);
            this.pictureBox4.TabIndex = 259;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(101, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 31);
            this.label9.TabIndex = 257;
            this.label9.Text = "   Always remember your Username and Password,\r\n this will strictly confidential " +
                "for the user only.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(453, 20);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 23);
            this.textBox1.TabIndex = 272;
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SecQues);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.verifypassword);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Changeuserrights);
            this.Controls.Add(this.User_listView);
            this.Controls.Add(this.beta_button);
            this.Controls.Add(this.Middlename);
            this.Controls.Add(this.userstatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.usertype);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SecrtAns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.create_save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "UserAccount";
            this.Size = new System.Drawing.Size(1120, 654);
            this.Load += new System.EventHandler(this.UserAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearlevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerizedaccountingsystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ToolStrip toolStrip2;
        internal System.Windows.Forms.ToolStripLabel toolStripLabel3;
        public System.Windows.Forms.ToolStripButton tooltipclose;
        internal System.Windows.Forms.ToolStripButton toolStripButton5;
        internal System.Windows.Forms.ToolStripButton LogIn_MinimizeBttn;
        public System.Windows.Forms.TextBox Password;
        public System.Windows.Forms.TextBox Middlename;
        public System.Windows.Forms.ComboBox userstatus;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox usertype;
        public System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox Username;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox SecrtAns;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Firstname;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Lastname;
        public System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Button create_save;
        private System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.Button cancel;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button5;
        public System.Windows.Forms.TextBox verifypassword;
        internal System.Windows.Forms.Button button9;
        internal System.Windows.Forms.Button Edit;
        public System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Button Changeuserrights;
        public System.Windows.Forms.ListView User_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        internal System.Windows.Forms.Button beta_button;
        internal System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource yearlevelBindingSource; 
        private System.Windows.Forms.BindingSource computerizedaccountingsystemDataSetBindingSource;
        public System.Windows.Forms.ComboBox SecQues;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textBox1;

    }
}
