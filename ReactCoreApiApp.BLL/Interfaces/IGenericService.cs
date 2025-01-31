﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReactCoreApiApp.BLL.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        //void Create(TEntity item);
        //TEntity FindById(int id);
        IEnumerable<TEntity> Get();
        //IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        //void Remove(TEntity item);
        //void Update(TEntity item);
    }
}
