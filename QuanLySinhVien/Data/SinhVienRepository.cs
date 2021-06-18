using Dapper;
using QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuanLySinhVien.Data
{
    public class SinhVienRepository : Repository<SinhVien>
    {
        public async Task<IEnumerable<SinhVien>> Read()
        {
            string query = "SELECT * FROM SinhVien";
            return await GetAll(query);
        }

        public async Task<IEnumerable<SinhVien>> Search(string Name)
        {
            string query = @"SELECT * FROM SinhVien 
                            WHERE Ten LIKE N'%' + @Name + '%'";
            DynamicParameters dp = new DynamicParameters();
            dp.Add("@Name", Name);
            return await GetAll(query, dp);
        }

        public async Task Insert(SinhVien sv)
        {
            if (sv.Validate().Length == 0)
            {
                string query = @"INSERT INTO  SinhVien (Ho, Ten, NgaySinh, GioiTinh, DiaChi, NganhHoc) 
                        values ( @Ho, @Ten, @NgaySinh, @GioiTinh, @DiaChi, @NganhHoc)";
                DynamicParameters dp = new DynamicParameters();
                dp.Add("@Ho", sv.Ho);
                dp.Add("@Ten", sv.Ten);
                dp.Add("@NgaySinh", sv.NgaySinh);
                dp.Add("@GioiTinh", sv.GioiTinh);
                dp.Add("@DiaChi", sv.DiaChi);
                dp.Add("@NganhHoc", sv.NganhHoc);
                await Execute(query, dp);
            }
            else throw new Exception(sv.Validate());
        }

        public async Task Delete(int id)
        {
            string query = "DELETE FROM SinhVien WHERE Id = @Id";
            DynamicParameters dp = new DynamicParameters();
            dp.Add("@Id", id);
            await Execute(query, dp);
        }

        public async Task Update(SinhVien sv)
        {
            if (sv.Validate().Length == 0)
            {
                string query = @"UPDATE SinhVien
                            SET
                                Ho = @Ho ,
                                Ten = @Ten ,
                                NgaySinh = @NgaySinh ,
                                GioiTinh = @GioiTinh ,
                                DiaChi = @DiaChi ,
                                NganhHoc = @NganhHoc
                            WHERE Id = @Id";
                DynamicParameters dp = new DynamicParameters();
                dp.Add("@Ho", sv.Ho);
                dp.Add("@Ten", sv.Ten);
                dp.Add("@NgaySinh", sv.NgaySinh);
                dp.Add("@GioiTinh", sv.GioiTinh);
                dp.Add("@DiaChi", sv.DiaChi);
                dp.Add("@NganhHoc", sv.NganhHoc);
                dp.Add("@Id", sv.Id);
                await Execute(query, dp);
            }
            else throw new Exception(sv.Validate());
        }
    }
}
