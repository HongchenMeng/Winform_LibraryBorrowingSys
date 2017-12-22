using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;


namespace 图书管理系统_二_
{
    public partial class frmHandleNote : Form
    {
        public frmHandleNote()
        {
            InitializeComponent();
        }
        string Sql="select HandleNumber 操作编号,Handletype 操作类型,HandleUser 操作用户,BookName 图书名称,BookStrichcode 图书编号,ReaderID 读者编号,ReaderName 读者姓名,ReaderSex 读者性别,BookNumber 借书数量,BookPrice 图书价格,HandleDate 操作日期 from HandleNote";
        Dblink db = new Dblink();
        Dbconnection dbc = new Dbconnection();
        DateTime NowTime = Convert.ToDateTime(DateTime.Now.ToString());
        private void frmBookSelect_Load(object sender, EventArgs e)
        {
            //显示所有操作日志
            cmbCheckList.SelectedIndex = 1;
            db.InfoShow(""+Sql+"", dgvNote);
            //获得屏幕的大小,并设置窗体初始化时的大小
            Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen; 
            this.Width =rect.Width- 135;
            this.Height = rect .Height - 157;
        }
     
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbToExcel_Click(object sender, EventArgs e)
        {
            //导出到EXCEL表格中
            db.ShowDgvInfo(dgvNote, true);
        }

        //单击工具栏按钮执行T-SQL查询语句
         #region  T-SQL查询语句
        private void cmbCheckList_TextChanged(object sender, EventArgs e)
        {
            tsbReflesh_Click(sender,e);
        }
        //当文本框中的文本变化时进行查询
        private void txtBookNameorID_TextChanged(object sender, EventArgs e)
        {
            string time = db.GetTime(9);
            if (cmbCheckList.Text.Trim() == "今日操作记录")
            {
                db.InfoShow("" + Sql + " where ((BookName like'%" + txtBookNameorID.Text.Trim() + "%') or (BookStrichcode like'%" + txtBookNameorID.Text.Trim() + "%'))and HandleDate like'" + time + "%' order by HandleNumber", dgvNote);
            }
            else
            {
                db.InfoShow("" + Sql + " where (BookName like'%" + txtBookNameorID.Text.Trim() + "%') or (BookStrichcode like'%" + txtBookNameorID.Text.Trim() + "%') order by HandleNumber", dgvNote);
            }
        }
        //当文本框中的文本变化时进行查询
        private void txtNameorID_TextChanged(object sender, EventArgs e)
        {
            string time = db.GetTime(9);
            if (cmbCheckList.Text.Trim() == "今日操作记录")
            {
                db.InfoShow("" + Sql + " where ((ReaderID like'%" + txtNameorID.Text.Trim() + "%') or (ReaderName like'%" + txtNameorID.Text.Trim() + "%')) and HandleDate like'" + time + "%' order by HandleNumber", dgvNote);
            }
            else
            {
                db.InfoShow("" + Sql + " where (ReaderID like'%" + txtNameorID.Text.Trim() + "%') or (ReaderName like'%" + txtNameorID.Text.Trim() + "%') order by HandleNumber", dgvNote);
            }
        }
        //更新数据
        private void tsbReflesh_Click(object sender, EventArgs e)
        {
            string time = db.GetTime(9);
            if (cmbCheckList.Text.Trim() == "今日操作记录")
            {
                db.InfoShow("" + Sql + " where HandleDate like'" + time + "%' order by HandleNumber", dgvNote);
            }
            else
            {
                db.InfoShow(""+Sql+"", dgvNote);
            }
        }
        //当CmbBox中的数据变化时,DGV中的数据发生改变
        private void cmbCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsbReflesh_Click(sender, e);
        }
        #endregion

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            //删除记录
            try
            {
                string Number = dgvNote.SelectedCells[0].Value.ToString();   //获得记录的流水编号 
                if (MessageBox.Show("是否当真删除编号为'"+Number+"'记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "delete from HandleNote where HandleNumber='" + Number + "'";    //用获得的编号去删除相应的记录
                    if (dbc.ExeInfochange(sql) == 1)
                    {
                        db.InfoShow("" + Sql + "", dgvNote);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("信息删除失败！", "提示");
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHandleNote_Resize(object sender, EventArgs e)
        {
            //当窗体的大小发生变化时,其它控件也相应地变化
            groupBox1.Width = this.Width - 27;
            groupBox2.Width = this.Width - 27;
            groupBox2.Height = this.Height - 158;
            dgvNote.Width = this.Width - 40;
            dgvNote.Height = this.Height - 185;
        }
    }
}