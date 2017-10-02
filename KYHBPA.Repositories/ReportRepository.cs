using KYHBPA.Data.Interfaces;
using KYHBPA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHBPA.Data.Repositories
{
    public class ReportRepository : IGenericRepository<Report>
    {
        private IKYHBPADbContext _dbContext;

        public ReportRepository(IKYHBPADbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddAsync(Report entity)
        {
            _dbContext.Report.Add(entity);
        }

        public void DeleteAsync(Report entity)
        {
            _dbContext.Report.Remove(entity);
        }

        public void EditAsync(Report entity)
        {
            _dbContext.Report.Attach(entity);
            _dbContext.SetModified(entity);
        }

        public IEnumerable<Report> GetAllAsync()
        {
            return _dbContext.Report.ToList();
        }

        public Report GetByIdAsync(int id)
        {
            return _dbContext.Report.Find(id);
        }

        public void Save()
        {
            _dbContext.Commit();
        }
    }
}

