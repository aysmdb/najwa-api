using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Najwa_Api.Models;

namespace Najwa_Api.Services
{
    public interface ITransaksiAkunService
    {
        IEnumerable<TransaksiAkun> GetAll();

        TransaksiAkun GetSingle(Guid id);
    }
}
