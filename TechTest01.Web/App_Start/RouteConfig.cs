﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TechTest01.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
          name: "Product",
          url: "Product",
          defaults: new { controller = "Product", action = "Index" }
          );


            routes.MapRoute(
           name: "ProductItem",
           url: "Product/{id}",
           defaults: new { controller = "Product", action = "Product", id = UrlParameter.Optional }
           );

             
            routes.MapRoute(
                 name: "Default",
                 url: "{controller}/{action}/{id}",
                 defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
             );

      

          




        }
    }
}
