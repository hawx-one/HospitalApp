using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalMvcApplication.Model;
using Ninject;

namespace HospitalMvcApplication.Areas.Default.Controllers
{
    public class HomeController : DefaultController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}