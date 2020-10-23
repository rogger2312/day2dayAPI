using Day2Day.Core.Entities;
using Day2Day.Core.Interfaces;
using Day2Day.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day2Day.Infrastructure.Repositories
{
    public class TutorRepository : ITutorRepository
    {
        private readonly PRY2020112V10Context _context;
        public TutorRepository(PRY2020112V10Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tutor>> GetTutors()
        {
            var tutors = await _context.Tutor.ToListAsync();
            return tutors;
        }
        public async Task<Tutor> GetTutor(int id)
        {
            var tutor = await _context.Tutor.FirstOrDefaultAsync(x => x.TutorId == id);
            return tutor;
        }
        public async Task<Tutor> GetTutor(string email)
        {
            var tutor = await _context.Tutor.FirstOrDefaultAsync(x => x.Email == email);
            return tutor;
        }
        public async Task InsertTutor(Tutor tutor)
        {
            _context.Tutor.Add(tutor);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdateTutor(Tutor tutor)
        {
            var currentTutor = await GetTutor(tutor.TutorId);
            currentTutor.FirstName = tutor.FirstName;
            currentTutor.LastName = tutor.LastName;
            currentTutor.DocType = tutor.DocType;
            currentTutor.DocNumber = tutor.DocNumber;
            currentTutor.Birthday = tutor.Birthday;
            currentTutor.Mobilephone = tutor.Mobilephone;
            currentTutor.Email = tutor.Email;
            currentTutor.Password = tutor.Password;
            currentTutor.Relation = tutor.Relation;
            currentTutor.Status = tutor.Status;
            currentTutor.StatusDescription = tutor.StatusDescription;

            var row = await _context.SaveChangesAsync();

            return row > 0;
        }
    }
}
