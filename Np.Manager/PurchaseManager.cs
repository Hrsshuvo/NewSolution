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
    public class PurchaseManager
    {
        PurchaseRepository _purchaseRepository = new PurchaseRepository();

        //public bool PerSave(PurchaseesModelsd p)
        //{
        //    var save = _purchaseRepository.PerSave(p);
        //    return save;
        //}
        //public bool AddPerSave(AddPurchaseess p)
        //{
        //    var save = _purchaseRepository.AddPerSave(p);
        //    return save;
        //}
        //public bool UpdateQty(PurchaseesModelsd AMM)
        //{
        //    var update2 = _purchaseRepository.UpdateQty(AMM);
        //    return update2;
        //}

        //public bool GetByCode(string Code)
        //{
        //    var isExist = false;
        //    var user = _purchaseRepository.GetByCode(Code);
        //    if (user != null)
        //        isExist = true;
        //    return isExist;
        //}
        //public SqlDataReader GetSupplyer()
        //{
        //    var reader = _purchaseRepository.GetSupplyer();
        //    return reader;
        //}
        //public SqlDataReader GetCategory()
        //{
        //    var reader = _purchaseRepository.GetCategory();
        //    return reader;
        //}
        //public SqlDataReader GetMedicine( )
        //{
        //    var reader = _purchaseRepository.GetMedicine();
        //    return reader;
        //}
        //public SqlDataReader GetPurchTot()
        //{
        //    var reader = _purchaseRepository.GetPurchTot();
        //    return reader;
        //}
        //public SqlDataReader GetSeallsTot()
        //{
        //    var reader = _purchaseRepository.GetSeallsTot();
        //    return reader;
        //}
        //public SqlDataReader GetPricee(string Name)
        //{
        //    var reader = _purchaseRepository.GetPricee(Name);
        //    return reader;
        //}
        //public SqlDataReader GetCatToMedicine(string Name)
        //{
        //    var reader = _purchaseRepository.GetCatToMedicine(Name);
        //    return reader;
        //}
        //public SqlDataReader PurchaseOrder(string code)
        //{
        //    var reader = _purchaseRepository.PurchaseOrder(code);
        //    return reader;
        //}
    }
}
