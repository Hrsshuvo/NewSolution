using NewP.Core.Model;
using NewP.Persistance.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewP.Persistance.Repository
{
    public class SealsRepository
    {
        private readonly string _connectionString = PharmaDb.ConnectionString();
        PharmaDb _pharmaDb = new PharmaDb();

        public bool AddPerSave(SealsModels p)
        {
            try
            {
                var query = "INSERT INTO tbl_Seals (CustomerName,Code,Date,Total,Discount,PaymentMathod,GrandTotal,Statas) VALUES('" + p.CustomerName + "','" + p.Code + "','"+p.Date+"','" + p.Total + "','" + p.Discount + "','" + p.PaymentMathod + "','" + p.GrandTotal + "','" + p.Statas + "')";
                var rowAffected = _pharmaDb.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool UpdateQty(PurchaseesModelsd AMM)
        {
            try
            {
                var query = "UPDATE tbl_Madecine SET Quantity='" + AMM.Quntity + "' where Name='" + AMM.Medicine + "' ";

                var rowAffected = _pharmaDb.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SqlDataReader GetSupplyer()
        {
            try
            {
                var query = "SELECT  *FROM tbl_Supply";
                var reader = _pharmaDb.ExecuteReader(query, _connectionString);
                return reader;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public SqlDataReader GetCategory()
        {
            try
            {
                var query = "SELECT  *FROM tbl_Category";
                var reader = _pharmaDb.ExecuteReader(query, _connectionString);
                return reader;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        public SqlDataReader GetMedicine()
        {
            try
            {
                var query = "SELECT  *FROM tbl_Madecine";
                var reader = _pharmaDb.ExecuteReader(query, _connectionString);
                return reader;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        public SqlDataReader GetPricee(string Name)
        {
            try
            {
                var query = "select *from tbl_Madecine where Name ='" + Name + "'";
                var reader = _pharmaDb.ExecuteReader(query, _connectionString);
                return reader;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public SqlDataReader GetCatToMedicine(int Category)
        {
            try
            {
                var query = "select *from tbl_Madecine where Category ='" + Category + "'";
                var reader = _pharmaDb.ExecuteReader(query, _connectionString);
                return reader;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        public SqlDataReader PurchaseOrder(string code)
        {
            try
            {
                var query = "select  from tbl_Purchase where Code='" + code + "' ";
                var reader = _pharmaDb.ExecuteReader(query, _connectionString);
                return reader;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
