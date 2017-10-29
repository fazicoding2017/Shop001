using HomeAccessories.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.DataAccess.Repositories
{
  
  public class DataContext : DbContext
  {
    public DataContext() : base("Name=DefaultConnection")
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ExtraDetail> Details { get; set; }


    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //    modelBuilder.Configurations.Add(new CategoryMap());
    //    modelBuilder.Configurations.Add(new ProductMap());
    //   // modelBuilder.Configurations.Add(new UserMap());
    //}
  }
}
