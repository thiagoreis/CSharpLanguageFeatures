using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to URL to...";
        }

        public ViewResult AutoProperty()
        {
            
            Product myProduct = new Product();
            myProduct.Name = "Teste";

            string productName = myProduct.Name;

            return View("Result", (object) String.Format("Product name: {0}", productName));

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