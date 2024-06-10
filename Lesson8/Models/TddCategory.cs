using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson8.Models
{
    public class TddCategory
    {
        /// <sumary>
        /// tạo cấu trúc bảng dữ liệu
        /// <sumary>
        [Key]
        public int TddCategoryId { get; set; }
        public int TddCategoryName { get; set; }

        //thuộc tính quan hệ
        public virtual ICollection<TddBook> TddBooks { get; set; }
    }
}