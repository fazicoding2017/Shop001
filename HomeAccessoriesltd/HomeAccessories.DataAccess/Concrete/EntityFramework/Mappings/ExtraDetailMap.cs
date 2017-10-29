using HomeAccessories.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.DataAccess.Concrete.EntityFramework.Mappings
{
  public class ExtraDetailMap : EntityTypeConfiguration<ExtraDetail>
  {
    public ExtraDetailMap()
    {
      HasKey(t => t.ExtraDetailId);


      Property(t => t.ExtraDetailTitle).IsRequired().HasMaxLength(40);
      Property(t => t.ExtraDetailDescription).IsRequired().HasMaxLength(300);


      ToTable("ExtraDetails");

      Property(t => t.ExtraDetailId).HasColumnName("ID");
      Property(t => t.ExtraDetailTitle).HasColumnName("Title");
      Property(t => t.ExtraDetailDescription).HasColumnName("Description");

      HasOptional(t => t.Product).WithMany(d => d.ExtraDetails).HasForeignKey(d => d.ProductId);
    }
  }
}
