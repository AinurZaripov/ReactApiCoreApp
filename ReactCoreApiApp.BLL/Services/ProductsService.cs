using AutoMapper;
using ReactCoreApiApp.BLL.DTO;
using ReactCoreApiApp.BLL.Interfaces;
using ReactCoreApiApp.DAL.Entities;
using ReactCoreApiApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactCoreApiApp.BLL.Services
{
    public class ProductsService : IProductsService
    {
        IGenericRepository<Products> _igr;
        public ProductsService(IGenericRepository<Products> igr)
        {
            _igr = igr;
        }
        public IEnumerable<ProductsDTO> Get()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Products, ProductsDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Products>, List<ProductsDTO>>(_igr.Get());
        }
    }
}
