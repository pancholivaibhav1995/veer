using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace veer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public class BundleConfig
        {
            public static void RegisterBundles(BundleCollection bundles)
            {
                bundles.Add(new ScriptBundle("~/GlobalJs.js")
                     .Include("~/Scripts/jquery-3.5.1.min.js")
                     .Include("~/Scripts/popper.min.js")
                      .Include("~/Scripts/bootstrap.min.js")
                        );
                bundles.Add(new StyleBundle("~/GlobalCss.css")
                    .Include("~/Content/bootstrap.min.css")
                       );

                bundles.Add(new ScriptBundle("~/Homejs.js")
                    .Include("~/Scripts/Home.js")
                      );

                bundles.Add(new StyleBundle("~/Home.css")
                   .Include("~/Content/Home.css")
                     );
            }
        }
    }
}
