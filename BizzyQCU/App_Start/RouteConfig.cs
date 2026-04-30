<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
=======
﻿using System.Web.Mvc;
>>>>>>> 873990e (login and register)
using System.Web.Routing;

namespace BizzyQCU
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
<<<<<<< HEAD
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
);

=======
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
            );
>>>>>>> 873990e (login and register)
        }
    }
}