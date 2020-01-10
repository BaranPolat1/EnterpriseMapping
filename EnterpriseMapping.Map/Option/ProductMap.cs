using EnterpriseMapping.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseMapping.Map.Option
{
   public class ProductMap:CoreMap<Product>
    {
        public ProductMap()
        {
            ToTable("dbo.Products");
            Property(x => x.Name).HasMaxLength(20).HasColumnType("NVarChar").IsRequired();
            Property(x => x.Descreption).HasMaxLength(50).HasColumnType("NVarChar").IsOptional();
            Property(x => x.UnitInStock).HasColumnType("smallint").IsRequired();
            Property(x => x.UnitPrice).HasColumnType("money").IsRequired();

            HasRequired(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryID)
                .WillCascadeOnDelete(true);

            HasMany(x => x.ProductComments)
                .WithRequired(x => x.Product)
                .HasForeignKey(x => x.ProductID)
                .WillCascadeOnDelete(true);
        }
    }
}
