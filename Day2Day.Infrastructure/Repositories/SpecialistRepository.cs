using Day2Day.Core.Entities;
using Day2Day.Core.Interfaces;
using Day2Day.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day2Day.Infrastructure.Repositories
{
    public class SpecialistRepository : ISpecialistRepository
    {
        private readonly PRY2020112V10Context _context;
        public SpecialistRepository(PRY2020112V10Context context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Specialist>> GetSpecialists()
        {
            var specialists = await _context.Specialist.ToListAsync();
            return specialists;
        }
        public async Task<Specialist> GetSpecialist(int id)
        {
            var specialist = await _context.Specialist.FirstOrDefaultAsync(x => x.SpecialistId == id);
            return specialist;
        }
        public async Task<Specialist> GetSpecialist(string email)
        {
            var specialist = await _context.Specialist.FirstOrDefaultAsync(x => x.Email == email);
            return specialist;
        }
        public async Task InsertSpecialist(Specialist specialist)
        {
            _context.Specialist.Add(specialist);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdateSpecialist(Specialist specialist)
        {
            var currentSpecialist = await GetSpecialist(specialist.SpecialistId);
            currentSpecialist.FirstName = specialist.FirstName;
            currentSpecialist.LastName = specialist.LastName;
            currentSpecialist.DocType = specialist.DocType;
            currentSpecialist.DocNumber = specialist.DocNumber;
            currentSpecialist.Birthday = specialist.Birthday;
            currentSpecialist.CollegeNumber = specialist.CollegeNumber;
            currentSpecialist.Speciality = specialist.Speciality;
            currentSpecialist.Email = specialist.Password;
            currentSpecialist.Password = specialist.Password;
            currentSpecialist.Company = specialist.Company;
            currentSpecialist.Job = specialist.Job;
            currentSpecialist.Status = specialist.Status;
            currentSpecialist.StatusDescription = specialist.StatusDescription;

            int rows = await _context.SaveChangesAsync();
            
            return rows > 0;
        }
    }
}
