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
    public partial class frmUsercontrol : Form
    {
        public frmUsercontrol()
        {
            InitializeComponent();
        }
        Dblink su = new Dblink();
        string name;
        private void frmUsercontrol_Load(object sender, EventArgs e)
        {
            //控件的可用性的设置
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            txtUsername.Enabled = false;
            txtPass.Enabled = false;
            txtRepass.Enabled = false;
            comboxUsertype.Enabled = false;
            comboxUsertype.SelectedIndex = 0;
            butSuerAdd.Enabled = false;
            butCancel.Enabled = false;
            if (frmlogin.type == "普通用户")
            {
                butAdd.Enabled = false;
                butDelete.Enabled = false;
            }
                Reflesh();
        }

        public void Reflesh()   //实时更新
        {
            DataSet dsUsers;
            string strSql = "select u_Name 用户名称,u_Pass 用户密码,u_Type 用户类型,u_Stopuser 是否停用 FROM Users";
            dsUsers = su.GetDataset(strSql);

            dgvUserselect.DataSource = dsUsers;
            dgvUserselect.DataMember = dsUsers.Tables[0].ToString();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            try
            {
                name = dgvUserselect.SelectedCells[0].Value.ToString();
                //如果选中的是自己,那么提示不能删除
                if (frmlogin.userName == name)
                {
                    MessageBox.Show("删除错误,不能删除自己!", "提示");
                }
                else
                {
                    if (MessageBox.Show("您将删除'"+name+"'用户,是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection conn = Dbconnection.Dblink();
                        conn.Open();
                        DataSet DS;
                        string strSql = "delete from Users where u_Name='" + name + "'";
                        DS = su.GetDataset(strSql);
                        conn.Close();
                        //实现实时更新
                        Reflesh();
                    }
                   
                }
            }
            catch (Exception)
            {
                ;
            }
        }

        private void butSuerAdd_Click_1(object sender, EventArgs e)
        {
            //控件的可用性的设置
            comboxUsertype.SelectedIndex = 0;
            butSuerAdd.Enabled = false;
            butAdd.Enabled = true;
            txtUsername.Enabled = false;
            txtPass.Enabled = false;
            txtRepass.Enabled = false;
            comboxUsertype.Enabled = false;
            butCancel.Enabled = false;
            
            if (txtUsername .Text .Length <3 || txtUsername .Text.Length >12|| txtPass.Text.Length < 5 || txtPass.Text.Length > 12 || txtPass.Text.Length == 0 || txtRepass.Text.Length < 5 || txtRepass.Text.Length > 12 || txtRepass.Text.Length == 0)
            {
                MessageBox.Show("密码长度不符合规定,请重新输入!", "提示");
                txtUsername.Clear();
                txtPass.Clear();
                txtRepass.Clear();
            }
            else 
            {
                if (txtPass.Text != txtRepass.Text)
                {
                    MessageBox.Show("两次输入的密码不一致,请重新输入!", "提示");
                    //txtPass.Focus();
                    txtUsername.Clear();
                    txtPass.Clear();
                    txtRepass.Clear();
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("您将添加用户'" + txtUsername .Text .Trim ()+ "',是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlConnection Strconn1 = Dbconnection.Dblink();            //调用Dbconnection类中的连接
                            Strconn1.Open();                              //打开连接
                            string sqlName1 = "insert into Users values ('" + txtUsername.Text + "','" + txtPass.Text + "','" + comboxUsertype.Text + "','" + "否" + "')";
                            SqlCommand scomd1 = new SqlCommand(sqlName1, Strconn1);
                            scomd1.ExecuteNonQuery();
                            Strconn1.Close();
                            //实现实时更新                       
                            Reflesh();
                            txtUsername.Clear();
                            txtPass.Clear();
                            txtRepass.Clear();
                            Strconn1.Close();
                        }
                        
                    }

                    catch (Exception c)
                    {
                        Console.WriteLine(c.Message);
                    }
                }
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            //控件的可用性的设置
            txtUsername.Enabled = true;
            txtPass.Enabled = true;
            txtRepass.Enabled = true;
            comboxUsertype.Enabled = true;
            butSuerAdd.Enabled = true;
            butAdd.Enabled = false;
            butCancel.Enabled = true;
            
        }
        private void butCancel_Click_1(object sender, EventArgs e)
        {
            //控件的可用性的设置
            butCancel.Enabled = false;
            txtUsername.Enabled = false;
            txtPass.Enabled = false;
            txtRepass.Enabled = false;
            comboxUsertype.Enabled = false;
            comboxUsertype.SelectedIndex = 0;
            butSuerAdd.Enabled = false;
            butAdd.Enabled = true;
            txtUsername.Clear();
            txtPass.Clear();
            txtRepass.Clear();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
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
                            MessageBox.Show("用户名'" + txtUsername .Text.Trim ()+ "'已存在,请重新选择用户名!", "提示");
                            txtUsername.Focus();
                            txtUsername.SelectAll();
                            break;
                        }
                    }
                  Strconn.Close();
               }
            catch (Exception j)
            {
                Console.WriteLine(j.Message);
            }
        }
        public static string User, Pass, Type, Statue;
        private void dgvUserselect_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            User =dgvUserselect.SelectedCells[0].Value .ToString ();
            Pass=dgvUserselect .SelectedCells [1].Value .ToString ();
            Type =dgvUserselect .SelectedCells [2].Value .ToString ();
            Statue =dgvUserselect .SelectedCells [3].Value .ToString ();
            frmUserRework fur = new frmUserRework();
            fur.ShowDialog();
        }

        private void frmUsercontrol_Paint(object sender, PaintEventArgs e)
        {
            Reflesh();
        }
    }
}