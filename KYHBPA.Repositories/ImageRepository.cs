using KYHBPA.Data.Interfaces;
using KYHBPA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHBPA.Data.Repositories
{
    public class ImageRepository : IGenericRepository<Image>
    {
        private IKYHBPADbContext _dbContext;       

        public ImageRepository(IKYHBPADbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddAsync(Image entity)
        {
            _dbContext.Image.Add(entity);
            Save();
        }

        public void DeleteAsync(Image entity)
        {
            _dbContext.Image.Remove(entity);
        }

        public void EditAsync(Image entity)
        {
            _dbContext.Image.Attach(entity);
            _dbContext.SetModified(entity);
        }

        public IEnumerable<Image> GetAllAsync()
        {
            return _dbContext.Image.ToList();
        }

        public Image GetByIdAsync(int id)
        {
            return _dbContext.Image.Find(id);
        }

        public void Save()
        {
            _dbContext.Commit();
        }
    }
}
