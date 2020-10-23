using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day2Day.Core.Entities;
using Day2Day.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day2Day.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestRepository _testRepository;
        public TestController(ITestRepository pacientRepository)
        {
            _testRepository = pacientRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetTests()
        {
            var tests = await _testRepository.GetTests();
            return Ok(tests);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestsByPacientId(int id)
        {
            var test = await _testRepository.GetTest(id);
            return Ok(test);
        }
        [HttpPost]
        public async Task<IActionResult> Test (Test test)
        {
            await _testRepository.InsertTest(test);
            return Ok(test);
        }
    }
}
