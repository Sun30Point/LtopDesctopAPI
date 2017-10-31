using System;

namespace LtopDesctopAPI.Models
{
    public class Photos
    {
        public long ID { get; set; }
        public byte[] Photo { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}