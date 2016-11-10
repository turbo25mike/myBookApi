using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Api
{
    public class TestController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse("Hello From Web Api!");
        }
    }
}
