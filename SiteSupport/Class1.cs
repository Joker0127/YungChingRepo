using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteSupport
{
    public class Class1
    {
        private readonly string ConnectStr = "Data Source=(LocalDB)\\MSSQLLOCALDB;Initial Catalog = Northwind; Persist Security Info=True;User ID = sa;Password=sa; MultipleActiveResultSets=True;Application Name = EntityFramework";


        public DataTable DB_GetDatatable(string str)
        {
            SqlConnection conn = null;
            DataTable dt = new DataTable();
            try
            {
                string connString = ConnectStr;
                conn = new SqlConnection(connString);
                string query = str;
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable DB_GetDatatable(string tablename, string condition)
        {
            SqlConnection conn = null;
            DataTable dt = new DataTable();
            try
            {
                string connString = ConnectStr;
                conn = new SqlConnection(connString);
                string query = $"select * from {tablename}";
                if (condition != string.Empty)
                {
                    query += $" where {condition}";
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool DB_Insert(string tablename, Dictionary<string, object> dic, out int modified)
        {
            SqlConnection conn = null;
            string insertstr = "INSERT INTO ";
            string columnname = tablename + "(";
            string values = "VALUES(";
            try
            {
                //資料處裡
                foreach (KeyValuePair<string, object> item in dic)
                {
                    columnname += item.Key + ",";
                    values += "'" + item.Value + "',";
                }
                columnname = columnname.Substring(0, columnname.Length - 1);
                columnname += ") ";
                values = values.Substring(0, values.Length - 1);
                values += ")";
                insertstr += columnname + values + ";SELECT SCOPE_IDENTITY()";
                //連線新增
                conn = new SqlConnection(ConnectStr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = insertstr;
                conn.Open();
                //cmd.ExecuteNonQuery();
                modified = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException e)
            {
                modified = 0;
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool DB_Update(string tablename, Dictionary<string, object> dic, string condition)
        {
            //update ReportBug set Title = '666' where ID = 27
            SqlConnection conn = null;
            string updatestr = "Update " + tablename + " set ";
            string columnvalue = string.Empty;
            try
            {
                //資料處裡
                foreach (KeyValuePair<string, object> item in dic)
                {
                    columnvalue += item.Key + " = " + item.Value + ",";
                }
                columnvalue = columnvalue.Substring(0, columnvalue.Length - 1);
                updatestr += columnvalue;
                if (condition != string.Empty)
                {
                    updatestr += " where " + condition;
                }
                //連線新增
                conn = new SqlConnection(ConnectStr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = updatestr;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool DB_Delete(string tablename, string condition)
        {
            //delete ReportBug where ID = 27
            SqlConnection conn = null;
            string deletestr = "Delete " + tablename + " where ";
            string columnvalue = string.Empty;
            try
            {
                //資料處裡
                if (condition == string.Empty)
                {
                    return false;
                }
                deletestr += condition;

                //連線新增
                conn = new SqlConnection(ConnectStr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = deletestr;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
    }
}
