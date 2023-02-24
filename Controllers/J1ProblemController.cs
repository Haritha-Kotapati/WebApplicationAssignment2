using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationAssignment.Controllers
{
    public class J1ProblemController : ApiController
    {
        [HttpGet]
        [Route("api/J1problem/Menu/{b}/{d}/{s}/{ds}")]
        public string Menu(int b, int d, int s, int ds)
        {
            int[] burgerCalories = { 461, 431, 420, 0 };
            int[] drinkCalories = { 130, 160, 118, 0 };
            int[] sidecalories = { 100, 57, 70, 0 };
            int[] dessertCalories = { 167, 266, 75, 0 };


            int total;
           
            total = burgerCalories[b-1] + drinkCalories[d-1] + sidecalories[s-1] + dessertCalories[ds-1] ;
              
            
            return "Your total calorrie count is " + total + ".";
        }

       
    }
}
