﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lesson9_BaiKiemTraGiuaKi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TddK22CNT2Lesson07DbEntities : DbContext
    {
        public TddK22CNT2Lesson07DbEntities()
            : base("name=TddK22CNT2Lesson07DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tddKhoa> tddKhoas { get; set; }
        public virtual DbSet<tddSinhVien> tddSinhViens { get; set; }
    }
}