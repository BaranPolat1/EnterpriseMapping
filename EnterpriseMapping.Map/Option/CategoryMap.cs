using EnterpriseMapping.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseMapping.Map.Option
{
  public  class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");
            Property(x => x.Name).HasMaxLength(20).HasColumnType("NVarChar").IsRequired();
            Property(x => x.Description).HasMaxLength(55).HasColumnType("NVarChar").IsOptional();

            HasMany(x => x.Products)
                .WithRequired(x => x.Category)
                .HasForeignKey(x => x.CategoryID)
                .WillCascadeOnDelete(true);
        }
    }
}
