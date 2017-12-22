using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;
using System.IO;
using System.Data.SqlClient;

namespace 图书管理系统_二_
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        string waybackup;
        Dblink dbl=new Dblink ();
        private void frmbackup_Load(object sender, EventArgs e)
        {
            //初始化文件的类型
            saveFileDialog1.Filter = "数据库备份文件(*.bak)|*.bak|数据库(*.mdf)|*.mdf";
            openFileDialog1.Filter = "数据库还原文件(*.bak)|*.bak|数据库(*.mdf)|*.mdf";
            cmbDataType.SelectedIndex = 0;       //默认为"数据库备份"
            this.MinimizeBox = false;
            InfoShow();
        }

        private void butBackWay_Click(object sender, EventArgs e)
        {
                if (cmbDataType.Text == "数据库备份")
                {
                       saveFileDialog1.Title = "选择数据库备份路径";
                       saveFileDialog1.ShowDialog();            //弹出保存对话框
                       txtBackupWay.Text = saveFileDialog1.FileName;    //获得备份路径
                       waybackup=txtBackupWay.Text;
                }
                else
                {
                        openFileDialog1.Title = "选择数据库还原路径";
                        openFileDialog1.ShowDialog();            //弹出打开对话框
                        txtBackupWay.Text = openFileDialog1.FileName;      //获得还原的数据库路径
                }
            }
        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void InserInfo(string str)
        {
            //添加备份日志
            string connectionString = "server=.;database =51asp.net_Library;uid=sa;pwd=51asp.net";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            string sql = str;    //添加相应的记录  
            SqlCommand scomd1 = new SqlCommand(sql, myConnection);
            scomd1.ExecuteNonQuery();
            myConnection.Close();
            myConnection.Dispose();
        }
        private void butOk_Click(object sender, EventArgs e)
        {
            if (cmbDataType.Text == "数据库备份")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "server=.;database =51asp.net_Library;uid=sa;pwd=51asp.net";
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    //实现数据库备份
                    com.CommandText = "BACKUP DATABASE " + "Library" + " TO DISK = '" + waybackup + "'";
                    com.Connection = con;
                    int number =com.ExecuteNonQuery();
                    if (number== -1)
                    {
                        MessageBox.Show("数据库备份成功！", "提示");
                        string time= dbl.GetTime(3);
                        int Number1 = dbl.AutoNumber("select Max(Number) from Backupinfo");
                        string strSql = "insert into Backupinfo values (" + Number1 + ",'" + frmlogin.userName + "','" + time + "','" + cmbDataType.Text + "','" + txtBackupWay.Text + "')";
                        InserInfo(strSql);
                    }
                    con.Close();
                    con.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("数据库备份失败！", "提示");
                }
            }
            else
            {
                if(cmbDataType.Text == "数据库还原")
                try
                {
                    //实现数据库还原
                    string SqlStr1 = "server=.;database =51asp.net_Library;uid=sa;pwd=51asp.net";
                    SqlConnection con = new SqlConnection(SqlStr1);
                    con.Open();
                    string SqlStr2 = "use master restore database " + "Library" + " from disk='" + txtBackupWay.Text+ "'";
                    //string SqlStr2 = "insert into Backupinfo values ('123','2008-12-5','D:')";
                    SqlCommand cmd = new SqlCommand(SqlStr2, con);
                    cmd.Connection = con;
                    int number =cmd.ExecuteNonQuery();
                    if (number== -1)
                    {
                        MessageBox.Show("还原数据库成功！", "提示");
                        string time = dbl.GetTime(3);
                        int Number2 = dbl.AutoNumber("select Max(Number) from Backupinfo");
                        string strSql1 = "insert into Backupinfo values (," + Number2 + "," + frmlogin.userName + "','" + time + "','" + cmbDataType.Text + "','" + txtBackupWay.Text + "')";
                        InserInfo(strSql1);
                    }
                    con.Close();
                    con.Dispose();
                }
                catch (Exception)
                {
                   //throw new Exception(ce.Message);
                   MessageBox.Show("数据库还原失败！","提示");
                }
            }
        }

        private void butSure_Click(object sender, EventArgs e)
        {
            InfoShow();
        }
        public void InfoShow()   //显示日志信息
        {
            DataSet backupinfo;
            string strSql = "select Number 流水编号,lodUser 登录用户,BackupTime 登录时间,Type 操作类型,BackupWay 备份路径 FROM Backupinfo";
            Dbconnection dbc = new Dbconnection();      //调用ClassLibrary 中的 ds 方法来显示数据
            backupinfo = dbc.ds(strSql);
            dgvBackupinfo.DataSource = backupinfo;
            dgvBackupinfo.DataMember = backupinfo.Tables[0].ToString();
        }
    }
}