using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClassLibrary;

namespace 图书管理系统_二_
{
    public partial class frmBorselect : Form
    {
        public frmBorselect()
        {
            InitializeComponent();
        }

        Dblink dbl = new Dblink();
        private void frmBorselect_Load(object sender, EventArgs e)
        {
            cmbTimelist.SelectedIndex = 1;
            //获得屏幕的大小,并设置窗体初始化时的大小
            Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;
            this.Width = rect.Width - 135;
            this.Height = rect.Height - 157;
            //调用方法显示所有数据
            cmbTimelist_SelectedIndexChanged(sender, e);
        }

        public void Reflseh(string Sql)     //实现刷新
        {
            try
            {
                dbl.InfoShow(Sql, dgvBorselect);
            }
            catch (Exception)
            {
                ;
            }
        }

        private void butSelect_Click(object sender, EventArgs e)
        {
            string time = dbl.GetTime(9);
            if (cmbTimelist.Text.Trim() == "所有借阅")
            {
                //利用今天的时间来查询符合条件的记录
                Reflseh("select Number 借阅编号,CardID 借书证号,ReaderName 读者姓名,BookID 图书编号,BookName 图书名称,Author 图书作者,Publisher 出版社,Price 图书价格,BorrowDate 借书日期,BorrowNumber 借书数量,UserName 操作员,BroTieme 借阅时长,IsOverdue 是否超期 FROM Borrow WHERE (CardID LIKE '%" + textBox1.Text + "%') or(ReaderName LIKE '%" + textBox1.Text + "%')");
            }
            else
            {
                //无条件,显示所有借阅记录
                Reflseh("select Number 借阅编号,CardID 借书证号,ReaderName 读者姓名,BookID 图书编号,BookName 图书名称,Author 图书作者,Publisher 出版社,Price 图书价格,BorrowDate 借书日期,BorrowNumber 借书数量,UserName 操作员,BroTieme 借阅时长,IsOverdue 是否超期 FROM Borrow WHERE ((CardID LIKE '%" + textBox1.Text + "%') or(ReaderName LIKE '%" + textBox1.Text + "%')) and BorrowDate like '" + time + "%'");
            }
        }
        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            butSelect_Click(sender,e);
        }

        private void frmBorselect_Resize(object sender, EventArgs e)
        {
            //当窗体的大小变化时各个控件的大小也随着发生变化
            groupBox1.Width = this.Width - 22;
            groupBox2.Width = this.Width - 22;
            groupBox2.Height = this.Height - 130;
            dgvBorselect.Width = this.Width - 39;
            dgvBorselect.Height = this.Height-123;
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbToExcel_Click(object sender, EventArgs e)
        {
            Dblink db = new Dblink();             //调用Dblink 方法来导出数据到Excel表格
            db.ShowDgvInfo(dgvBorselect, true);
        }

        private void tsbReflesh_Click(object sender, EventArgs e)
        {
            //显示全部的信息
            cmbTimelist_SelectedIndexChanged(sender,e);
        }

        private void cmbTimelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string time = dbl.GetTime(9);
            if (cmbTimelist.Text.Trim() == "所有借阅")
            {
                //利用今天的时间来查询符合条件的记录
                Reflseh("select Number 借阅编号,CardID 借书证号,ReaderName 读者姓名,BookID 图书编号,BookName 图书名称,Author 图书作者,Publisher 出版社,Price 图书价格,BorrowDate 借书日期,BorrowNumber 借书数量,UserName 操作员,BroTieme 借阅时长,IsOverdue 是否超期 FROM Borrow ");
            }
            else
            {
                //无条件,显示所有借阅记录
                Reflseh("select Number 借阅编号,CardID 借书证号,ReaderName 读者姓名,BookID 图书编号,BookName 图书名称,Author 图书作者,Publisher 出版社,Price 图书价格,BorrowDate 借书日期,BorrowNumber 借书数量,UserName 操作员,BroTieme 借阅时长,IsOverdue 是否超期 FROM Borrow where BorrowDate like '" + time + "%'");
            }
        }
    }
}