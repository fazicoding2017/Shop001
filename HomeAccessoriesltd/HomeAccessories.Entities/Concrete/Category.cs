using HomeAccessories.Entities.Abstract;
using System.Collections.Generic;

namespace HomeAccessories.Entities
{
    public class Category : IEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}