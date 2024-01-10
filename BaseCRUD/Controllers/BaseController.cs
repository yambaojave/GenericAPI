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
    public class BaseController<T> : Controller
    {
        private readonly IBaseService<T> _service;
        public BaseController(IBaseService<T> service)
        {
            _service = service;
        }



        // GET: api/Base
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        // GET: api/Base/5
        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var model = _service.GetOne(id);
            if (model == null)
                return NotFound();

            return Ok(model);
        }

        // POST: api/Base
        [HttpPost]
        public IActionResult Create([FromBody] T model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _service.Add(model);
            return Ok();
        }

        // PUT: api/Base/5
        [HttpPut]
        public IActionResult Update([FromBody] T model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _service.Update(model);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
