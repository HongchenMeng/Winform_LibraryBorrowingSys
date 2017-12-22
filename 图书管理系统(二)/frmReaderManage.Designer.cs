namespace 图书管理系统_二_
{
    partial class frmReaderManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReaderManage));
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butExit = new System.Windows.Forms.Button();
            this.butAll = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfident = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUserManage = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmReflesh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txmChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tabpage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBorInfo = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvBorrowlist = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tspAdd = new System.Windows.Forms.ToolStripButton();
            this.tspChange = new System.Windows.Forms.ToolStripButton();
            this.tspDelete = new System.Windows.Forms.ToolStripButton();
            this.tspCheck = new System.Windows.Forms.ToolStripButton();
            this.tspReflesh = new System.Windows.Forms.ToolStripButton();
            this.tspExcle = new System.Windows.Forms.ToolStripButton();
            this.tspExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbReaderAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbReaderChange = new System.Windows.Forms.ToolStripButton();
            this.tsbReaderDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbReaderCheck = new System.Windows.Forms.ToolStripButton();
            this.tsbReaderReflesh = new System.Windows.Forms.ToolStripButton();
            this.tsbReaderToExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbReaderExit = new System.Windows.Forms.ToolStripButton();
            this.tsp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserManage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabpage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorInfo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowlist)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmAdd
            // 
            this.tsmAdd.Image = global::图书管理系统_二_.Properties.Resources.File_Editing;
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(136, 22);
            this.tsmAdd.Text = "增加读者(&A)";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butExit);
            this.groupBox1.Controls.Add(this.butAll);
            this.groupBox1.Controls.Add(this.butOk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtConfident);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件查询";
            // 
            // butExit
            // 
            this.butExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butExit.Location = new System.Drawing.Point(577, 17);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(57, 23);
            this.butExit.TabIndex = 6;
            this.butExit.Text = "退出(&C)";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butAll
            // 
            this.butAll.Location = new System.Drawing.Point(491, 17);
            this.butAll.Name = "butAll";
            this.butAll.Size = new System.Drawing.Size(57, 23);
            this.butAll.TabIndex = 5;
            this.butAll.Text = "全显(&A)";
            this.butAll.UseVisualStyleBackColor = true;
            this.butAll.Click += new System.EventHandler(this.butAll_Click);
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(405, 17);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(57, 23);
            this.butOk.TabIndex = 4;
            this.butOk.Text = "查找(&S)";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 3;
            // 
            // txtConfident
            // 
            this.txtConfident.Location = new System.Drawing.Point(182, 17);
            this.txtConfident.Name = "txtConfident";
            this.txtConfident.Size = new System.Drawing.Size(180, 21);
            this.txtConfident.TabIndex = 1;
            this.txtConfident.TextChanged += new System.EventHandler(this.txtConfident_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入借书证号或读者姓名(&C):";
            // 
            // dgvUserManage
            // 
            this.dgvUserManage.AllowUserToResizeRows = false;
            this.dgvUserManage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUserManage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUserManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserManage.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUserManage.Location = new System.Drawing.Point(6, 20);
            this.dgvUserManage.MultiSelect = false;
            this.dgvUserManage.Name = "dgvUserManage";
            this.dgvUserManage.ReadOnly = true;
            this.dgvUserManage.RowTemplate.Height = 23;
            this.dgvUserManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserManage.Size = new System.Drawing.Size(720, 309);
            this.dgvUserManage.TabIndex = 2;
            this.dgvUserManage.DoubleClick += new System.EventHandler(this.dgvUserManage_DoubleClick);
            this.dgvUserManage.Click += new System.EventHandler(this.dgvUserManage_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReflesh,
            this.toolStripSeparator1,
            this.txmChange,
            this.toolStripSeparator2,
            this.tsmAdd,
            this.toolStripMenuItem2,
            this.tsmDelete,
            this.toolStripSeparator3,
            this.tsmClose});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 138);
            // 
            // tsmReflesh
            // 
            this.tsmReflesh.Image = global::图书管理系统_二_.Properties.Resources.desktopicon;
            this.tsmReflesh.Name = "tsmReflesh";
            this.tsmReflesh.Size = new System.Drawing.Size(136, 22);
            this.tsmReflesh.Text = "刷新列表(&E)";
            this.tsmReflesh.Click += new System.EventHandler(this.tsmReflesh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // txmChange
            // 
            this.txmChange.Image = global::图书管理系统_二_.Properties.Resources.Assistant_Internet_Editing;
            this.txmChange.Name = "txmChange";
            this.txmChange.Size = new System.Drawing.Size(136, 22);
            this.txmChange.Tag = "";
            this.txmChange.Text = "修改读者(&R)";
            this.txmChange.Click += new System.EventHandler(this.txmChange_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::图书管理系统_二_.Properties.Resources.Trash_Full;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(136, 22);
            this.tsmDelete.Text = "删除读者(&D)";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmClose
            // 
            this.tsmClose.Image = global::图书管理系统_二_.Properties.Resources.删除_小_1;
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(136, 22);
            this.tsmClose.Text = "退出窗口(&C)";
            this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // tabpage
            // 
            this.tabpage.Controls.Add(this.tabPage1);
            this.tabpage.Controls.Add(this.tabPage2);
            this.tabpage.Location = new System.Drawing.Point(8, 432);
            this.tabpage.Name = "tabpage";
            this.tabpage.SelectedIndex = 0;
            this.tabpage.Size = new System.Drawing.Size(733, 160);
            this.tabpage.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvBorInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 135);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "当前借阅状态";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBorInfo
            // 
            this.dgvBorInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorInfo.Location = new System.Drawing.Point(1, 1);
            this.dgvBorInfo.Name = "dgvBorInfo";
            this.dgvBorInfo.ReadOnly = true;
            this.dgvBorInfo.RowTemplate.Height = 23;
            this.dgvBorInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorInfo.Size = new System.Drawing.Size(723, 144);
            this.dgvBorInfo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvBorrowlist);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(725, 135);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "借阅历史";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowlist
            // 
            this.dgvBorrowlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowlist.Location = new System.Drawing.Point(0, 2);
            this.dgvBorrowlist.Name = "dgvBorrowlist";
            this.dgvBorrowlist.RowTemplate.Height = 23;
            this.dgvBorrowlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowlist.Size = new System.Drawing.Size(727, 145);
            this.dgvBorrowlist.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUserManage);
            this.groupBox2.Location = new System.Drawing.Point(6, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 335);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读者信息";
            // 
            // tspAdd
            // 
            this.tspAdd.Name = "tspAdd";
            this.tspAdd.Size = new System.Drawing.Size(23, 23);
            // 
            // tspChange
            // 
            this.tspChange.Name = "tspChange";
            this.tspChange.Size = new System.Drawing.Size(23, 23);
            // 
            // tspDelete
            // 
            this.tspDelete.Name = "tspDelete";
            this.tspDelete.Size = new System.Drawing.Size(23, 23);
            // 
            // tspCheck
            // 
            this.tspCheck.Name = "tspCheck";
            this.tspCheck.Size = new System.Drawing.Size(23, 23);
            // 
            // tspReflesh
            // 
            this.tspReflesh.Name = "tspReflesh";
            this.tspReflesh.Size = new System.Drawing.Size(23, 23);
            // 
            // tspExcle
            // 
            this.tspExcle.Name = "tspExcle";
            this.tspExcle.Size = new System.Drawing.Size(23, 23);
            // 
            // tspExit
            // 
            this.tspExit.Name = "tspExit";
            this.tspExit.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReaderAdd,
            this.tsbReaderChange,
            this.tsbReaderDelete,
            this.tsbReaderCheck,
            this.tsbReaderReflesh,
            this.tsbReaderToExcel,
            this.tsbReaderExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(749, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // tsbReaderAdd
            // 
            this.tsbReaderAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbReaderAdd.Image")));
            this.tsbReaderAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReaderAdd.Name = "tsbReaderAdd";
            this.tsbReaderAdd.Size = new System.Drawing.Size(49, 22);
            this.tsbReaderAdd.Text = "添加";
            this.tsbReaderAdd.Click += new System.EventHandler(this.tsbReaderAdd_Click);
            // 
            // tsbReaderChange
            // 
            this.tsbReaderChange.Image = ((System.Drawing.Image)(resources.GetObject("tsbReaderChange.Image")));
            this.tsbReaderChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReaderChange.Name = "tsbReaderChange";
            this.tsbReaderChange.Size = new System.Drawing.Size(49, 22);
            this.tsbReaderChange.Text = "修改";
            this.tsbReaderChange.Click += new System.EventHandler(this.tsbReaderChange_Click);
            // 
            // tsbReaderDelete
            // 
            this.tsbReaderDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbReaderDelete.Image")));
            this.tsbReaderDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReaderDelete.Name = "tsbReaderDelete";
            this.tsbReaderDelete.Size = new System.Drawing.Size(49, 22);
            this.tsbReaderDelete.Text = "删除";
            this.tsbReaderDelete.Click += new System.EventHandler(this.tsbReaderDelete_Click);
            // 
            // tsbReaderCheck
            // 
            this.tsbReaderCheck.Image = ((System.Drawing.Image)(resources.GetObject("tsbReaderCheck.Image")));
            this.tsbReaderCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReaderCheck.Name = "tsbReaderCheck";
            this.tsbReaderCheck.Size = new System.Drawing.Size(49, 22);
            this.tsbReaderCheck.Text = "筛选";
            this.tsbReaderCheck.Click += new System.EventHandler(this.tsbReaderCheck_Click);
            // 
            // tsbReaderReflesh
            // 
            this.tsbReaderReflesh.Image = ((System.Drawing.Image)(resources.GetObject("tsbReaderReflesh.Image")));
            this.tsbReaderReflesh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReaderReflesh.Name = "tsbReaderReflesh";
            this.tsbReaderReflesh.Size = new System.Drawing.Size(49, 22);
            this.tsbReaderReflesh.Text = "刷新";
            this.tsbReaderReflesh.Click += new System.EventHandler(this.tsbReaderReflesh_Click);
            // 
            // tsbReaderToExcel
            // 
            this.tsbReaderToExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbReaderToExcel.Image")));
            this.tsbReaderToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReaderToExcel.Name = "tsbReaderToExcel";
            this.tsbReaderToExcel.Size = new System.Drawing.Size(49, 22);
            this.tsbReaderToExcel.Text = "导出";
            this.tsbReaderToExcel.ToolTipText = "导出到Excel表";
            this.tsbReaderToExcel.Click += new System.EventHandler(this.tsbReaderToExcel_Click);
            // 
            // tsbReaderExit
            // 
            this.tsbReaderExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbReaderExit.Image")));
            this.tsbReaderExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReaderExit.Name = "tsbReaderExit";
            this.tsbReaderExit.Size = new System.Drawing.Size(49, 22);
            this.tsbReaderExit.Text = "退出";
            this.tsbReaderExit.Click += new System.EventHandler(this.tsbReaderExit_Click);
            // 
            // tsp
            // 
            this.tsp.Name = "tsp";
            this.tsp.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // frmReaderManage
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butExit;
            this.ClientSize = new System.Drawing.Size(749, 601);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabpage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmReaderManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "读者管理";
            this.Resize += new System.EventHandler(this.frmReaderManage_Resize);
            this.Load += new System.EventHandler(this.frmReaderManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserManage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabpage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorInfo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowlist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tspAdd;
        private System.Windows.Forms.ToolStripButton tspChange;
        private System.Windows.Forms.ToolStripButton tspDelete;
        private System.Windows.Forms.ToolStripButton tspCheck;
        private System.Windows.Forms.ToolStripButton tspReflesh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabpage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butAll;
      //  private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.ToolStripButton tspExit;
        private System.Windows.Forms.ToolStripButton tspExcle;
        private System.Windows.Forms.DataGridView dgvBorInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvUserManage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem txmChange;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmReflesh;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsp;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbReaderAdd;
        private System.Windows.Forms.ToolStripButton tsbReaderChange;
        private System.Windows.Forms.ToolStripButton tsbReaderDelete;
        private System.Windows.Forms.ToolStripButton tsbReaderCheck;
        private System.Windows.Forms.ToolStripButton tsbReaderReflesh;
        private System.Windows.Forms.ToolStripButton tsbReaderToExcel;
        private System.Windows.Forms.ToolStripButton tsbReaderExit;
        private System.Windows.Forms.DataGridView dgvBorrowlist;
    }
}