using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Najwa_Api.Models
{
    public class TransaksiAkun
    {
        public Guid Id { get; set; }

        public Guid AkunId { get; set; }

        public Akun Akun { get; set; }

        public Guid UserId { get; set; }

        public IdentityUser User { get; set; }

        public int Amount { get; set; }
    }
}
