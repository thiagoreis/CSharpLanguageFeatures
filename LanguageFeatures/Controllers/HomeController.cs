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

        public ViewResult CreateCollection()
        {
            string[] stringArray = {"Apple", "orange", "plum"};
            List<int> intList = new List<int> {10, 20, 30, 40};
            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"apple", 10},
                {"orange", 20 },
                {"plum", 30 }
            };
            return View("Result", (object) stringArray[1]);
        }

      
    }
}