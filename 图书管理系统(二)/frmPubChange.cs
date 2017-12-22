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
    public partial class frmPubChange : Form
    {
        public frmPubChange(string text)
        {
            InitializeComponent();
            txtNumber.Text = text;
        }
        DataSet ds = new DataSet();
        Dblink dbl = new Dblink();
        Dbconnection dbc = new Dbconnection();
        private void frmPubChange_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txtNumber.ReadOnly = true;

            if (this.Text == "出版社信息(修改)")
            {
                //利用获得的编号去搜索符合条件的信息
                ds = dbl.GetDataset("select * from Publishing where PulNumber =" + txtNumber.Text.Trim() + "");
                txtName.Text = Convert.ToString(ds.Tables[0].Rows[0][1]);
                txtAdress.Text = Convert.ToString(ds.Tables[0].Rows[0][2]);
                txtShuoming.Text = Convert.ToString(ds.Tables[0].Rows[0][3]);
            }

        }

        private void butOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Length == 0)
                {
                    MessageBox.Show("出版社名称不能为空,请重新输入！", "提示");
                }
                else
                {
                    if (this.Text == "出版社信息(增加)")
                    {
                        dbc.ExeInfochange("insert into Publishing values ('" + txtNumber.Text.Trim() + "','" + txtName.Text.Trim() + "','" + txtAdress.Text.Trim() + "','" + txtShuoming.Text.Trim() + "')");
                        MessageBox.Show("'" + txtName.Text.Trim() + "'信息增加成功！", "提示");
                    }
                    if (this.Text == "出版社信息(修改)")
                    {
                        dbc.ExeInfochange("update Publishing set PulName='" + txtName.Text.Trim() + "',PulAdress='" + txtAdress.Text.Trim() + "',PulExplain='" + txtShuoming.Text.Trim() + "'");
                        MessageBox.Show("'" + txtName.Text.Trim() + "'信息修改成功！", "提示");
                    }
                }
            }
            catch
            {
                MessageBox.Show("添加失败,据长度过长,请重新输入！", "提示");
            }
            this.Close();
        }
    }
}
