using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using HospitalMvcApplication.Model;
using HospitalMvcApplication.Mappers;

namespace HospitalMvcApplication.Controllers
{
    public abstract class BaseController : Controller
    {
        [Inject]
        public IRepository Repository { get; set; }
   

     [Inject]
        public IMapper ModelMapper { get; set; }
    }
    
}
