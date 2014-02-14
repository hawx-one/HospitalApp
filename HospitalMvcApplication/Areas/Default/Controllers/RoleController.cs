using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalMvcApplication.Areas.Default.Controllers
{
    public class RoleController : DefaultController
    {
        public ActionResult Index()
        {
            var roles = Repository.Roles.ToList();
            return View(roles);
        }

    }
}
