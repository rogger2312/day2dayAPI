using Day2Day.Core.Entities;
using Day2Day.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Day2Day.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaryController : ControllerBase
    {
        private readonly IDiaryRepository _diaryRepository;
        public DiaryController(IDiaryRepository diaryRepository)
        {
            _diaryRepository = diaryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetDiaries()
        {
            var diaries = await _diaryRepository.GetDiaries();
            return Ok(diaries);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiary(int id)
        {
            var diary = await _diaryRepository.GetDiaryByPacientId(id);
            return Ok(diary);
        }
        [HttpPost] 
        public async Task<IActionResult> Diary (Diary diary)
        {
            await _diaryRepository.InserDiary(diary);
            return Ok(diary);
        }
    }
}
