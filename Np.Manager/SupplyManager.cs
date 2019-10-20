using NewP.Core.Model;
using NewP.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Np.Manager
{
    public class SupplyManager
    {
        SupplyRepository _supplyRepository = new SupplyRepository();

        public bool Save(SupplyModelss shalf)
        {
            var save = _supplyRepository.Save(shalf);
            return save;
        }
        public bool IsUserNameExist(string Name)
        {
            var isExist = false;
            var user = _supplyRepository.GetByName(Name);
            if (user != null)
                isExist = true;
            return isExist;
        }
    }
}
