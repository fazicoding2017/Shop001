using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.Entities.Complex
{
    public class ProductFilter
    {
        public int? CategoryId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        public string ProductName { get; set; }
    }
}
