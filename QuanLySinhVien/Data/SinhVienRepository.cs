using QuanLySinhVien.Model;
using System.Collections.Generic;

namespace QuanLySinhVien.Data
{
    public class SinhVienRepository : Repository<SinhVien>
    {

        public List<SinhVien> Read()
        {
            string query = $"SELECT * FROM SinhVien";
            return GetAll(query);
        }
        public List<SinhVien> Search(string Name)
        {
            string query = $@"SELECT * FROM SinhVien 
                            WHERE Ten LIKE N'{Name.ToLower()}%' 
                               OR Ten LIKE N'{Name.ToUpper()}%'";
            return GetAll(query);
        }

        public void Insert(SinhVien entity)
        {
            string query = $@"INSERT INTO  SinhVien (Ho, Ten, NgaySinh, GioiTinh, DiaChi, NganhHoc) 
                           values ( N'{entity.Ho}', N'{entity.Ten}', '{entity.NgaySinh}', {entity.GioiTinh}, N'{entity.DiaChi}', N'{entity.NganhHoc}')";
            Execute(query);
        }

        public List<SinhVien> Sort()
        {
            string query = $"SELECT * FROM SinhVien ORDER BY Ten ASC";
            return GetAll(query);
        }

        public void Delete(int id)
        {
            string query = $"DELETE FROM SinhVien WHERE Id = {id}";
            Execute(query);
        }

        public void Update(SinhVien sv)
        {
            string query = $@"UPDATE SinhVien
                            SET
                                Ho = N'{sv.Ho}' ,
                                Ten = N'{sv.Ten}' ,
                                NgaySinh = '{sv.NgaySinh}' ,
                                GioiTinh = {sv.GioiTinh} ,
                                DiaChi = N'{sv.DiaChi}' ,
                                NganhHoc = N'{sv.NganhHoc}'
                            WHERE Id = {sv.Id}";
            Execute(query);
        }
    }
}
