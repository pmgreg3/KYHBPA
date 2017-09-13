using System;
using System.Collections.Generic;
using System.Text;

namespace KYHBPA.Entities
{
    /// <summary>
    /// Only format should be JPEG..?
    /// => store as byte[] in DB after conversion
    /// </summary>
    public class Photo : BaseDbObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
