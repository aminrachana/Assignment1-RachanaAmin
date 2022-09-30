using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Web.Http;
using System.Web.Routing;

namespace Assignment1_RachanaAmin.Controllers
{
    public class NumberMachineController : ApiController
    {
        ///<summary>
        ///returns an integer after applying 4 mathematical operations to th input
        ///</summary>
        ///<param name="id">applies four mathematical operations to {math}</param>
        ///<example>GET api/NumberMachine/10 ->?</example>
        ///<return>{math} after applying four mathematical operations to input</return>

        //GET: api/NumberMachine

        public int Get(int id)
        {
            int total = ((id + id) * id) / id - id;
            return total;
        }
    

    
    
    }
}
