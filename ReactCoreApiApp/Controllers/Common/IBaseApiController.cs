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
        //IHttpActionResult Get(int id);
        //IHttpActionResult Put(int id, T item);
        //IHttpActionResult Post(T item);
        //IHttpActionResult Delete(int id);
        //IHttpActionResult Delete(string _filters);
    }
}
