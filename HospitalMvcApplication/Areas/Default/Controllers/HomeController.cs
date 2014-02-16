﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalMvcApplication.Controllers;
using HospitalMvcApplication.Model;

namespace HospitalMvcApplication.Areas.Default.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Default/Home/

        public ActionResult Index()
        {
          
            return View();
        }

        public ActionResult UserLogin()
        {
            return View(CurrentUser);
        }
    }
}
