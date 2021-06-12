using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
