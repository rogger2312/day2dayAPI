using Day2Day.Core.Entities;
using Day2Day.Core.Interfaces;
using Day2Day.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day2Day.Infrastructure.Repositories
{
    public class PacientRepository : IPacientRepository
    {
        private readonly PRY2020112V10Context _context;
        public PacientRepository(PRY2020112V10Context context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Pacient>> GetPacients()
        {
            var pacients = await _context.Pacient.ToListAsync();
            return pacients;
        }
        public async Task<Pacient> GetPacient(int id)
        {
            var pacient = await _context.Pacient.FirstOrDefaultAsync(x => x.PacientId == id);
            return pacient;
        }
        public async Task<Pacient> GetPacient(string email)
        {
            var pacient = await _context.Pacient.FirstOrDefaultAsync(x => x.Email == email);
            return pacient;
        }
        public async Task InsertPacient(Pacient pacient)
        {
            _context.Pacient.Add(pacient);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdatePacient(Pacient pacient)
        {
            var currentPacient = await GetPacient(pacient.PacientId);
            currentPacient.FirstName = pacient.FirstName;
            currentPacient.LastName = pacient.LastName;
            currentPacient.DocType = pacient.DocType;
            currentPacient.DocNumber = pacient.DocNumber;
            currentPacient.Birthday = pacient.Birthday;
            currentPacient.StudyLevel = pacient.StudyLevel;
            currentPacient.StudyLevelDescription = pacient.StudyLevelDescription;
            currentPacient.Ocupation = pacient.Ocupation;
            currentPacient.Mobilephone = pacient.Mobilephone;
            currentPacient.Email = pacient.Email;
            currentPacient.Password = pacient.Password;
            currentPacient.Address = pacient.Address;
            currentPacient.District = pacient.District;
            currentPacient.Province = pacient.Province;
            currentPacient.Department = pacient.Department;
            currentPacient.Status = pacient.Status;
            currentPacient.StatusDescription = pacient.StatusDescription;
            currentPacient.SpecialistId = pacient.SpecialistId;
            currentPacient.TutorId = pacient.TutorId;

            int rows = await _context.SaveChangesAsync();

            return rows > 0;
        }

    }
}
