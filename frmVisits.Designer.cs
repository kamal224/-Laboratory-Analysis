namespace Laboratory_Analysis
{
    partial class frmVisits
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisits));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comSearch = new System.Windows.Forms.ComboBox();
            this.DatePicSearch = new System.Windows.Forms.DateTimePicker();
            this.comSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DatePic = new System.Windows.Forms.DateTimePicker();
            this.comGander = new System.Windows.Forms.ComboBox();
            this.comDoctors = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataAGV = new System.Windows.Forms.DataGridView();
            this.AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comAnalysis = new System.Windows.Forms.ComboBox();
            this.comType = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSavePrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataAGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGV);
            this.groupBox1.Controls.Add(this.comSearch);
            this.groupBox1.Controls.Add(this.DatePicSearch);
            this.groupBox1.Controls.Add(this.comSearchBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(312, 699);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGV.BackgroundColor = System.Drawing.Color.White;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataGV.Location = new System.Drawing.Point(14, 107);
            this.DataGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.RowHeadersVisible = false;
            this.DataGV.RowTemplate.Height = 26;
            this.DataGV.Size = new System.Drawing.Size(290, 585);
            this.DataGV.TabIndex = 2;
            this.DataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "VID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Doctor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Gander";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "BYear";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // comSearch
            // 
            this.comSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comSearch.FormattingEnabled = true;
            this.comSearch.Location = new System.Drawing.Point(23, 60);
            this.comSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comSearch.Name = "comSearch";
            this.comSearch.Size = new System.Drawing.Size(267, 24);
            this.comSearch.TabIndex = 1;
            this.comSearch.SelectedIndexChanged += new System.EventHandler(this.comSearch_SelectedIndexChanged);
            // 
            // DatePicSearch
            // 
            this.DatePicSearch.Location = new System.Drawing.Point(23, 60);
            this.DatePicSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatePicSearch.Name = "DatePicSearch";
            this.DatePicSearch.Size = new System.Drawing.Size(267, 22);
            this.DatePicSearch.TabIndex = 4;
            this.DatePicSearch.ValueChanged += new System.EventHandler(this.DatePicSearch_ValueChanged);
            // 
            // comSearchBy
            // 
            this.comSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comSearchBy.FormattingEnabled = true;
            this.comSearchBy.Items.AddRange(new object[] {
            "Patient Name",
            "Visit Date",
            "Doctor Name"});
            this.comSearchBy.Location = new System.Drawing.Point(130, 21);
            this.comSearchBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comSearchBy.Name = "comSearchBy";
            this.comSearchBy.Size = new System.Drawing.Size(159, 24);
            this.comSearchBy.TabIndex = 0;
            this.comSearchBy.SelectedIndexChanged += new System.EventHandler(this.comSearchBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name :";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(151, 53);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFName.MaxLength = 15;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(228, 22);
            this.txtFName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name :";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(151, 85);
            this.txtLName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLName.MaxLength = 15;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(228, 22);
            this.txtLName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Midel Name :";
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(151, 117);
            this.txtMName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMName.MaxLength = 15;
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(228, 22);
            this.txtMName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "BYear :";
            // 
            // txtBYear
            // 
            this.txtBYear.Location = new System.Drawing.Point(151, 149);
            this.txtBYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBYear.MaxLength = 4;
            this.txtBYear.Name = "txtBYear";
            this.txtBYear.Size = new System.Drawing.Size(151, 22);
            this.txtBYear.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Gander :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Phone :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(151, 213);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.MaxLength = 12;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(228, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Doctor :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Visit Date :";
            // 
            // DatePic
            // 
            this.DatePic.Location = new System.Drawing.Point(151, 17);
            this.DatePic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatePic.Name = "DatePic";
            this.DatePic.Size = new System.Drawing.Size(266, 22);
            this.DatePic.TabIndex = 0;
            // 
            // comGander
            // 
            this.comGander.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGander.FormattingEnabled = true;
            this.comGander.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comGander.Location = new System.Drawing.Point(151, 180);
            this.comGander.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comGander.Name = "comGander";
            this.comGander.Size = new System.Drawing.Size(159, 24);
            this.comGander.TabIndex = 5;
            // 
            // comDoctors
            // 
            this.comDoctors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comDoctors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comDoctors.FormattingEnabled = true;
            this.comDoctors.Location = new System.Drawing.Point(151, 245);
            this.comDoctors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comDoctors.Name = "comDoctors";
            this.comDoctors.Size = new System.Drawing.Size(347, 24);
            this.comDoctors.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comDoctors);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comGander);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.DatePic);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtFName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.txtBYear);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMName);
            this.groupBox2.Location = new System.Drawing.Point(342, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(593, 302);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visit Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DataAGV);
            this.groupBox3.Controls.Add(this.comAnalysis);
            this.groupBox3.Controls.Add(this.comType);
            this.groupBox3.Location = new System.Drawing.Point(342, 324);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(593, 390);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Analysis Information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // DataAGV
            // 
            this.DataAGV.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.DataAGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataAGV.BackgroundColor = System.Drawing.Color.White;
            this.DataAGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AID,
            this.Column7,
            this.Column8});
            this.DataAGV.Location = new System.Drawing.Point(14, 98);
            this.DataAGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataAGV.Name = "DataAGV";
            this.DataAGV.RowHeadersVisible = false;
            this.DataAGV.Size = new System.Drawing.Size(534, 273);
            this.DataAGV.TabIndex = 2;
            // 
            // AID
            // 
            this.AID.HeaderText = "AID";
            this.AID.Name = "AID";
            this.AID.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Analysis Name";
            this.Column7.Name = "Column7";
            this.Column7.Width = 250;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Resulte";
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // comAnalysis
            // 
            this.comAnalysis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comAnalysis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comAnalysis.FormattingEnabled = true;
            this.comAnalysis.Location = new System.Drawing.Point(16, 65);
            this.comAnalysis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comAnalysis.Name = "comAnalysis";
            this.comAnalysis.Size = new System.Drawing.Size(567, 24);
            this.comAnalysis.TabIndex = 1;
            this.comAnalysis.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comAnalysis_KeyUp);
            // 
            // comType
            // 
            this.comType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comType.FormattingEnabled = true;
            this.comType.Location = new System.Drawing.Point(16, 34);
            this.comType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(286, 24);
            this.comType.TabIndex = 0;
            this.comType.SelectedIndexChanged += new System.EventHandler(this.comType_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnOk.Image = global::Laboratory_Analysis.Properties.Resources.save;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(950, 472);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(218, 55);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Save Data";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorPro
            // 
            this.errorPro.ContainerControl = this;
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSavePrint.Image = global::Laboratory_Analysis.Properties.Resources.save;
            this.btnSavePrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePrint.Location = new System.Drawing.Point(950, 537);
            this.btnSavePrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.Size = new System.Drawing.Size(218, 61);
            this.btnSavePrint.TabIndex = 2;
            this.btnSavePrint.Text = "Save && Print";
            this.btnSavePrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSavePrint.UseVisualStyleBackColor = true;
            this.btnSavePrint.Click += new System.EventHandler(this.btnSavePrint_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(942, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 378);
            this.panel1.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 210);
            this.label10.TabIndex = 22;
            this.label10.Tag = "";
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(55, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 29);
            this.label11.TabIndex = 21;
            this.label11.Text = "Visits";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory_Analysis.Properties.Resources.PatientFile;
            this.pictureBox1.Location = new System.Drawing.Point(13, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnMove
            // 
            this.btnMove.BackgroundImage = global::Laboratory_Analysis.Properties.Resources.Move;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Location = new System.Drawing.Point(1151, 51);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(37, 32);
            this.btnMove.TabIndex = 27;
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMove_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Laboratory_Analysis.Properties.Resources.Exit;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1151, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 32);
            this.btnExit.TabIndex = 26;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1200, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSavePrint);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisits";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visits";
            this.Load += new System.EventHandler(this.frmVisits_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataAGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comSearch;
        private System.Windows.Forms.DateTimePicker DatePicSearch;
        private System.Windows.Forms.ComboBox comSearchBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DatePic;
        private System.Windows.Forms.ComboBox comGander;
        private System.Windows.Forms.ComboBox comDoctors;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DataAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox comAnalysis;
        private System.Windows.Forms.ComboBox comType;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorPro;
        private System.Windows.Forms.Button btnSavePrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnExit;
    }
}