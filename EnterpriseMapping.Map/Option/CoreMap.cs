using EnterpriseMapping.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseMapping.Map.Option
{
    public class CoreMap<T>:EntityTypeConfiguration<T> where T:BaseEntity
    {
        public CoreMap()
        {
            Property(x => x.ID).HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.UpdateDate).HasColumnName("UpdateDate").IsOptional();
            Property(x => x.AddDate).HasColumnName("AddedDate").IsRequired();
            Property(x => x.DeleteDate).HasColumnName("DeletedDate").IsOptional();
            
        }
    }
}
