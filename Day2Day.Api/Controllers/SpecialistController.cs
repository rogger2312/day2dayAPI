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
    public class SpecialistController : ControllerBase
    {
        private readonly ISpecialistRepository _specialistRepository;
        public SpecialistController(ISpecialistRepository specialistRepository)
        {
            _specialistRepository = specialistRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetSpecialist()
        {
            var specialists = await _specialistRepository.GetSpecialists();
            return Ok(specialists);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpecialistById(int id)
        {
            var specialist = await _specialistRepository.GetSpecialist(id);
            return Ok(specialist);
        }

        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetSpecialist(string email)
        {
            var specialist = await _specialistRepository.GetSpecialist(email);
            return Ok(specialist);
        }
        [HttpPost]
        public async Task<IActionResult> Specialist(Specialist specialist)
        {
            await _specialistRepository.InsertSpecialist(specialist);
            return Ok(specialist);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, Specialist specialist)
        {
            specialist.SpecialistId = id;
            await _specialistRepository.UpdateSpecialist(specialist);
            return Ok(specialist);
        }
    }
}
