using ProjectsMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectsMVCApplication.Controllers
{
    public class DesignPatternController : Controller
    {
        DesignPattern obj = new DesignPattern();
        // GET: DesignPattern
        public ActionResult Index()
        {
           
            
            var countryList = new List<SelectListItem>();

            foreach (var response in obj.Country)
            {
                countryList.Add(new SelectListItem()
                {
                    Text = response
                });
            }
            TempData["countryList"] = countryList;
            TempData["hobbiesList"] = obj.Hobbies;
            TempData.Keep();
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(DesignPattern model, FormCollection collection) { 
        
        //    var data = string.Empty;
        //    foreach (var item in collection) {

        //        if (FormCollection[item].ToString().Contains("true")) {
        //            data = data + item + " ,";
        //        }
        //    }
        //    obj.HoobiesValue = data;
        //    obj.AddEmployee(obj);
        //    obj.CountryValue = data;
        //    return View();
        //}
    }
}