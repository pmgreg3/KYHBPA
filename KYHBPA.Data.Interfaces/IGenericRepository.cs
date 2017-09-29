using KYHBPA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHBPA.Data.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseDbObject
    {
        IEnumerable<TEntity> GetAllAsync();
        TEntity GetByIdAsync(int id);
        void AddAsync(TEntity entity);
        void DeleteAsync(TEntity entity);
        void EditAsync(TEntity entity);
        void Save();
    }
}
