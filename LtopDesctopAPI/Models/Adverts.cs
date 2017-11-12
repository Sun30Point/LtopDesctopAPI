using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LtopDesctopAPI.Models
{
    public class Adverts
    {
        public long ID { get; set; }
        public string DescriptionEng { get; set; }
        public string DescriptionRus { get; set; }
        public string DescriptionUkr { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Guid PersonGuid { get; set; }
        public long? AdvertTypeID { get; set; }
        public long? DeviceID { get; set; }
        public int DeviceCategoryId { get; set; }
    }
}
