namespace 图书管理系统_二_
{
    partial class frmBookManage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookManage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbChange = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbOut = new System.Windows.Forms.ToolStripButton();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.tsbReflsh = new System.Windows.Forms.ToolStripButton();
            this.tsbToexcel = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectOrder = new System.Windows.Forms.TextBox();
            this.butSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBookManger = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsbReflshe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExitform = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBookStatue = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvBorrowList = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookManger)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookStatue)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbChange,
            this.tsbDelete,
            this.tsbOut,
            this.tsbSelect,
            this.tsbReflsh,
            this.tsbToexcel,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(739, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(49, 22);
            this.tsbAdd.Text = "添加";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbChange
            // 
            this.tsbChange.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange.Image")));
            this.tsbChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange.Name = "tsbChange";
            this.tsbChange.Size = new System.Drawing.Size(49, 22);
            this.tsbChange.Text = "修改";
            this.tsbChange.Click += new System.EventHandler(this.tsbChange_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(49, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbOut
            // 
            this.tsbOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbOut.Image")));
            this.tsbOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOut.Name = "tsbOut";
            this.tsbOut.Size = new System.Drawing.Size(49, 22);
            this.tsbOut.Text = "下架";
            // 
            // tsbSelect
            // 
            this.tsbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelect.Image")));
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(49, 22);
            this.tsbSelect.Text = "筛选";
            // 
            // tsbReflsh
            // 
            this.tsbReflsh.Image = ((System.Drawing.Image)(resources.GetObject("tsbReflsh.Image")));
            this.tsbReflsh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReflsh.Name = "tsbReflsh";
            this.tsbReflsh.Size = new System.Drawing.Size(49, 22);
            this.tsbReflsh.Text = "刷新";
            this.tsbReflsh.Click += new System.EventHandler(this.tsbReflsh_Click);
            // 
            // tsbToexcel
            // 
            this.tsbToexcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbToexcel.Image")));
            this.tsbToexcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToexcel.Name = "tsbToexcel";
            this.tsbToexcel.Size = new System.Drawing.Size(49, 22);
            this.tsbToexcel.Text = "导出";
            this.tsbToexcel.ToolTipText = "导出到Excel表";
            this.tsbToexcel.Click += new System.EventHandler(this.tsbToexcel_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSelectOrder);
            this.groupBox1.Controls.Add(this.butSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSelect);
            this.groupBox1.Location = new System.Drawing.Point(7, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件查询";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "图书名称或作者或ISBN(&N):";
            // 
            // txtSelectOrder
            // 
            this.txtSelectOrder.Location = new System.Drawing.Point(503, 19);
            this.txtSelectOrder.Name = "txtSelectOrder";
            this.txtSelectOrder.Size = new System.Drawing.Size(153, 21);
            this.txtSelectOrder.TabIndex = 3;
            this.txtSelectOrder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // butSelect
            // 
            this.butSelect.Location = new System.Drawing.Point(246, 18);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(75, 23);
            this.butSelect.TabIndex = 2;
            this.butSelect.Text = "查找(&S)";
            this.butSelect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "查询条件(&A)";
            // 
            // cmbSelect
            // 
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "全部图书",
            "已借完的图书",
            "已被预借的图书",
            "已出借且超期的图书"});
            this.cmbSelect.Location = new System.Drawing.Point(97, 19);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(130, 20);
            this.cmbSelect.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBookManger);
            this.groupBox2.Location = new System.Drawing.Point(8, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 313);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书信息";
            // 
            // dgvBookManger
            // 
            this.dgvBookManger.AllowUserToResizeRows = false;
            this.dgvBookManger.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBookManger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBookManger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookManger.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBookManger.Location = new System.Drawing.Point(6, 20);
            this.dgvBookManger.MultiSelect = false;
            this.dgvBookManger.Name = "dgvBookManger";
            this.dgvBookManger.ReadOnly = true;
            this.dgvBookManger.RowTemplate.Height = 23;
            this.dgvBookManger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookManger.Size = new System.Drawing.Size(710, 287);
            this.dgvBookManger.TabIndex = 0;
            this.dgvBookManger.DoubleClick += new System.EventHandler(this.dgvBookManger_DoubleClick);
            this.dgvBookManger.Click += new System.EventHandler(this.dgvBookManger_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReflshe,
            this.toolStripSeparator1,
            this.tsmChange,
            this.toolStripSeparator2,
            this.tsmAdd,
            this.toolStripSeparator3,
            this.tsmDelete,
            this.toolStripSeparator4,
            this.tsbExitform});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 138);
            // 
            // tsbReflshe
            // 
            this.tsbReflshe.Image = global::图书管理系统_二_.Properties.Resources.desktopicon;
            this.tsbReflshe.Name = "tsbReflshe";
            this.tsbReflshe.Size = new System.Drawing.Size(136, 22);
            this.tsbReflshe.Text = "刷新列表(&E)";
            this.tsbReflshe.Click += new System.EventHandler(this.刷新列表EToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmChange
            // 
            this.tsmChange.Image = global::图书管理系统_二_.Properties.Resources.Assistant_Internet_Editing;
            this.tsmChange.Name = "tsmChange";
            this.tsmChange.Size = new System.Drawing.Size(136, 22);
            this.tsmChange.Text = "修改图书(&R)";
            this.tsmChange.Click += new System.EventHandler(this.tsmChange_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Image = global::图书管理系统_二_.Properties.Resources.File_Editing;
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(136, 22);
            this.tsmAdd.Text = "增加图书(&A)";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::图书管理系统_二_.Properties.Resources.Trash_Full;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(136, 22);
            this.tsmDelete.Text = "删除图书(&D)";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(133, 6);
            // 
            // tsbExitform
            // 
            this.tsbExitform.Image = global::图书管理系统_二_.Properties.Resources.删除_小_1;
            this.tsbExitform.Name = "tsbExitform";
            this.tsbExitform.Size = new System.Drawing.Size(136, 22);
            this.tsbExitform.Text = "退出窗口(&C)";
            this.tsbExitform.Click += new System.EventHandler(this.退出窗口ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 409);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 143);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvBookStatue);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 118);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "当前借阅状态";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBookStatue
            // 
            this.dgvBookStatue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookStatue.Location = new System.Drawing.Point(3, 6);
            this.dgvBookStatue.Name = "dgvBookStatue";
            this.dgvBookStatue.ReadOnly = true;
            this.dgvBookStatue.RowTemplate.Height = 23;
            this.dgvBookStatue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookStatue.Size = new System.Drawing.Size(708, 107);
            this.dgvBookStatue.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvBorrowList);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 118);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "借阅历史";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowList
            // 
            this.dgvBorrowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowList.Location = new System.Drawing.Point(-1, 1);
            this.dgvBorrowList.Name = "dgvBorrowList";
            this.dgvBorrowList.RowTemplate.Height = 23;
            this.dgvBorrowList.Size = new System.Drawing.Size(712, 115);
            this.dgvBorrowList.TabIndex = 2;
            // 
            // frmBookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 565);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBookManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "图书管理";
            this.Resize += new System.EventHandler(this.frmBookManage_Resize);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBookManage_KeyDown);
            this.Load += new System.EventHandler(this.frmBookManage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookManger)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookStatue)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbChange;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbOut;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.ToolStripButton tsbReflsh;
        private System.Windows.Forms.ToolStripButton tsbToexcel;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelectOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBookManger;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvBookStatue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmChange;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsbReflshe;
        private System.Windows.Forms.ToolStripMenuItem tsbExitform;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridView dgvBorrowList;
    }
}