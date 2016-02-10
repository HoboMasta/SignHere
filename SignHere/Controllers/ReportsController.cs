using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingEnvironmentWebApp.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Accounting()
        {
            return View();
        }

        public ActionResult EmailLog()
        {
            return View();
        }
    }
}