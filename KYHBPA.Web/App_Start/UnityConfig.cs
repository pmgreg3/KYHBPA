using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using KYHBPA.Data.Interfaces;
using KYHBPA.Entities;
using KYHBPA.Data.Repositories;
using Microsoft.AspNet.Identity;
using KYHBPA.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using KYHBPA.Web.Controllers;
using System.Data.Entity;

namespace KYHBPA.Web.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IGenericRepository<Report>, ReportRepository>();
            container.RegisterType<IGenericRepository<Image>, ImageRepository>();
            container.RegisterType<IKYHBPADbContext, KYHBPADbContext>();

            //Register for Microsoft Identity
            container.RegisterType<DbContext, ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<UserManager<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());
        }
    }
}
