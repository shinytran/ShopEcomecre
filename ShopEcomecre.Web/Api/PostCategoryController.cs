using ShopEcomecre.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopEcomecre.Web.Api
{
    public class PostCategoryController : ApiControllerBase
    {
        //Get api
        public IEnumerable<string> Get() 
            {
            return new string[] { "1", "2" };
            }
        public string get(int id) {
            return "abc";
        }
        public void Post([FromBody] string value) {

        }
        public void Put(int id, [FromBody] string value)
        {

        }
    }
}
