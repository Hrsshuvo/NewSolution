using NewP.Core.Model;
using NewP.Persistance.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewP.Persistance.Repository
{
    public class CategoryRepository
    {
        private readonly string _connectionString = PharmaDb.ConnectionString();
        PharmaDb _pharmaDb = new PharmaDb();
        public bool CatSave(CategoryModel cat)
        {
            try
            {
                var query = "INSERT INTO tbl_Category (Name, Description) VALUES('" + cat.Name + "','" + cat.Description + "')";
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
                var query = "SELECT * FROM tbl_Category WHERE Name='" + Name + "'";
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
