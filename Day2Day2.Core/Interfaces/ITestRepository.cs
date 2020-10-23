using Day2Day.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day2Day.Core.Interfaces
{
    public interface ITestRepository
    {
        Task<IEnumerable<Test>> GetTests();
        Task<Test> GetTest(int id);
        Task InsertTest(Test test);
    }
}
