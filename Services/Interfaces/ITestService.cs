using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Najwa_Api.Models;

namespace Najwa_Api.Services
{
    public interface ITestService
    {
        IEnumerable<Test> ReadAllAsync();
        Test ReadOneAsync();

        string ahay();
    }
}