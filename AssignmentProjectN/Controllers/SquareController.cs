using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentProjectN01649953.Controllers
{
    public class SquareController : ApiController
    {
        // <summary>
        // This multiply id by it's self
        // localhost:xx/api/Square/id
        //</Summary>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
