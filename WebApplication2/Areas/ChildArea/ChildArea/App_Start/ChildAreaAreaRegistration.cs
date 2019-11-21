using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChildArea.App_Start
{
    public class ChildAreaAreaRegistration : AreaRegistration
    {
        public override string AreaName => "ChildArea";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ChildArea_default",
                "ChildArea/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "ChildArea.Controllers" }
            );
        }
    }
}