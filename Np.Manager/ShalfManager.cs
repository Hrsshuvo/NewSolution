using NewP.Core.Model;
using NewP.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Np.Manager
{
    public class ShalfManager
    {
        readonly ShalfRepository _shalfRepository = new ShalfRepository();
        readonly CategoryRepository _categoryRepository = new CategoryRepository();

        public bool Save(ShalfModel shalf)
        {
            var save = _shalfRepository.Save(shalf);
            return save;
        }
        public bool CatSave(CategoryModel cat)
        {
            var save = _categoryRepository.CatSave(cat);
            return save;
        }

        public bool IsUserNameExist(string Name)
        {
            var isExist = false;
            var user = _shalfRepository.GetByName(Name);
            if (user != null)
                isExist = true;
            return isExist;
        }
        public bool IsUserNameExists(string Name)
        {
            var isExist = false;
            var user = _categoryRepository.GetByName(Name);
            if (user != null)
                isExist = true;
            return isExist;
        }
        public bool IsNumberExist(string Number)
        {
            var isExist = false;
            var user = _shalfRepository.GetByNumber(Number);
            if (user != null)
                isExist = true;
            return isExist;
        }
    }
}
