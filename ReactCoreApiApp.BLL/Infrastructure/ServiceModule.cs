using Microsoft.EntityFrameworkCore;
using Ninject.Modules;
using ReactCoreApiApp.DAL.Entities;
using ReactCoreApiApp.DAL.Interfaces;
using ReactCoreApiApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactCoreApiApp.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind(typeof(IGenericRepository<>))
                .To(typeof(EFGenericRepository<>)).WithConstructorArgument(connectionString);
            Bind<IGenericRepository<Products>>()
                .To<ProductsRepository>().WithConstructorArgument(connectionString);
        }
    }
}
