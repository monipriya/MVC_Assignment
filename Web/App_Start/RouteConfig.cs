﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Priya",
                url: "{end}/{Action}/{id}",
                defaults: new { controller = "Display", action = "End", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{Action}/{id}",
                defaults: new { controller = "Events", action = "Start", id = UrlParameter.Optional }
            );

            
        }
    }
}
