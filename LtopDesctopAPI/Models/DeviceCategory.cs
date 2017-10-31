using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LtopDesctopAPI.Models
{
    public class DeviceCategory
    {
        public long ID { get; set; }
        public string Type { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}