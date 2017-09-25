using KYHBPA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHBPA.Data.Interfaces
{
    public interface IKYHBPADbContext
    {
        DbSet<Image> Image { get; set; }
        DbSet<Report> Report { get; set; }
        DbSet<Member> Member { get; set; }
    }
}
