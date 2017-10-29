using HomeAccessories.Entities.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.Entities
{
  public class Product : IEntity
  {
    public Product()
    {
      ExtraDetails = new List<ExtraDetail>();

    }
    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public string ProductDescription { get; set; }

    public virtual IList<ExtraDetail> ExtraDetails { get; set; }

    public string QuantityPerUnit { get; set; }

    public decimal? UnitPrice { get; set; }

    public short? UnitsInStock { get; set; }

    public int? CategoryId { get; set; }
    public virtual Category Category { get; set; }
  }
}
