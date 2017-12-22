using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;
using System.Data .SqlClient ;
using System.Windows.Forms;


namespace ClassLibrary
{
    public class Dblink
    {
        string strConn = "server=.;database =51asp.net_Library;uid=sa;pwd=123456";
        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>DataSet GetDataset</returns>
        public DataSet GetDataset(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                int i = adapter.Fill(ds);
                if (i == 0)
                    return null;
                else
                    return ds;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 水晶报表的数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="table"></param>
        /// <returns>DataSet GetDatasetReport</returns>
        public DataSet GetDatasetReport(string sql,string table)
        {
            try
            {
                DataSet ds = new DataSet();
                //string strConn = "server=.;database =51asp.net_Library;uid=sa;pwd=51asp.net";
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                int i = adapter.Fill(ds,table);
                if (i == 0)
                    return null;
                else
                    return ds;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 将DataGridView控件中数据导出到Excel
        /// </summary>
        /// <param name="gridView">DataGridView对象</param>
        /// <param name="isShowExcle">是否显示Excel界面</param>
        /// <returns></returns>
        public bool ShowDgvInfo(DataGridView gridView, bool isShowExcle)
        {
                if (gridView.Rows.Count == 0)
                  return false;
                //建立Excel对象
          
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                //excel.Application.Workbooks.Add(true);
                //excel.Visible = isShowExcle;
                //生成字段名称
                for (int i = 0; i < gridView.ColumnCount; i++)
                {
                   // excel.Cells[1, i + 1] = gridView.Columns[i].HeaderText;
                }
                //填充数据
                try
                {
                    for (int i = 0; i < gridView.RowCount; i++)
                    {
                        for (int j = 0; j < gridView.ColumnCount; j++)
                        {
                            if (gridView[j, i].ValueType == typeof(string))
                            {
                              //  excel.Cells[i + 2, j + 1] = "'" + gridView[j, i].Value.ToString();
                            }
                            else
                            {
                               // excel.Cells[i + 2, j + 1] = gridView[j, i].Value.ToString();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                   // MessageBox.Show(Ex.Message);
                    ;
                }
                return true;
        }

        /// <summary>
        ///  下拉形式显示数据
        /// </summary>
        /// <param name="Sql">Sql 语句</param>
        /// <param name="field">字段名</param>
        /// <param name="name">ComboBox名称</param>
        public void ShowInfoList(string Sql,string field,ComboBox name)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                SqlDataAdapter da = new SqlDataAdapter(Sql, conn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                name.DataSource = ds.Tables[0];      //以下拉的形式显示所有用户名
                name.DisplayMember = field;
                conn.Close();
            }
            catch (Exception)
            {
                ;
            }
        }

        /// <summary>
        /// 获得时间字符串
        /// </summary>
        /// <returns>时间字符串</returns>
        public string GetTime(int Number)
        {
            DateTime Str = Convert.ToDateTime(DateTime.Now.ToString ());
            string Mditime = Str.ToString("yyyy/MM/dd hh:mm:ss");
           // string Time = Str.ToString().Substring(0,Number);
            string Time = Mditime.Substring(0,Mditime .Length -Number);
            return Time;
        }

        /// <summary>
        /// 获得备忘时间
        /// </summary>
        /// <returns></returns>
        public string Remindtime()
        {
            DateTime Str = Convert.ToDateTime(DateTime.Now.ToString());
            string RemindTime = Str.ToString();
            return RemindTime;
        }
        /// <summary>
        /// 自动编号
        /// </summary>
        /// <returns>获得的编号</returns>
        public int AutoNumber(string Sql)
        {
            DataSet ds=new DataSet ();
            string SqlMax = Sql;
            ds = GetDataset(SqlMax);
            int Number = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString())+1;
            //string MaxNumber = Convert.ToString(number);
            return Number;
        }

        /// <summary>
        /// 显示DGV数据
        /// </summary>
        /// <param name="str">sql 查询语句</param>
        /// <param name="dgv">DataGridView</param>
        public void InfoShow(string str, DataGridView dgv)
        {
            try
            {
                DataSet dsNote;
                string strSql = str;
                Dbconnection dbc = new Dbconnection();      //调用ClassLibrary 中的 ds 方法来显示数据
                dsNote = dbc.ds(strSql);
                dgv.DataSource = dsNote;
                dgv.DataMember = dsNote.Tables[0].ToString();
            }
            catch (Exception)
            {
                ;
            }
        }
    }
}
