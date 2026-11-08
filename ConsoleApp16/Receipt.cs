using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    public class Receipt
    {
        public Receipt(decimal price, decimal quantity, decimal discountPercent, decimal sum, decimal total)
        {
            Price = price;
            Quantity = quantity;
            DiscountPercent = discountPercent;
            Sum = sum;
            Total = total;
        }

        public decimal Price { get; }
        public decimal Quantity { get; }
        public decimal DiscountPercent { get; }
        public decimal Sum { get; }
        public decimal Total { get; }
    }
}
