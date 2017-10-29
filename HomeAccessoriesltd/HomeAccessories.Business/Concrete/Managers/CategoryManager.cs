using HomeAccessories.Business.Abstract;
using HomeAccessories.DataAccess.Abstract;
using HomeAccessories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.Business.Concrete.Managers
{
  public class CategoryManager : ICategoryService
  {
    private IRepositoryBase<Category> _categories;

    public CategoryManager(IRepositoryBase<Category> categories)
    {
      _categories = categories;
    }

    public List<Category> GetAll()
    {
      return _categories.GetAll().ToList();
    }
  }
}
