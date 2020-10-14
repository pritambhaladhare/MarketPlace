using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketPlace_DAL;
using MarketPlace_Services;
using System.Data.SqlClient;

namespace MarketPlace.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        //Login Action
        public ActionResult Authenticate(tblUser user)
        {

            if (ModelState.IsValid)
            {
                Service loginService = new Service();
                var IsValid = loginService.LoginCustomer(user.email, user.password);
                return IsValid ? RedirectToAction("SearchPage", "Search") : RedirectToAction("Login", "Login");
            }
            else
            {
                return View("Login");
            }


        }

        //Save New User
        public ActionResult Insert(tblUser user)
        {
            Service insert_Service = new Service();
            insert_Service.saveCustomer(user);
            return View("Login");
        }

     
    }
}