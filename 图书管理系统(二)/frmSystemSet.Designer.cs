namespace 图书管理系统_二_
{
    partial class frmSystemSet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dudStudentNuber = new System.Windows.Forms.DomainUpDown();
            this.dudTeacherNumber = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSetMoney = new System.Windows.Forms.TextBox();
            this.cbxIsGo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butClose = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSetReserDay = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSetReserDay);
            this.groupBox1.Controls.Add(this.dudStudentNuber);
            this.groupBox1.Controls.Add(this.dudTeacherNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSetMoney);
            this.groupBox1.Controls.Add(this.cbxIsGo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(114, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // dudStudentNuber
            // 
            this.dudStudentNuber.Items.Add("1");
            this.dudStudentNuber.Items.Add("2");
            this.dudStudentNuber.Items.Add("3");
            this.dudStudentNuber.Items.Add("4");
            this.dudStudentNuber.Items.Add("5");
            this.dudStudentNuber.Items.Add("6");
            this.dudStudentNuber.Items.Add("7");
            this.dudStudentNuber.Items.Add("8");
            this.dudStudentNuber.Location = new System.Drawing.Point(228, 24);
            this.dudStudentNuber.Name = "dudStudentNuber";
            this.dudStudentNuber.Size = new System.Drawing.Size(46, 21);
            this.dudStudentNuber.TabIndex = 11;
            this.dudStudentNuber.Text = "4";
            // 
            // dudTeacherNumber
            // 
            this.dudTeacherNumber.Items.Add("4");
            this.dudTeacherNumber.Items.Add("5");
            this.dudTeacherNumber.Items.Add("6");
            this.dudTeacherNumber.Items.Add("7");
            this.dudTeacherNumber.Items.Add("8");
            this.dudTeacherNumber.Items.Add("9");
            this.dudTeacherNumber.Items.Add("10");
            this.dudTeacherNumber.Location = new System.Drawing.Point(171, 24);
            this.dudTeacherNumber.Name = "dudTeacherNumber";
            this.dudTeacherNumber.Size = new System.Drawing.Size(44, 21);
            this.dudTeacherNumber.TabIndex = 10;
            this.dudTeacherNumber.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "教师\\学生可借图书数目:";
            // 
            // txtSetMoney
            // 
            this.txtSetMoney.Location = new System.Drawing.Point(227, 59);
            this.txtSetMoney.MaxLength = 5;
            this.txtSetMoney.Name = "txtSetMoney";
            this.txtSetMoney.Size = new System.Drawing.Size(46, 21);
            this.txtSetMoney.TabIndex = 5;
            this.txtSetMoney.Text = "0.2";
            // 
            // cbxIsGo
            // 
            this.cbxIsGo.AutoSize = true;
            this.cbxIsGo.Location = new System.Drawing.Point(21, 129);
            this.cbxIsGo.Name = "cbxIsGo";
            this.cbxIsGo.Size = new System.Drawing.Size(246, 16);
            this.cbxIsGo.TabIndex = 2;
            this.cbxIsGo.Text = " 每次启动本系统时,自动打开逾期列表(D)";
            this.cbxIsGo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "读者预借资料有效期 (单位-天)(&D):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "还书每逾期一天罚款 (单位-元)(&M):";
            // 
            // butClose
            // 
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butClose.Location = new System.Drawing.Point(186, 20);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(64, 23);
            this.butClose.TabIndex = 4;
            this.butClose.Text = "取消(&C)";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(93, 20);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(64, 23);
            this.butOk.TabIndex = 3;
            this.butOk.Text = "确定(&O)";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::图书管理系统_二_.Properties.Resources.set;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butOk);
            this.groupBox2.Controls.Add(this.butClose);
            this.groupBox2.Location = new System.Drawing.Point(114, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtSetReserDay
            // 
            this.txtSetReserDay.Location = new System.Drawing.Point(228, 94);
            this.txtSetReserDay.Name = "txtSetReserDay";
            this.txtSetReserDay.Size = new System.Drawing.Size(45, 21);
            this.txtSetReserDay.TabIndex = 12;
            this.txtSetReserDay.Text = "15";
            // 
            // frmSystemSet
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butClose;
            this.ClientSize = new System.Drawing.Size(421, 248);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystemSet";
            this.ShowInTaskbar = false;
            this.Text = "参数设置";
            this.Load += new System.EventHandler(this.frmSystemSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSetMoney;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.CheckBox cbxIsGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DomainUpDown dudStudentNuber;
        private System.Windows.Forms.DomainUpDown dudTeacherNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSetReserDay;
    }
}