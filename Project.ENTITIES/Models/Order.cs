using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{

    //1 appUser   n order
    //1 order     1 AppUser
    public class Order : BaseEntity
    {
        public string OrderNo { get; set; }
        public string OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippedDate { get; set; }
        public int? UserID { get; set; }
        public int? ShipperID { get; set; }
        //Relational Properties
        public virtual AppUser User { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
