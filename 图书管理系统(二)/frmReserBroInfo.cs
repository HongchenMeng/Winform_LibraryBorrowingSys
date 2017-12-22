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
    public partial class frmReserBroInfo : Form
    {
        public frmReserBroInfo()
        {
            InitializeComponent();
        }
        Dblink dbl = new Dblink();
        Dbconnection dbc = new Dbconnection();
        string Sql = "select r_Number 编号,r_BookId 图书编号,r_BookName 图书名称,r_BookAuthor 图书作者,r_ReaderId 读者编号,r_ReaderName 读者姓名,r_ReaderSex 读者性别,r_BookNumber 预借数量,r_BookPrice 图书价格,r_Publisher 出版社,r_HandleUsr 操作用户,r_ReadyTime 预借时间 from ReserBroInfo";
        private void frmReserBroInfo_Load(object sender, EventArgs e)
        {
            //获得屏幕的大小,并设置窗体初始化时的大小
            Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;
            this.Width = rect.Width - 123;
            this.Height = rect.Height - 157;
            cmbCheckList.SelectedIndex = 0;
            dbl.InfoShow(Sql,dgvReserBroInfo);
        }
        
        private void tsbReflesh_Click(object sender, EventArgs e)
        {
            string time =dbl.GetTime(9);
            if (cmbCheckList.Text.Trim() == "所有预借记录")
            {
                dbl.InfoShow("" + Sql + "", dgvReserBroInfo);
            }
            if (cmbCheckList.Text.Trim() == "今天预借记录")
            {
                dbl.InfoShow("" + Sql + " where r_ReadyTime like'%"+time+"%'", dgvReserBroInfo);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string Number = dgvReserBroInfo.SelectedCells[0].Value.ToString();         //获得记录的流水编号 
            if (MessageBox.Show("是否当真删除编号为'" + Number + "'的信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Strsql = "delete from ReserBroInfo where r_Number='"+Number+"'";
                if (dbc.ExeInfochange(Strsql) == 1)
                {
                    dbl.InfoShow("" + Sql + "", dgvReserBroInfo);
                }
            }
        }

        private void cmbCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsbReflesh_Click(sender, e);
        }

        private void tsbToExcel_Click(object sender, EventArgs e)
        {
            dbl.ShowDgvInfo(dgvReserBroInfo ,true);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReaderIDorName_TextChanged(object sender, EventArgs e)
        {
            string time = dbl.GetTime(9);
            if (cmbCheckList.Text.Trim() == "今天预借记录")
            {
                dbl.InfoShow("" + Sql + " where ((r_ReaderId like '%" + txtReaderIDorName.Text+ "%') or (r_ReaderName like '%" + txtReaderIDorName.Text+ "%')) and  r_ReadyTime like '%" + time + "%'", dgvReserBroInfo);
            }
            if (cmbCheckList.Text.Trim() == "所有预借记录")
            {
                dbl.InfoShow("" + Sql + " where ((r_ReaderId like '%" + txtReaderIDorName.Text+ "%') or (r_ReaderName like '%" + txtReaderIDorName.Text + "%'))", dgvReserBroInfo);
            }
        }

        private void txtBookIDorName_TextChanged(object sender, EventArgs e)
        {
            string time = dbl.GetTime(9);
            if (cmbCheckList.Text.Trim() == "今天预借记录")
            {
                dbl.InfoShow("" + Sql + "  where ((r_BookName like '%"+txtBookIDorName.Text.Trim()+"%') or (r_BookId like '%"+txtBookIDorName.Text.Trim()+"%'))and r_ReadyTime like '" + time + "%' order by r_Number", dgvReserBroInfo);
            }
            if (cmbCheckList.Text.Trim() == "所有预借记录")
            {
                dbl.InfoShow("" + Sql + " where ((r_BookName like '%" + txtBookIDorName.Text.Trim () + "%') or (r_BookId like '%" + txtBookIDorName.Text.Trim ()+ "%'))", dgvReserBroInfo);
            }
        }

        private void frmReserBroInfo_Resize(object sender, EventArgs e)
        {
            //窗口大小变化
            groupBox1.Width = this.Width - 25;
            groupBox2.Width = this.Width - 25;
            groupBox2.Height = this.Height - 150;
            dgvReserBroInfo.Width = this.Width - 37;
            dgvReserBroInfo.Height = this.Height - 175;
        }

        private void frmReserBroInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode  == Keys.F5)
            {
                tsbReflesh_Click(sender, e);
            }
        }

        private void tsbToBorrow_Click(object sender, EventArgs e)
        {
            
        }

        //private void frmReserBroInfo_Paint(object sender, PaintEventArgs e)
        //{
        //    frmBookAbout fba=new frmBookAbout ();
        //    txtBookIDorName.Text = fba.BookID.Trim();
        //    txtReaderIDorName.Text = fba.ReaderID.Trim();
        //}

    }
}