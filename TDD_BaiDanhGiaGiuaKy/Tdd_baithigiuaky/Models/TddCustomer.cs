using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Tdd_baithigiuaky.Models
{
    public class TddCustomer
    {
        [Key]
        
        [Required(ErrorMessage = "TDD: Mã khách hàng không hợp lệ")]
        [DisplayName("Mã Khách Hàng")]
            public uint TddId { get; set; }
        
        [Required(ErrorMessage = "TDD: Hãy nhập hãy nhập họ tên của bạn")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Tdd: Hãy nhập độ dài trong khoảng [2-50] kí tự")]
        [DisplayName("Họ và Tên")]
        public string TddFullName { get; set; }
        
        [Required(ErrorMessage = "TDD: Hãy nhập địa chỉ email")]
        [EmailAddress(ErrorMessage = "địa chỉ email không hợp lệ")]
        [DisplayName("Email")]
        public string TddEmail { get; set; }
        
        [Required(ErrorMessage = "TDD: Hãy nhập số điện thoại")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Tdd: Hãy nhập số điện thoại có 10 số không hơn")]
        [DisplayName("Số điện thoại")]
        public uint TddPhone { get; set; }
        
        [Required(ErrorMessage = "TDD: Hãy nhập số tuổi của bạn")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Tdd: chỉ chứa 2 ký tự số; trong phạm vi: 18-65")]
        [Range(18, 65, ErrorMessage = "độ tuổi nằm trong khoảng từ 18-65 tuổi")]
        [DisplayName("Độ Tuổi")]
        public int TddAge { get; set; }
        
        [Required(ErrorMessage = "TDD: Hãy nhập giới tính của bạn")]
        [Range(0, 1, ErrorMessage = "giới tính nam là 0, nữ là 1")]
        [DisplayName("Giới tính")]
        public int TddGender { get; set; }
    }
}