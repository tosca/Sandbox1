using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sandbox
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });
            routes.IgnoreRoute("{folder}/{*pathInfo}", new { folder = "Content" });

            routes.MapRoute(
               "Default",
               "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               "Index",
               "Index",
               new { controller = "Home", action = "Index" }
               );

            routes.MapRoute(
               "Scribbles",
               "Scribbles",
               new { controller = "Home", action = "Scribbles" }
               );

            routes.MapRoute(
               "Kids-Rings",
               "Kids-Rings",
               new { controller = "Home", action = "KidsRings" }
               );

            routes.MapRoute(
               "The-Mother-Load-Project",
               "The-Mother-Load-Project",
               new { controller = "Home", action = "TheMotherLoadProject" }
               );

            routes.MapRoute(
               "About-Natalie-Macellaio",
               "About-Natalie-Macellaio",
               new { controller = "Home", action = "About" }
               );

            routes.MapRoute(
               "Contact-Natalie-Macellaio",
               "Contact-Natalie-Macellaio",
               new { controller = "Home", action = "Contact" }
               );

            
        }
    }
}