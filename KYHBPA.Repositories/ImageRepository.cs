using KYHBPA.Data.Interfaces;
using KYHBPA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHBPA.Data.Repositories
{
    public class ImageRepository : IGenericRepository<Image>
    {
        private IKYHBPADbContext _dbcontext;       

        public ImageRepository(IKYHBPADbContext dbContext)
        {
            _dbcontext = dbContext;
        }

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
