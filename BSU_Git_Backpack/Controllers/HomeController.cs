﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BSU_Git_Backpack.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AccountManagement()
        {
            ViewBag.Message = "Your account management page.";

            return View();
        }

        public ActionResult CreateAccount()
        {
            ViewBag.Message = "Your account management page.";

            return View();
        }
    }
}