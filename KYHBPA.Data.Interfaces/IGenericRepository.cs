using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHBPA.Data.Interfaces
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAllAsync();
        T GetByIdAsync(int id);
        void AddAsync(T entity);
        void DeleteAsync(T entity);
        void EditAsync(T entity);
        void SaveAsync(T entity);
    }
}
