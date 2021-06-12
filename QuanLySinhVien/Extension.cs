using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public static class Extension
    {
        public static string Validate(this object obj)
        {
            StringBuilder sb = new StringBuilder();
            ValidationContext context = new ValidationContext(obj, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(obj, context, errors, true))
            {
                foreach (ValidationResult vr in errors)
                {
                    sb.AppendLine(vr.ErrorMessage);
                }
            }
            return sb.ToString();
        }

        public static SortableBindingList<T> ToSortableBindingList<T>(this IEnumerable<T> data)
        {
            return new SortableBindingList<T>(data);
        }

        public static void FormatDataGridView(this DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;

            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;

            dgv.GridColor = Color.Gainsboro;
            dgv.BackgroundColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.Font = new Font("Cambria", 12);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightPink;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
