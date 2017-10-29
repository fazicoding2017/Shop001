using HomeAccessories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeAccessories.Website.ViewModels
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }

        public int? CurrentCategory { get; set; }
    }
}