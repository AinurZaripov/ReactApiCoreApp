using System;
using System.Collections.Generic;
using System.Text;

namespace ReactCoreApiApp.BLL.DTO
{
    public class ProductsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public int? AddressId { get; set; }
    }
}
