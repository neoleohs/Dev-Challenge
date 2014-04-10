using Ninject.Web.Common;
using Ninject;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Configuration;

namespace DevChallenge
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected override IKernel CreateKernel()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["TitlesConnectionString"].ConnectionString;

            var module = new NinjectBootstrapper(connectionString);

            var kernel = new StandardKernel(module);

            return kernel;
        }
    }
}
