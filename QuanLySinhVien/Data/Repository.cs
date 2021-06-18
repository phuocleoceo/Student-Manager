using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace QuanLySinhVien.Data
{
    public class Repository<T> where T : class
    {
        private string ConnectionString => ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;

        public async Task<IEnumerable<T>> GetAll(string query, DynamicParameters dp = null)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                return await con.QueryAsync<T>(query, dp);
            }
        }

        public async Task<T> GetOne(string query, DynamicParameters dp = null)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                return await con.QueryFirstOrDefaultAsync<T>(query, dp);
            }
        }

        public async Task Execute(string query, DynamicParameters dp)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                await con.ExecuteAsync(query, dp);
            }
        }
    }
}
