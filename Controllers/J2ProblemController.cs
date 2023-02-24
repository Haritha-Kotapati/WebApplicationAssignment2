using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationAssignment.Controllers
{
    
    public class J2ProblemController : ApiController

    {//Have started the attempt , still need to figure on the logic
        [HttpGet]
        [Route("api/J2problem/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, m);
            int dice2 = rnd.Next(1, n);

            return "hello world";

       


        }
    }
}
