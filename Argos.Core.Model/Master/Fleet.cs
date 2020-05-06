using System;
using System.ComponentModel.DataAnnotations;

namespace Argos.Core.Model.Master
{
    public class Fleet : IBase<Fleet>
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdateDate { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
