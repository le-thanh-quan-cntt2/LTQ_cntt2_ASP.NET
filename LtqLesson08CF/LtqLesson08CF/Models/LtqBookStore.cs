using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LtqLesson08CF.Models
{
    public class LtqBookStore:DbContext
    {
        public LtqBookStore() : base("LtqBookStoreConnectionString)
        {

        }
        // Tạo các bảng
        public DbSet<LtqCategory> LtqCategories { get; set; }
        public DbSet<LtqBook> LtqBooks { get; set; }

    }
}