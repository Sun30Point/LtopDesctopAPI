//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LtopDesctopAPI.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonsToPersonType
    {
        public long ID { get; set; }
        public Nullable<System.Guid> PersonGuid { get; set; }
        public Nullable<long> PersonTypeId { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual PersonType PersonType { get; set; }
    }
}
