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
    public partial class frmChangepass : Form
    {
        public frmChangepass()
        {
            InitializeComponent();
        }

      

        public static string connection = System.Configuration.ConfigurationManager.AppSettings["connection"];
   
        private void frmChangepass_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
        }

        private void butOk_Click(object sender, EventArgs e)
        {

            #region 验证
            if (txtOldpass.Text == "" || txtNewpass.Text == "" || txtRepass.Text == "")
            {
                MessageBox.Show("输入信息不能为空!","修改提示");
                txtOldpass.Focus();
                txtOldpass.SelectAll();
            }
            else
            {
                if (txtOldpass.Text != frmlogin.passWord)
                {
                    MessageBox.Show("您输入的旧密码不正确!", "修改提示");
                    txtOldpass.Focus();
                    txtOldpass.SelectAll();
                }
                else
                {
                    if (txtNewpass.Text != txtRepass.Text)
                    {
                        MessageBox.Show("两次输入的新密码不一致!", "修改提示");
                        txtNewpass.Focus();
                        txtNewpass.SelectAll();
                    }
                    else
                    {
                        if (txtNewpass.Text.Length < 5 || txtNewpass.Text.Length > 12)
                        {
                            MessageBox.Show("密码长度不符合规定,请重新输入!", "修改提示");
                            txtNewpass.Focus();
                            txtNewpass.SelectAll();
                        }
            #endregion 
                        else
                        {
                            #region   非调用方法
                            //butOk.Enabled = true;
                            //SqlConnection myConnection = new SqlConnection(connection);
                            //SqlCommand myCommand = myConnection.CreateCommand();
                            //myCommand.CommandText = "update Users set u_Pass='" + txtNewpass.Text + "'where u_Name='" + frmlogin.userName + "'";
                            //myConnection.Open();
                            //myCommand.ExecuteNonQuery();
                            //myConnection.Close();
                            #endregion

                            Dbconnection dbc = new Dbconnection();
                            string  Strsql ="update Users set u_Pass='" + txtNewpass.Text + "'where u_Name='" + frmlogin.userName + "'";
                            int number = dbc.ExeInfochange(Strsql);
                            if (number > 0)
                            {
                                frmlogin.passWord = txtNewpass.Text.Trim();
                                MessageBox.Show("密码修改成功!", "修改提示");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("密码修改失败!", "修改提示");
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            txtOldpass.Focus();   
            txtOldpass.SelectAll();     
        }
    }
}