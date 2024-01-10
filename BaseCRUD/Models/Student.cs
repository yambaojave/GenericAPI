using BaseCRUD.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCRUD.Models
{
    public class Student : IBaseModel
    {
        public int StudentId { get; set; }
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Roll { get; set; }
        public string Message { get; set; }

        int IBaseModel.Id
        {
            get { return StudentId; }
            set { StudentId = value; }
        }
    }
}
