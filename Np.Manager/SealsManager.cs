using NewP.Core.Model;
using NewP.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Np.Manager
{
    public class SealsManager
    {
        SealsRepository _purchaseRepository = new SealsRepository();

        public bool AddPerSave(SealsModels p)
        {
            var save = _purchaseRepository.AddPerSave(p);
            return save;
        }
        public bool UpdateQty(PurchaseesModelsd AMM)
        {
            var update2 = _purchaseRepository.UpdateQty(AMM);
            return update2;
        }

        public SqlDataReader GetSupplyer()
        {
            var reader = _purchaseRepository.GetSupplyer();
            return reader;
        }
        public SqlDataReader GetCategory()
        {
            var reader = _purchaseRepository.GetCategory();
            return reader;
        }
        public SqlDataReader GetMedicine()
        {
            var reader = _purchaseRepository.GetMedicine();
            return reader;
        }
        public SqlDataReader GetPricee(string Name)
        {
            var reader = _purchaseRepository.GetPricee(Name);
            return reader;
        }
        public SqlDataReader GetCatToMedicine(int Category)
        {
            var reader = _purchaseRepository.GetCatToMedicine(Category);
            return reader;
        }
        public SqlDataReader PurchaseOrder(string code)
        {
            var reader = _purchaseRepository.PurchaseOrder(code);
            return reader;
        }
    }
}
