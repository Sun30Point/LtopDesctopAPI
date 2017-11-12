using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LtopDesctopAPI.Models
{
    public class Properties
    {
        public long ID { get; set; }
        public string Value { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public PropertyTypes PropertyType { get; set; }
        public long ModelsId { get; set; }
        public long SeriesId { get; set; }
        public long DeviceId { get; set; }

    }
}