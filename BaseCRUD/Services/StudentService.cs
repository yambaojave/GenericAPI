using BaseCRUD.IServices;
using BaseCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCRUD.Services
{
    public class StudentService : BaseService<Student>, IStudentService
    {
        public StudentService() : base() { }

        public IEnumerable<Student> GetByRoll(string roll)
        {
            return _table.Where(e => e.Roll == roll);
        }
    }
}
