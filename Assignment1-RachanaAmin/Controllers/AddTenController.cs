using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using System.Web.Routing;

namespace Assignment1_RachanaAmin.Controllers
{
    public class AddTenController : ApiController
    ///<summary>
    ///Add 10 to the input integer.
    ///<example>GET api/AddTen/21 -> 31</example>
    ///<example>GET api/AddTen/0 -> 10</example>
    ///<example>GET api/AddTen/-9 -> 1</example>
    ///</summary>
    ///<param name="=id">21</param>
    ///<return>ten more of the input</return>
    
    {
        //GET :api/AddTen
        public int Get(int id)

        {
            int total = id + 10;
            return total;
           
        }

        

    }

}
