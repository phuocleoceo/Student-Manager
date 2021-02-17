using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLySinhVien.Data
{
    public class Repository<T> where T : class
    {
        private string ConnectionString => ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;

        public List<T> GetAll(string query)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                return con.Query<T>(query).ToList();
            }
        }

        public T GetOne(string query)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                return con.Query<T>(query).FirstOrDefault();
            }
        }

        public void Execute(string query)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                con.Execute(query);
            }
        }
    }
}
