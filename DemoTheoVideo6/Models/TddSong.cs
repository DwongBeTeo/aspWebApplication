using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;


namespace DemoTheoVideo6.Models
{
    public class TddSong
    {
        [Key]
        public uint Id { get; set; }
        [Required (ErrorMessage ="TDD: Hãy nhập tiêu đề bài hát")]
        [DisplayName("Tiêu đề")]
        public string TddTitle { get; set; }
        [Required(ErrorMessage = "TDD: Hãy nhập tên tác giả bài hát")]
        [DisplayName("Tác giả")]
        public string TddAuthor { get; set; }
        [Required(ErrorMessage = "TDD: Hãy nhập tên nghệ sĩ")]
        [StringLength(50, MinimumLength =2, ErrorMessage ="Tdd: Hãy nhập độ dài trong khoảng [2-50] kí tự")]
        [DisplayName("Nghệ sĩ")]
        public string TddArtist { get; set; }
        [Required(ErrorMessage = "TDD: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage ="Hãy nhập 4 ký tự là số")]
        [Range(1900,2024, ErrorMessage = "Hãy nhập giá trị trong khoảng[1900-2024]")]
        [DisplayName("Năm sản xuất")]
        public int TddYearRelaese { get; set; }
    }
}