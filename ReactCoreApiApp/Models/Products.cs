using System;
using System.Collections.Generic;

namespace ReactCoreApiApp
{
    public partial class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public int? AddressId { get; set; }

        public virtual Addresses Address { get; set; }
    }
}
