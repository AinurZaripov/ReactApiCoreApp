using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ReactCoreApiApp;
using ReactCoreApiApp.DAL.Entities;
using ReactCoreApiApp.DAL.Interfaces;
using ReactCoreApiApp.Filters;

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
        public override IList<Addresses> Get(int? _page = null, int? _perPage = null, string _sortDir = null, string _sortField = null, string filter = null)
        {
            return base.Get(_page, _perPage, _sortDir, _sortField, filter);
        }

        // GET: api/Addresses/5
        [HttpGet("{id}")]
        public override IActionResult Get(int id)
        {
            return base.Get(id);
        }

        //// PUT: api/Addresses/5
        [ResponseType(typeof(Addresses))]
        [HttpPut("{id}")]
        public override IActionResult Put(Addresses addresses)
        {
            Response.Headers.Add("Access-Control-Expose-Headers", "*");
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
