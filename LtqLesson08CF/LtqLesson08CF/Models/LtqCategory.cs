using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LtqLesson08CF.Models
{
    /// <summary>
    ///  Tạo cấu trúc bảng dữ liệu
    /// </summary>
    public class LtqCategory
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        // Thuộc tính quan hệ
        public virtual ICollection<LtqBook> Books { get; set; }

    }
}