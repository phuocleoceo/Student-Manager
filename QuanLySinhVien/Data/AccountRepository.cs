using QuanLySinhVien.Model;
using System.Collections.Generic;

namespace QuanLySinhVien.Data
{
    public class AccountRepository : Repository<Account>
    {
        public List<Account> Read()
        {
            string query = "SELECT * FROM Account";
            return GetAll(query);
        }

        public bool CheckLogin(string UserName, string PassWord)
        {
            var listAccount = Read();
            foreach (Account nick in listAccount)
            {
                if (nick.UserName == UserName && nick.PassWord == PassWord)
                    return true;
            }
            return false;
        }
    }
}
