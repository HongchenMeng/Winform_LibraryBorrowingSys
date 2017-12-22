namespace 图书管理系统_二_
{
    partial class frmChangepass
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldpass = new System.Windows.Forms.TextBox();
            this.txtNewpass = new System.Windows.Forms.TextBox();
            this.txtRepass = new System.Windows.Forms.TextBox();
            this.butClear = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入您当前密码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "请输入新的密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "再次确认新密码:";
            // 
            // txtOldpass
            // 
            this.txtOldpass.Location = new System.Drawing.Point(129, 47);
            this.txtOldpass.Name = "txtOldpass";
            this.txtOldpass.PasswordChar = '*';
            this.txtOldpass.Size = new System.Drawing.Size(145, 21);
            this.txtOldpass.TabIndex = 3;
            // 
            // txtNewpass
            // 
            this.txtNewpass.Location = new System.Drawing.Point(129, 78);
            this.txtNewpass.Name = "txtNewpass";
            this.txtNewpass.PasswordChar = '*';
            this.txtNewpass.Size = new System.Drawing.Size(145, 21);
            this.txtNewpass.TabIndex = 4;
            // 
            // txtRepass
            // 
            this.txtRepass.Location = new System.Drawing.Point(129, 109);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '*';
            this.txtRepass.Size = new System.Drawing.Size(145, 21);
            this.txtRepass.TabIndex = 5;
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(129, 158);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(59, 25);
            this.butClear.TabIndex = 6;
            this.butClear.Text = "重置(&C)";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(212, 158);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(62, 25);
            this.butOk.TabIndex = 7;
            this.butOk.Text = "确定(&O)";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::图书管理系统_二_.Properties.Resources.更改密码;
            this.pictureBox1.Location = new System.Drawing.Point(19, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(66, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "* 密码长度设置在5-12位之间!";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 212);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // frmChangepass
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 229);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.txtNewpass);
            this.Controls.Add(this.txtOldpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangepass";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.frmChangepass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldpass;
        private System.Windows.Forms.TextBox txtNewpass;
        private System.Windows.Forms.TextBox txtRepass;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}