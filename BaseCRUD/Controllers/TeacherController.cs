using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseCRUD.IServices;
using BaseCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : BaseController<Teacher>
    {
        public TeacherController(IBaseService<Teacher> service) : base(service) { }
    }
}