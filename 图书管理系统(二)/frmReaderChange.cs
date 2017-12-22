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
    public partial class frmReaderChange : Form
    {
        public frmReaderChange()
        {
            InitializeComponent();
        }

        private void frmUserChange_Load(object sender, EventArgs e)
        {
            #region 填充数据
            cmbReadertype.SelectedIndex = 0;
            cmbSex.SelectedIndex = 0;
            cmbStatu.SelectedIndex = 0;
            txtNumber.Text = frmReaderManage.ReaderCardID;
            txtNumber.ReadOnly = true;
            txtName.Text = frmReaderManage.ReaderName;
            txtBarcode.Text = frmReaderManage.ReaderStrichcode;
            cmbReadertype.Text = frmReaderManage.ReaderType;
            cmbStatu.Text = frmReaderManage.ReaderStatue;
            dateTimePicker1.Text = frmReaderManage.ReaderEndtime;
            cmbSex.Text = frmReaderManage.ReaderSex;
            txtWorkshop.Text = frmReaderManage.ReaderWorkPlace;
            txtPhoneNumber.Text = frmReaderManage.ReaderTelNumber;
            this.MinimizeBox = false;
            #endregion
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butSure_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length == 0 || txtName.Text.Length == 0)
            {
                MessageBox.Show("借书证号和读者姓名为必填项！", "提示");   //借书证号和姓名为必填项
                txtNumber.Focus();
                txtNumber.SelectAll();
            }
            else
            {
                //if (txtName.Text.Length > 10 || txtWorkshop.Text.Length > 20 || txtPhoneNumber.Text.Length > 15)
                //{
                //    MessageBox.Show("输入信息的长度不符合要求,请重新检查！", "提示");
                //}
                //else
                //{
                    if (MessageBox.Show("您将修改用户名为：'" + txtNumber.Text + "'的信息,是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Dbconnection db = new Dbconnection();
                            // 添加读者的信息
                            string sql = "update Reader set ReaderName='" + txtName.Text.Trim() + "',ReaderTypeID='" + cmbReadertype.Text.Trim() + "',Mode='" + cmbStatu.Text.Trim() + "',ValidTime='" + dateTimePicker1.Text.Trim() + "',Sex='" + cmbSex.Text.Trim() + "',Dept='" + txtWorkshop.Text.Trim() + "',Call='" + txtPhoneNumber.Text.Trim() + "'where CardID='" + txtNumber.Text.Trim() + "'";
                            if (db.ExeInfochange(sql) == 1)
                            {
                                db.ExeInfochange("update Borrow set ReaderName='" + txtName.Text.Trim() + "'where CardID='" + txtNumber.Text.Trim() + "'");
                                db.ExeInfochange("update OverdueInfo set ReaderName='" + txtName.Text.Trim() + "'where CardID='" + txtNumber.Text.Trim() + "'");
                                db.ExeInfochange("update HandleNote set ReaderName='" + txtName.Text.Trim() + "',ReaderSex='" + cmbSex.Text.Trim() + "'where ReaderID='" + txtNumber.Text.Trim() + "'");
                                db.ExeInfochange("update ReserBroInfo set r_ReaderName='" + txtName.Text.Trim() + "',r_ReaderSex='" + cmbSex.Text.Trim() + "' where CardID='" + txtNumber.Text.Trim() + "'");
                                db.ExeInfochange("update PenaltryInfo set ReaderName='" + txtName.Text.Trim() + "'where CardID='" + txtNumber.Text.Trim() + "'");
                                db.ExeInfochange("update RenewNote set ReaderName='" + txtName.Text.Trim() + "'where CardID='" + txtNumber.Text.Trim() + "'");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("读者信息修改失败！", "提示");
                            }
                        }
                        catch (Exception)
                        {
                            ;
                        }
                    }
                //}
            }
        }
    }
}