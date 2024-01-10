using BaseCRUD.Context;
using BaseCRUD.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCRUD.Services
{
    public class BaseService<T> : IBaseService<T> where T : class, IBaseModel
    {
        protected readonly FakeDbContext _db = new FakeDbContext();
        protected readonly List<T> _table;

        public BaseService()
        {
            _table = _db.GetTable<T>();
        }


        public void Add(T model)
        {
            model.Id = _table.Count + 1;
            _table.Add(model);
        }

        public void Delete(int id)
        {
            _table.RemoveAll(e => e.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _table;
        }

        public T GetOne(int id)
        {
            return _table.FirstOrDefault(e => e.Id == id);
        }

        public void Update(T model)
        {
            var index = _table.FindIndex(u => u.Id == model.Id);
            _table[index] = model;
        }
    }
}
