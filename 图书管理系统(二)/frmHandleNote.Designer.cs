namespace 图书管理系统_二_
{
    partial class frmHandleNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandleNote));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameorID = new System.Windows.Forms.TextBox();
            this.txtBookNameorID = new System.Windows.Forms.TextBox();
            this.cmbCheckList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butExit = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbReflesh = new System.Windows.Forms.ToolStripButton();
            this.tsbToExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.dgvNote = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "图书名称或编号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "读者姓名或编号:";
            // 
            // txtNameorID
            // 
            this.txtNameorID.Location = new System.Drawing.Point(513, 26);
            this.txtNameorID.Name = "txtNameorID";
            this.txtNameorID.Size = new System.Drawing.Size(100, 21);
            this.txtNameorID.TabIndex = 3;
            this.txtNameorID.TextChanged += new System.EventHandler(this.txtNameorID_TextChanged);
            // 
            // txtBookNameorID
            // 
            this.txtBookNameorID.Location = new System.Drawing.Point(305, 26);
            this.txtBookNameorID.MaxLength = 20;
            this.txtBookNameorID.Name = "txtBookNameorID";
            this.txtBookNameorID.Size = new System.Drawing.Size(99, 21);
            this.txtBookNameorID.TabIndex = 4;
            this.txtBookNameorID.TextChanged += new System.EventHandler(this.txtBookNameorID_TextChanged);
            // 
            // cmbCheckList
            // 
            this.cmbCheckList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckList.FormattingEnabled = true;
            this.cmbCheckList.Items.AddRange(new object[] {
            "今日操作记录",
            "所有操作记录"});
            this.cmbCheckList.Location = new System.Drawing.Point(76, 25);
            this.cmbCheckList.Name = "cmbCheckList";
            this.cmbCheckList.Size = new System.Drawing.Size(121, 20);
            this.cmbCheckList.TabIndex = 5;
            this.cmbCheckList.SelectedIndexChanged += new System.EventHandler(this.cmbCheckList_SelectedIndexChanged);
            this.cmbCheckList.TextChanged += new System.EventHandler(this.cmbCheckList_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCheckList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBookNameorID);
            this.groupBox1.Controls.Add(this.butExit);
            this.groupBox1.Controls.Add(this.txtNameorID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 62);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件查询";
            // 
            // butExit
            // 
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butExit.Location = new System.Drawing.Point(635, 24);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(57, 23);
            this.butExit.TabIndex = 0;
            this.butExit.Text = "退出(&C)";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDelete,
            this.tsbReflesh,
            this.tsbToExcel,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(739, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
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
            this.tsbToExcel.ToolTipText = "导出至Excel表格";
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
            // dgvNote
            // 
            this.dgvNote.AllowUserToResizeRows = false;
            this.dgvNote.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNote.Location = new System.Drawing.Point(5, 20);
            this.dgvNote.MultiSelect = false;
            this.dgvNote.Name = "dgvNote";
            this.dgvNote.ReadOnly = true;
            this.dgvNote.RowTemplate.Height = 23;
            this.dgvNote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNote.Size = new System.Drawing.Size(708, 263);
            this.dgvNote.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNote);
            this.groupBox2.Location = new System.Drawing.Point(10, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 291);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书信息";
            // 
            // frmHandleNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHandleNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "操作流水";
            this.Resize += new System.EventHandler(this.frmHandleNote_Resize);
            this.Load += new System.EventHandler(this.frmBookSelect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameorID;
        private System.Windows.Forms.TextBox txtBookNameorID;
        private System.Windows.Forms.ComboBox cmbCheckList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbReflesh;
        private System.Windows.Forms.ToolStripButton tsbToExcel;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.DataGridView dgvNote;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}