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
    public partial class frmReaderAdd : Form
    {
        public frmReaderAdd()
        {
            InitializeComponent();
        }
        private void frmReaderAdd_Load(object sender, EventArgs e)
        {
            cmbReadertype.SelectedIndex = 0;
            cmbStatu.SelectedIndex = 0;
            cmbSex.SelectedIndex = 0;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length == 0 || txtName.Text.Length == 0)
            {
                MessageBox.Show("借书证号和读者姓名为必填项！", "提示");   //借书证号和姓名为必填项
                txtNumber.Focus();
                txtNumber.SelectAll();
            }
            else
            {
                if (MessageBox.Show("您将添加一位读者,是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Dbconnection db = new Dbconnection();
                        Dblink dbl=new Dblink ();
                        int Number=dbl.AutoNumber ("select Max(Number) from Reader");
                        // 添加读者的信息
                        string sql = "insert into Reader values ("+Number+",'" + txtNumber.Text.Trim() + "','" + txtName.Text.Trim() + "','0','" + txtBarcode.Text.Trim() + "','" + cmbReadertype.Text.Trim() + "','" + cmbStatu.Text.Trim() + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + cmbSex.Text + "','" + txtWorkshop.Text.Trim() + "','" + txtPhoneNumber.Text + "')";
                        if (db.ExeInfochange(sql) == 1)
                        {

                            MessageBox.Show("读者信息添加成功！", "提示");
                            //ShowAll();
                        }
                        else
                        {
                            MessageBox.Show("数据长度不符合要求,读者信息添加失败！", "提示");
                        }
                    }
                    catch (Exception)
                    {
                        ;
                    }
                }
            }
        }
    }
}