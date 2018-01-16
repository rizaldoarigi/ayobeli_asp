using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;

namespace ayobeli_asp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
												BundleConfig.RegisterBundles(BundleTable.Bundles);

        }

								protected void Application_Error(object sender, EventArgs e)
								{
												Exception exception = Server.GetLastError();
												Server.ClearError();
												Response.Redirect("/Default/Error/502");
								}
    }
}
