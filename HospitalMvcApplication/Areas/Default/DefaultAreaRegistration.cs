﻿using System.Web.Mvc;

namespace HospitalMvcApplication.Areas.Default
{
    public class DefaultAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Default";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                null,
                url: "Error",
                defaults: new { controller = "Error", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "HospitalMvcApplication.Areas.Default.Controllers" }
            );

            context.MapRoute(
                null,
                url: "NotFoundPage",
                defaults: new { controller = "Error", action = "NotFoundPage", id = UrlParameter.Optional },
                namespaces: new[] { "HospitalMvcApplication.Areas.Default.Controllers" }
            );

        }
    }
}
