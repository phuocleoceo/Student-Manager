using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLySinhVien;

namespace QuanLySinhVien.Data
{
    public class Repository<T> where T : class
    {
        private string ConnectionString => ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;

        public SortableBindingList<T> GetAll(string query, DynamicParameters dp = null)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                return con.Query<T>(query, dp).ToSortableBindingList();
            }
        }

        public T GetOne(string query, DynamicParameters dp = null)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                return con.Query<T>(query, dp).FirstOrDefault();
            }
        }

        public void Execute(string query, DynamicParameters dp)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                con.Execute(query, dp);
            }
        }
    }
}
