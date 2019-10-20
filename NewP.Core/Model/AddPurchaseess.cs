using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewP.Core.Model
{
    public class AddPurchaseess
    {
        public int Id { get; set; }
        public string SupplyerName { get; set; }
        public string Code { get; set; }
        public int Total { get; set; }
        public int Discount { get; set; }
        public string PaymentMathod { get; set; }
        public int GrandTotal { get; set; }
        public string Statas { get; set; }
    }
}
