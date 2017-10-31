using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LtopDesctopAPI.Models
{
    public class PersonTypes
    {
        public long ID { get; set; }
        public string NameEng { get; set; }
        public string NameRus { get; set; }
        public string NameUkr { get; set; }
        public string DescriptionEng { get; set; }
        public string DescriptionRus { get; set; }
        public string DescriptionUkr { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}