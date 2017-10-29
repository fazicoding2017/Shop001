using HomeAccessories.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.DataAccess.Concrete.EntityFramework.Contexts
{
  public class HomeAccessoriesContext : DbContext
  {
    public HomeAccessoriesContext() : base("Name=DefaultConnection")
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ExtraDetail> ExtraDetails { get; set; }


    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //    modelBuilder.Configurations.Add(new CategoryMap());
    //    modelBuilder.Configurations.Add(new ProductMap());
    //   // modelBuilder.Configurations.Add(new UserMap());
    //}
  }
}
