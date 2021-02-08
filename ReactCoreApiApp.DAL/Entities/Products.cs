using ReactCoreApiApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactCoreApiApp.DAL.Entities
{
    public partial class Products : IEntity
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public int? AddressId { get; set; }

        public virtual Addresses Address { get; set; }
    }
}
