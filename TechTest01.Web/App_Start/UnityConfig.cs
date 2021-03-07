using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using TechTest01.Services.Catalog;

namespace TechTest01.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterSingleton<IProductService,ProductServices>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            
        }
    }
}