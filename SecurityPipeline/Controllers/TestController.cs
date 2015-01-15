using SecurityPipeline.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SecurityPipeline
{
    [TestAuthenticationFilter]
    [TestAuthorizationFilter]
    public class TestController : ApiController
    {
        public IHttpActionResult Get() 
        {
            Helper.Write("Test Controller", User);
            return Ok();
        }
    }
}
