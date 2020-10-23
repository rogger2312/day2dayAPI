using Day2Day.Core.Entities;
using Day2Day.Core.Interfaces;
using Day2Day.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day2Day.Infrastructure.Repositories
{
    public class TestRepository : ITestRepository
    {
        private readonly PRY2020112V10Context _context;
        public TestRepository(PRY2020112V10Context context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Test>> GetTests()
        {
            var tests = await _context.Test.ToListAsync();
            return tests;
        }
        public async Task<Test> GetTest(int id)
        {
            var test = await _context.Test.FirstOrDefaultAsync(x => x.PacientId == id);
            return test;
        }
        public async Task InsertTest(Test test)
        {
            _context.Test.Add(test);
            await _context.SaveChangesAsync();
        }
    }
}
