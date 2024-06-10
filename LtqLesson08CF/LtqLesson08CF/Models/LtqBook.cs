using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LtqLesson08CF.Models
{
    /// <summary>
    /// tạo ra cấu trúc bảng Book
    /// </summary>
    public class LtqBook
    {
        [Key]
        public int LtqBookId { get; set; }
        public string LtqTitle { get; set; }
        public string LtqAuthor { get; set; }
        public int LtqYear { get; set; }
        public string LtqPublisher { get; set; }
        public string LtqPicture { get; set; }
        public int LtqCategoryId { get; set; }

        // Thuộc tính quan hệ
        public virtual LtqCategory LtqCategory { get; set; }
    }
}