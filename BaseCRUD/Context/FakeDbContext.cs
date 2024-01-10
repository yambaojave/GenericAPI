using BaseCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCRUD.Context
{
    public class FakeDbContext
    {
        public FakeDbContext()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();

            for (int i = 1; i <= 9; i++)
            {
                Students.Add(new Student()
                {
                    StudentId = i,
                    Name = $"Student{i}",
                    Roll = "100" + i,
                    Message = ""
                });

                Teachers.Add(new Teacher()
                {
                    TeacherId = i,
                    Name = $"Teacher{i}",
                    Subject = $"Sub{i}",
                    Message = ""
                });
            }
        }

        public List<Student> Students { get; }
        public List<Teacher> Teachers { get; }

        public List<T> GetTable<T>()
        {
            return GetType().GetProperties().FirstOrDefault(p => p.GetValue(this, null) is List<T>)
                ?.GetValue(this, null) as List<T>;
        }
    }
}
