using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary1;
namespace WebApplication2.Controllers
{
    public class msmController : ApiController
    {
        testdatabaseEntities contex = new testdatabaseEntities();
        [HttpPost]
        [Route ("~/post/customers")]
        public HttpResponseMessage post([FromBody] Customer customer) {
            contex.Customers.Add(customer);
            contex.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Created, "moshtari mored naszar sabt shod");
        }
        [HttpGet]
        [Route("~/get/customers")]
        public IEnumerable <Customer> get()
        {
            return contex.Customers.ToList();
        }
        [HttpGet]
        [Route("~/get/customers/{id}")]
        public IEnumerable<Customer> get(int id)
        {
            return contex.Customers.ToList().Where(c=>c.id==id);
        }
    }
}
