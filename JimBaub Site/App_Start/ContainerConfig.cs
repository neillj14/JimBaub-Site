using Autofac;
using Autofac.Integration.Mvc;
using JimBaub_Site.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JimBaub_Site
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            //Register Components
            builder.RegisterType<InMemoryMerch>()
                .As<IStoreData>()
                .SingleInstance();
            builder.RegisterAssemblyTypes(typeof(MvcApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}