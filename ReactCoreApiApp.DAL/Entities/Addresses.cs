using ReactCoreApiApp.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace ReactCoreApiApp.DAL.Entities
{
    public partial class Addresses : IEntity
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
