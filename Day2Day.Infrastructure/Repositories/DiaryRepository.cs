using Day2Day.Core.Entities;
using Day2Day.Core.Interfaces;
using Day2Day.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day2Day.Infrastructure.Repositories
{
    public class DiaryRepository : IDiaryRepository
    {
        private readonly PRY2020112V10Context _context;
        public DiaryRepository(PRY2020112V10Context context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Diary>> GetDiaries()
        {
            var diaries = await _context.Diary.ToListAsync();
            return diaries;
        }
        public async Task<Diary> GetDiaryByPacientId(int id)
        {
            var diary = await _context.Diary.FirstOrDefaultAsync(x => x.PacientId == id);
            return diary;
        }
        public async Task InserDiary(Diary diary)
        {
            _context.Diary.Add(diary);
            await _context.SaveChangesAsync();
        }
    }
}
