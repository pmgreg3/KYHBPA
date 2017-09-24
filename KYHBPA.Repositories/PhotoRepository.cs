using KYHBPA.Data.Interfaces;
using KYHBPA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHBPA.Repositories
{
    public class PhotoRepository : IGenericRepository<Image>
    {
        public void AddAsync(Image entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(Image entity)
        {
            throw new NotImplementedException();
        }

        public void EditAsync(Image entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Image> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Image GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveAsync(Image entity)
        {
            throw new NotImplementedException();
        }
    }
}
