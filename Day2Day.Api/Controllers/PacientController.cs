using Day2Day.Core.Entities;
using Day2Day.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Day2Day.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("AllowMy")]
    public class PacientController : ControllerBase
    {
        private readonly IPacientRepository _pacientRepository;
        public PacientController(IPacientRepository pacientRepository)
        {
            _pacientRepository = pacientRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetPacients()
        {
            var pacients = await _pacientRepository.GetPacients();
            return Ok(pacients);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPacient(int id)
        {
            var pacient = await _pacientRepository.GetPacient(id);
            return Ok(pacient);
        }

        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetPacient(string email)
        {
            var pacient = await _pacientRepository.GetPacient(email);
            return Ok(pacient);
        }
        [HttpPost]
        public async Task<IActionResult> Pacient(Pacient pacient)
        {
            await _pacientRepository.InsertPacient(pacient);
            return Ok(pacient);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, Pacient pacient)
        {
            pacient.PacientId = id;
            await _pacientRepository.UpdatePacient(pacient);
            return Ok(pacient);
        }
    }
}
