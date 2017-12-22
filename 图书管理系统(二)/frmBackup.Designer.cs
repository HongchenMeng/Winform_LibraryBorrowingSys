namespace 图书管理系统_二_
{
    partial class frmBackup
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
            this.txtBackupWay = new System.Windows.Forms.TextBox();
            this.butBackWay = new System.Windows.Forms.Button();
            this.butSure = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDataType = new System.Windows.Forms.ComboBox();
            this.butOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBackupinfo = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackupinfo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBackupWay
            // 
            this.txtBackupWay.Location = new System.Drawing.Point(106, 22);
            this.txtBackupWay.Name = "txtBackupWay";
            this.txtBackupWay.Size = new System.Drawing.Size(199, 21);
            this.txtBackupWay.TabIndex = 0;
            // 
            // butBackWay
            // 
            this.butBackWay.Location = new System.Drawing.Point(322, 22);
            this.butBackWay.Name = "butBackWay";
            this.butBackWay.Size = new System.Drawing.Size(61, 23);
            this.butBackWay.TabIndex = 2;
            this.butBackWay.Text = "浏览(&B)";
            this.butBackWay.UseVisualStyleBackColor = true;
            this.butBackWay.Click += new System.EventHandler(this.butBackWay_Click);
            // 
            // butSure
            // 
            this.butSure.Location = new System.Drawing.Point(12, 21);
            this.butSure.Name = "butSure";
            this.butSure.Size = new System.Drawing.Size(56, 23);
            this.butSure.TabIndex = 4;
            this.butSure.Text = "查看(&S)";
            this.butSure.UseVisualStyleBackColor = true;
            this.butSure.Click += new System.EventHandler(this.butSure_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(12, 59);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(56, 23);
            this.butExit.TabIndex = 5;
            this.butExit.Text = "退出(&C)";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDataType);
            this.groupBox1.Controls.Add(this.butOk);
            this.groupBox1.Controls.Add(this.butBackWay);
            this.groupBox1.Controls.Add(this.txtBackupWay);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库备份/还原";
            // 
            // cmbDataType
            // 
            this.cmbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.Items.AddRange(new object[] {
            "数据库备份",
            "数据库还原"});
            this.cmbDataType.Location = new System.Drawing.Point(9, 23);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(84, 20);
            this.cmbDataType.TabIndex = 4;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(393, 23);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(58, 22);
            this.butOk.TabIndex = 3;
            this.butOk.Text = "确定(&O)";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBackupinfo);
            this.groupBox2.Location = new System.Drawing.Point(6, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 166);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "备份日志";
            // 
            // dgvBackupinfo
            // 
            this.dgvBackupinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBackupinfo.Location = new System.Drawing.Point(5, 20);
            this.dgvBackupinfo.Name = "dgvBackupinfo";
            this.dgvBackupinfo.ReadOnly = true;
            this.dgvBackupinfo.RowTemplate.Height = 23;
            this.dgvBackupinfo.Size = new System.Drawing.Size(364, 140);
            this.dgvBackupinfo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butExit);
            this.groupBox3.Controls.Add(this.butSure);
            this.groupBox3.Location = new System.Drawing.Point(388, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(82, 95);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::图书管理系统_二_.Properties.Resources.保存;
            this.pictureBox1.Location = new System.Drawing.Point(389, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 254);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBackup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据备份/还原";
            this.Load += new System.EventHandler(this.frmbackup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackupinfo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBackupWay;
        private System.Windows.Forms.Button butBackWay;
        private System.Windows.Forms.Button butSure;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.ComboBox cmbDataType;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvBackupinfo;

    }
}