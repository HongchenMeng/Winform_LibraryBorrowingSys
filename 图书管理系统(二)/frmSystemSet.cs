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
    public partial class frmSystemSet : Form
    {
        public frmSystemSet()
        {
            InitializeComponent();
        }
        Dbconnection dbc = new Dbconnection();
        private void frmSystemSet_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
      
        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您将修改系统数据,是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dudStudentNuber.Text.Length == 0 || dudTeacherNumber.Text.Length == 0 || txtSetMoney.Text.Length == 0 || txtSetReserDay.Text.Length == 0)
                {
                    MessageBox.Show("数据不能为空,请重新填写！", "提示");
                }
                else
                {
                    if (cbxIsGo.Checked == true)
                    {
                        //执行更新语句
                        dbc.ExeInfochange("update SystemSet set TeaBroNumber='" + dudTeacherNumber.Text.Trim() + "',StuBroNumber='" + dudStudentNuber.Text.Trim() + "',PayMoney='" + txtSetMoney.Text.Trim() + "',SetReserDay='" + txtSetReserDay.Text.Trim() + "',IsOpenOverdue='是'");
                    }
                    else
                    {
                        //执行更新语句
                        dbc.ExeInfochange("update SystemSet set TeaBroNumber='" + dudTeacherNumber.Text.Trim() + "',StuBroNumber='" + dudStudentNuber.Text.Trim() + "',PayMoney='" + txtSetMoney.Text.Trim() + "',SetReserDay='" + txtSetReserDay.Text.Trim() + "',IsOpenOverdue='否'");
                    }
                    this.dudStudentNuber.Text = dudStudentNuber.Text.Trim();
                    this.dudTeacherNumber.Text = dudTeacherNumber.Text.Trim();
                    this.txtSetMoney.Text = txtSetMoney.Text.Trim();
                    this.txtSetReserDay.Text = txtSetReserDay.Text.Trim();
                    this.cbxIsGo.Checked = cbxIsGo.Checked;
                    this.Close();
                }
            }
        }
    }
}