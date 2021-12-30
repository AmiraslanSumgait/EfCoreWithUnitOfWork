
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkWithEfCore.Models;
using UnitOfWorkWithEfCore.DataAccess.Context;
using UnitOfWorkWithEfCore.DataAccess.Repositories.Abstract;
using UnitOfWorkWithEfCore.DataAccess.Repositories.Concrete;

namespace EfCoreWithUnitOfWork.Unit_Of_Work.Concrete
{
    public class UnitOfWork : IUnitofWork
    {
        private MyDbContext _context;

        public UnitOfWork(MyDbContext context)
        {
            _context = context;
            CategoryRepo = new GenericRepository<Category>(_context);
            BookRepo = new GenericRepository<Book>(_context);
        }

        public IGenericRepository<Category> CategoryRepo { get; private set; }

        public IGenericRepository<Book> BookRepo { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
