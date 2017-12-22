using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ClassLibrary;
using System.Data.SqlClient;

namespace 图书管理系统_二_
{
    public partial class frmBorrowReport : Form
    {
        public frmBorrowReport()
        {
            InitializeComponent();
        }
        
        private void frmBorrowReport_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load("LibraryReport1.rpt");
            string strSql = "SELECT CardId,BookID,BookName,Author,Publisher,Price,BorrowDate,SpilthDay FROM Borrow";
            Dblink db = new Dblink();
            //以SQL语句为参数，产生一个Dataset
            DataSet dsTemp = db.GetDatasetReport(strSql, "Borrow");
            DataTable dt = new DataTable();
            dt = dsTemp.Tables[0];
            rd.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rd;
        }
    }
}