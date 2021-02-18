
//#########################################################
//#     ___         __                                     #
//#    /   |  _____/ /_  ______                            #
//#   / /| | / ___/ / / / / __ \                           #
//#  / ___ |(__  ) / /_/ / / / /                           #
//# /_/  |_/____/_/\__,_/_/ /_/                            #
//#                                                        #
//# Développeur multi-platerformes                         #
//# Twitter : https://twitter.com/aslunFR                  #
//##########################################################

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Efredia
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Home",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }




            );
        }
    }
}
