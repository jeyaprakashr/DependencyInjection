using DataAccess.IRepository;
using WebAPIService.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using DataAccess.Repository;

namespace DependencyApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<ICustomerService, CustomerService>();

        }
    }
}