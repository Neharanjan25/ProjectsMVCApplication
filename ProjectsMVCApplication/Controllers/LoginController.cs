using ProjectsMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjectsMVCApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            ViewBag.Title = "Login";
            return View();
        }

        public ActionResult LoginCheck()
        {
            string userName = Request.Form["username"];
            string password = Request.Form["password"];
            DataAccessLayer_model obj = new DataAccessLayer_model();
            //implement DB logic here
            int result = obj.CheckUserDetails(userName, password);
            if(result == 1) 
                {
                FormsAuthentication.SetAuthCookie(userName,true);
                return RedirectToAction("index", "Home");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}