using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab05._1.Models
{
    public class LTQMember
    {
        // với cách 1 và 2 ta sử dụng khai báo thuộc tính như sau

        //public int? Id { get; set; }

        //public string Username { get; set:

        //public string FullName (8 (get; set; )

        //public string Password (get; set; }

        //public int? Age { get; set;)

        //public string Email { get; set; set;)

        // với cách 3 khai báo như sau:

        [Required(ErrorMessage = "Hãy nhập mã số")]

        [DataType(DataType.Currency)]

        public int? Id { get; set; }

        [Required(ErrorMessage "Hay nhập tên đăng nhập")]

        public string Username { get; set; }

        [Required(ErrorMessage = "Hãy nhập họ và tên")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Hãy nhập mật khẩu")]

        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Required(ErrorMessage = "Hãy nhập tuổi")]

        [Range(18, 50, ErrorMessage = "Tuổi từ 18-50")]

        public int? Age { get; set; }

        [Required(ErrorMessage = "Hãy nhập email")]

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
         ErrorMessage = "Email phải đúng định dạng")]
        
        public string Email { get; set; }
    }
}