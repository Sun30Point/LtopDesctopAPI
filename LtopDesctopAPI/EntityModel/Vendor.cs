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
    
    public partial class Vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendor()
        {
            this.Devices = new HashSet<Device>();
            this.VendorsToDeviceCategories = new HashSet<VendorsToDeviceCategory>();
            this.VendorsToModels = new HashSet<VendorsToModel>();
        }
    
        public long ID { get; set; }
        public string NameEng { get; set; }
        public string NameRus { get; set; }
        public string NameUkr { get; set; }
        public string DescriptionEng { get; set; }
        public string DescriptionRus { get; set; }
        public string DescriptionUkr { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Devices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorsToDeviceCategory> VendorsToDeviceCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorsToModel> VendorsToModels { get; set; }
    }
}