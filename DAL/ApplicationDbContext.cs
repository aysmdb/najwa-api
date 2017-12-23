using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Najwa_Api.Models;

namespace Najwa_Api.DAL
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Test> Test { get; set; }

        public DbSet<Akun> Akun { get; set; }

        public DbSet<TransaksiAkun> TransaksiAkun { get; set; }
    }
}