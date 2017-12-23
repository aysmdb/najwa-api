using System;
using System.Collections.Generic;
using Najwa_Api.Models;
using Najwa_Api.Repositories;
using System.Threading.Tasks;

namespace Najwa_Api.Services
{
    public class TestService : ITestService
    {
        private ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public IEnumerable<Test> ReadAllAsync()
        {
            return _testRepository.ReadAllAsync();
        }

        public Test ReadOneAsync()
        {
            return _testRepository.ReadOneAsync();
        }

        public string ahay()
        {
            return _testRepository.ahay();
        }
    }
}