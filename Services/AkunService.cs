using System;
using System.Collections.Generic;
using System.Linq;
using Najwa_Api.Repositories;
using Najwa_Api.Models;

namespace Najwa_Api.Services
{
    public class AkunService : IAkunService
    {
        private readonly IAkunRepository _repo;

        public AkunService(IAkunRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Akun> GetAll()
        {
           return _repo.GetAll();
        }

        public Akun GetSingle(Guid id)
        {
            return _repo.GetSingle(id);
        }

        public Akun Add(Akun model)
        {
            if(model == null)
                throw new ArgumentNullException(nameof(model));

            _repo.Add(model);

            return model;
        }

        public Akun Update(Akun model)
        {
            if(model == null)
                throw new ArgumentNullException(nameof(model));

            _repo.Update(model);

            return model;
        }

        public Akun Delete(Akun model)
        {
            if(model == null)
                throw new ArgumentNullException(nameof(model));

            _repo.Delete(model);

            return model;
        }
    }
}