using HomeAccessories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeAccessories.Website.ViewModels
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}