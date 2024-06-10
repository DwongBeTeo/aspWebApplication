using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson8.Models
{
    //tạo ra cấu trúc bảng book
    public class TddBook
    {
        [Key]
        public int TddBookId { get; set; }
        public string TddTitle { get; set; }
        public string TddAuthor { get; set; }
        public int TddYear { get; set; }
        public string TddPublisher { get; set; }
        public string TddPicture { get; set; }
        public int TddCategoryId { get; set; }
        //thuộc tính quan hệ
        public virtual TddCategory TddCategory { get; set; }
    }
}