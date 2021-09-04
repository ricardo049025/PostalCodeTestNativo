using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain.Interfaces;
using Domain.Entities;
namespace Infraestructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected NativoContext context;

        public BaseRepository(NativoContext context)
        {
            this.context = context;
        }

        public IEnumerable<TEntity> getAll()
        {
            return context.Set<TEntity>();
        }

        public TEntity getById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void add(TEntity entity) 
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void update(TEntity entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void delete(int id)
        {
            var entity = context.Set<TEntity>().Find(id);
            context.Remove(entity);
            context.SaveChanges();
        }
    }
}
