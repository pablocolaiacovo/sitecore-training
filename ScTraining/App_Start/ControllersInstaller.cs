using Glass.Mapper;
using Glass.Mapper.Sc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Configuration;
using Glass.Mapper.Pipelines.DataMapperResolver;

namespace ScTraining.App_Start
{
    //public class ControllersInstaller : IDataMapperResolverTask, IWindsorInstaller
    //{
    //    public void Execute(DataMapperResolverArgs args)
    //    {

    //    }

    //    public void Install(IWindsorContainer container, IConfigurationStore store)
    //    {
    //        //container.Register(Classes.FromThisAssembly().BasedOn<IController>().LifestyleTransient());
    //        container.Register(
    //            Component.For<ISitecoreContext>().ImplementedBy<SitecoreContext>().LifestyleTransient(),
    //            Component.For<ISitecoreService>().ImplementedBy<SitecoreService>().LifestyleTransient()
    //                .DependsOn(Dependency.OnValue("databaseName", "master"))
    //        );
    //    }
    //}
}