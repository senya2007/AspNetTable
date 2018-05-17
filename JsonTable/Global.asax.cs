using JsonTable.Clients.Mappers;
using JsonTable.Services;
using JsonTable.Services.Business;
using JsonTable.Services.Mappers;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace JsonTable
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            var container = new ServiceContainer();
            container.RegisterControllers();
            RegisterServices(container);
            container.EnableMvc();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void RegisterServices(ServiceContainer container)
        {
            container.Register<IStockService, StockService>();
            container.Register<IStockClientMapper, StockClientMapper>();
            container.Register<IPhisixApiService, PhisixApiService>();
            container.Register<IPhisixMapper, PhisixMapper>();
        }
    }
}
