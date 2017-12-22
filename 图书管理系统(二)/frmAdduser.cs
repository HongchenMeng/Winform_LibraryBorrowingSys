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
    public partial class frmAdduser : Form
    {
        public frmAdduser()
        {
            InitializeComponent();
        }
        Dblink su = new Dblink();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                SqlConnection Strconn = Dbconnection.Dblink(); ;//调用Dbconnection类中的连接
                Strconn.Open();//打开连接
                string sqlName = "select u_Name from Users";
                SqlCommand scomd = new SqlCommand(sqlName, Strconn);
                scomd.ExecuteNonQuery();
                SqlDataReader sDR = scomd.ExecuteReader();
                while (sDR.Read())
                {
                    string name = sDR["u_Name"].ToString();
                    if (txtUsername.Text == name)
                    {
                        MessageBox.Show("此用户名已存在,请重新选择用户名!", "提示");
                        txtUsername.Focus();
                        txtUsername.SelectAll();
                        break;
                    }
                    else
                    {
                        if (txtUsername.Text == "")
                        {
                            MessageBox.Show("用户名不能为空,请重新输入!","提示");
                            txtUsername.Focus();
                            txtUsername.SelectAll();
                            break;
                        }
                    }

                }
                Strconn.Close();
            }
            catch(Exception j)
            {
                Console.WriteLine(j.Message);
            }
        }

        #region  注释代码

        //private void txtPass_Validated(object sender, EventArgs e)
        //{
        //    if (txtPass.Text.Length < 5 || txtPass.Text.Length >12 || txtPass.Text.Length == 0)
        //    {
        //        MessageBox.Show("密码长度不符合规定,请重新输入!","提示");
        //        txtPass.Focus ();
        //        txtPass.SelectAll();
        //    }
        //}

        //private void txtRepass_Validated(object sender, EventArgs e)
        //{
        //    if (xtPass.Text.Length < 5 || txtPass.Text.Length >12 || txtPass.Text.Length == 0||txtRepass.Text.Length < 5 || txtRepass.Text.Length > 12 || txtRepass.Text.Length == 0)
        //    {
        //        MessageBox.Show("密码长度不符合规定,请重新输入!", "提示");
        //        txtRepass.Focus();
        //        txtRepass.SelectAll();
        //    }
        //    else
        //    {
        //        if (txtPass.Text != txtRepass.Text)
        //        {
        //            MessageBox.Show("两次输入的密码不一致,请重新输入!", "提示");
        //            txtPass.Focus();
        //            txtPass.SelectAll();
        //        }
        //        else
        //        {
        //            butOk.Enabled = true;
        //        }
        //    }
        //}
        #endregion

        private void butOk_Click(object sender, EventArgs e)
           {
               if (txtPass.Text.Length < 5 || txtPass.Text.Length > 12 || txtPass.Text.Length == 0 || txtRepass.Text.Length < 5 || txtRepass.Text.Length > 12 || txtRepass.Text.Length == 0)
               {
                   MessageBox.Show("密码长度不符合规定,请重新输入!", "提示");
                   txtRepass.Focus();
                   txtRepass.SelectAll();
               }
               else
               {
                   if (txtPass.Text != txtRepass.Text)
                   {
                       MessageBox.Show("两次输入的密码不一致,请重新输入!", "提示");
                       txtPass.Focus();
                       txtPass.SelectAll();
                   }
                   else
                   {
                       try
                       {
                           SqlConnection Strconn1 = Dbconnection.Dblink(); ;//调用Dbconnection类中的连接
                           Strconn1.Open();//打开连接
                           string sqlName1 = "insert into Users values ('" + txtUsername.Text + "','" + txtPass.Text + "','" + comboxtype.Text + "','" + "否" + "')";
                           SqlCommand scomd1 = new SqlCommand(sqlName1, Strconn1);
                           scomd1.ExecuteNonQuery();
                           //实现实时更新
                           frmUsercontrol fuc = new frmUsercontrol();
                           fuc.Reflesh();
                           Strconn1.Close();
                           this.Dispose();
                           MessageBox.Show("用户添加成功!", "提示");

                       }

                       catch (Exception c)
                       {
                           Console.WriteLine(c.Message);
                       }
                   }
               }
                  
           }

        private void frmAdduser_Load(object sender, EventArgs e)
        {
            //butOk.Enabled = false;
            comboxtype.SelectedIndex = 0;
        }
      
    }
}