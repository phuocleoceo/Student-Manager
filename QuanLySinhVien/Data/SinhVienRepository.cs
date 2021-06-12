using QuanLySinhVien.Model;
using System.Collections.Generic;
using QuanLySinhVien;
using Dapper;
using System;

namespace QuanLySinhVien.Data
{
    public class SinhVienRepository : Repository<SinhVien>
    {
        public SortableBindingList<SinhVien> Read()
        {
            string query = "SELECT * FROM SinhVien";
            return GetAll(query);
        }
        public SortableBindingList<SinhVien> Search(string Name)
        {
            string query = @"SELECT * FROM SinhVien 
                            WHERE Ten LIKE N'%' + @Name + '%'";
            DynamicParameters dp = new DynamicParameters();
            dp.Add("@Name", Name);
            return GetAll(query, dp);
        }

        public void Insert(SinhVien sv)
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
                Execute(query, dp);
            }
            else throw new Exception(sv.Validate());
        }

        public SortableBindingList<SinhVien> Sort()
        {
            string query = "SELECT * FROM SinhVien ORDER BY Ten ASC";
            return GetAll(query);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM SinhVien WHERE Id = @Id";
            DynamicParameters dp = new DynamicParameters();
            dp.Add("@Id", id);
            Execute(query, dp);
        }

        public void Update(SinhVien sv)
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
                Execute(query, dp);
            }
            else throw new Exception(sv.Validate());
        }
    }
}
