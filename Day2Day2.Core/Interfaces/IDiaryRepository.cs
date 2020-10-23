using Day2Day.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day2Day.Core.Interfaces
{
    public interface IDiaryRepository
    {
        Task<IEnumerable<Diary>> GetDiaries();
        Task<Diary> GetDiaryByPacientId(int id);
        Task InserDiary(Diary diary);
    }
}
