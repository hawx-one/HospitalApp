using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalMvcApplication.Model;
using Ninject;

namespace HospitalMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        [Inject]
        public IRepository Repository { get; set; }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var roles = Repository.Roles.ToList();
            return View(roles);
        }

    }
}
