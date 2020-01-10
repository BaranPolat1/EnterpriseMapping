using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseMapping.Model.Entity.Concrete
{
   public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Descreption { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitInStock { get; set; }

        public Guid CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public List<ProductComment>  ProductComments { get; set; }
    }
}
