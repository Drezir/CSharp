using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DotNet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes(); // enable better way of creating routes
            // order of routes matters
            // most specific at top
            // not cleanes way to create route
            /*
            routes.MapRoute(
                "MoviesByReleaseDate",
                "movie/released/{year}/{month}",
                new { controller = "Movie", action = "ByReleaseDate" }, 
                new {year = @"\d{4}", month = @"\d{2}"} // regex
            );
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
