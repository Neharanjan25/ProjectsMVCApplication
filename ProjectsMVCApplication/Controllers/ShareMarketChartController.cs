using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectsMVCApplication.Controllers
{
    public class ShareMarketChartController : Controller
    {
        // GET: ShareMarketChart
        public ActionResult Chart()
        {
            return View();
        }
    }
}