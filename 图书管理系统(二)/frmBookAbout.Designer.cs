namespace 图书管理系统_二_
{
    partial class frmBookAbout
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookAbout));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dupBroTime = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dupBookNumber = new System.Windows.Forms.DomainUpDown();
            this.butCheckbook = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butCheckReader = new System.Windows.Forms.Button();
            this.txtReader = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labQty = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labPublisher = new System.Windows.Forms.Label();
            this.labAuthor = new System.Windows.Forms.Label();
            this.labBookName = new System.Windows.Forms.Label();
            this.labBookID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labSex = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labBroNumber = new System.Windows.Forms.Label();
            this.labSatue = new System.Windows.Forms.Label();
            this.labReaderTypeID = new System.Windows.Forms.Label();
            this.labReaderName = new System.Windows.Forms.Label();
            this.labCardId = new System.Windows.Forms.Label();
            this.rdbForBorrow = new System.Windows.Forms.RadioButton();
            this.rdbBorrow = new System.Windows.Forms.RadioButton();
            this.rdbContuine = new System.Windows.Forms.RadioButton();
            this.rdbReback = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvHandleInfo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbExeNoQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbClearData = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.butSearch = new System.Windows.Forms.Button();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.cmbCheckList = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHandleInfo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dupBroTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dupBookNumber);
            this.panel1.Controls.Add(this.butCheckbook);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.butCheckReader);
            this.panel1.Controls.Add(this.txtReader);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rdbForBorrow);
            this.panel1.Controls.Add(this.rdbBorrow);
            this.panel1.Controls.Add(this.rdbContuine);
            this.panel1.Controls.Add(this.rdbReback);
            this.panel1.Location = new System.Drawing.Point(10, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 247);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "选择读者:";
            // 
            // dupBroTime
            // 
            this.dupBroTime.Items.Add("30");
            this.dupBroTime.Items.Add("60");
            this.dupBroTime.Items.Add("90");
            this.dupBroTime.Location = new System.Drawing.Point(674, 209);
            this.dupBroTime.Name = "dupBroTime";
            this.dupBroTime.Size = new System.Drawing.Size(50, 21);
            this.dupBroTime.TabIndex = 15;
            this.dupBroTime.Text = "90";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "借阅时长:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "借阅册数:";
            // 
            // dupBookNumber
            // 
            this.dupBookNumber.Items.Add("1");
            this.dupBookNumber.Items.Add("2");
            this.dupBookNumber.Items.Add("3");
            this.dupBookNumber.Items.Add("4");
            this.dupBookNumber.Location = new System.Drawing.Point(535, 209);
            this.dupBookNumber.Name = "dupBookNumber";
            this.dupBookNumber.Size = new System.Drawing.Size(52, 21);
            this.dupBookNumber.TabIndex = 12;
            this.dupBookNumber.Text = "1";
            // 
            // butCheckbook
            // 
            this.butCheckbook.Image = global::图书管理系统_二_.Properties.Resources.SearchButton;
            this.butCheckbook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCheckbook.Location = new System.Drawing.Point(704, 18);
            this.butCheckbook.Name = "butCheckbook";
            this.butCheckbook.Size = new System.Drawing.Size(56, 23);
            this.butCheckbook.TabIndex = 11;
            this.butCheckbook.Text = "  浏览";
            this.butCheckbook.UseVisualStyleBackColor = true;
            this.butCheckbook.Click += new System.EventHandler(this.butCheckbook_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(536, 19);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(159, 21);
            this.txtBookName.TabIndex = 10;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "选择书籍:";
            // 
            // butCheckReader
            // 
            this.butCheckReader.Image = global::图书管理系统_二_.Properties.Resources.SearchButton;
            this.butCheckReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCheckReader.Location = new System.Drawing.Point(362, 17);
            this.butCheckReader.Name = "butCheckReader";
            this.butCheckReader.Size = new System.Drawing.Size(56, 23);
            this.butCheckReader.TabIndex = 8;
            this.butCheckReader.Text = "   浏览";
            this.butCheckReader.UseVisualStyleBackColor = true;
            this.butCheckReader.Click += new System.EventHandler(this.butCheckReader_Click);
            // 
            // txtReader
            // 
            this.txtReader.Location = new System.Drawing.Point(207, 18);
            this.txtReader.Name = "txtReader";
            this.txtReader.Size = new System.Drawing.Size(146, 21);
            this.txtReader.TabIndex = 7;
            this.txtReader.TextChanged += new System.EventHandler(this.txtReader_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.labQty);
            this.panel3.Controls.Add(this.labPrice);
            this.panel3.Controls.Add(this.labPublisher);
            this.panel3.Controls.Add(this.labAuthor);
            this.panel3.Controls.Add(this.labBookName);
            this.panel3.Controls.Add(this.labBookID);
            this.panel3.Location = new System.Drawing.Point(465, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 145);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::图书管理系统_二_.Properties.Resources._default;
            this.pictureBox2.Location = new System.Drawing.Point(191, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "图书照片:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 11;
            this.label17.Text = "可借数量:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 10;
            this.label18.Text = "图书价格:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 9;
            this.label19.Text = "图书出版:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 8;
            this.label20.Text = "图书作者:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 7;
            this.label21.Text = "图书名称:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 6;
            this.label22.Text = "图书编号:";
            // 
            // labQty
            // 
            this.labQty.AutoSize = true;
            this.labQty.ForeColor = System.Drawing.Color.Red;
            this.labQty.Location = new System.Drawing.Point(84, 123);
            this.labQty.Name = "labQty";
            this.labQty.Size = new System.Drawing.Size(53, 12);
            this.labQty.TabIndex = 5;
            this.labQty.Text = "可借数量";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.ForeColor = System.Drawing.Color.Red;
            this.labPrice.Location = new System.Drawing.Point(84, 100);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(53, 12);
            this.labPrice.TabIndex = 4;
            this.labPrice.Text = "图书价格";
            // 
            // labPublisher
            // 
            this.labPublisher.AutoSize = true;
            this.labPublisher.ForeColor = System.Drawing.Color.Red;
            this.labPublisher.Location = new System.Drawing.Point(84, 77);
            this.labPublisher.Name = "labPublisher";
            this.labPublisher.Size = new System.Drawing.Size(53, 12);
            this.labPublisher.TabIndex = 3;
            this.labPublisher.Text = "图书出版";
            // 
            // labAuthor
            // 
            this.labAuthor.AutoSize = true;
            this.labAuthor.ForeColor = System.Drawing.Color.Red;
            this.labAuthor.Location = new System.Drawing.Point(84, 54);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(53, 12);
            this.labAuthor.TabIndex = 2;
            this.labAuthor.Text = "图书作者";
            // 
            // labBookName
            // 
            this.labBookName.AutoSize = true;
            this.labBookName.ForeColor = System.Drawing.Color.Red;
            this.labBookName.Location = new System.Drawing.Point(84, 31);
            this.labBookName.Name = "labBookName";
            this.labBookName.Size = new System.Drawing.Size(53, 12);
            this.labBookName.TabIndex = 1;
            this.labBookName.Text = "图书名称";
            // 
            // labBookID
            // 
            this.labBookID.AutoSize = true;
            this.labBookID.ForeColor = System.Drawing.Color.Red;
            this.labBookID.Location = new System.Drawing.Point(84, 8);
            this.labBookID.Name = "labBookID";
            this.labBookID.Size = new System.Drawing.Size(53, 12);
            this.labBookID.TabIndex = 0;
            this.labBookID.Text = "图书编号";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labSex);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.labBroNumber);
            this.panel2.Controls.Add(this.labSatue);
            this.panel2.Controls.Add(this.labReaderTypeID);
            this.panel2.Controls.Add(this.labReaderName);
            this.panel2.Controls.Add(this.labCardId);
            this.panel2.Location = new System.Drawing.Point(136, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 178);
            this.panel2.TabIndex = 4;
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.ForeColor = System.Drawing.Color.Red;
            this.labSex.Location = new System.Drawing.Point(80, 69);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(53, 12);
            this.labSex.TabIndex = 13;
            this.labSex.Text = "读者性别";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "读者姓别:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::图书管理系统_二_.Properties.Resources._default;
            this.pictureBox1.Location = new System.Drawing.Point(163, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "读者照片:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "已借资料:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "读者状态:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "读者类别:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 6;
            this.label14.Text = "读者姓名:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 5;
            this.label15.Text = "读者卡号:";
            // 
            // labBroNumber
            // 
            this.labBroNumber.AutoSize = true;
            this.labBroNumber.ForeColor = System.Drawing.Color.Red;
            this.labBroNumber.Location = new System.Drawing.Point(80, 150);
            this.labBroNumber.Name = "labBroNumber";
            this.labBroNumber.Size = new System.Drawing.Size(53, 12);
            this.labBroNumber.TabIndex = 4;
            this.labBroNumber.Text = "已借资料";
            // 
            // labSatue
            // 
            this.labSatue.AutoSize = true;
            this.labSatue.ForeColor = System.Drawing.Color.Red;
            this.labSatue.Location = new System.Drawing.Point(80, 123);
            this.labSatue.Name = "labSatue";
            this.labSatue.Size = new System.Drawing.Size(53, 12);
            this.labSatue.TabIndex = 3;
            this.labSatue.Text = "读者状态";
            // 
            // labReaderTypeID
            // 
            this.labReaderTypeID.AutoSize = true;
            this.labReaderTypeID.ForeColor = System.Drawing.Color.Red;
            this.labReaderTypeID.Location = new System.Drawing.Point(80, 96);
            this.labReaderTypeID.Name = "labReaderTypeID";
            this.labReaderTypeID.Size = new System.Drawing.Size(53, 12);
            this.labReaderTypeID.TabIndex = 2;
            this.labReaderTypeID.Text = "读者类别";
            // 
            // labReaderName
            // 
            this.labReaderName.AutoSize = true;
            this.labReaderName.ForeColor = System.Drawing.Color.Red;
            this.labReaderName.Location = new System.Drawing.Point(80, 42);
            this.labReaderName.Name = "labReaderName";
            this.labReaderName.Size = new System.Drawing.Size(53, 12);
            this.labReaderName.TabIndex = 1;
            this.labReaderName.Text = "读者姓名";
            // 
            // labCardId
            // 
            this.labCardId.AutoSize = true;
            this.labCardId.ForeColor = System.Drawing.Color.Red;
            this.labCardId.Location = new System.Drawing.Point(80, 15);
            this.labCardId.Name = "labCardId";
            this.labCardId.Size = new System.Drawing.Size(53, 12);
            this.labCardId.TabIndex = 0;
            this.labCardId.Text = "读者卡号";
            // 
            // rdbForBorrow
            // 
            this.rdbForBorrow.AutoSize = true;
            this.rdbForBorrow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbForBorrow.Location = new System.Drawing.Point(19, 200);
            this.rdbForBorrow.Name = "rdbForBorrow";
            this.rdbForBorrow.Size = new System.Drawing.Size(96, 16);
            this.rdbForBorrow.TabIndex = 3;
            this.rdbForBorrow.Text = "预借资料(&W)";
            this.rdbForBorrow.UseVisualStyleBackColor = true;
            this.rdbForBorrow.Click += new System.EventHandler(this.rdbForBorrow_Click);
            // 
            // rdbBorrow
            // 
            this.rdbBorrow.AutoSize = true;
            this.rdbBorrow.Checked = true;
            this.rdbBorrow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbBorrow.Location = new System.Drawing.Point(19, 65);
            this.rdbBorrow.Name = "rdbBorrow";
            this.rdbBorrow.Size = new System.Drawing.Size(96, 16);
            this.rdbBorrow.TabIndex = 0;
            this.rdbBorrow.TabStop = true;
            this.rdbBorrow.Text = "出借资料(&B)";
            this.rdbBorrow.UseVisualStyleBackColor = true;
            this.rdbBorrow.Click += new System.EventHandler(this.rdbBorrow_Click);
            // 
            // rdbContuine
            // 
            this.rdbContuine.AutoSize = true;
            this.rdbContuine.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbContuine.Location = new System.Drawing.Point(19, 155);
            this.rdbContuine.Name = "rdbContuine";
            this.rdbContuine.Size = new System.Drawing.Size(96, 16);
            this.rdbContuine.TabIndex = 2;
            this.rdbContuine.Text = "续借资料(&C)";
            this.rdbContuine.UseVisualStyleBackColor = true;
            this.rdbContuine.Click += new System.EventHandler(this.rdbContuine_Click);
            // 
            // rdbReback
            // 
            this.rdbReback.AutoSize = true;
            this.rdbReback.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbReback.Location = new System.Drawing.Point(19, 110);
            this.rdbReback.Name = "rdbReback";
            this.rdbReback.Size = new System.Drawing.Size(96, 16);
            this.rdbReback.TabIndex = 1;
            this.rdbReback.Text = "归还资料(&R)";
            this.rdbReback.UseVisualStyleBackColor = true;
            this.rdbReback.Click += new System.EventHandler(this.rdbReback_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgvHandleInfo);
            this.panel4.Location = new System.Drawing.Point(147, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(669, 150);
            this.panel4.TabIndex = 5;
            // 
            // dgvHandleInfo
            // 
            this.dgvHandleInfo.AllowUserToResizeRows = false;
            this.dgvHandleInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHandleInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHandleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHandleInfo.Location = new System.Drawing.Point(3, 3);
            this.dgvHandleInfo.MultiSelect = false;
            this.dgvHandleInfo.Name = "dgvHandleInfo";
            this.dgvHandleInfo.ReadOnly = true;
            this.dgvHandleInfo.RowTemplate.Height = 23;
            this.dgvHandleInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHandleInfo.Size = new System.Drawing.Size(661, 142);
            this.dgvHandleInfo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(14, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "今日操作列表:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOk,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(827, 35);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOk
            // 
            this.tsbOk.Image = ((System.Drawing.Image)(resources.GetObject("tsbOk.Image")));
            this.tsbOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOk.Name = "tsbOk";
            this.tsbOk.Size = new System.Drawing.Size(73, 32);
            this.tsbOk.Text = "执行操作";
            this.tsbOk.Click += new System.EventHandler(this.tsbOk_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(49, 32);
            this.tsbClose.Text = "退出";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tsbExeNoQuery
            // 
            this.tsbExeNoQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbExeNoQuery.Image")));
            this.tsbExeNoQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExeNoQuery.Name = "tsbExeNoQuery";
            this.tsbExeNoQuery.Size = new System.Drawing.Size(73, 22);
            this.tsbExeNoQuery.Text = "执行操作";
            // 
            // tsbClearData
            // 
            this.tsbClearData.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearData.Image")));
            this.tsbClearData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearData.Name = "tsbClearData";
            this.tsbClearData.Size = new System.Drawing.Size(73, 22);
            this.tsbClearData.Text = "清空数据";
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(73, 22);
            this.tsbExit.Text = "退出窗口";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.butSearch);
            this.panel5.Controls.Add(this.txtCondition);
            this.panel5.Controls.Add(this.cmbCheckList);
            this.panel5.Location = new System.Drawing.Point(10, 335);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(138, 150);
            this.panel5.TabIndex = 22;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(23, 98);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(83, 23);
            this.butSearch.TabIndex = 3;
            this.butSearch.Text = "开始搜索(&S)";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(19, 60);
            this.txtCondition.MaxLength = 20;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(96, 21);
            this.txtCondition.TabIndex = 2;
            this.txtCondition.TextChanged += new System.EventHandler(this.txtCondition_TextChanged);
            // 
            // cmbCheckList
            // 
            this.cmbCheckList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckList.FormattingEnabled = true;
            this.cmbCheckList.Items.AddRange(new object[] {
            "读者卡号",
            "图书编号",
            "读者姓名",
            "图书名称"});
            this.cmbCheckList.Location = new System.Drawing.Point(19, 22);
            this.cmbCheckList.Name = "cmbCheckList";
            this.cmbCheckList.Size = new System.Drawing.Size(96, 20);
            this.cmbCheckList.TabIndex = 1;
            // 
            // frmBookAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 510);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(835, 544);
            this.Name = "frmBookAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BookAbout";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmBookAbout_Paint);
            this.Resize += new System.EventHandler(this.frmBookAbout_Resize);
            this.Load += new System.EventHandler(this.frmBookAbout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHandleInfo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butCheckbook;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butCheckReader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label labBroNumber;
        public System.Windows.Forms.Label labSatue;
        public System.Windows.Forms.Label labReaderTypeID;
        public System.Windows.Forms.Label labReaderName;
        public System.Windows.Forms.Label labCardId;
        public System.Windows.Forms.Label labQty;
        public System.Windows.Forms.Label labPrice;
        public System.Windows.Forms.Label labPublisher;
        public System.Windows.Forms.Label labAuthor;
        public System.Windows.Forms.Label labBookName;
        public System.Windows.Forms.Label labBookID;
        public System.Windows.Forms.TextBox txtReader;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DomainUpDown dupBookNumber;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExeNoQuery;
        private System.Windows.Forms.ToolStripButton tsbClearData;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.RadioButton rdbForBorrow;
        public System.Windows.Forms.RadioButton rdbBorrow;
        public System.Windows.Forms.RadioButton rdbContuine;
        public System.Windows.Forms.RadioButton rdbReback;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DomainUpDown dupBroTime;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvHandleInfo;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.ComboBox cmbCheckList;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private System.Windows.Forms.ToolStripButton tsbClose;
    }
}