using System;
using System.Collections.Generic;
using System.Text;
using System.Data .SqlClient;
using System.Data;
namespace ClassLibrary
{
    public class Dbconnection
    {
        /// <summary>
        /// SQL-server 数据库连接
        /// </summary>
        /// <returns>SqlConnection myConnection</returns>
        public static SqlConnection Dblink()
        {
            string connectionString = "server=.;database =51asp.net_Library;uid=sa;pwd=51asp.net";
            SqlConnection myConnection = new SqlConnection(connectionString);
            //SqlCommand command = new SqlCommand(connectionString);
            return myConnection;
        }

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>int number</returns>
        public int ExeInfochange(string sql)
        {
            try
            {
                SqlConnection myConnection = Dblink();
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = sql;
                myConnection.Open();
                int number = myCommand.ExecuteNonQuery();
                myConnection.Close();
                myConnection.Dispose();
                return number;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 执行 Select 语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object ExecuteSelect(string sql)
        {
            try
            {
                SqlConnection myConnection = Dblink();
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = sql;
                myConnection.Open();
                int number = Convert .ToInt32(myCommand.ExecuteScalar());
                myConnection.Close();
                myConnection.Dispose();
                return number;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="str1"></param>
        /// <returns>DataSet ds</returns>
        public DataSet ds(string str1)
        {
            string sql = str1;
            try
            {
                SqlConnection myConnection = Dblink();
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = sql;
                myConnection.Open();
                SqlDataAdapter myDataReader = new SqlDataAdapter();
                myDataReader.SelectCommand = myCommand;
                DataSet ds = new DataSet();
                myDataReader.Fill(ds);
                myConnection.Close();
                myConnection.Dispose();
                return ds;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}