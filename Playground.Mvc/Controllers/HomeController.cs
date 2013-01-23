using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Playground.Mvc.Controllers
{
    public class HomeController : Controller
    {

        /* Create a simple .NET MVC application that allows users to search Twitter for a hashtag 
         * and page through results 10 items at a time. At a bare minimum, the UI should display 
         * a search box, a search button, a list of 10 results, and forward and back paging links. 
         * Bonus points will be given for CSS/design hotness. To minimize calls to the Twitter 
         * Search API, the server should retrieve 100 results per page and store them locally.
         */

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
