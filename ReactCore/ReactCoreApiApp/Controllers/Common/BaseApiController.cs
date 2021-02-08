﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NLog;
using ReactCoreApiApp.Controllers.Common;
using ReactCoreApiApp.Filters;
using ReactCoreApiApp.Repository;

namespace ReactCoreApiApp.Controllers
{
    public abstract class BaseApiController<TEntity> : ControllerBase, IBaseApiController<TEntity> where TEntity : class
    {
        private Logger logger = LogManager.GetCurrentClassLogger();

        private readonly ShopContext _context;
        private IGenericRepository<TEntity> _repository;

        public BaseApiController(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }
        [BaseResourceFilters]
        public virtual IList<TEntity> Get()
        {
            return _repository.Get().ToList();
        }

        public virtual IActionResult Get(int id)
        {
            try
            {
                var item = _repository.FindById(id);
                if (item != null)
                {
                    return Ok(item);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                logger.Error("Errorr base Get: " + ex);
                return NotFound();
                throw;
            }
        }

        public virtual IActionResult Post(TEntity item)
        {
            try
            {
                _repository.Create(item);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.Error("Errorr base Post: " + ex);
                return NotFound();
                throw;
            }

        }
        public virtual IActionResult Delete(TEntity item)
        {
            try
            {
                _repository.Remove(item);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.Error("Errorr base Delete: " + ex);
                return NotFound();
                throw;
            }
        }
        public virtual IActionResult Put(TEntity item)
        {
            try
            {
                _repository.Update(item);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.Error("Errorr base Put: " + ex);
                return NotFound();
                throw;
            }
        }

        public virtual IActionResult Delete(string filter)
        {
            var ListId = JsonConvert.DeserializeObject<Root>(filter);
            if (ListId.id == null)
            {
                return NotFound();
            }
            foreach (var id in ListId.id)
            {
                try
                {
                    var item = _repository.FindById(id);
                    _repository.Remove(item);
                }
                catch (Exception ex)
                {
                    logger.Error("Errorr base Delete by filter: " + ex);
                    continue;
                }
            }
            return Ok();
        }

        public class Root
        {
            public List<int> id { get; set; }
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