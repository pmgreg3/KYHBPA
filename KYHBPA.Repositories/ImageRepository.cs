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
        private IKYHBPADbContext _dbcontext;       

        public ImageRepository(IKYHBPADbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public void AddAsync(Image entity)
        {
            _dbcontext.Image.Add(entity);
        }

        public void DeleteAsync(Image entity)
        {
            _dbcontext.Image.Remove(entity);
        }

        public void EditAsync(Image entity)
        {
            _dbcontext.Image.Attach(entity);
            _dbcontext.SetModified(entity);
        }

        public IEnumerable<Image> GetAllAsync()
        {
            return _dbcontext.Image.ToList();
        }

        public Image GetByIdAsync(int id)
        {
            return _dbcontext.Image.Find(id);
        }

        public void Save()
        {
            _dbcontext.Commit();
        }
    }
}
