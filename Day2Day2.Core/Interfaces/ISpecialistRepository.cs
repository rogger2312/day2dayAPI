using Day2Day.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Day2Day.Core.Interfaces
{
    public interface ISpecialistRepository
    {
        Task<IEnumerable<Specialist>> GetSpecialists();
        Task<Specialist> GetSpecialist(int id);
        Task<Specialist> GetSpecialist(string email);
        Task InsertSpecialist(Specialist specialist);
        Task<bool> UpdateSpecialist(Specialist specialist);

    }
}
