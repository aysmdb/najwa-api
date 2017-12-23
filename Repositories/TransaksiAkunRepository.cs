using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Najwa_Api.DAL;
using Najwa_Api.Models;

namespace Najwa_Api.Repositories
{
    public class TransaksiAkunRepository : ITransaksiAkunRepository
    {
        private readonly ApplicationDbContext _context;

        public TransaksiAkunRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TransaksiAkun> GetAll()
        {
            return _context.TransaksiAkun.AsEnumerable();
        }

        public TransaksiAkun GetSingle(Guid id)
        {
            return _context.TransaksiAkun.Find(id);
        }
    }
}
