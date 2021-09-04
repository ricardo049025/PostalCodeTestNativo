using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Domain.Interfaces;
using Domain.Domain.Interfaces.Services;
using Domain.Entities.Models;
using Infraestructure.Data.Repositories;
namespace Business.Main.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity: class
    {
        protected IBaseRepository<TEntity> baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public IEnumerable<TEntity> getAll()
        {
            return this.baseRepository.getAll();
        }

        public TEntity getById(int id)
        {
            return this.baseRepository.getById(id);
        }

        public void add(TEntity entity)
        {
            this.baseRepository.add(entity);
        }

        public void update(TEntity entity)
        {
            this.baseRepository.update(entity);
        }

        public void delete(int id)
        {
            this.baseRepository.delete(id);
        }

    }
}
