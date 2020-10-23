using Day2Day.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day2Day.Core.Interfaces
{
    public interface IPacientRepository
    {
        Task<IEnumerable<Pacient>> GetPacients();
        Task<Pacient> GetPacient(int id);
        Task<Pacient> GetPacient(string email);
        Task InsertPacient(Pacient pacient);
        Task<bool> UpdatePacient(Pacient pacient);
    }
}
