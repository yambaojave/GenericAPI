using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCRUD.IServices
{
    public interface IBaseService<T>
    {
        IEnumerable<T> GetAll();
        T GetOne(int id);
        void Add(T model);
        void Update(T model);
        void Delete(int id);
    }
}
