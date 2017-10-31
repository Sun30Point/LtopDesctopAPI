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
    
    public partial class DeviceCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeviceCategory()
        {
            this.Devices = new HashSet<Device>();
            this.ModelsToDeviceCategories = new HashSet<ModelsToDeviceCategory>();
            this.VendorsToDeviceCategories = new HashSet<VendorsToDeviceCategory>();
        }
    
        public int ID { get; set; }
        public string Type { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Devices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelsToDeviceCategory> ModelsToDeviceCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorsToDeviceCategory> VendorsToDeviceCategories { get; set; }
    }
}