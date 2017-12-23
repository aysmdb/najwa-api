using System;
using System.Collections.Generic;
using System.Linq;
using Najwa_Api.Models;

namespace Najwa_Api.Repositories {
    public interface IAkunRepository {
        IEnumerable<Akun> GetAll();
        Akun GetSingle(Guid id);
        void Add(Akun akun);
        void Update(Akun akun);
        void Delete(Akun akun);
    }
}