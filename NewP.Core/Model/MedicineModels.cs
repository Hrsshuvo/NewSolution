using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewP.Core.Model
{
    public class MedicineModels
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Shalf { get; set; }
        public string Name { get; set; }
        public string BatchNo { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int Quantity { get; set; }
    }
}
