﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignHere.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult NewOrder()
        {
            return View();
        }
    }
}