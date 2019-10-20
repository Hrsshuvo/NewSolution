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
    public class MedicineRepository
    {
        private readonly string _connectionString = PharmaDb.ConnectionString();
        PharmaDb _pharmaDb = new PharmaDb();

        public bool MediSave(MedicineModels m)
        {
            try
            {
                var query = "INSERT INTO tbl_Madecine (Category,Shalf,Name, BatchNo,BuyingPrice,SellingPrice,Quantity) VALUES('" + m.Category+"','"+m.Shalf+"','" + m.Name + "','" + m.BatchNo + "','"+m.BuyingPrice+"','"+m.SellingPrice+"','"+m.Quantity+"')";
                var rowAffected = _pharmaDb.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool Update(MedicineModels AMM)
        {
            try
            {
                var query = "UPDATE tbl_Add_Member SET Category='" + AMM.Category + "',Shalf='" + AMM.Shalf + "', Name='" + AMM.Name + "',BatchNo='" + AMM.BatchNo + "',BuyingPrice='" + AMM.BuyingPrice + "',SellingPrice='" + AMM.SellingPrice + "',Quantity='" + AMM.Quantity + "' where Name='" + AMM.Name + "' ";

                var rowAffected = _pharmaDb.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public MedicineModels GetByName(string Name)
        {
            try
            {
                var query = "SELECT * FROM tbl_Madecine WHERE Name='" + Name + "'";
                var reader = _pharmaDb.ExecuteReader(query, _connectionString);
                if (reader.HasRows)
                {
                    reader.Read();
                    var MedicineModel = new MedicineModels()
                    { 
                        Category = reader["Category"].ToString(),
                        Shalf = reader[""].ToString(),
                        Name = reader["Name"].ToString(),
                        BatchNo =reader[""].ToString(),
                        BuyingPrice = Convert.ToInt32(reader["BuyingPrice"]),
                        SellingPrice = Convert.ToInt32(reader["SellingPrice"]),
                        Quantity = Convert.ToInt32(reader["Quantity"])
                    };
                    return MedicineModel;
                }
                return null;
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
        public SqlDataReader GetShalf()
        {
            try
            {
                var query = "SELECT  *FROM tbl_Shelf";
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
