using System;
using System.Collections.Generic;

namespace Library.DomainOrders
{
    public class Order
    {
        public int S { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public byte[] RowVersion { get; set; }
    }
}