using System;
using System.Collections.Generic;
using Najwa_Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Najwa_Api.Services;

namespace Najwa_Api.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Test>), 200)]
        public Task<IActionResult> GetTest()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("Ahay")]
        public string Ahay()
        {
            Test tes = new Test(){
                Id = 1,
                key = "ahay",
                name = "ahay"
            };
            return "ahay";
        }
    }
}