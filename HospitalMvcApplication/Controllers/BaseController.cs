using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalMvcApplication.Mappers;
using HospitalMvcApplication.Model;
using Ninject;

namespace HospitalMvcApplication.Controllers
{
    public class BaseController : Controller
    {
        [Inject]
        public IRepository Repository { get; set; }

        [Inject]
        public IMapper ModelMapper { get; set; }
    }
}
