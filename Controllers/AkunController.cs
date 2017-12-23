using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Najwa_Api.Services;
using Najwa_Api.Models;

namespace Najwa_Api.Controllers
{
    [Route("api/[controller]")]
    public class AkunController : Controller
    {
        private readonly IAkunService _service;

        public AkunController(IAkunService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("/GetALl")]
        [ProducesResponseType(typeof(IEnumerable<Akun>), 200)]
        public IActionResult GetAll()
        {
            IEnumerable<Akun> akun = _service.GetAll();

            return Ok(akun);
        }

        [HttpGet]
        [ProducesResponseType(typeof(Akun), 200)]
        public IActionResult GetSingle(Guid id)
        {
            Akun akun = _service.GetSingle(id);

            if(akun == null)
                throw new ArgumentNullException();

            return Ok(akun);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Akun), 200)]
        public IActionResult Add(Akun model)
        {
            model.Id = new Guid();
            model.CreatedAt = new DateTime();
            if(!ModelState.IsValid)
                return BadRequest();

            _service.Add(model);

            return Ok(model);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Akun), 200)]
        public IActionResult Update(Akun model)
        {
            if(!ModelState.IsValid)
                return BadRequest();

            _service.Update(model);

            return Ok(model);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Akun), 200)]
        public IActionResult Delete(Akun model)
        {
            if(!ModelState.IsValid)
                return BadRequest();

            _service.Delete(model);

            return Ok(model);
        }
    }
}