using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;

using HomeAccessories.Business.Abstract;
using HomeAccessories.DataAccess.Abstract;
using HomeAccessories.Business.Concrete.Managers;
using HomeAccessories.DataAccess.Concrete.EntityFramework;
using HomeAccessories.DataAccess.Concrete;
using HomeAccessories.Entities;
using HomeAccessories.DataAccess.Repositories;

namespace HomeAccessories.Website.DependencyResolvers
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel _kernel;

        public NinjectControllerFactory()
        {
            _kernel =new StandardKernel();

      
      _kernel.Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
      _kernel.Bind<IProductService>().To<ProductManager>().InSingletonScope();
      _kernel.Bind<IRepositoryBase<Product>>().To<ProductRepository>().InSingletonScope();
      _kernel.Bind<IRepositoryBase<Category>>().To<CategoryRepository>().InSingletonScope();

      _kernel.Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
      _kernel.Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
      ////_kernel.Bind<IUserService>().To<UserManager>().InSingletonScope();
      ////_kernel.Bind<IUserDal>().To<EfUserDal>().InSingletonScope();
    }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null? null : (IController) _kernel.Get(controllerType);
        }
    }
}