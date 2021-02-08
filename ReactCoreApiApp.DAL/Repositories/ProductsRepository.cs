using Microsoft.EntityFrameworkCore;
using ReactCoreApiApp.DAL.EF;
using ReactCoreApiApp.DAL.Entities;
using ReactCoreApiApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ReactCoreApiApp.DAL.Repositories
{
    public class ProductsRepository : IGenericRepository<Products> 
    {
        ShopContext _context;
        public ProductsRepository(ShopContext context)
        {
            _context = context;
        }
        public void Create(Products item)
        {
            Create(item);
        }
        public IEnumerable<Products> Get(Dictionary<string, string> filters)
        {
            var shop = _context.Products.AsQueryable();
            if (filters.Count > 0)
            {
                int valueFilter;
                foreach (var key in filters)
                {
                    valueFilter = Convert.ToInt32(key.Value);
                    switch (key.Key)
                    {
                        case "id":
                            shop = shop.Where(w => w.Id == valueFilter);
                            break;
                        default:
                            break;
                    }
                }
            }
            return shop.ToList();
        }

        public IEnumerable<Products> Get()
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Products>.Create(Products item)
        {
            throw new NotImplementedException();
        }

        Products IGenericRepository<Products>.FindById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Products> IGenericRepository<Products>.Get(Func<Products, bool> predicate)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Products>.Remove(Products item)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Products>.Update(Products item)
        {
            throw new NotImplementedException();
        }
    }
}