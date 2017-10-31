using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LtopDesctopAPI.Models
{
    public class Persons
    {
        public System.Guid Guid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Skype { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsBlocked { get; set; }
    }
}