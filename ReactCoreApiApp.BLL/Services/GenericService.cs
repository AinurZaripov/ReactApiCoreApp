using AutoMapper;
using ReactCoreApiApp.BLL.DTO;
using ReactCoreApiApp.BLL.Interfaces;
using ReactCoreApiApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactCoreApiApp.BLL.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        IGenericRepository<TEntity> DataBase { get; set; }
        public GenericService(IGenericRepository<TEntity> gr)
        {
            DataBase = gr;
        }

        public IEnumerable<TEntity> Get()
        {
            return DataBase.Get();
        }
    }
}
