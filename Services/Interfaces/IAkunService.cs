using System;
using System.Collections.Generic;
using System.Linq;
using Najwa_Api.Repositories;
using Najwa_Api.Models;

namespace Najwa_Api.Services {
    public interface IAkunService
    {
        IEnumerable<Akun> GetAll();

        Akun GetSingle(Guid id);

        Akun Add(Akun model);

        Akun Update(Akun model);

        Akun Delete(Akun model);
    }
}