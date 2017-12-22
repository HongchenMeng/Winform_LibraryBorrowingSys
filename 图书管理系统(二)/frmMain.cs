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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //定义
        //frmChangepass fcp;
        //frmAbout fa;
        //frmbackup fba;
        Dbconnection db = new Dbconnection();
        Dblink dbl = new Dblink();
        frmMemorandum fmr = new frmMemorandum();
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (frmlogin.type == "普通用户")
            {
                用户管理UToolStripMenuItem.Enabled = false;
            }
            //设置时间和日期
            tssl1.Text = "今天日期：" + System.DateTime.Now.ToLongDateString ();
            tssl2.Text = "登录时间：" + System.DateTime.Now.ToLongTimeString();
            tsslLoginUser.Text = "当前用户："+" " +frmlogin .userName;
            //系统启动时导航栏的状态
            listView1.Clear();
            listView1.LargeImageList = imageList1;
            listView1.Items.Add("借阅管理", "  借阅管理", 0);
            listView1.Items.Add("借阅查询", "  借阅查询", 1);
            listView1.Items.Add("操作流水", "  操作流水", 2);
            listView1.Items.Add("预借详情", "  预借详情", 3);
            listView1.Items.Add("帐务管理", "  帐务管理", 4);
            listView1.Items.Add("备忘管理", "  备忘管理", 5);
            //起始窗口布局
            层叠窗口CToolStripMenuItem.Checked = true;
            this.LayoutMdi(MdiLayout.Cascade);
            竖排窗口VToolStripMenuItem.Checked = false;
            横排窗口HToolStripMenuItem.Checked = false;
            toolStrip1.AutoSize = false;
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            notifyIcon1.Visible = false;
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged );
            //Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;   //获得屏幕宽度
            tssl1.Width = this.Width / 5;
            tssl2.Width = this.Width /5;
            tssl3.Width = this.Width / 5;
            tsslLoginUser.Width = this.Width /5;
            

            //插入登录记录
            string time=dbl.GetTime(3);
            int Number = dbl.AutoNumber("select Max(Number) from Journal");
            db.ExeInfochange("insert into Journal values ("+Number+",'" + frmlogin.userName + "','" + frmlogin.type + "','" + time + "')");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssl3.Text = "现在时间：" + System.DateTime.Now.ToLongTimeString();
            string time = dbl.Remindtime();
            if (Convert.ToInt32(db.ExecuteSelect("select * from Remind where RemindTime='" + time + "'and IsRemind='是' and Statue='尚未提示'")) > 0)
            {
                DataSet ds = new DataSet();
                ds = dbl.GetDataset("select * from Remind where RemindTime='" + time + "'");
                string Reminid =Convert .ToString ( ds.Tables[0].Rows[0][3]);         //获得备忘表中的备忘记录
                string type = Convert.ToString(ds.Tables[0].Rows[0][5]);
                if (type == "一次提醒")
                {
                    db.ExeInfochange("update Remind set Statue='已经提示' where RemindTime='" + time + "'");   //更改提示的状态

                }
                if (MessageBox.Show("\n 您有新的备忘：        \n \n" + "    " + Reminid+"    ", "备忘提示", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fmr.Refresh ();
                }
            }
        }

        #region 导航栏

        
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Dock = DockStyle.None;

            button1.Dock = DockStyle.Top;
            // button5.SendToBack();
            button5.Dock = DockStyle.Bottom;
            button4.SendToBack();
            button4.Dock = DockStyle.Bottom;
            button3.SendToBack();
            button3.Dock = DockStyle.Bottom;
            button2.SendToBack();
            button2.Dock = DockStyle.Bottom;
            //listView1.BringToFront();
            listView1.Dock = DockStyle.Bottom;
            listView1.Clear();
            listView1.Items.Add("借阅管理", "  借阅管理", 0);
            listView1.Items.Add("借阅查询", "  借阅查询", 1);
            listView1.Items.Add("操作流水", "  操作流水", 2);
            listView1.Items.Add("预借详情", "  预借详情", 3);
            listView1.Items.Add("帐务管理", "  帐务管理", 4);
            listView1.Items.Add("备忘管理", "  备忘管理", 5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Dock = DockStyle.None;

            // button5.SendToBack();    两排显示
            button5.Dock = DockStyle.Top;
            button1.SendToBack();
            button1.Dock = DockStyle.Top;

            button4.SendToBack();
            button4.Dock = DockStyle.Bottom;
            button3.SendToBack();
            button3.Dock = DockStyle.Bottom;
            button2.SendToBack();
            button2.Dock = DockStyle.Bottom;
            listView1.Dock = DockStyle.Bottom;
            listView1.Clear();
            listView1.Items.Add("书籍管理", "  书籍管理", 6);
            listView1.Items.Add("期刊管理", "   期刊管理", 7);
            listView1.Items.Add("物品管理", "  物品管理", 8);
            listView1.Items.Add("读者管理", "  读者管理", 9);
            listView1.Items.Add("类别资料", "  类别资料", 10);
            listView1.Items.Add("资料下架管理", " 资料下架管理", 11);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Dock = DockStyle.None;

            //button4.SendToBack();
            button4.Dock = DockStyle.Top;
            button5.SendToBack();
            button5.Dock = DockStyle.Top;
            button1.SendToBack();
            button1.Dock = DockStyle.Top;

            button3.SendToBack();
            button3.Dock = DockStyle.Bottom;
            button2.SendToBack();
            button2.Dock = DockStyle.Bottom;
            listView1.Dock = DockStyle.Bottom;
            listView1.Clear();
            listView1.Items.Add("借阅排行榜", " 借阅排行榜", 12);
            listView1.Items.Add("资料状态统计", " 资料状态统计", 13);
            listView1.Items.Add("借阅统计分析", " 借阅统计分析", 14);
            listView1.Items.Add("图书类别统计", " 图书类别统计", 15);
            listView1.Items.Add("数据资料盘点", " 数据资料盘点", 16);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Dock = DockStyle.None;

            //button3.SendToBack();
            button3.Dock = DockStyle.Top;
            button4.SendToBack();
            button4.Dock = DockStyle.Top;
            button5.SendToBack();
            button5.Dock = DockStyle.Top;
            button1.SendToBack();
            button1.Dock = DockStyle.Top;

            button2.SendToBack();
            button2.Dock = DockStyle.Bottom;
            listView1.Dock = DockStyle.Bottom;
            listView1.Clear();
            listView1.Items.Add("读者当前借阅", " 读者当前借阅", 17);
            listView1.Items.Add("读者借阅日志", " 读者借阅日志", 18);
            listView1.Items.Add("资料当前借阅", " 资料当前借阅", 19);
            listView1.Items.Add("资料借阅日志", " 资料借阅日志", 20);
            listView1.Items.Add("系统条码标签", " 系统条码标签", 21);
            listView1.Items.Add("自定条码标签", " 自定条码标签", 22);
            listView1.Items.Add("系统书标制作", " 系统书标制作", 23);
            listView1.Items.Add("自定书标制作", " 自定书标制作", 24);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Dock = DockStyle.None;

            //button2.SendToBack();
            button2.Dock = DockStyle.Top;
            button3.SendToBack();
            button3.Dock = DockStyle.Top;
            button4.SendToBack();
            button4.Dock = DockStyle.Top;
            button5.SendToBack();
            button5.Dock = DockStyle.Top;
            button1.SendToBack();
            button1.Dock = DockStyle.Top;

            listView1.Dock = DockStyle.Bottom;
            listView1.Clear();
            listView1.Items.Add("用户管理", "  用户管理", 25);
            listView1.Items.Add("切换用户", "  切换用户", 26);
            listView1.Items.Add("修改密码", "  修改密码", 27);
            listView1.Items.Add("系统参数", "  系统参数", 28);
            listView1.Items.Add("备份管理", "  备份管理", 29);
            listView1.Items.Add("系统初始化", "  系统初始化", 30);
            listView1.Items.Add("暂时离开", "  暂时离开", 31);
            listView1.Items.Add("数据库连接", " 数据库连接", 32);
            listView1.Items.Add("系统界面", "  系统界面", 33);

        }
        #endregion

        #region  导航栏字体改变
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font, button1.Font.Style | FontStyle.Bold);
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font, button1.Font.Style ^ FontStyle.Bold);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Font = new Font(button1.Font, button5.Font.Style ^ FontStyle.Bold);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.Font = new Font(button5.Font, button1.Font.Style | FontStyle.Bold);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Font = new Font(button4.Font, button1.Font.Style | FontStyle.Bold);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Font = new Font(button1.Font, button4.Font.Style ^ FontStyle.Bold);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Font = new Font(button1.Font, button3.Font.Style ^ FontStyle.Bold);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Font = new Font(button3.Font, button1.Font.Style | FontStyle.Bold);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Font = new Font(button2.Font, button1.Font.Style | FontStyle.Bold);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Font = new Font(button1.Font, button2.Font.Style ^ FontStyle.Bold);
        }
        #endregion

        #region 导航单击快捷方式

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (frmlogin.type == "超级用户")
            {
                if (listView1.SelectedItems[0].Text == "  用户管理")
                {
                    frmUsercontrol fuc = new frmUsercontrol();
                    fuc.Owner = this;
                    fuc.ShowDialog();
                }
            }
            else
            {
                ;
            }
            if (listView1.SelectedItems[0].Text == "  切换用户")
            {
                切换用户LToolStripMenuItem_Click(sender,e);
            }
            if (listView1.SelectedItems[0].Text == "  修改密码")
            {
                修改密码MToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "  备份管理")
            {
                备份管理BToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "  读者管理")
            {
                读者资料管理PToolStripMenuItem_Click(sender, e);
            }
           if (listView1.SelectedItems[0].Text == "  操作流水")
            {
                操作流水HToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "  借阅查询")
            {
                借阅查询BToolStripMenuItem_Click(sender,e);
            }
            if (listView1.SelectedItems[0].Text == "  系统初始化")
            {
                系统初始化IToolStripMenuItem_Click(sender,e);
            }
            if (listView1.SelectedItems[0].Text == "  借阅管理")
            {
                toolStripButton2_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "  预借详情")
            {
                预借查询PToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "  书籍管理")
            {
                if (!OnlyOpen("frmBookManage", "  书籍管理"))
                {
                    frmBookManage fbm = new frmBookManage();
                    fbm.MdiParent = this;
                    fbm.Show();
                }
                //读者资料管理PToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "  暂时离开")
            {
                 暂时离开OToolStripMenuItem_Click(sender, e);
            }

            if (listView1.SelectedItems[0].Text == "  备忘管理")
            {
                  备忘管理RToolStripMenuItem_Click(sender,e);
            }
           
            if (listView1.SelectedItems[0].Text == "  系统参数")
            {
                if (!OnlyOpen("frmSystemSet", "  系统参数"))
                {
                    frmSystemSet fss = new frmSystemSet();
                    fss.ShowDialog();
                }
            }    
        }

        #endregion 

        #region  窗口布局
        //窗口布局
        //private void 平铺窗口AToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.LayoutMdi(MdiLayout.TileHorizontal);
        //}

        
        private void 竖排窗口VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            竖排窗口VToolStripMenuItem.Checked =true;
            this.LayoutMdi(MdiLayout.TileVertical);
            横排窗口HToolStripMenuItem.Checked = false;
            层叠窗口CToolStripMenuItem.Checked = false;
        }

        private void 层叠窗口CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            层叠窗口CToolStripMenuItem.Checked = true;
            this.LayoutMdi(MdiLayout.Cascade );
            竖排窗口VToolStripMenuItem.Checked = false;
            横排窗口HToolStripMenuItem.Checked = false;
        }

        private void 横排窗口HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            横排窗口HToolStripMenuItem.Checked =true;
            this.LayoutMdi(MdiLayout.TileHorizontal);
            层叠窗口CToolStripMenuItem.Checked = false;
            竖排窗口VToolStripMenuItem.Checked = false;

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)//隐藏和显示状态栏
        {
            statusStrip1.Visible = !statusStrip1.Visible;
            toolStripMenuItem8.Checked=!toolStripMenuItem8.Checked;
            listView1.Height = this.panel1.Height - 127;
          
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)//隐藏和显示工具栏
        {
            toolStrip1.Visible = !toolStrip1.Visible;
            toolStripMenuItem7.Checked = !toolStripMenuItem7.Checked;
            listView1.Height =this.panel1.Height - 127;
         
        }
        #endregion

        #region  菜单栏和工具栏
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "帮助.chm");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //如果有子窗口,则关闭子窗体
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }
        private void 借阅管理IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton2_Click(sender, e);
        }

        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Help.ShowHelp(this, "帮助.chm");//调用帮助
        }
        private void 关闭所有SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //关闭所有子窗体(提取所有的子窗体,然后一个一个的关闭)

            //Form[] frmList = this.MdiChildren;
            //foreach (Form frm in frmList)
            //{
            //    frm.Close();
            //}   
            foreach (Form _form in this.MdiChildren)
            {
                _form.Close();
            }
        }
        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmAbout", "关于"))
            {
                frmAbout fm = new frmAbout();
                fm.MdiParent = this;
                fm.Show();
            }
        }
        private void 备份管理BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmbackup", "备份管理"))
            {
                frmBackup fbu = new frmBackup();
                fbu.ShowDialog();
            }
        }

        private void 系统参数YToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmSystemSet", "系统参数"))
            {
                frmSystemSet fss = new frmSystemSet();
                fss.ShowDialog();
            }
        }

        private void 系统初始化IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmDataDelete", "系统初始化"))
            {
                frmDataDelete fdd = new frmDataDelete();
                fdd.ShowDialog();
            }
        }

        private void 办卡管理CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmReaderAdd", "读者添加"))
            {
                frmReaderAdd fra = new frmReaderAdd();
                fra.MdiParent = this;
                fra.Show();
            }
        }
        private void 修改密码MToolStripMenuItem_Click(object sender, EventArgs e)
        {
                frmChangepass fcp = new frmChangepass();
                fcp.ShowDialog();
        }

        private void 操作流水HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmHandleNote", "操作流水"))
            {
                frmHandleNote fhn = new frmHandleNote();
                fhn.MdiParent = this;
                fhn.Show();
            }
        }

        private void 暂时离开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeavetime flt = new frmLeavetime();
            flt.ShowDialog();
            contextMenuStrip1.Enabled = false;
        }

        private void 切换用户LToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            this.Dispose();
            frmlogin fl = new frmlogin();
            fl.ShowDialog();
        }

        private void 用户管理UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsercontrol fuc = new frmUsercontrol();
            fuc.ShowDialog();
        }

        private void 借阅查询BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmBorselect", "借阅查询"))
            {
                frmBorselect fbs = new frmBorselect();
                fbs.MdiParent = this;
                fbs.Show();
            }
        }


        private void 查看登录日志DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmLodingJournal", "查看登录日志"))
            {
                frmLodingJournal flj = new frmLodingJournal();
                flj.MdiParent = this;
                flj.Show();
            }
        }
        private void 读者资料管理PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmReaderManage", "读者资料管理"))
            {
                frmReaderManage frm = new frmReaderManage();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void 备忘管理RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmMemorandum", "备忘管理"))
            {
                frmMemorandum fm = new frmMemorandum();
                fm.MdiParent = this;
                fm.Show();
            }
        }
        private void 预借查询PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmReserBroInfo", "预借查询"))
            {
                frmReserBroInfo frb = new frmReserBroInfo();
                frb.MinimizeBox = true;
                frb.MaximizeBox = true;
                frb.StartPosition = FormStartPosition.Manual;
                frb.MdiParent = this;
                frb.Show();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)    //单击“出借资料”按钮事件
        {
            frmBookAbout fba = new frmBookAbout();
            fba.rdbBorrow.Checked = true;
            fba.dupBroTime.Visible = true;
            fba.label3.Visible = true;
            fba.dupBookNumber.Visible = true;
            fba.label2.Visible = true;
            if (!OnlyOpen("frmBookAbout", "出借资料"))
            {
                fba.MdiParent = this;
                fba.Show();
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)       //单击“归还资料”按钮事件
        {
            frmBookAbout fba = new frmBookAbout();
            fba.rdbReback.Checked = true;
            fba.dupBroTime.Visible = false;
            fba.label3.Visible = false;
            fba.dupBookNumber.Visible = true;
            fba.label2.Visible = true;
            if (!OnlyOpen("frmBookAbout", "归还资料"))
            {
                fba.MdiParent = this;
                fba.Show();
            }
        }
        private void notepadNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");//调用系统记事本 
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");   //调用系统Word 文档 
        }

        private void excelEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel.exe");// 调用系统Excel 

        }
        private void calcuatorCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");// 调用系统计算器
        }

        #endregion

        #region 窗口效果

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //导航栏的收\放
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                this.panel1.Width = 0;
            }
            else
            {
                panel1.Visible = true;
                this.panel1.Width = 117;
            }
        }
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)  //判断是否最小化
            {
                this.ShowInTaskbar = false;  //不显示在系统任务栏
                notifyIcon1.Visible = true;  //托盘图标可见
            }

            listView1.Height = this.panel1.Height - 127;//,窗口拖放时,设置高度的大小
        }

        private void timer2_Tick(object sender, EventArgs e)     //窗口的渐显 
        {
            this.Opacity += 0.1;
            if (Opacity == 1)
            {
                timer2.Dispose();
            }
        }

        private void frmMain_SizeChanged_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)  //如果窗体当前是最小化   
            {
                this.ShowInTaskbar = false;
                this.notifyIcon1.Visible = true;
            }   
            listView1.Height = this.panel1.Height - 129;
        }
     

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)    //双击托盘图标，实现最大化
        {
            if (this.WindowState == FormWindowState.Minimized)
            {  
                //如果窗口是最小化,则把它最大化
                this.WindowState = FormWindowState.Maximized;
                this.Activate();
                this.notifyIcon1.Visible = false;
                this.ShowInTaskbar = true;
            }
        }


        public bool OnlyOpen(string MdiChildrenClassName, string funtion)
        {
            //遍历每一个MDI子窗体实例
            foreach (Form childFrm in this.MdiChildren)
            {
                //若子窗体的类型与实参相同,则存在该类的实例
                if (childFrm.Name == MdiChildrenClassName)
                {
                    //若该窗体被最小化了,则显将其恢复到原来状态
                    if (childFrm.WindowState == FormWindowState.Minimized)
                    {
                        childFrm.WindowState = FormWindowState.Normal;
                    }
                    childFrm.Activate();
                    return true;
                }
            }
            return false;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            tssl1.Width = this.Width / 5;
            tssl2.Width = this.Width / 5;
            tssl3.Width = this.Width / 5;
            tsslLoginUser.Width = this.Width /5;
        }
        #endregion

        #region  最小化右键菜单

        private void 最小化IToolStripMenuItem_Click(object sender, EventArgs e)
        {
             WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar =false;  //不显示在系统任务栏
        }

        private void 最大化MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = true;  //显示在系统任务栏
        }

