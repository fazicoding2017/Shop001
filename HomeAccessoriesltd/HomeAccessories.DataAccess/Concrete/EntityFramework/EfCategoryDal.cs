using HomeAccessories.DataAccess.Abstract;
using HomeAccessories.DataAccess.Concrete.EntityFramework.Contexts;
using HomeAccessories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.DataAccess.Concrete.EntityFramework
{
  public class EfCategoryDal : EfEntityRepositoryBase<Category, HomeAccessoriesContext>, ICategoryDal
  {
  }
}
