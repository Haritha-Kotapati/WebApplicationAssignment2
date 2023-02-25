using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationAssignment.Controllers
{
    public class RobbersLanguageController : Controller
    {
        // GET: RobbersLanguage
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Word()
        {
            return View();
        }

        public ActionResult ConvertToRobbers(string wordInput)
        {
            ViewData["wordInput"] = wordInput;
            return View();
        }
    }
}