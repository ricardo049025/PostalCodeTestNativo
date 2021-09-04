using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> getAll();
        TEntity getById(int id);
        void add(TEntity entity);
        void update(TEntity entity);
        void delete(int id);
    }
}
