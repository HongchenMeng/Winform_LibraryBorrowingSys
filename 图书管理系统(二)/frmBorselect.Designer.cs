namespace 图书管理系统_二_
{
    partial class frmBorselect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorselect));
            this.butClose = new System.Windows.Forms.Button();
            this.butSelect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTimelist = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBorselect = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbReflesh = new System.Windows.Forms.ToolStripButton();
            this.tsbToExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorselect)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(550, 20);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(59, 23);
            this.butClose.TabIndex = 4;
            this.butClose.Text = "退出(&C)";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butSelect
            // 
            this.butSelect.Location = new System.Drawing.Point(472, 20);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(57, 23);
            this.butSelect.TabIndex = 3;
            this.butSelect.Text = "查询(&S)";
            this.butSelect.UseVisualStyleBackColor = true;
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 21);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者编号或姓名:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTimelist);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butClose);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.butSelect);
            this.groupBox1.Location = new System.Drawing.Point(7, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件查询";
            // 
            // cmbTimelist
            // 
            this.cmbTimelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimelist.FormattingEnabled = true;
            this.cmbTimelist.Items.AddRange(new object[] {
            "今天借阅",
            "所有借阅"});
            this.cmbTimelist.Location = new System.Drawing.Point(97, 20);
            this.cmbTimelist.Name = "cmbTimelist";
            this.cmbTimelist.Size = new System.Drawing.Size(104, 20);
            this.cmbTimelist.TabIndex = 6;
            this.cmbTimelist.SelectedIndexChanged += new System.EventHandler(this.cmbTimelist_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "借阅时间:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBorselect);
            this.groupBox2.Location = new System.Drawing.Point(8, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 270);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dgvBorselect
            // 
            this.dgvBorselect.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBorselect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBorselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorselect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorselect.Location = new System.Drawing.Point(3, 17);
            this.dgvBorselect.MultiSelect = false;
            this.dgvBorselect.Name = "dgvBorselect";
            this.dgvBorselect.ReadOnly = true;
            this.dgvBorselect.RowTemplate.Height = 23;
            this.dgvBorselect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorselect.Size = new System.Drawing.Size(634, 250);
            this.dgvBorselect.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReflesh,
            this.tsbToExcel,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(661, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbReflesh
            // 
            this.tsbReflesh.Image = ((System.Drawing.Image)(resources.GetObject("tsbReflesh.Image")));
            this.tsbReflesh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReflesh.Name = "tsbReflesh";
            this.tsbReflesh.Size = new System.Drawing.Size(49, 22);
            this.tsbReflesh.Text = "刷新";
            this.tsbReflesh.Click += new System.EventHandler(this.tsbReflesh_Click);
            // 
            // tsbToExcel
            // 
            this.tsbToExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbToExcel.Image")));
            this.tsbToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToExcel.Name = "tsbToExcel";
            this.tsbToExcel.Size = new System.Drawing.Size(49, 22);
            this.tsbToExcel.Text = "导出";
            this.tsbToExcel.Click += new System.EventHandler(this.tsbToExcel_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(49, 22);
            this.tsbExit.Text = "退出";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // frmBorselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 377);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBorselect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "借阅查询";
            this.Resize += new System.EventHandler(this.frmBorselect_Resize);
            this.Load += new System.EventHandler(this.frmBorselect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorselect)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBorselect;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbReflesh;
        private System.Windows.Forms.ToolStripButton tsbToExcel;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ComboBox cmbTimelist;
        private System.Windows.Forms.Label label2;

    }
}