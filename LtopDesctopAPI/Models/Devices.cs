using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LtopDesctopAPI.Models
{
    public class Devices
    {
        public long ID { get; set; }
        public string DescriptionEng { get; set; }
        public string DescriptionRus { get; set; }
        public string DescriptionUkr { get; set; }
        public long? VendorsId { get; set; }
        public long? ModelsId { get; set; }
        public long? SeriesId { get; set; }
        public int? DeviceCategoryId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public List<Photos> PhotosList { get; set; }
        public List<Properties> PropertiesList { get; set; }
        public Guid PersonGuid { get; set; }

    }
}



