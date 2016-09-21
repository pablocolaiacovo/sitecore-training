using Glass.Mapper;
using Glass.Mapper.Sc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Configuration;
using Glass.Mapper.Pipelines.DataMapperResolver;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;

namespace ScTraining.App_Start
{
    public class ControllersInstaller : IWindsorInstaller
    { 
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<ISitecoreContext>().ImplementedBy<SitecoreContext>().LifestyleTransient(),
                Component.For<ISitecoreService>().ImplementedBy<SitecoreService>().LifestyleTransient()
                    .DependsOn(Dependency.OnValue("databaseName", "master"))
            );
        }
    }
}