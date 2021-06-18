using QuanLySinhVien.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuanLySinhVien.Data
{
    public class AccountRepository : Repository<Account>
    {
        public async Task<IEnumerable<Account>> Read()
        {
            string query = "SELECT * FROM Account";
            return await GetAll(query);
        }

        public async Task<bool> CheckLogin(string UserName, string PassWord)
        {
            foreach (Account nick in await Read())
            {
                if (nick.UserName == UserName && nick.PassWord == PassWord)
                    return true;
            }
            return false;
        }
    }
}
