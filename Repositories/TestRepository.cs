using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Najwa_Api.Models;

namespace Najwa_Api.Repositories
{
    public class TestRepository : ITestRepository
    {
        private readonly List<Test> _test;

        public TestRepository(IEnumerable<Test> tests)
        {
            if(tests == null)
                _test = new List<Test>();
        }

        public IEnumerable<Test> ReadAllAsync()
        {
            return _test;
        }

        public Test ReadOneAsync()
        {
            Test test = new Test();

            return test;
        }

        public string ahay()
        {
            return "Ahayyy";
        }
    }
}