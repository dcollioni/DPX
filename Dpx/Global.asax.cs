using Dpx.Controllers;
using Raven.Client;
using Raven.Client.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Dpx
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IDocumentStore DocumentStore { get; set; }

        public MvcApplication()
        {
            BeginRequest += (sender, args) =>
            {
                HttpContext.Current.Items["CurrentRequestRavenSession"] = RavenController.DocumentStore.OpenSession();
            };

            EndRequest += (sender, args) =>
            {
                using (var session = (IDocumentSession)HttpContext.Current.Items["CurrentRequestRavenSession"])
                {
                    if (session == null) return;
                    if (Server.GetLastError() != null) return;
                    session.SaveChanges();
                }
            };
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Configure(GlobalConfiguration.Configuration);
            FilterConfig.Configure(GlobalFilters.Filters);
            RouteConfig.Configure(RouteTable.Routes);
            BundleConfig.Configure(BundleTable.Bundles);
            AuthConfig.Configure();
            DocumentStoreConfig.Configure();
            RavenController.DocumentStore = DocumentStore;            
        }
    }
}