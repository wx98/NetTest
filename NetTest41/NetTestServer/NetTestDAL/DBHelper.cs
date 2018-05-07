using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NetTestDAL
{
   
        /// <summary>
        /// 数据库操作类
        /// </summary>
        public class DBHelper
        {

            public static String constring = " Database=NetTest;Server=192.168.18.162;User ID=sa;Password=sa;";
            private SqlConnection con;
            private SqlCommand cmd;
            public DBHelper(SqlConnection con)
            {
                con.Open();
                this.con = con;
                cmd = new SqlCommand();
                cmd.Connection = con;
            }

            public int executeCommand(String sql)
            {
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                return cmd.ExecuteNonQuery();
            }
            public int executeCommand(String sql, params SqlParameter[] values)
            {
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(values);
                return cmd.ExecuteNonQuery();
            }
            public SqlDataReader getReader(String sql)
            {
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            public SqlDataReader getReader(String sql, params SqlParameter[] values)
            {
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(values);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            public SqlDataAdapter getAdapter(String sql)
            {
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                return adapter;
            }
            public SqlDataAdapter getAdapter(String sql, params SqlParameter[] values)
            {
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(values);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                return adapter;
            }
            public int getScalar(String sql)
            {
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                return (int)cmd.ExecuteScalar();
            }
            public int getScalar(String sql, params SqlParameter[] values)
            {
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(values);
                return (int)cmd.ExecuteScalar();
            }
        }

   
}
