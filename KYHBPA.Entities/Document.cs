using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHBPA.Entities
{
    public class Document : BaseDbObject
    {
        public int Type { get; set; }
        public string Description { get; set; }
        public byte[] FileContent { get; set; }
    }
}
