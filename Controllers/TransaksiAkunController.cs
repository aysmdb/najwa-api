using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Najwa_Api.Services;
using Najwa_Api.Models;

namespace Najwa_Api.Controllers
{
    [Produces("application/json")]
    [Route("api/TransaksiAkun")]
    public class TransaksiAkunController : Controller
    {
        private readonly ITransaksiAkunService _service;

        public TransaksiAkunController(ITransaksiAkunService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(IEnumerable<TransaksiAkun>), 200)]
        public IActionResult GetAll()
        {
            IEnumerable<TransaksiAkun> transaksiAkun = _service.GetAll();

            return Ok(transaksiAkun);
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(TransaksiAkun), 200)]
        public IActionResult GetSingle(Guid id)
        {
            TransaksiAkun transaksiAkun = _service.GetSingle(id);

            if (transaksiAkun == null)
                return BadRequest();

            return Ok(transaksiAkun);
        }
    }
}