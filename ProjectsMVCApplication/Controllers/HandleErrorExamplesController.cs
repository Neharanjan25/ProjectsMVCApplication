using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectsMVCApplication.Controllers
{
    public class HandleErrorExamplesController : Controller
    {
        // GET: HandleErrorExamples
        [HandleError] //https://localhost:44337/HandleErrorExamples/index
        public ActionResult Index()
        {
            int a = 1;
            int b = 0;
            int c = a / b; //This would cause an Extron 
            return View();
        }

        
    }
}