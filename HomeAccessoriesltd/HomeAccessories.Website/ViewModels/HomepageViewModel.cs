using HomeAccessories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeAccessories.Website.ViewModels
{
    public class HomepageViewModel
    {
        public List<Category> Categories { get; set;}
        public List<Product> Products { get; set; }
    }
}