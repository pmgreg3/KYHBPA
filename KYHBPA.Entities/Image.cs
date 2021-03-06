﻿using System;
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
        public string Type { get; set; }
        public bool InImageGallery { get; set; }
    }
}
