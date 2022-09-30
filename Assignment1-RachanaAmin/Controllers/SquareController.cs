using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_RachanaAmin.Controllers
{
    public class SquareController : ApiController
    { 
        ///<summary>
        ///Get a square of an input
        ///<example>GET api/Square/2 -> 4</example>
        ///<example>GET api/Square/-2 -> 4</example>
        ///<example>GET api/Square/10 -> 100</example>
        ///</summary>
        ///<param name = "id"></param>
        ///<return>a square of an input</return>
    

    
        //GET: api/Square
        public int Get(int id)

        {
            int square = id * id;
            return square;
        }

       
    }

    
}
