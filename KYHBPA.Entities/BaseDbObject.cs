using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHBPA.Entities
{
    public abstract class BaseDbObject
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
    }
}
