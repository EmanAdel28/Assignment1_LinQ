using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_LinQ
{
    internal class Order
    {

        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }

        public decimal Total { get; set; }

        public Order(int orderId, DateTime orderDate, decimal total)
        {
            OrderID = orderId;
            OrderDate = orderDate;
            Total = total;
        }

        public Order()
        {
        }

        public override string ToString()
        {
            return $"OrderId: {OrderID} ,OrderDate: {OrderDate.ToShortDateString()} , Total: {Total} ";
        }

    }
}
