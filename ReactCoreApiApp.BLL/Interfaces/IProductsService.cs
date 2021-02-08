using ReactCoreApiApp.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactCoreApiApp.BLL.Interfaces
{
    public interface IProductsService
    {
        IEnumerable<ProductsDTO> Get();
    }
}
