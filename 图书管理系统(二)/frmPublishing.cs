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
    public partial class frmPublishing : Form
    {
        public frmPublishing()
        {
            InitializeComponent();
        }

        Dblink dbl = new Dblink();
        Dbconnection dbc = new Dbconnection();
        private void frmPublishing_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //显示所有出版社的信息
            dbl.InfoShow("select PulNumber 编号,PulName 出版社名称,PulAdress 地址,PulExplain 说明 from Publishing order by PulNumber", dgvPulb);
            
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            //删除记录
            try
            {
                string Number =  dgvPulb.SelectedCells[0].Value.ToString();   //获得记录的流水编号 
                if (MessageBox.Show("是否当真删除编号为'" + Number + "'记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "delete from Publishing where PulNumber='" + Number + "'";    //用获得的编号去删除相应的记录
                    if (dbc.ExeInfochange(sql) == 1)
                    {
                        dbl.InfoShow("select PulNumber 编号,PulName 出版社名称,PulAdress 地址,PulExplain 说明 from Publishing order by PulNumber", dgvPulb);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("信息删除失败！", "提示");
            }
        }

        private void tsbToExcel_Click(object sender, EventArgs e)
        {
            //导出数据到Excel
            dbl.ShowDgvInfo(dgvPulb ,true);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            string AutoNumber = Convert.ToString(dbl.AutoNumber("select Max(PulNumber) from Publishing"));
            frmPubChange fpc = new frmPubChange(AutoNumber);
            fpc.Text = "出版社信息(增加)";
            fpc.ShowDialog();
        }

        private void tsbChange_Click(object sender, EventArgs e)
        {
            //获得备忘编号
            string Number = dgvPulb.SelectedCells[0].Value.ToString();
            frmPubChange fpc = new frmPubChange(Number);
            fpc.Text = "出版社信息(修改)";
            fpc.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //利用获得的条件查询符合条件的数据
            dbl.InfoShow("select PulNumber 编号,PulName 出版社名称,PulAdress 地址,PulExplain 说明 from Publishing where PulName like '%" + txtName.Text.Trim() + "%' order by PulNumber", dgvPulb);
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender,e);
        }

        private void tsbReflsh_Click(object sender, EventArgs e)
        {
            //显示所有数据
            dbl.InfoShow("select PulNumber 编号,PulName 出版社名称,PulAdress 地址,PulExplain 说明 from Publishing order by PulNumber", dgvPulb);
        }

        private void frmPublishing_Paint(object sender, PaintEventArgs e)
        {
            tsbReflsh_Click(sender, e);
        }

        public string PulName;
        private void dgvPulb_DoubleClick(object sender, EventArgs e)
        {
            PulName = dgvPulb.SelectedCells[1].Value.ToString();
            this.Close();
        }
    }
}