using BaseCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCRUD.IServices
{
    public interface IStudentService : IBaseService<Student>
    {
        IEnumerable<Student> GetByRoll(string roll);
    }
}
