using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentProjectN01649953.Controllers
{
    public class NumberMachineController : ApiController
    {
        //<summary>
        //The method perform different mathematical operations based on the value of the input parameter "id"
        //</summary>
        public int Get(int id)
        {
            if (id < 1)
            {
                return id + 10;
            }
            else if (id >= 1 && id <= 10)
            {
                return id - 1;
            }
            else if (id > 10 && id <= 20)
            {
                return id * id;
            }
            else 
            {
                return id / 2; 
            }
        }
    }
}
