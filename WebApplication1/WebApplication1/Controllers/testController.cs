using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class testController : ApiController
    {
        testApiEntities contex = new testApiEntities();
        [HttpGet]
        [Route ("get/all")]
        public IEnumerable<testApi> Get()
        {
            return contex.testApis.ToList();
        }

        [HttpGet]
        [Route("get/all/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var q = contex.testApis.FirstOrDefault(c => c.Id == id);
            if (q != null)
            {
                return Request.CreateResponse(HttpStatusCode.Created, q);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Error khkhkhkhkhkhkhkhk");
            }
        }

        [HttpPost]
        [Route("post/customer")]
        public HttpResponseMessage post([FromBody]testApi tApi)
        {
            try
            {
                if (tApi.name.Length!=0)
                {
                    contex.testApis.Add(tApi);
                    contex.SaveChanges();
                    var msg = Request.CreateResponse(HttpStatusCode.Created, tApi);
                    return msg;
                }
                else
                {
                    var msg = Request.CreateResponse(HttpStatusCode.Ambiguous, "What is this mardak");
                    return msg;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

        }
    }
}
