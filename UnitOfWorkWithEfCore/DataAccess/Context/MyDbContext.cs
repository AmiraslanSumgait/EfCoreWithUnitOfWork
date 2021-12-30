using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkWithEfCore.Models;

namespace UnitOfWorkWithEfCore.DataAccess.Context
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5EGU4LU;Initial Catalog=UnitOfWorkProductsAndCategories;Integrated Security=True;");
        }
        public DbSet<Book>? Books { get; set; }
        public DbSet<Category>? Categories { get; set; }
    }
}
