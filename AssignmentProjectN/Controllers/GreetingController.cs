using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentProjectN01649953.Controllers
{
    public class GreetingController : ApiController
 
    {
        public string Get ()
        {
            return "Hello World!";
        }
        public string Get (string id)
        {
            return "Hello to " + id + " People!";
        }
    }
}
