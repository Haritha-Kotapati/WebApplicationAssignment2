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
       
        public ActionResult Winner(string personName, int maxAmountBidded)
        {
            //int maxAmount;
            //for (int i = 1; i )
            ViewData["name"] = personName;
            ViewData["amount"] = maxAmountBidded;
            return View();
        }
        [HttpPost]
        public ActionResult FindWinner(List<string> personNames, List<int> amountsBidded)
        {
            string personName = String.Empty;
            int maxAmountBidded = amountsBidded.Max();
            int maxIndex = amountsBidded.ToList().IndexOf(maxAmountBidded);

            personName = personNames[maxIndex];

            //   names.Add(ViewData["personName3"].ToString());

            return RedirectToAction("Winner", "Auction", new { personName, maxAmountBidded });
            //return View();
          // ViewData["amountBidded"] = bidAmounts.Append(amountBidded);

        }
    }
}