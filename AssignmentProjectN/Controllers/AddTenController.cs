using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentProjectN01649953.Controllers
{
    public class AddTenController : ApiController
    {
        // <summary>
        // This number return 10 to any number that is assigned to the parameter
        // localhost:xx/api/AddTen/10
        //</Summary>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
