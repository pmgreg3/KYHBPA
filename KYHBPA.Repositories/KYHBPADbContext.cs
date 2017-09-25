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
    public class KYHBPADbContext : DbContext , IKYHBPADbContext
    {
        public DbSet<Image> Image { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<Member> Member { get; set; }

    }
}
