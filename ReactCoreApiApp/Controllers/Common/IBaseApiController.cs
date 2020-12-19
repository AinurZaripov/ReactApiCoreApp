using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace ReactCoreApiApp.Controllers.Common
{
    interface IBaseApiController<T> where T : class
    {
        IList<T> Get();
        IActionResult Get(int id);
        IActionResult Put(T item);
        IActionResult Post(T item);
        IActionResult Delete(T item);
        IActionResult Delete(string filter);
    }
}
