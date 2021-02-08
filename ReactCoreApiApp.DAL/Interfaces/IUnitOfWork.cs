using ReactCoreApiApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactCoreApiApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Products> Products { get; }
    }
}
