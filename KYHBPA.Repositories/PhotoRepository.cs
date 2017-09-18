using KYHBPA.Data.Interfaces;
using KYHBPA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHBPA.Repositories
{
    public class PhotoRepository : IGenericRepository<Photo>
    {
        public void AddAsync(Photo entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(Photo entity)
        {
            throw new NotImplementedException();
        }

        public void EditAsync(Photo entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Photo> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Photo GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveAsync(Photo entity)
        {
            throw new NotImplementedException();
        }
    }
}
