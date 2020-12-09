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
        public override Addresses FindById(int id)
        {
            return base.FindById(id);
        }


        
        //// GET: api/Addresses/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Addresses>> GetAddresses(int id)
        //{
        //    var addresses = await _context.Addresses.FindAsync(id);

        //    if (addresses == null)
        //    {
        //        return NotFound();
        //    }

        //    return addresses;
        //}

        //// PUT: api/Addresses/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAddresses(int id, Addresses addresses)
        //{
        //    if (id != addresses.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(addresses).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AddressesExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Addresses
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Addresses>> PostAddresses(Addresses addresses)
        //{
        //    _context.Addresses.Add(addresses);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAddresses", new { id = addresses.Id }, addresses);
        //}

        //// DELETE: api/Addresses/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Addresses>> DeleteAddresses(int id)
        //{
        //    var addresses = await _context.Addresses.FindAsync(id);
        //    if (addresses == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Addresses.Remove(addresses);
        //    await _context.SaveChangesAsync();

        //    return addresses;
        //}

        //[HttpDelete]
        //public async Task<ActionResult<Addresses>> DeleteAddresses(string filter)
        //{
        //    var ListId = JsonConvert.DeserializeObject<Root>(filter);
        //    if (ListId.id == null)
        //    {
        //        return NotFound();
        //    }
        //    Addresses addresses = new Addresses();
        //    foreach (var item in ListId.id)
        //    {
        //        addresses = await _context.Addresses.FindAsync(item);
        //        _context.Addresses.Remove(addresses);
        //        await _context.SaveChangesAsync();
        //    }

        //    return Ok();
        //}

        //private bool AddressesExists(int id)
        //{
        //    return _context.Addresses.Any(e => e.Id == id);
        //}
        public class Root
        {
            public List<int> id { get; set; }
        }

    }
}
