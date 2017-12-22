using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;

namespace 图书管理系统_二_
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        //定义
        private Point mouseOffset;        //记录鼠标指针的坐标
        private bool isMouseDown = false; //记录鼠标按键是否按下
        public static string userName;
        public static string passWord;
        public static string type;
        Dblink dbl = new Dblink();
        public static string connection = System.Configuration.ConfigurationManager.AppSettings["connection"];

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
             #region 我的方法
            userName = comboBoxUser.Text.Trim();
            passWord = textBox1.Text.Trim();
            try
            {
                //数据库连接的建立
                SqlConnection myConnection = new SqlConnection(connection);
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "select * from Users where u_Name ='" + userName + "'and u_Pass ='" + passWord.Trim() + "'and u_Type='" + comboxType.Text + "'and u_Stopuser='否'";
                myConnection.Open();
                SqlDataReader myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows == true)     //一条一条的读取记录,如果有则为真
                {
                    type = comboxType.Text;
                    myDataReader.Close();
                    myConnection.Close();
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("此用户已停用或密码错误,请重新输入!", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxUser.Text = "";
                    textBox1.Text = "";
                    comboBoxUser.Focus();
                }
                myConnection.Close();
                myCommand.Dispose();
            }
            catch (Exception)
            {
                //MessageBox.Show("此用户已停用或密码错误,请重新输入!", "登录提示");
            }
            #endregion
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void frmlogin_Load(object sender, EventArgs e)
        {
            this.TopMost = true;      //设置窗口在最前端
            dbl.ShowInfoList("select * from Users where u_Type='普通用户'", "u_Name", comboBoxUser);   //调用方法以下拉的形式显示用户名
            comboxType.SelectedIndex = 0;
            buttonLogin.Parent = pictureBox1;
            this.AcceptButton = buttonLogin;

            # region 控件的透明设置
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            buttonLogin.Parent = pictureBox1;
            buttonLogin.BackColor = Color.Transparent;
            butExit.Parent = pictureBox1;
            butExit.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            #endregion
        }

            #region    验证
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBoxUser.Text == "")
            {
                buttonLogin.Enabled = false;
            }
            else
                buttonLogin.Enabled = true;
        }


        private void comboBoxUser_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBoxUser.Text == "")
            {
                buttonLogin.Enabled = false;
            }
            else
                buttonLogin.Enabled = true;
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboxType_Validated(object sender, EventArgs e)
        {
            if (comboxType.Text.Length == 0)
            {
                comboBoxUser.Enabled = false;
            }
            else
            {
                comboBoxUser.Enabled = true;
            }
        }

#endregion

            #region 窗口移动


        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            int xOffset;

            int yOffset;

            if (e.Button == MouseButtons.Left)
            {

                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;

                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;

                mouseOffset = new Point(xOffset, yOffset);

                isMouseDown = true;

            }
        }
        //private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    int xOffset;

        //    int yOffset;

        //    if (e.Button == MouseButtons.Left)
        //    {

        //        xOffset = -e.X - SystemInformation.FrameBorderSize.Width;

        //        yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;

        //        mouseOffset = new Point(xOffset, yOffset);

        //        isMouseDown = true;

        //    }
        //}

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {

                Point mousePos = Control.MousePosition;

                mousePos.Offset(mouseOffset.X, mouseOffset.Y);

                Location = mousePos;

            }
        }
        //private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isMouseDown)
        //    {

        //        Point mousePos = Control.MousePosition;

        //        mousePos.Offset(mouseOffset.X, mouseOffset.Y);

        //        Location = mousePos;

        //    }
        //}

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            // 修改鼠标状态isMouseDown的值

            // 确保只有鼠标左键按下并移动时，才移动窗体

            if (e.Button == MouseButtons.Left)
            {

                isMouseDown = false;

            }
        }

  
        //private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    // 修改鼠标状态isMouseDown的值

        //    // 确保只有鼠标左键按下并移动时，才移动窗体

        //    if (e.Button == MouseButtons.Left)
        //    {

        //        isMouseDown = false;

        //    }
        //}

        #endregion

        #region 下拉形式显示用户名
        private void comboxType_TextChanged(object sender, EventArgs e)
        {
            //UserList("select * from Users where u_Type='" + comboxType.Text + "'");
            dbl.ShowInfoList("select * from Users where u_Type='" + comboxType.Text + "'", "u_Name", comboBoxUser);
        }

        private void comboxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UserList("select * from Users where u_Type='" + comboxType.Text + "'");
            dbl.ShowInfoList("select * from Users where u_Type='" + comboxType.Text + "'", "u_Name", comboBoxUser);
        }
        
        #endregion
   
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");        //调用系统软键盘 
        }
    }
}