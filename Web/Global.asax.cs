using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Service.Helpers;
using Autofac;
using Autofac.Integration.Mvc;

using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Service.Interfaces;
using Service.Implementation;

namespace Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            builder.RegisterType<CustomerService>().As<ICustomerService>();

            builder.RegisterGeneric(typeof(Repository<>))
                   .As(typeof(IRepository<>))

                   .InstancePerRequest();
            builder.Register(ctx =>
            {
                var efcontext = new EfContext();
                return new UnitOfWork(efcontext);
            }).As<IUnitOfWork>();


            IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));



            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);









        }
    }
}
