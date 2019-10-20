using NewP.Persistance.Database;
using NewP.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewP.Persistance.Repository
{
    public class PurchaseRepository
    {
        PharmaDb _pharmaDb = new PharmaDb();

        public decimal AlreadyExistData()
        {
            string query = "Select Count(*)from Purchase ";
            return _pharmaDb.ExecuteScalar(query, _pharmaDb.ConnectionStrings());
        }
        public Purchases GetLastPurchaseId()
        {
            Purchases _Purchase = null;

            string query = "Select top 1 PurchaseId from Purchase order by PurchaseId desc";
            var reader = _pharmaDb.Reader(query, _pharmaDb.ConnectionStrings());
            if (reader.HasRows)
            {
                reader.Read();
                _Purchase = new Purchases();
                _Purchase.PurchaseId = (reader["PurchaseId"].ToString());
            }
            reader.Close();

            return _Purchase;
        }
        public List<SupplyModelss> GetAllSupplliers()
        {
            var _SuppliersList = new List<SupplyModelss>();
            string query = ("Select *From Suppliers");
            var reader = _pharmaDb.Reader(query, _pharmaDb.ConnectionStrings());
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var _Suppliers = new SupplyModelss();
                    _Suppliers.Id = Convert.ToInt32(reader["Id"].ToString());
                    _Suppliers.Name = reader["Name"].ToString();

                    _SuppliersList.Add(_Suppliers);
                }
            }
            reader.Close();

            return _SuppliersList;
        }
        public List<CategoryModel> GetAllCategories()
        {
            var _CategoryList = new List<CategoryModel>();
            string query = ("Select *From Categories");
            var reader = _pharmaDb.Reader(query, _pharmaDb.ConnectionStrings());
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var _Category = new CategoryModel();
                    _Category.Id = Convert.ToInt32(reader["Id"].ToString());
                    _Category.Name = reader["Name"].ToString();

                    _CategoryList.Add(_Category);
                }
            }
            reader.Close();

            return _CategoryList;
        }
        public List<MedicineModels> GetAllItemsByCategories(int Id)
        {
            var _ItemsList = new List<MedicineModels>();
            string query = ("Select *From Items Where CategoriesId='" + Id + "' ");
            var reader = _pharmaDb.Reader(query, _pharmaDb.ConnectionStrings());
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var _Items = new MedicineModels();
                    _Items.BatchNo = reader["BatchNo"].ToString();
                    _Items.Name = reader["Name"].ToString();

                    _ItemsList.Add(_Items);
                }
            }
            reader.Close();

            return _ItemsList;
        }
        public List<Purchases> GetAllPurchase()
        {
            var _PurchasesList = new List<Purchases>();
            string query = ("select Suppliers.Name,Purchase.PurchaseId,Purchase.TotalAmount,Purchase.Discount,Purchase.GrandTotal,Purchase.Status,Purchase.Date from Purchase join Suppliers on Suppliers.Id = Purchase.SupplierId");
            var reader = _pharmaDb.Reader(query, _pharmaDb.ConnectionStrings());
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var _Purchases = new Purchases();
                    _Purchases.Name = reader["Name"].ToString();
                    _Purchases.PurchaseId = reader["PurchaseId"].ToString();
                    _Purchases.TotalAmount = Convert.ToDecimal(reader["TotalAmount"].ToString());
                    _Purchases.Discount = Convert.ToDecimal(reader["Discount"].ToString());
                    _Purchases.GrandTotal = Convert.ToDecimal(reader["GrandTotal"].ToString());
                    _Purchases.Status = reader["Status"].ToString();
                    _Purchases.Date = reader["Date"].ToString();

                    _PurchasesList.Add(_Purchases);
                }
            }
            reader.Close();

            return _PurchasesList;
        }
        public List<PurchaseDetails> GetAllPurchaseDetails(string id)
        {
            var _PurchaseDetaillist = new List<PurchaseDetails>();
            string query = ("Select *From PurchaseDetails Where PurchaseId='" + id + "'");
            var reader = _pharmaDb.Reader(query, _pharmaDb.ConnectionStrings());
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var _PurchaseDetails = new PurchaseDetails();
                    _PurchaseDetails.PurchaseId = reader["PurchaseId"].ToString();
                    _PurchaseDetails.Item = reader["Item"].ToString();
                    _PurchaseDetails.Batch = Convert.ToInt32(reader["Batch"].ToString());
                    _PurchaseDetails.Qty = Convert.ToDecimal(reader["Qty"].ToString());
                    _PurchaseDetails.CostPrice = Convert.ToDecimal(reader["CostPrice"].ToString());
                    _PurchaseDetails.TotalPrice = Convert.ToDecimal(reader["TotalPrice"].ToString());
                    _PurchaseDetails.SellingPrice = Convert.ToDecimal(reader["SellingPrice"].ToString());
                    _PurchaseDetails.Expire = reader["Expire"].ToString();

                    _PurchaseDetaillist.Add(_PurchaseDetails);
                }
            }
            reader.Close();

            return _PurchaseDetaillist;
        }
        public Purchases PurchaseData(string id)
        {
            Purchases _PurchaseDetails = null;

            string query = "select *From Purchase Where PurchaseId='" + id + "'";
            var reader = _pharmaDb.Reader(query, _pharmaDb.ConnectionStrings());
            if (reader.HasRows)
            {
                reader.Read();
                _PurchaseDetails = new Purchases();
                _PurchaseDetails.PurchaseId = reader["PurchaseId"].ToString();
                _PurchaseDetails.Date = reader["Date"].ToString();
                _PurchaseDetails.Status = reader["Status"].ToString();
            }
            reader.Close();

            return _PurchaseDetails;
        }

        public List<PurchaseDetails> GetPdfPurchaseDetails(string id)
        {
            var _PurchaseDetaillist = new List<PurchaseDetails>();
            string query = ("Select Item,Batch,Qty,CostPrice,TotalPrice,Expire from PurchaseDetails where PurchaseId='" + id + "'");
            var reader = _pharmaDb.Reader(query, _pharmaDb.ConnectionStrings());
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var _PurchaseDetails = new PurchaseDetails();
                    _PurchaseDetails.Item = reader["Item"].ToString();
                    _PurchaseDetails.Batch = Convert.ToInt32(reader["Batch"].ToString());
                    _PurchaseDetails.Qty = Convert.ToDecimal(reader["Qty"].ToString());
                    _PurchaseDetails.CostPrice = Convert.ToDecimal(reader["CostPrice"].ToString());
                    _PurchaseDetails.TotalPrice = Convert.ToDecimal(reader["TotalPrice"].ToString());
                    _PurchaseDetails.Expire = reader["Expire"].ToString();

                    _PurchaseDetaillist.Add(_PurchaseDetails);
                }
            }
            reader.Close();

            return _PurchaseDetaillist;
        }

    }
}
