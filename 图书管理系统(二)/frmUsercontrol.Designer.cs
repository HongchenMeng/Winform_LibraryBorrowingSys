namespace 图书管理系统_二_
{
    partial class frmUsercontrol
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
            this.dgvUserselect = new System.Windows.Forms.DataGridView();
            this.butSuerAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRepass = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboxUsertype = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserselect)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserselect
            // 
            this.dgvUserselect.AllowUserToResizeRows = false;
            this.dgvUserselect.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUserselect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUserselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserselect.Location = new System.Drawing.Point(6, 15);
            this.dgvUserselect.MultiSelect = false;
            this.dgvUserselect.Name = "dgvUserselect";
            this.dgvUserselect.ReadOnly = true;
            this.dgvUserselect.RowTemplate.Height = 23;
            this.dgvUserselect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserselect.Size = new System.Drawing.Size(324, 190);
            this.dgvUserselect.TabIndex = 0;
            this.dgvUserselect.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserselect_CellDoubleClick);
            // 
            // butSuerAdd
            // 
            this.butSuerAdd.Location = new System.Drawing.Point(10, 84);
            this.butSuerAdd.Name = "butSuerAdd";
            this.butSuerAdd.Size = new System.Drawing.Size(81, 29);
            this.butSuerAdd.TabIndex = 1;
            this.butSuerAdd.Text = "确认添加(&S)";
            this.butSuerAdd.UseVisualStyleBackColor = true;
            this.butSuerAdd.Click += new System.EventHandler(this.butSuerAdd_Click_1);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(10, 119);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(81, 29);
            this.butDelete.TabIndex = 3;
            this.butDelete.Text = "确认删除(&D)";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(10, 154);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(81, 29);
            this.butExit.TabIndex = 4;
            this.butExit.Text = "确认退出(&E)";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(43, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "单击作部标头按钮,选定用户,然后对其进行编辑!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Controls.Add(this.butSuerAdd);
            this.groupBox1.Controls.Add(this.butExit);
            this.groupBox1.Controls.Add(this.butDelete);
            this.groupBox1.Location = new System.Drawing.Point(353, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 188);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(11, 49);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(81, 29);
            this.butCancel.TabIndex = 6;
            this.butCancel.Text = "取消添加(&C)";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click_1);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(10, 15);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(83, 28);
            this.butAdd.TabIndex = 5;
            this.butAdd.Text = "选择添加(&A)";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUserselect);
            this.groupBox2.Location = new System.Drawing.Point(6, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 211);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查看/删除用户";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "用户名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "确认密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "密码:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "用户类型:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(66, 17);
            this.txtUsername.MaxLength = 12;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(98, 21);
            this.txtUsername.TabIndex = 13;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(240, 18);
            this.txtPass.MaxLength = 12;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 21);
            this.txtPass.TabIndex = 14;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtRepass
            // 
            this.txtRepass.Location = new System.Drawing.Point(66, 48);
            this.txtRepass.MaxLength = 12;
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '*';
            this.txtRepass.Size = new System.Drawing.Size(98, 21);
            this.txtRepass.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboxUsertype);
            this.groupBox3.Controls.Add(this.txtRepass);
            this.groupBox3.Controls.Add(this.txtPass);
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 76);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加用户";
            // 
            // comboxUsertype
            // 
            this.comboxUsertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxUsertype.FormattingEnabled = true;
            this.comboxUsertype.Items.AddRange(new object[] {
            "普通用户",
            "超级用户"});
            this.comboxUsertype.Location = new System.Drawing.Point(241, 47);
            this.comboxUsertype.Name = "comboxUsertype";
            this.comboxUsertype.Size = new System.Drawing.Size(98, 20);
            this.comboxUsertype.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::图书管理系统_二_.Properties.Resources.用户设置;
            this.pictureBox1.Location = new System.Drawing.Point(358, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 323);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUsercontrol";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmUsercontrol_Paint);
            this.Load += new System.EventHandler(this.frmUsercontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserselect)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserselect;
        private System.Windows.Forms.Button butSuerAdd;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRepass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboxUsertype;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butCancel;
    }
}