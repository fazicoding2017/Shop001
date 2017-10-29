using HomeAccessories.Entities;
using HomeAccessories.Entities.Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.DataAccess.Abstract
{
  public interface IProductDal : IEntityRepository<Product>
  {
    List<ProductDetail> GetProductDetails();

    int GetProductsCountByCategory(int? categoryId);
  }
}
