using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectsMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Authorize]
        public ContentResult Index()
        {
            return Content(" I AM FROM HOME CONTROLLER AFTER AUTHENTICATION ");
           
        }
    }
}


