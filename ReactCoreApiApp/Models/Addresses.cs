using System;
using System.Collections.Generic;

namespace ReactCoreApiApp
{
    public partial class Addresses
    {
        public Addresses()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
