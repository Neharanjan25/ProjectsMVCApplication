using ProjectsMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectsMVCApplication.Controllers
{
    public class ValidationMSGexampleController : Controller
    {
        // GET: ValidationMSGexample
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ValidationMSGexampleModel validationModal)
        {
            return View(validationModal);
        }

    }
}