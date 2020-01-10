using EnterpriseMapping.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseMapping.Map.Option
{
   public class AppuserMap:CoreMap<AppUser>
    {
        public AppuserMap()
        {
            ToTable("dbo.AppUsers");
            Property(x => x.FirstName).HasMaxLength(15).HasColumnType("NVarChar").IsRequired();
            Property(x => x.LastName).HasMaxLength(20).HasColumnType("NVarChar").IsRequired();
            Property(x => x.Email).HasColumnType("NVarChar").IsRequired();
            Property(x => x.Password).HasMaxLength(16).HasColumnType("NVarChar").IsRequired();
            Property(x => x.UserName).HasMaxLength(10).HasColumnType("NvarChar").IsRequired();
            Property(x => x.Role).IsRequired();

            HasMany(x => x.ProductComments)
                .WithRequired(x => x.AppUser)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(true);

        }
    }
}
