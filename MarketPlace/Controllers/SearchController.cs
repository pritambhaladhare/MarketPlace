using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketPlace_DAL;
using MarketPlace_Services;
using System.Data.SqlClient;

namespace MarketPlace.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchPage()
        {
            return View();
        }

        public ActionResult Search(string searchitem)
        {
            ViewData["SearchItem"] = "Fan";  
            return View();
        }

           //Get products autocomplete
        public ActionResult GetProducts(string ProductName)
        {
            Service Service = new Service();
            var ProductList = Service.GetAllProductsByName(ProductName);
            return Json(ProductList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetProductsJson(string ProductName)
        {
            Service Service = new Service();
            var ProductList = Service.GetAllProductsByName(ProductName);
            return Json(ProductList, JsonRequestBehavior.AllowGet);
            //return View("Search", Json(ProductList, JsonRequestBehavior.AllowGet));
        }

        


    }
}