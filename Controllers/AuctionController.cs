using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationAssignment.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auction
        public ActionResult Index()
        {

            return View();
        }

        //GET: localhost:xxx/Auction/Welcome

        public ActionResult Welcome()
        {
            return View();
        }

        //GET: localhost:xxx/Auction/StartAuction
        public ActionResult StartAuction()
        {
            return View();
        }
       
        /// <summary>
        /// This method returns the name & value of maximum amount bidded 
        /// </summary>
        /// <param name="personName"></param>
        /// <param name="maxAmountBidded"></param>
        /// <returns></returns>
        public ActionResult Winner(string personName, int maxAmountBidded)
        {
            
            ViewData["name"] = personName;
            ViewData["amount"] = maxAmountBidded;
            return View();
        }
        [HttpPost]
        
        ///List to save the input data and hold it as an array
        public ActionResult FindWinner(List<string> personNames, List<int> amountsBidded)
        {
            string personName = String.Empty;
            int maxAmountBidded = amountsBidded.Max();
            int maxIndex = amountsBidded.ToList().IndexOf(maxAmountBidded);

            personName = personNames[maxIndex];

            return RedirectToAction("Winner", "Auction", new { personName, maxAmountBidded });
           

        }
    }
}