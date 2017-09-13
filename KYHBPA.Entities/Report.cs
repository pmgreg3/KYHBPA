using System;

namespace KYHBPA.Entities
{
    public class Report : BaseDbObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
