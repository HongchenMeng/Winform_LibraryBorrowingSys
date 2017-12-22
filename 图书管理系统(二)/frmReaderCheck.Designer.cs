namespace 图书管理系统_二_
{
    partial class frmReaderCheck
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.butOk = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.dgvCheckUser = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者卡号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "读者姓名:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 11);
            this.textBox2.MaxLength = 8;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(300, 269);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 25);
            this.butOk.TabIndex = 4;
            this.butOk.Text = "选择(&O)";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butExit
            // 
            this.butExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butExit.Location = new System.Drawing.Point(397, 268);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 25);
            this.butExit.TabIndex = 5;
            this.butExit.Text = "取消(&C)";
            this.butExit.UseVisualStyleBackColor = true;
            // 
            // dgvCheckUser
            // 
            this.dgvCheckUser.AllowUserToResizeRows = false;
            this.dgvCheckUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCheckUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCheckUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckUser.Location = new System.Drawing.Point(7, 66);
            this.dgvCheckUser.MultiSelect = false;
            this.dgvCheckUser.Name = "dgvCheckUser";
            this.dgvCheckUser.ReadOnly = true;
            this.dgvCheckUser.RowTemplate.Height = 23;
            this.dgvCheckUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckUser.Size = new System.Drawing.Size(488, 196);
            this.dgvCheckUser.TabIndex = 6;
            this.dgvCheckUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckUser_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 48);
            this.panel1.TabIndex = 7;
            // 
            // frmReaderCheck
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butExit;
            this.ClientSize = new System.Drawing.Size(501, 303);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCheckUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReaderCheck";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读者列表选择";
            this.Load += new System.EventHandler(this.frmReaderCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.DataGridView dgvCheckUser;
        private System.Windows.Forms.Panel panel1;
    }
}