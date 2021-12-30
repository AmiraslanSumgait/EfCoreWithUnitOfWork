
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkWithEfCore.Models;
using UnitOfWorkWithEfCore.DataAccess.Repositories.Abstract;

namespace EfCoreWithUnitOfWork.Unit_Of_Work
{
    public interface IUnitofWork : IDisposable
    {
        IGenericRepository<Category> CategoryRepo { get; }
        IGenericRepository<Book> BookRepo { get; }
        int Complete();
    }
}
