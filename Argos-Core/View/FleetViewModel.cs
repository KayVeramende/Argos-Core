using System;

namespace Argos_Core.View
{
    public class FleetViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Timestamp { get; set; }

    }
}
