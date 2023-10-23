using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    //1 shipper  n order
    //1 order    1 shipper
    public class Supplier : BaseEntity
    {
        public string CompanyName { get; set; }
        public string ContactNo { get; set; }
        //Relational Properties
        public virtual List<Product> Products { get; set; }
    }
}
