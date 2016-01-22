using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using MvcSitemap3.DI;
using MvcSitemap3.DI.Unity;
using MvcSitemap3.DI.Unity.ContainerExtensions;


internal class CompositionRoot
{
    public static IDependencyInjectionContainer Compose()
    {
        var container = new UnityContainer();
        container.AddNewExtension<MvcSiteMapProviderContainerExtension>();

        return new UnityDependencyInjectionContainer(container);
    }
}
