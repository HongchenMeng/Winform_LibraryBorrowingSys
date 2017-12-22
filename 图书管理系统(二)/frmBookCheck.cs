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
    public partial class frmBookCheck : Form
    {
        public frmBookCheck()
        {
            InitializeComponent();
        }
        Dbconnection dbc = new Dbconnection();      //调用ClassLibrary 中的 ds 方法来显示数据
        private void frmBookCheck_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //显示所有的读者的信息
            ShowInfo("select BookID 图书编号,Strichcode 条形码,SlassificationID 图书分类,BookName 图书名称,Type1 图书类型,Author 图书作者,Translator 图书译者,ISBN ISBN码,Publisher 出版社,Revision 图书版次,Format 图书开本,Word 图书字数,Page 图书页码,Price 图书价格,EnterTime 入馆时间,Qty 库存数目,Extant 可借数量,Circulate 是否流通 FROM Book");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ShowInfo("select BookID 图书编号,Strichcode 条形码,SlassificationID 图书分类,BookName 图书名称,Type1 图书类型,Author 图书作者,Translator 图书译者,ISBN ISBN码,Publisher 出版社,Revision 图书版次,Format 图书开本,Word 图书字数,Page 图书页码,Price 图书价格,EnterTime 入馆时间,Qty 库存数目,Extant 可借数量,Circulate 是否流通 FROM Book WHERE(BookName LIKE '%" + textBox1.Text.Trim() + "%')");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ShowInfo("select BookID 图书编号,Strichcode 条形码,SlassificationID 图书分类,BookName 图书名称,Type1 图书类型,Author 图书作者,Translator 图书译者,ISBN ISBN码,Publisher 出版社,Revision 图书版次,Format 图书开本,Word 图书字数,Page 图书页码,Price 图书价格,EnterTime 入馆时间,Qty 库存数目,Extant 可借数量,Circulate 是否流通 FROM Book WHERE(BookID LIKE '%" + textBox2.Text.Trim() + "%')");
        }

        public static string BookID,BookName,BookAuhor,BookPblisher,BookPrice, BookStore;
        private void butOk_Click(object sender, EventArgs e)
        {
            BookID= dgvBook.SelectedCells[0].Value.ToString();
            BookName  = dgvBook.SelectedCells[3].Value.ToString();
            BookAuhor = dgvBook.SelectedCells[5].Value.ToString();
            BookPblisher = dgvBook.SelectedCells[8].Value.ToString();
            BookPrice = dgvBook.SelectedCells[13].Value.ToString();
            BookStore = dgvBook.SelectedCells[16].Value.ToString();
            this.Close();
        }

        private void ShowInfo(string sql)
        {
            DataSet dsb = new DataSet();
                dsb = dbc.ds(sql);
                dgvBook.DataSource = dsb;
                dgvBook.DataMember = dsb.Tables[0].ToString();
        }
        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            butOk_Click(sender,e);
        }
    }
}