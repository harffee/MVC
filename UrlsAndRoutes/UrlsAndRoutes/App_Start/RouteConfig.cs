﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /*
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            
    */
            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}", 
                new { controller = "Home", action = "Index", id = UrlParameter.Optional},
                new { customConstraint= new UserAgentConstraint("Chrome") });
        }
    }
}
