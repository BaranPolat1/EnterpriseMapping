using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseMapping.Model.Entity.Concrete
{
    public class ProductComment:BaseEntity
    {
        public string Content { get; set; }
        private DateTime _commentDate = DateTime.Now;
        public DateTime CommentDate { get { return _commentDate; } set { _commentDate = value; } }

        public Guid ProductID { get; set; }
        public virtual Product Product { get; set; }

        public Guid AppUserID { get; set; }
        public  virtual AppUser AppUser { get; set; }
    }
}
