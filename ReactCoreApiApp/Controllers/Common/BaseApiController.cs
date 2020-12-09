using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using ReactCoreApiApp.Controllers.Common;
using ReactCoreApiApp.Filters;
using ReactCoreApiApp.Repository;

namespace ReactCoreApiApp.Controllers
{
    public abstract class BaseApiController<TEntity> : ControllerBase, IBaseApiController<TEntity> where TEntity : class
    {
        private readonly ShopContext _context;
        private IGenericRepository<TEntity> _repository;
        //private IRepositoryA _repository;

        public BaseApiController(IGenericRepository<TEntity> repository/*IGenericRepository<TEntity> repository*/)
        {
            _repository = repository;
        }
        [BaseResourceFilters]
        public virtual IList<TEntity> Get()
        {
            return _repository.Get().ToList();
        }

        public virtual TEntity FindById(int id)
        {
            return _repository.FindById(id);
        }


        //[HttpGet]
        //public virtual async Task<ActionResult<IEnumerable<T>>> Get()
        //{
        //    return await _context.Addresses.ToListAsync();
        //}
        //public override void OnActionExecuting(ActionExecutingContext context)
        //{
        //    if (context.HttpContext.Request.Headers.ContainsKey("User-Agent"))
        //    {
        //        // получаем заголовок User-Agent 
        //        var useragent = context.HttpContext.Request.Headers["User-Agent"].FirstOrDefault();
        //        Response.Headers.Add("content-range2", "10");
        //        context.HttpContext.Response.Headers.Add("content-range3", "10");
        //        // сравниваем его значение
        //        if (useragent.Contains("MSIE") || useragent.Contains("Trident"))
        //        {
        //            context.Result = Content("Internet Explorer не поддерживается");
        //        }
        //    }
        //    base.OnActionExecuting(context);
        //}
    }
}