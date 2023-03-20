using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Model
{
    public class OrderObject
    {
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public string OrderDate { get; set; }
        public Decimal TotalMoney { get; set; }
        public int FoodID { get; set; }
        public int Quantity { get; set; }

    }
}