#endregion

        #region 退出系统前提示

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //退出系统之前提示
            QuitAnswer();
        }
        
        private void frmMain_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitAnswer();
        }

        private void 退出系统QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitAnswer();
        }

        public void QuitAnswer()  //退出前提示
        {   
                Application.Exit();
        }

        private void frmMain_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您将退出系统,是否继续？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region  主窗体右键菜单
        private void 暂时离开LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            暂时离开OToolStripMenuItem_Click(sender, e);
        }

        private void tsmBookBorrow_Click(object sender, EventArgs e)
        {
            toolStripButton2_Click(sender, e);
        }

        private void tsmBookReBack_Click(object sender, EventArgs e)
        {
            toolStripButton3_Click(sender, e);
        }
        #endregion

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

#region       没有使用的代码
   //private void notifyIcon1_Click(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Minimized)
        //        this.WindowState = FormWindowState.Maximized;
        //    this.Activate();
        //    this.notifyIcon1.Visible = false;
        //    this.ShowInTaskbar = true;   
        //}

      
        //private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        //{
        //    this.ShowInTaskbar =false;  //显示在系统任务栏
        //    if (this.WindowState == FormWindowState.Minimized)
        //    {

        //        if (this.WindowState == FormWindowState.Minimized)
        //        this.WindowState = FormWindowState.Normal;
        //        this.Activate();
        //        this.notifyIcon1.Visible = false;
        //        this.ShowInTaskbar = true;   

        //    }

        //}


        //if (MessageBox.Show("您真想退出本系统吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
          
     //private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Minimized)
        //    {
        //       // this.ShowInTaskbar = true;  //显示在系统任务栏
        //        this.WindowState = FormWindowState.Normal;  //还原窗体
        //        notifyIcon1.Visible = true;  //托盘图标隐藏
        //    }

        //}
 
#endregion