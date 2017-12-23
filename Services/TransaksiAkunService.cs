using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Najwa_Api.Repositories;
using Najwa_Api.Models;

namespace Najwa_Api.Services
{
    public class TransaksiAkunService : ITransaksiAkunService
    {
        private readonly ITransaksiAkunRepository _repo;

        public TransaksiAkunService(ITransaksiAkunRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<TransaksiAkun> GetAll()
        {
            return _repo.GetAll();
        }

        public TransaksiAkun GetSingle(Guid id)
        {
            return _repo.GetSingle(id);
        }
    }
}
