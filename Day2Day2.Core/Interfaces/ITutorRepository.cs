using Day2Day.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day2Day.Core.Interfaces
{
    public interface ITutorRepository
    {
        Task<IEnumerable<Tutor>> GetTutors();
        Task<Tutor> GetTutor(int id);
        Task<Tutor> GetTutor(string email);
        Task InsertTutor(Tutor tutor);
        Task<bool> UpdateTutor(Tutor tutor);
    }
}
