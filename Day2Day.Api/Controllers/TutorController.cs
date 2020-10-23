using Day2Day.Core.Entities;
using Day2Day.Core.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Day2Day.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("AllowMy")]
    public class TutorController : ControllerBase
    {
        private readonly ITutorRepository _tutorRepository;
        public TutorController(ITutorRepository tutorRepository)
        {
            _tutorRepository = tutorRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetTutors()
        {
            var pacients = await _tutorRepository.GetTutors();
            return Ok(pacients);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTutor(int id)
        {
            var pacient = await _tutorRepository.GetTutor(id);
            return Ok(pacient);
        }
        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetTutor(string email)
        {
            var pacient = await _tutorRepository.GetTutor(email);
            return Ok(pacient);
        }
        [HttpPost]
        public async Task<IActionResult> Tutor(Tutor tutor)
        {
            await _tutorRepository.InsertTutor(tutor);
            return Ok(tutor);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, Tutor tutor)
        {
            tutor.TutorId = id;
            await _tutorRepository.UpdateTutor(tutor);
            return Ok(tutor);
        }
    }
}
