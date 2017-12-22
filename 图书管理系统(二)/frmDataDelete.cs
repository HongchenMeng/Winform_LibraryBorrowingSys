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
    public partial class frmDataDelete : Form
    {
        public frmDataDelete()
        {
            InitializeComponent();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDataDelete_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        #region  Checkbox的选择
        private void IsCheckNone_Click(object sender, EventArgs e)
        {
            //全选和反选的Checked属性变为False,全不选的Checked属性变为False并且所有的表是未选中状态
            IsCheckAll.Checked = false;
            IsCheckNone.Checked = true;
            IsCheckObv.Checked = false;
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked =false;
            CheckBox6.Checked = false;
            CheckBox7.Checked = false;
            CheckBox8.Checked = false;
            CheckBox9.Checked = false;
            CheckBox10.Checked = false;
            CheckBox11.Checked = false;
            CheckBox11.Checked = false;
            CheckBox12.Checked = false;
            CheckBox13.Checked = false;
        }

        private void IsCheckAll_Click(object sender, EventArgs e)
        {
            //全不选和反选的Checked属性变为False,全选的Checked属性变为True并且所有的表是选中状态
            IsCheckAll.Checked = true;
            IsCheckNone.Checked = false;
            IsCheckObv.Checked = false;
            CheckBox1.Checked = true;
            CheckBox2.Checked = true;
            CheckBox3.Checked = true;
            CheckBox4.Checked = true;
            CheckBox5.Checked = true;
            CheckBox6.Checked = true;
            CheckBox7.Checked = true;
            CheckBox8.Checked = true;
            CheckBox9.Checked = true;
            CheckBox10.Checked = true;
            CheckBox11.Checked = true;
            CheckBox11.Checked = true;
            CheckBox12.Checked = true;
            CheckBox13.Checked = true;
        }

        private void IsCheckObv_Click(object sender, EventArgs e)
        {
            //全不选和全选的Checked属性变为False,反选的Checked属性变为True并且所有的表是反选中状态
            IsCheckAll.Checked = false;
            IsCheckNone.Checked = false;
            IsCheckObv.Checked = true;
            CheckBox1.Checked = !CheckBox1.Checked;
            CheckBox2.Checked = !CheckBox2.Checked;
            CheckBox3.Checked = !CheckBox3.Checked;
            CheckBox4.Checked = !CheckBox4.Checked;
            CheckBox5.Checked = !CheckBox5.Checked;
            CheckBox6.Checked = !CheckBox6.Checked;
            CheckBox7.Checked = !CheckBox7.Checked;
            CheckBox8.Checked = !CheckBox8.Checked;
            CheckBox9.Checked = !CheckBox9.Checked;
            CheckBox10.Checked = !CheckBox10.Checked;
            CheckBox11.Checked = !CheckBox11.Checked;
            CheckBox12.Checked = !CheckBox12.Checked;
            CheckBox13.Checked = !CheckBox13.Checked;
        }
        #endregion

        private void tsbOk_Click(object sender, EventArgs e)
        {
            Dbconnection db = new Dbconnection();
            if (MessageBox.Show("您在对数据进行初始化,是否继续？", "敬告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int number = 0;   //记录所选表的个数
                string Str = null;

                #region  判断是否选中表格 有则删除选中表的信息

                if (CheckBox1.Checked  == true)
                {
                    db.ExeInfochange("delete from Book");
                    number++;
                    Str = Str + " 图书表";
                }
                if (CheckBox2.Checked == true)
                {
                    db.ExeInfochange("delete from Reader");
                    number++;
                    Str = Str + " 读者表";
                }
                if (CheckBox3.Checked == true)
                {
                    db.ExeInfochange("delete from Borrow");
                    number++;
                    Str = Str + " 借阅表";
                }
                if (CheckBox4.Checked == true)
                {
                    db.ExeInfochange("delete from Users");
                    number++;
                    Str = Str + " 用户表";
                }
                if (CheckBox5.Checked == true)
                {
                    db.ExeInfochange("delete from OverdueInfo");
                    number++;
                    Str = Str + " 超期表";
                }
                if (CheckBox6.Checked == true)
                {
                    db.ExeInfochange("delete from RenewNote");
                    number++;
                    Str = Str + " 续借表";
                }
                if (CheckBox7.Checked == true)
                {
                    db.ExeInfochange("delete from ReserBroInfo");
                    number++;
                    Str = Str + " 预借表";
                }
                if (CheckBox8.Checked == true)
                {
                    db.ExeInfochange("delete from Publishing");
                    number++;
                    Str = Str + " 出版社表";
                }
                if (CheckBox9.Checked == true)
                {
                    db.ExeInfochange("delete from HandleNote");
                    number++;
                    Str = Str + " 操作日志表";
                }
                if (CheckBox10.Checked == true)
                {
                    db.ExeInfochange("delete from PenaltryInfo");
                    number++;
                    Str = Str + " 罚款表";
                }
                if (CheckBox11.Checked == true)
                {
                    db.ExeInfochange("delete from Backupinfo");
                    number++;
                    Str = Str + " 备份信息表";
                }
                if (CheckBox12.Checked == true)
                {
                    db.ExeInfochange("delete from Journal");
                    number++;
                    Str = Str + " 登录信息表";
                }
                if (CheckBox13.Checked == true)
                {
                    db.ExeInfochange("delete from Remind");
                    number++;
                    Str = Str + " 备忘表";
                }

                #endregion

                if (number == 0)
                {
                    MessageBox.Show("请先选择表,再进行初始化！", "提示");
                }
                else
                {
                    MessageBox.Show("您已成功删除了 " + Str + " \n\n" +number+" 个表的所有数据！", "提示");
                }
            }
            this.Close();
        }
    }
}