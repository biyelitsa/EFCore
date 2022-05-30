using System;
using System.Collections.Generic;

#nullable disable

namespace CoreDbFirst.Models.Data
{
    public partial class Sati
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string Satici { get; set; }
        public string ProductName { get; set; }
        public DateTime? OrderDate { get; set; }
        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public float Discount { get; set; }
        public decimal? Price { get; set; }
        public float? Indirimlifiyat { get; set; }
    }
}
