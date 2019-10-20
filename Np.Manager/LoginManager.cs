using NewP.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Np.Manager
{
    public class LoginManager
    {
        readonly LoginRepository _loginRepository = new LoginRepository();
        public bool Login(string email, string password)
        {
            var login = _loginRepository.Login(email, password);
            return login;
        }
    }
}
