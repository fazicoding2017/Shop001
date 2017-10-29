using HomeAccessories.DataAccess.Abstract;
using HomeAccessories.DataAccess.Concrete.EntityFramework.Contexts;
using HomeAccessories.DataAccess.Repositories;
using HomeAccessories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.DataAccess.Concrete.EntityFramework
{
  public class ProductRepository : RepositoryBase<Product>
  {
    public ProductRepository(DataContext context)
        : base(context)
    {
      if (context == null)
        throw new ArgumentNullException();
    }
  }
}
