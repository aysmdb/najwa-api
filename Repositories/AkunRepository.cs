using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Najwa_Api.DAL;
using Najwa_Api.Models;

namespace Najwa_Api.Repositories {
    public class AkunRepository : IAkunRepository
    {
        private readonly ApplicationDbContext _context;

        public AkunRepository(ApplicationDbContext context){
            _context = context;
        }

        public IEnumerable<Akun> GetAll(){
            return _context.Akun.AsEnumerable();
        }

        public Akun GetSingle(Guid id){
            return _context.Akun.Find(id);
        }

        public void Add(Akun akun){
            if(akun == null)
                throw new ArgumentNullException();

            _context.Akun.Add(akun);

            _context.SaveChanges();
        }

        public void Update(Akun akun){
            if(akun == null)
                throw new ArgumentNullException();

            _context.Akun.Update(akun);

            _context.SaveChanges();
        }

        public void Delete(Akun akun){
            if(akun == null)
                throw new ArgumentNullException();

            _context.Akun.Remove(akun);

            _context.SaveChanges();
        }
    }
}