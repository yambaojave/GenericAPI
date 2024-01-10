using BaseCRUD.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCRUD.Models
{
    public class Teacher : IBaseModel
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        int IBaseModel.Id
        {
            get { return TeacherId; }
            set { TeacherId = value; }
        }
    }
}
