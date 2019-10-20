using NewP.Core.Model;
using NewP.Persistance.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewP.Persistance.Repository
{
    public class SupplyRepository
    {
        private readonly string _connectionString = PharmaDb.ConnectionString();
        PharmaDb _pharmaDb = new PharmaDb();

        public bool Save(SupplyModelss s)
        {
            try
            {
                var query = "INSERT INTO tbl_Supply (Name,Email,Phone,Address, Notes) VALUES('" + s.Name + "','" + s.Email + "','"+s.Phone+"','"+s.Address+"','"+s.Notes+"')";
                var rowAffected = _pharmaDb.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SupplyModelss GetByName(string Name)
        {
            try
            {
                var query = "SELECT * FROM tbl_Supply WHERE Name='" + Name + "'";
                var reader = _pharmaDb.ExecuteReader(query, _connectionString);
                if (reader.HasRows)
                {
                    reader.Read();
                    var SupplyModel = new SupplyModelss()
                    {
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString(),
                        Notes = reader["Notes"].ToString()
                    };
                    return SupplyModel;
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
