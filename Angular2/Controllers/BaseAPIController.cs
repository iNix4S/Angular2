using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Angular2.DBContext;
using Newtonsoft.Json;
using System.Text;

namespace Angular2.Controllers
{
    public class BaseAPIController : ApiController
    {
        protected readonly UserDBEntities UserDB = new UserDBEntities();
        protected HttpResponseMessage ToJson(dynamic obj)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return response;
        }

        protected HttpResponseMessage ErrorJson(dynamic obj)
        {
            var response = Request.CreateResponse(HttpStatusCode.Unauthorized);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return response;
        }
    }
}
