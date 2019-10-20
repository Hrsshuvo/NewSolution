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
    public class MedicineManager
    {
        readonly MedicineRepository _medicineRepository = new MedicineRepository();
        public bool CatSave(MedicineModels m)
        {
            var save = _medicineRepository.MediSave(m);
            return save;
        }
        public bool Update(MedicineModels AMM)
        {
            var update2 = _medicineRepository.Update(AMM);
            return update2;
        }

        public bool IsUserNameExist(string Name)
        {
            var isExist = false;
            var user = _medicineRepository.GetByName(Name);
            if (user != null)
                isExist = true;
            return isExist;
        }
        public SqlDataReader GetCategory()
        {
            var reader = _medicineRepository.GetCategory();
            return reader;
        }
        public SqlDataReader GetShalf()
        {
            var reader = _medicineRepository.GetShalf();
            return reader;
        }
    }
}
