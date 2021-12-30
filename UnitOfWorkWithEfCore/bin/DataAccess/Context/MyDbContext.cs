using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Models;

namespace UnitOfWork.DataAccess.Context
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5EGU4LU;Initial Catalog=UnitOfWorkProducts;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Book>? Books { get; set; }
        public DbSet<Category>? Categories { get; set; }
    }
}
