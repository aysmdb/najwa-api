using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Najwa_Api.Models;

namespace Najwa_Api.Repositories
{
    public interface ITransaksiAkunRepository
    {
        IEnumerable<TransaksiAkun> GetAll();

        TransaksiAkun GetSingle(Guid id);
    }
}
