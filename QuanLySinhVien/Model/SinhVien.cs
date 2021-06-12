using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.Model
{
    public class SinhVien
    {
        public int Id { get; set; }

        [DisplayName("Họ")]
        [Required(ErrorMessage ="Họ không được để trống")]
        public string Ho { get; set; }

        [DisplayName("Tên")]
        [Required(ErrorMessage = "Tên không được để trống")]
        public string Ten { get; set; }

        [DisplayName("Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        public DateTime NgaySinh { get; set; }

        [DisplayName("Giới tính")]
        [Required(ErrorMessage = "Giới tính phải được chọn")]
        public int GioiTinh { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string DiaChi { get; set; }

        [DisplayName("Ngành học")]
        [Required(ErrorMessage = "Ngành học không được để trống")]
        public string NganhHoc { get; set; }

        [DisplayName("Mã sinh viên")]
        public string MaSinhVien { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }
    }
}
