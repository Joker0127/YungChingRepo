using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteSupport.Model
{
    public class Order_Details
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public Decimal UnitPrice { get; set; }
        public Int16 Quantity { get; set; }
        public Single Discount { get; set; }
    }
}
