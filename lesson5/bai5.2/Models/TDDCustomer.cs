using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai5._2.Models
{
    public class TDDCustomer
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Balance { get; set; }
    }
    public interface ICustomerRepository
    {
        //khai báo phương thức lấy danh sách khách hàng
        IList<TDDCustomer> GetCustomers();
        //khai báo phương thức lấy khách hàng
       TDDCustomer GetCustomer(string customerId);
        //khai báo phương thức thêm khách hàng
        void AddCustomer(TDDCustomer cus);
        //khai báo phương thức cập nhật khách hàng
        void UpdateCustomer(TDDCustomer cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<TDDCustomer> SearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void DeleteCustomer(TDDCustomer cus);
    }
}