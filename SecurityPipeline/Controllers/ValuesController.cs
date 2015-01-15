using SecurityPipeline.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SecurityPipeline.Controllers
{
    [TestAuthenticationFilter]
    [TestAuthorizationFilter]
    public class ValuesController : ApiController
    {
        private List<int> _valueList = new List<int>() { 1, 3, 5, 7, 9 };

       
        public List<int> Get() 
        {
            Helper.Write("Values Controller", User);
            return _valueList;
        }
    }
}
