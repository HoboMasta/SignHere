using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingEnvironmentWebApp.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Notaries()
        {
            return View();
        }

        public ActionResult Clients()
        {
            return View();
        }

        public ActionResult ProximitySearch()
        {
            return View();
        }
    }
}