using System;

namespace QuanLySinhVien.Model
{
    public class SinhVien
    {
        public int Id { get; set; }

        public string Ho { get; set; }

        public string Ten { get; set; }

        public DateTime NgaySinh { get; set; }

        public int GioiTinh { get; set; }

        public string DiaChi { get; set; }

        public string NganhHoc { get; set; }

        public string MaSinhVien { get; set; }

        public string Email { get; set; }
    }
}
