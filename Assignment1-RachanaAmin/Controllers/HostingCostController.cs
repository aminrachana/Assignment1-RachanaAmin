using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_RachanaAmin.Controllers
{
    public class HostingCostController : ApiController
    {
        ///<summary>
        ///Calculate the Hosting cost.
        ///</summary>
        ///<param name="id">The input {days} reperesents the number of days which has elapsed since the beginning of the hosting.</param>
        ///<return>
        ///cost(as per Fortnight),
        ///Tax(13% HST),
        ///Total cost=(cost + total cost)
        ///</return>
        ///<example>
        ///GET api/HostingCost/0 -> “1 fortnights at $5.50/FN = $5.50 CAD” “HST 13% = $0.72 CAD” “Total = $6.22 CAD”
        ///</example>
        ///<example>
        ///GET api/HostingCost/14 -> “2 fortnights at $5.50/FN = $11.00 CAD” “HST 13% = $1.43 CAD” “Total = $12.43 CAD”
        ///</example>
        ///<example>
        ///GET api/HostingCost/15 -> “2 fortnights at $5.50/FN = $11.00 CAD” “HST 13% = $1.43 CAD” “Total = $12.43 CAD”
        ///</example>
        ///<example>
        ///GET api/HostingCost/21 -> “2 fortnights at $5.50/FN = $11.00 CAD” “HST 13% = $1.43 CAD” “Total = $12.43 CAD”
        ///</example>
        ///<example>
        ///GET api/HostingCost/28 -> 3 fortnights at $5.50/FN = $16.50 CAD” “HST 13% = $2.14 CAD” “Total = $18.64 CAD"
        ///</example>
       
        public IEnumerable<string> Get(int id)
        {
            int days = id;
            int FN = (days / 14)+1;
            double cost = FN * 5.50;
            double tax = 0.13 * cost;
            double totalCost = tax + cost;
            return new string[] { FN+" "+"fortnight at $5.50/FN=" + cost + "CAD", "HST 13% =" + tax, "Total=" + totalCost + "CAD" };
        }

    }
}
