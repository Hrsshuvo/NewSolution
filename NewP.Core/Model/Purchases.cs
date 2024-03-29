﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewP.Core.Model
{
    public class Purchases
    {
        public int Id { get; set; }
        public string PurchaseId { get; set; }
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
    }
}
