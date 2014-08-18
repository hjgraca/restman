using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using RestManager.DataContexts;

namespace RestManager.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Title = "Food Craving - Restaurant Manager";
            var rest = new RestaurantDbContext();
            var id = int.Parse(User.Identity.GetRestaurantId());
            return PartialView("_Details", rest.Restaurants.First(x => x.Id == id));
        }
    }
}