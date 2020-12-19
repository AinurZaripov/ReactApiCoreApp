using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ReactCoreApiApp;
using ReactCoreApiApp.Filters;
using ReactCoreApiApp.Repository;

namespace ReactCoreApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : BaseApiController<Addresses>
    {
        public AddressesController(IGenericRepository<Addresses> repository) : base(repository)
        {
        }

        // GET: api/Addresses
        [HttpGet]
        public override IList<Addresses> Get()
        {
            return base.Get();
        }

        // GET: api/Addresses/5
        [HttpGet("{id}")]
        public override IActionResult Get(int id)
        {
            return base.Get(id);
        }

        //// PUT: api/Addresses/5
        [HttpPut("{id}")]
        public override IActionResult Put(Addresses addresses)
        {
            return base.Put(addresses);
        }

        //// POST: api/Addresses
        [HttpPost]
        public override IActionResult Post(Addresses addresses)
        {
            return base.Post(addresses);
        }

        //// DELETE: api/Addresses/5
        [HttpDelete("{id}")]
        public override IActionResult Delete(Addresses addresses)
        {
            return base.Delete(addresses);
        }

        // DELETE: api/Addresses/filter={,,,}
        [HttpDelete]
        public override IActionResult Delete(string filter)
        {
            return base.Delete(filter);
        }

    }
}
