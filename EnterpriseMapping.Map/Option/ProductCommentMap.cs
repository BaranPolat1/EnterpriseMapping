using EnterpriseMapping.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseMapping.Map.Option
{
    public class ProductCommentMap:CoreMap<ProductComment>
    {
        public ProductCommentMap()
        {
            ToTable("dbo.ProductComments");
            Property(x => x.Content).HasMaxLength(255).HasColumnType("NVarChar").IsOptional();
            Property(x => x.CommentDate).HasColumnType("datetime").IsOptional();

            HasRequired(x => x.AppUser)
                .WithMany(x => x.ProductComments)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(true);

            HasRequired(x => x.Product)
                .WithMany(x => x.ProductComments)
                .HasForeignKey(x => x.ProductID)
                .WillCascadeOnDelete(true);
                
        }
    }
}
