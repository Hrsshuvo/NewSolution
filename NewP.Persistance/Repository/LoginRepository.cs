using NewP.Persistance.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewP.Persistance.Repository
{
    public class LoginRepository
    {
        private string _email;

        private string _password;

        private readonly string _connectionString = PharmaDb.ConnectionString();

        readonly PharmaDb _pharmaDb = new PharmaDb();

        public bool Login(string email, string password)

        {

            try

            {

                var query = "SELECT * FROM tbl_Login WHERE Email='" + email + "' AND Password='" + password + "'";

                var reader = _pharmaDb.ExecuteReader(query, _connectionString);

                if (reader.HasRows)

                {

                    reader.Read();

                    this._email = reader["Email"].ToString();

                    this._password = reader["Password"].ToString();

                }



                if (this._email == email && this._password == password)

                    return true;



                throw new ApplicationException("Your User Name and Password is not correct.");

            }

            catch (Exception e)

            {

                throw new Exception(e.Message);

            }

        }
    }
}
