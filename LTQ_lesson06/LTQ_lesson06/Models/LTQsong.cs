using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTQ_lesson06.Models
{
    public class LTQsong
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "LTQ:Hãy nhập tiêu đề bài hát")]
        [DisplayName("Tiêu đề")]
        public string LTQTitle { get; set; }

        [Required(ErrorMessage = "LTQ:Hãy nhập tác giả bài hát")]
        [DisplayName("Nghệ sĩ")]
        public string LTQAuthor { get; set; }

        [Required(ErrorMessage = "LTQ: Hãy nhập nghệ sĩ")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Độ dài trong khoảng [2-50]")]
        [DisplayName("Tác giả")]

        public string LTQArtist { get; set; }

        [Required(ErrorMessage = "LTQ: Hãy Nhập năm sản xuất")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "LTQ:Nhập năm xuất bản là 4 kí tự số")]
        [Range(1900, 2020, ErrorMessage = "LTQ:Nhập Năm trong khoảng [1900-2020]")]
        [DisplayName("Năm ra mắt")]
        public int LTQYearRelease { get; set; }


    } 
}