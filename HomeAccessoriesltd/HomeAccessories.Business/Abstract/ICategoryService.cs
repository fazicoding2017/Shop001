using HomeAccessories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
