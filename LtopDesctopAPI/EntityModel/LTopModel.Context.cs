﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LTopDBEntities : DbContext
    {
        public LTopDBEntities()
            : base("name=LTopDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Advert> Adverts { get; set; }
        public virtual DbSet<AdvertsToAdvertType> AdvertsToAdvertTypes { get; set; }
        public virtual DbSet<AdvertsToDevice> AdvertsToDevices { get; set; }
        public virtual DbSet<AdvertType> AdvertTypes { get; set; }
        public virtual DbSet<AdvertVersion> AdvertVersions { get; set; }
        public virtual DbSet<DeviceCategory> DeviceCategories { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<ModelsToDeviceCategory> ModelsToDeviceCategories { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<PersonsToAdvert> PersonsToAdverts { get; set; }
        public virtual DbSet<PersonsToPersonType> PersonsToPersonTypes { get; set; }
        public virtual DbSet<PersonsToPhoto> PersonsToPhotoes { get; set; }
        public virtual DbSet<PersonType> PersonTypes { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyToModel> PropertyToModels { get; set; }
        public virtual DbSet<PropertyToPropertyType> PropertyToPropertyTypes { get; set; }
        public virtual DbSet<PropertyToSery> PropertyToSeries { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<SeriesToDevice> SeriesToDevices { get; set; }
        public virtual DbSet<SeriesToModel> SeriesToModels { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorsToDeviceCategory> VendorsToDeviceCategories { get; set; }
        public virtual DbSet<VendorsToModel> VendorsToModels { get; set; }
    
        public virtual ObjectResult<Nullable<decimal>> CreateAdvertType(string nameEng, string nameRus, string nameUkr, string descriptionEng, string descriptionRus, string descriptionUkr)
        {
            var nameEngParameter = nameEng != null ?
                new ObjectParameter("NameEng", nameEng) :
                new ObjectParameter("NameEng", typeof(string));
    
            var nameRusParameter = nameRus != null ?
                new ObjectParameter("NameRus", nameRus) :
                new ObjectParameter("NameRus", typeof(string));
    
            var nameUkrParameter = nameUkr != null ?
                new ObjectParameter("NameUkr", nameUkr) :
                new ObjectParameter("NameUkr", typeof(string));
    
            var descriptionEngParameter = descriptionEng != null ?
                new ObjectParameter("DescriptionEng", descriptionEng) :
                new ObjectParameter("DescriptionEng", typeof(string));
    
            var descriptionRusParameter = descriptionRus != null ?
                new ObjectParameter("DescriptionRus", descriptionRus) :
                new ObjectParameter("DescriptionRus", typeof(string));
    
            var descriptionUkrParameter = descriptionUkr != null ?
                new ObjectParameter("DescriptionUkr", descriptionUkr) :
                new ObjectParameter("DescriptionUkr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CreateAdvertType", nameEngParameter, nameRusParameter, nameUkrParameter, descriptionEngParameter, descriptionRusParameter, descriptionUkrParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> CreateModel(string nameEng, string nameRus, string nameUkr, string descriptionEng, string descriptionRus, string descriptionUkr)
        {
            var nameEngParameter = nameEng != null ?
                new ObjectParameter("NameEng", nameEng) :
                new ObjectParameter("NameEng", typeof(string));
    
            var nameRusParameter = nameRus != null ?
                new ObjectParameter("NameRus", nameRus) :
                new ObjectParameter("NameRus", typeof(string));
    
            var nameUkrParameter = nameUkr != null ?
                new ObjectParameter("NameUkr", nameUkr) :
                new ObjectParameter("NameUkr", typeof(string));
    
            var descriptionEngParameter = descriptionEng != null ?
                new ObjectParameter("DescriptionEng", descriptionEng) :
                new ObjectParameter("DescriptionEng", typeof(string));
    
            var descriptionRusParameter = descriptionRus != null ?
                new ObjectParameter("DescriptionRus", descriptionRus) :
                new ObjectParameter("DescriptionRus", typeof(string));
    
            var descriptionUkrParameter = descriptionUkr != null ?
                new ObjectParameter("DescriptionUkr", descriptionUkr) :
                new ObjectParameter("DescriptionUkr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CreateModel", nameEngParameter, nameRusParameter, nameUkrParameter, descriptionEngParameter, descriptionRusParameter, descriptionUkrParameter);
        }
    
        public virtual ObjectResult<Nullable<System.Guid>> CreatePerson(Nullable<System.Guid> personGuid, string name, string email, string phone, string skype, string password, string salt)
        {
            var personGuidParameter = personGuid.HasValue ?
                new ObjectParameter("PersonGuid", personGuid) :
                new ObjectParameter("PersonGuid", typeof(System.Guid));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var skypeParameter = skype != null ?
                new ObjectParameter("Skype", skype) :
                new ObjectParameter("Skype", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var saltParameter = salt != null ?
                new ObjectParameter("Salt", salt) :
                new ObjectParameter("Salt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.Guid>>("CreatePerson", personGuidParameter, nameParameter, emailParameter, phoneParameter, skypeParameter, passwordParameter, saltParameter);
        }
    
        public virtual ObjectResult<Nullable<long>> CreatePhoto(Nullable<System.Guid> personGuid, byte[] photo)
        {
            var personGuidParameter = personGuid.HasValue ?
                new ObjectParameter("PersonGuid", personGuid) :
                new ObjectParameter("PersonGuid", typeof(System.Guid));
    
            var photoParameter = photo != null ?
                new ObjectParameter("Photo", photo) :
                new ObjectParameter("Photo", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("CreatePhoto", personGuidParameter, photoParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> CreateProperty(string value)
        {
            var valueParameter = value != null ?
                new ObjectParameter("Value", value) :
                new ObjectParameter("Value", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CreateProperty", valueParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> CreatePropertyType(string nameEng, string nameRus, string nameUkr, string descriptionEng, string descriptionRus, string descriptionUkr)
        {
            var nameEngParameter = nameEng != null ?
                new ObjectParameter("NameEng", nameEng) :
                new ObjectParameter("NameEng", typeof(string));
    
            var nameRusParameter = nameRus != null ?
                new ObjectParameter("NameRus", nameRus) :
                new ObjectParameter("NameRus", typeof(string));
    
            var nameUkrParameter = nameUkr != null ?
                new ObjectParameter("NameUkr", nameUkr) :
                new ObjectParameter("NameUkr", typeof(string));
    
            var descriptionEngParameter = descriptionEng != null ?
                new ObjectParameter("DescriptionEng", descriptionEng) :
                new ObjectParameter("DescriptionEng", typeof(string));
    
            var descriptionRusParameter = descriptionRus != null ?
                new ObjectParameter("DescriptionRus", descriptionRus) :
                new ObjectParameter("DescriptionRus", typeof(string));
    
            var descriptionUkrParameter = descriptionUkr != null ?
                new ObjectParameter("DescriptionUkr", descriptionUkr) :
                new ObjectParameter("DescriptionUkr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CreatePropertyType", nameEngParameter, nameRusParameter, nameUkrParameter, descriptionEngParameter, descriptionRusParameter, descriptionUkrParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> CreateSeries(string nameEng, string nameRus, string nameUkr, string descriptionEng, string descriptionRus, string descriptionUkr)
        {
            var nameEngParameter = nameEng != null ?
                new ObjectParameter("NameEng", nameEng) :
                new ObjectParameter("NameEng", typeof(string));
    
            var nameRusParameter = nameRus != null ?
                new ObjectParameter("NameRus", nameRus) :
                new ObjectParameter("NameRus", typeof(string));
    
            var nameUkrParameter = nameUkr != null ?
                new ObjectParameter("NameUkr", nameUkr) :
                new ObjectParameter("NameUkr", typeof(string));
    
            var descriptionEngParameter = descriptionEng != null ?
                new ObjectParameter("DescriptionEng", descriptionEng) :
                new ObjectParameter("DescriptionEng", typeof(string));
    
            var descriptionRusParameter = descriptionRus != null ?
                new ObjectParameter("DescriptionRus", descriptionRus) :
                new ObjectParameter("DescriptionRus", typeof(string));
    
            var descriptionUkrParameter = descriptionUkr != null ?
                new ObjectParameter("DescriptionUkr", descriptionUkr) :
                new ObjectParameter("DescriptionUkr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CreateSeries", nameEngParameter, nameRusParameter, nameUkrParameter, descriptionEngParameter, descriptionRusParameter, descriptionUkrParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> CreateVendors(string nameEng, string nameRus, string nameUkr, string descriptionEng, string descriptionRus, string descriptionUkr)
        {
            var nameEngParameter = nameEng != null ?
                new ObjectParameter("NameEng", nameEng) :
                new ObjectParameter("NameEng", typeof(string));
    
            var nameRusParameter = nameRus != null ?
                new ObjectParameter("NameRus", nameRus) :
                new ObjectParameter("NameRus", typeof(string));
    
            var nameUkrParameter = nameUkr != null ?
                new ObjectParameter("NameUkr", nameUkr) :
                new ObjectParameter("NameUkr", typeof(string));
    
            var descriptionEngParameter = descriptionEng != null ?
                new ObjectParameter("DescriptionEng", descriptionEng) :
                new ObjectParameter("DescriptionEng", typeof(string));
    
            var descriptionRusParameter = descriptionRus != null ?
                new ObjectParameter("DescriptionRus", descriptionRus) :
                new ObjectParameter("DescriptionRus", typeof(string));
    
            var descriptionUkrParameter = descriptionUkr != null ?
                new ObjectParameter("DescriptionUkr", descriptionUkr) :
                new ObjectParameter("DescriptionUkr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CreateVendors", nameEngParameter, nameRusParameter, nameUkrParameter, descriptionEngParameter, descriptionRusParameter, descriptionUkrParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> DeleteAdvertType(Nullable<long> advertTypeId)
        {
            var advertTypeIdParameter = advertTypeId.HasValue ?
                new ObjectParameter("AdvertTypeId", advertTypeId) :
                new ObjectParameter("AdvertTypeId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("DeleteAdvertType", advertTypeIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> DeleteModel(Nullable<long> modelId)
        {
            var modelIdParameter = modelId.HasValue ?
                new ObjectParameter("ModelId", modelId) :
                new ObjectParameter("ModelId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("DeleteModel", modelIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> DeletePerson(Nullable<System.Guid> personGuid)
        {
            var personGuidParameter = personGuid.HasValue ?
                new ObjectParameter("PersonGuid", personGuid) :
                new ObjectParameter("PersonGuid", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("DeletePerson", personGuidParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> DeletePhoto(Nullable<long> photoId)
        {
            var photoIdParameter = photoId.HasValue ?
                new ObjectParameter("PhotoId", photoId) :
                new ObjectParameter("PhotoId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("DeletePhoto", photoIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> DeletePropertyType(Nullable<long> propertyTypeId)
        {
            var propertyTypeIdParameter = propertyTypeId.HasValue ?
                new ObjectParameter("PropertyTypeId", propertyTypeId) :
                new ObjectParameter("PropertyTypeId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("DeletePropertyType", propertyTypeIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> DeleteSeries(Nullable<long> seriesId)
        {
            var seriesIdParameter = seriesId.HasValue ?
                new ObjectParameter("SeriesId", seriesId) :
                new ObjectParameter("SeriesId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("DeleteSeries", seriesIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> DeleteVendors(Nullable<long> vendorsId)
        {
            var vendorsIdParameter = vendorsId.HasValue ?
                new ObjectParameter("VendorsId", vendorsId) :
                new ObjectParameter("VendorsId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("DeleteVendors", vendorsIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> UpdateAdvertType(Nullable<long> advertTypeId, string newNameEng, string newNameRus, string newNameUkr, string newDescriptionEng, string newDescriptionRus, string newDescriptionUkr, Nullable<bool> newIsActive)
        {
            var advertTypeIdParameter = advertTypeId.HasValue ?
                new ObjectParameter("AdvertTypeId", advertTypeId) :
                new ObjectParameter("AdvertTypeId", typeof(long));
    
            var newNameEngParameter = newNameEng != null ?
                new ObjectParameter("NewNameEng", newNameEng) :
                new ObjectParameter("NewNameEng", typeof(string));
    
            var newNameRusParameter = newNameRus != null ?
                new ObjectParameter("NewNameRus", newNameRus) :
                new ObjectParameter("NewNameRus", typeof(string));
    
            var newNameUkrParameter = newNameUkr != null ?
                new ObjectParameter("NewNameUkr", newNameUkr) :
                new ObjectParameter("NewNameUkr", typeof(string));
    
            var newDescriptionEngParameter = newDescriptionEng != null ?
                new ObjectParameter("NewDescriptionEng", newDescriptionEng) :
                new ObjectParameter("NewDescriptionEng", typeof(string));
    
            var newDescriptionRusParameter = newDescriptionRus != null ?
                new ObjectParameter("NewDescriptionRus", newDescriptionRus) :
                new ObjectParameter("NewDescriptionRus", typeof(string));
    
            var newDescriptionUkrParameter = newDescriptionUkr != null ?
                new ObjectParameter("NewDescriptionUkr", newDescriptionUkr) :
                new ObjectParameter("NewDescriptionUkr", typeof(string));
    
            var newIsActiveParameter = newIsActive.HasValue ?
                new ObjectParameter("NewIsActive", newIsActive) :
                new ObjectParameter("NewIsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("UpdateAdvertType", advertTypeIdParameter, newNameEngParameter, newNameRusParameter, newNameUkrParameter, newDescriptionEngParameter, newDescriptionRusParameter, newDescriptionUkrParameter, newIsActiveParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> UpdateModel(Nullable<long> modelId, string newNameEng, string newNameRus, string newNameUkr, string newDescriptionEng, string newDescriptionRus, string newDescriptionUkr, Nullable<bool> newIsActive)
        {
            var modelIdParameter = modelId.HasValue ?
                new ObjectParameter("ModelId", modelId) :
                new ObjectParameter("ModelId", typeof(long));
    
            var newNameEngParameter = newNameEng != null ?
                new ObjectParameter("NewNameEng", newNameEng) :
                new ObjectParameter("NewNameEng", typeof(string));
    
            var newNameRusParameter = newNameRus != null ?
                new ObjectParameter("NewNameRus", newNameRus) :
                new ObjectParameter("NewNameRus", typeof(string));
    
            var newNameUkrParameter = newNameUkr != null ?
                new ObjectParameter("NewNameUkr", newNameUkr) :
                new ObjectParameter("NewNameUkr", typeof(string));
    
            var newDescriptionEngParameter = newDescriptionEng != null ?
                new ObjectParameter("NewDescriptionEng", newDescriptionEng) :
                new ObjectParameter("NewDescriptionEng", typeof(string));
    
            var newDescriptionRusParameter = newDescriptionRus != null ?
                new ObjectParameter("NewDescriptionRus", newDescriptionRus) :
                new ObjectParameter("NewDescriptionRus", typeof(string));
    
            var newDescriptionUkrParameter = newDescriptionUkr != null ?
                new ObjectParameter("NewDescriptionUkr", newDescriptionUkr) :
                new ObjectParameter("NewDescriptionUkr", typeof(string));
    
            var newIsActiveParameter = newIsActive.HasValue ?
                new ObjectParameter("NewIsActive", newIsActive) :
                new ObjectParameter("NewIsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("UpdateModel", modelIdParameter, newNameEngParameter, newNameRusParameter, newNameUkrParameter, newDescriptionEngParameter, newDescriptionRusParameter, newDescriptionUkrParameter, newIsActiveParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> UpdatePerson(Nullable<System.Guid> personGuid, string newName, string newEmail, string newPhone, string newSkype, string newPassword, string newSalt, Nullable<bool> newIsActive, Nullable<bool> newIsBlocke)
        {
            var personGuidParameter = personGuid.HasValue ?
                new ObjectParameter("PersonGuid", personGuid) :
                new ObjectParameter("PersonGuid", typeof(System.Guid));
    
            var newNameParameter = newName != null ?
                new ObjectParameter("NewName", newName) :
                new ObjectParameter("NewName", typeof(string));
    
            var newEmailParameter = newEmail != null ?
                new ObjectParameter("NewEmail", newEmail) :
                new ObjectParameter("NewEmail", typeof(string));
    
            var newPhoneParameter = newPhone != null ?
                new ObjectParameter("NewPhone", newPhone) :
                new ObjectParameter("NewPhone", typeof(string));
    
            var newSkypeParameter = newSkype != null ?
                new ObjectParameter("NewSkype", newSkype) :
                new ObjectParameter("NewSkype", typeof(string));
    
            var newPasswordParameter = newPassword != null ?
                new ObjectParameter("NewPassword", newPassword) :
                new ObjectParameter("NewPassword", typeof(string));
    
            var newSaltParameter = newSalt != null ?
                new ObjectParameter("NewSalt", newSalt) :
                new ObjectParameter("NewSalt", typeof(string));
    
            var newIsActiveParameter = newIsActive.HasValue ?
                new ObjectParameter("NewIsActive", newIsActive) :
                new ObjectParameter("NewIsActive", typeof(bool));
    
            var newIsBlockeParameter = newIsBlocke.HasValue ?
                new ObjectParameter("NewIsBlocke", newIsBlocke) :
                new ObjectParameter("NewIsBlocke", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("UpdatePerson", personGuidParameter, newNameParameter, newEmailParameter, newPhoneParameter, newSkypeParameter, newPasswordParameter, newSaltParameter, newIsActiveParameter, newIsBlockeParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> UpdatePhoto(Nullable<long> photoId, byte[] newPhoto, Nullable<bool> newIsActive)
        {
            var photoIdParameter = photoId.HasValue ?
                new ObjectParameter("PhotoId", photoId) :
                new ObjectParameter("PhotoId", typeof(long));
    
            var newPhotoParameter = newPhoto != null ?
                new ObjectParameter("NewPhoto", newPhoto) :
                new ObjectParameter("NewPhoto", typeof(byte[]));
    
            var newIsActiveParameter = newIsActive.HasValue ?
                new ObjectParameter("NewIsActive", newIsActive) :
                new ObjectParameter("NewIsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("UpdatePhoto", photoIdParameter, newPhotoParameter, newIsActiveParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> UpdatePropertyType(Nullable<long> propertyTypeId, string newNameEng, string newNameRus, string newNameUkr, string newDescriptionEng, string newDescriptionRus, string newDescriptionUkr, Nullable<bool> newIsActive)
        {
            var propertyTypeIdParameter = propertyTypeId.HasValue ?
                new ObjectParameter("PropertyTypeId", propertyTypeId) :
                new ObjectParameter("PropertyTypeId", typeof(long));
    
            var newNameEngParameter = newNameEng != null ?
                new ObjectParameter("NewNameEng", newNameEng) :
                new ObjectParameter("NewNameEng", typeof(string));
    
            var newNameRusParameter = newNameRus != null ?
                new ObjectParameter("NewNameRus", newNameRus) :
                new ObjectParameter("NewNameRus", typeof(string));
    
            var newNameUkrParameter = newNameUkr != null ?
                new ObjectParameter("NewNameUkr", newNameUkr) :
                new ObjectParameter("NewNameUkr", typeof(string));
    
            var newDescriptionEngParameter = newDescriptionEng != null ?
                new ObjectParameter("NewDescriptionEng", newDescriptionEng) :
                new ObjectParameter("NewDescriptionEng", typeof(string));
    
            var newDescriptionRusParameter = newDescriptionRus != null ?
                new ObjectParameter("NewDescriptionRus", newDescriptionRus) :
                new ObjectParameter("NewDescriptionRus", typeof(string));
    
            var newDescriptionUkrParameter = newDescriptionUkr != null ?
                new ObjectParameter("NewDescriptionUkr", newDescriptionUkr) :
                new ObjectParameter("NewDescriptionUkr", typeof(string));
    
            var newIsActiveParameter = newIsActive.HasValue ?
                new ObjectParameter("NewIsActive", newIsActive) :
                new ObjectParameter("NewIsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("UpdatePropertyType", propertyTypeIdParameter, newNameEngParameter, newNameRusParameter, newNameUkrParameter, newDescriptionEngParameter, newDescriptionRusParameter, newDescriptionUkrParameter, newIsActiveParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> UpdateSeries(Nullable<long> seriesId, string newNameEng, string newNameRus, string newNameUkr, string newDescriptionEng, string newDescriptionRus, string newDescriptionUkr, Nullable<bool> newIsActive)
        {
            var seriesIdParameter = seriesId.HasValue ?
                new ObjectParameter("SeriesId", seriesId) :
                new ObjectParameter("SeriesId", typeof(long));
    
            var newNameEngParameter = newNameEng != null ?
                new ObjectParameter("NewNameEng", newNameEng) :
                new ObjectParameter("NewNameEng", typeof(string));
    
            var newNameRusParameter = newNameRus != null ?
                new ObjectParameter("NewNameRus", newNameRus) :
                new ObjectParameter("NewNameRus", typeof(string));
    
            var newNameUkrParameter = newNameUkr != null ?
                new ObjectParameter("NewNameUkr", newNameUkr) :
                new ObjectParameter("NewNameUkr", typeof(string));
    
            var newDescriptionEngParameter = newDescriptionEng != null ?
                new ObjectParameter("NewDescriptionEng", newDescriptionEng) :
                new ObjectParameter("NewDescriptionEng", typeof(string));
    
            var newDescriptionRusParameter = newDescriptionRus != null ?
                new ObjectParameter("NewDescriptionRus", newDescriptionRus) :
                new ObjectParameter("NewDescriptionRus", typeof(string));
    
            var newDescriptionUkrParameter = newDescriptionUkr != null ?
                new ObjectParameter("NewDescriptionUkr", newDescriptionUkr) :
                new ObjectParameter("NewDescriptionUkr", typeof(string));
    
            var newIsActiveParameter = newIsActive.HasValue ?
                new ObjectParameter("NewIsActive", newIsActive) :
                new ObjectParameter("NewIsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("UpdateSeries", seriesIdParameter, newNameEngParameter, newNameRusParameter, newNameUkrParameter, newDescriptionEngParameter, newDescriptionRusParameter, newDescriptionUkrParameter, newIsActiveParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> UpdateVendors(Nullable<long> vendorsId, string newNameEng, string newNameRus, string newNameUkr, string newDescriptionEng, string newDescriptionRus, string newDescriptionUkr, Nullable<bool> newIsActive)
        {
            var vendorsIdParameter = vendorsId.HasValue ?
                new ObjectParameter("VendorsId", vendorsId) :
                new ObjectParameter("VendorsId", typeof(long));
    
            var newNameEngParameter = newNameEng != null ?
                new ObjectParameter("NewNameEng", newNameEng) :
                new ObjectParameter("NewNameEng", typeof(string));
    
            var newNameRusParameter = newNameRus != null ?
                new ObjectParameter("NewNameRus", newNameRus) :
                new ObjectParameter("NewNameRus", typeof(string));
    
            var newNameUkrParameter = newNameUkr != null ?
                new ObjectParameter("NewNameUkr", newNameUkr) :
                new ObjectParameter("NewNameUkr", typeof(string));
    
            var newDescriptionEngParameter = newDescriptionEng != null ?
                new ObjectParameter("NewDescriptionEng", newDescriptionEng) :
                new ObjectParameter("NewDescriptionEng", typeof(string));
    
            var newDescriptionRusParameter = newDescriptionRus != null ?
                new ObjectParameter("NewDescriptionRus", newDescriptionRus) :
                new ObjectParameter("NewDescriptionRus", typeof(string));
    
            var newDescriptionUkrParameter = newDescriptionUkr != null ?
                new ObjectParameter("NewDescriptionUkr", newDescriptionUkr) :
                new ObjectParameter("NewDescriptionUkr", typeof(string));
    
            var newIsActiveParameter = newIsActive.HasValue ?
                new ObjectParameter("NewIsActive", newIsActive) :
                new ObjectParameter("NewIsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("UpdateVendors", vendorsIdParameter, newNameEngParameter, newNameRusParameter, newNameUkrParameter, newDescriptionEngParameter, newDescriptionRusParameter, newDescriptionUkrParameter, newIsActiveParameter);
        }
    
        public virtual int CreatePropertyDevice(string propertyValue, Nullable<long> propertyTypeId, Nullable<long> deviceId)
        {
            var propertyValueParameter = propertyValue != null ?
                new ObjectParameter("PropertyValue", propertyValue) :
                new ObjectParameter("PropertyValue", typeof(string));
    
            var propertyTypeIdParameter = propertyTypeId.HasValue ?
                new ObjectParameter("PropertyTypeId", propertyTypeId) :
                new ObjectParameter("PropertyTypeId", typeof(long));
    
            var deviceIdParameter = deviceId.HasValue ?
                new ObjectParameter("DeviceId", deviceId) :
                new ObjectParameter("DeviceId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreatePropertyDevice", propertyValueParameter, propertyTypeIdParameter, deviceIdParameter);
        }
    
        public virtual ObjectResult<Nullable<long>> CreatePropertyModels(string propertyValue, Nullable<long> propertyTypeId, Nullable<long> modelId)
        {
            var propertyValueParameter = propertyValue != null ?
                new ObjectParameter("PropertyValue", propertyValue) :
                new ObjectParameter("PropertyValue", typeof(string));
    
            var propertyTypeIdParameter = propertyTypeId.HasValue ?
                new ObjectParameter("PropertyTypeId", propertyTypeId) :
                new ObjectParameter("PropertyTypeId", typeof(long));
    
            var modelIdParameter = modelId.HasValue ?
                new ObjectParameter("ModelId", modelId) :
                new ObjectParameter("ModelId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("CreatePropertyModels", propertyValueParameter, propertyTypeIdParameter, modelIdParameter);
        }
    
        public virtual ObjectResult<Nullable<long>> CreatePropertySeries(string propertyValue, Nullable<long> propertyTypeId, Nullable<long> seriesId)
        {
            var propertyValueParameter = propertyValue != null ?
                new ObjectParameter("PropertyValue", propertyValue) :
                new ObjectParameter("PropertyValue", typeof(string));
    
            var propertyTypeIdParameter = propertyTypeId.HasValue ?
                new ObjectParameter("PropertyTypeId", propertyTypeId) :
                new ObjectParameter("PropertyTypeId", typeof(long));
    
            var seriesIdParameter = seriesId.HasValue ?
                new ObjectParameter("SeriesId", seriesId) :
                new ObjectParameter("SeriesId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("CreatePropertySeries", propertyValueParameter, propertyTypeIdParameter, seriesIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> DeleteProperty(Nullable<long> propertyId)
        {
            var propertyIdParameter = propertyId.HasValue ?
                new ObjectParameter("PropertyId", propertyId) :
                new ObjectParameter("PropertyId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("DeleteProperty", propertyIdParameter);
        }
    
        public virtual ObjectResult<Nullable<long>> UpdatePropertyDevice(Nullable<long> propertyId, string newPropertyValue, Nullable<bool> newIsActive, Nullable<long> newPropertyTypeId, Nullable<long> newDeviceId)
        {
            var propertyIdParameter = propertyId.HasValue ?
                new ObjectParameter("PropertyId", propertyId) :
                new ObjectParameter("PropertyId", typeof(long));
    
            var newPropertyValueParameter = newPropertyValue != null ?
                new ObjectParameter("NewPropertyValue", newPropertyValue) :
                new ObjectParameter("NewPropertyValue", typeof(string));
    
            var newIsActiveParameter = newIsActive.HasValue ?
                new ObjectParameter("NewIsActive", newIsActive) :
                new ObjectParameter("NewIsActive", typeof(bool));
    
            var newPropertyTypeIdParameter = newPropertyTypeId.HasValue ?
                new ObjectParameter("NewPropertyTypeId", newPropertyTypeId) :
                new ObjectParameter("NewPropertyTypeId", typeof(long));
    
            var newDeviceIdParameter = newDeviceId.HasValue ?
                new ObjectParameter("NewDeviceId", newDeviceId) :
                new ObjectParameter("NewDeviceId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("UpdatePropertyDevice", propertyIdParameter, newPropertyValueParameter, newIsActiveParameter, newPropertyTypeIdParameter, newDeviceIdParameter);
        }
    
        public virtual ObjectResult<Nullable<long>> UpdatePropertyModels(Nullable<long> propertyId, string newPropertyValue, Nullable<bool> newIsActive, Nullable<long> newPropertyTypeId, Nullable<long> newModelsId)
        {
            var propertyIdParameter = propertyId.HasValue ?
                new ObjectParameter("PropertyId", propertyId) :
                new ObjectParameter("PropertyId", typeof(long));
    
            var newPropertyValueParameter = newPropertyValue != null ?
                new ObjectParameter("NewPropertyValue", newPropertyValue) :
                new ObjectParameter("NewPropertyValue", typeof(string));
    
            var newIsActiveParameter = newIsActive.HasValue ?
                new ObjectParameter("NewIsActive", newIsActive) :
                new ObjectParameter("NewIsActive", typeof(bool));
    
            var newPropertyTypeIdParameter = newPropertyTypeId.HasValue ?
                new ObjectParameter("NewPropertyTypeId", newPropertyTypeId) :
                new ObjectParameter("NewPropertyTypeId", typeof(long));
    
            var newModelsIdParameter = newModelsId.HasValue ?
                new ObjectParameter("NewModelsId", newModelsId) :
                new ObjectParameter("NewModelsId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("UpdatePropertyModels", propertyIdParameter, newPropertyValueParameter, newIsActiveParameter, newPropertyTypeIdParameter, newModelsIdParameter);
        }
    
        public virtual ObjectResult<Nullable<long>> UpdatePropertySeries(Nullable<long> propertyId, string newPropertyValue, Nullable<bool> newIsActive, Nullable<long> newPropertyTypeId, Nullable<long> newSeriesId)
        {
            var propertyIdParameter = propertyId.HasValue ?
                new ObjectParameter("PropertyId", propertyId) :
                new ObjectParameter("PropertyId", typeof(long));
    
            var newPropertyValueParameter = newPropertyValue != null ?
                new ObjectParameter("NewPropertyValue", newPropertyValue) :
                new ObjectParameter("NewPropertyValue", typeof(string));
    
            var newIsActiveParameter = newIsActive.HasValue ?
                new ObjectParameter("NewIsActive", newIsActive) :
                new ObjectParameter("NewIsActive", typeof(bool));
    
            var newPropertyTypeIdParameter = newPropertyTypeId.HasValue ?
                new ObjectParameter("NewPropertyTypeId", newPropertyTypeId) :
                new ObjectParameter("NewPropertyTypeId", typeof(long));
    
            var newSeriesIdParameter = newSeriesId.HasValue ?
                new ObjectParameter("NewSeriesId", newSeriesId) :
                new ObjectParameter("NewSeriesId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("UpdatePropertySeries", propertyIdParameter, newPropertyValueParameter, newIsActiveParameter, newPropertyTypeIdParameter, newSeriesIdParameter);
        }
    }
}
