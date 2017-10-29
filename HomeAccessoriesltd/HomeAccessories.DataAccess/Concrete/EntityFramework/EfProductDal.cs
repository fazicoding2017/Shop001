using HomeAccessories.DataAccess.Abstract;
using HomeAccessories.DataAccess.Concrete.EntityFramework.Contexts;
using HomeAccessories.Entities;
using HomeAccessories.Entities.Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.DataAccess.Concrete.EntityFramework
{
  public class EfProductDal : EfEntityRepositoryBase<Product, HomeAccessoriesContext>, IProductDal
  {
    public List<ProductDetail> GetProductDetails()
    {
      throw new NotImplementedException();
    }

    public int GetProductsCountByCategory(int? categoryId)
    {
      using (var context = new HomeAccessoriesContext())
      {
        if (categoryId == null)
        {
          return context.Products.Count();
        }

        return context.Products.Count(p => p.CategoryId == categoryId);
      }
    }
  }
}
