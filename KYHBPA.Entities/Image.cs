using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHBPA.Entities
{
    public class Image : BaseDbObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Content { get; set; }
        string Type { get; set; }
    }
}
