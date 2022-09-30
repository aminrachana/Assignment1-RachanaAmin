using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using System.Web.Routing;

namespace Assignment1_RachanaAmin.Controllers
{
    public class GreetingController : ApiController

    {
        public void Post([FromBody] string id)
        {

        }

        /// <summary>
        /// says "Hello World!"
        /// <example>POST api/Greeting -> "Hello World!"</example>
        /// </summary>
        /// <returns>"Hello World!"</returns>
        ///POST api/Post/Greeting

        public string Get()

        {
            return "Hello World!";
        }


        /// <summary>
        /// returns {id} with string
        /// <example> GET api/Greeting/3 -> Greetings to 3 people!</example>
        /// <example> GET api/Greeting/6 -> Greetings to 6 people!</example>
        /// <example> GET api/Greeting/0 -> Greetings to 0 people!</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Greetings to {id} people!</returns>

        //GET api/Greeting

        public string Get(int id)
        {
            return "Greetings to"+" "+ id +" "+"people!";
        }

       



    }

}
