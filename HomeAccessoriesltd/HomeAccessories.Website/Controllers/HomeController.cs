using HomeAccessories.DataAccess.Concrete.EntityFramework.Contexts;
using HomeAccessories.Website.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeAccessories.Website.Controllers
{
    public class HomeController : Controller
    {
        private HomeAccessoriesContext context;

        public HomeController()
        {
            context = new HomeAccessoriesContext();
        }

        public ActionResult Index()
        {

            var products = context.Products.ToList();
            var categories = context.Categories.ToList();

            var model = new HomepageViewModel
            {
                Products = products,               
                Categories = categories
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}