using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC.RestAPI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "NewUser", // Route name
                "{controller}/", // URL with parameters
                new { controller = "Users", action = "Create" },
                new { httpMethod = new HttpMethodConstraint("POST") }
            );

            routes.MapRoute(
                "ListUser", // Route name
                "{controller}/", // URL with parameters
                new { controller = "Users", action = "Index" },
                new { httpMethod = new HttpMethodConstraint("GET") }
            );

            routes.MapRoute(
                "UpdateUser", // Route name
                "{controller}/{id}", // URL with parameters
                new { controller = "Users", action = "Update", id = UrlParameter.Optional },
                new { httpMethod = new HttpMethodConstraint("PUT") }
            );

            routes.MapRoute(
                "DeleteUser", // Route name
                "{controller}/{id}", // URL with parameters
                new { controller = "Users", action = "Delete", id = UrlParameter.Optional },
                new { httpMethod = new HttpMethodConstraint("DELETE") }
            );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Users", action = "Index", id = UrlParameter.Optional }
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}