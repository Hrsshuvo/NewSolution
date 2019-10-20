using NewP.Core.Model;
using NewP.Persistance.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewP.Persistance.Repository
{
    public class ShalfRepository
    {
        private readonly string _connectionString = PharmaDb.ConnectionString();
        PharmaDb _pharmaDb = new PharmaDb();
        public bool Save(ShalfModel shalf)
        {
            try
            {
                var query = "INSERT INTO tbl_Shelf (Name, NumericNumber) VALUES('" + shalf.Name + "','" + shalf.NumericNumber + "')";
                var rowAffected = _pharmaDb.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public ShalfModel GetByName(string Name)
        {
            try
            {
                var query = "SELECT * FROM tbl_Shelf WHERE Name='" + Name + "'";
                var reader = _pharmaDb.ExecuteReader(query, _connectionString);
                if (reader.HasRows)
                {
                    reader.Read();
                    var ShalfModel = new ShalfModel()
                    {
                        Name = reader["Name"].ToString(),
                        NumericNumber = reader["NumericNumber"].ToString(),
                    };
                    return ShalfModel;
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public ShalfModel GetByNumber(string Number)
        {
            try
            {
                var query = "SELECT * FROM tbl_Shelf WHERE NumericNumber='" + Number + "'";
                var reader = _pharmaDb.ExecuteReader(query, _connectionString);
                if (reader.HasRows)
                {
                    reader.Read();
                    var ShalfModel = new ShalfModel()
                    {
                        Name = reader["Name"].ToString(),
                        NumericNumber = reader["NumericNumber"].ToString(),
                    };
                    return ShalfModel;
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
