using KYHBPA.Data.Interfaces;
using KYHBPA.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KYHBPA.Data
{
    public abstract class BaseGenericRepository<T> : IGenericRepository<T>
    {
        public virtual void AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual void DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual void EditAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual T GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void SaveAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
