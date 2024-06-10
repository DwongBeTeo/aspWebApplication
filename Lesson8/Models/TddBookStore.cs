using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lesson8.Models
{
    public class TddBookStore:DbContext 
    {
        public TddBookStore() : base("TddBookStoreConnectionString") { }

        //tạo các bảng
        //khai báo các thuộc tính trong bảng csdl

        public DbSet<TddCategory> TddCategories { get; set; }
        public DbSet<TddBook> TddBooks { get; set; }

    }
}