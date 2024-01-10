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
    public class StudentController : BaseController<Student>
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service) : base(service)
        {
            _service = service;
        }


        [HttpGet("ByRoll/{roll}")]
        public IActionResult GetByRoll(string roll)
        {
            return Ok(_service.GetByRoll(roll));
        }
    }
}