using System;
namespace Argos.Core.Model
{
    public interface IBase<T> where T : class
    {
        public Guid Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public byte[] Timestamp { get; set; }

    }
}
