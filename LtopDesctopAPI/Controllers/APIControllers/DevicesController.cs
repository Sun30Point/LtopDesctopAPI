using LtopDesctopAPI.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class DevicesController : ApiController
    {
        //--------------------------------------------------DB--------------------------------------------------------------

        LTopDBEntities db = new LTopDBEntities();

        //--------------------------------------------------Get-------------------------------------------------------------

        [HttpGet]
        public List<Models.Devices> GetList()
        {
            return db.Devices.Select(item => new Models.Devices()
            {
                ID = item.ID,
                DescriptionEng = item.DescriptionEng,
                DescriptionRus = item.DescriptionRus,
                DescriptionUkr = item.DescriptionUkr,
                DeviceCategoryId = item.DeviceCategoryId,
                VendorsId = item.VendorsId,
                ModelsId = item.ModelsId,
                SeriesId = item.SeriesToDevices.FirstOrDefault().SeriesId,
                IsActive = item.IsActive,
                PropertiesList = item.PropertyToDevices.Select(item1 => new Models.Properties()
                {
                    ID = item1.Property.ID,
                    Value = item1.Property.Value,
                    IsActive = item1.Property.IsActive,
                    PropertyType = item1.Property.PropertyToPropertyTypes.Select(item2 => new Models.PropertyTypes()
                    {
                        ID = item2.PropertyType.ID,
                        NameEng = item2.PropertyType.NameEng,
                        NameRus = item2.PropertyType.NameRus,
                        NameUkr = item2.PropertyType.NameUkr,
                        DescriptionEng = item2.PropertyType.DescriptionEng,
                        DescriptionRus = item2.PropertyType.DescriptionRus,
                        DescriptionUkr = item2.PropertyType.DescriptionUkr,
                        IsActive = item2.PropertyType.IsActive
                    }).FirstOrDefault(),
                }).ToList(),
                PhotosList = item.DevicesToPhotoes.Select(item1 => new Models.Photos()
                {
                    ID = item1.Photo.ID,
                    Photo = item1.Photo.Photo1,
                    IsActive = item1.Photo.IsActive
                }).ToList()  
                }).ToList();
        }

        //--------------------------------------------------GetList/PersonGuid,DeviceCategoryId------------------------------

        [HttpGet]
        public List<Models.Devices> GetList(string PersonGuid, int DeviceCategoryId)
        {
            Guid Person1 = Guid.Parse(PersonGuid);
            if (Person1!=Guid.Empty)
            {
                return db.Devices.Select(item => new Models.Devices()
                {
                    ID = item.ID,
                    DescriptionEng = item.DescriptionEng,
                    DescriptionRus = item.DescriptionRus,
                    DescriptionUkr = item.DescriptionUkr,
                    DeviceCategoryId = item.DeviceCategoryId,
                    VendorsId = item.VendorsId,
                    ModelsId = item.ModelsId,
                    SeriesId = item.SeriesToDevices.FirstOrDefault().SeriesId,
                    IsActive = item.IsActive,
                    PropertiesList = item.PropertyToDevices.Select(item1 => new Models.Properties()
                    {
                        ID = item1.Property.ID,
                        Value = item1.Property.Value,
                        IsActive = item1.Property.IsActive,
                        PropertyType = item1.Property.PropertyToPropertyTypes.Select(item2 => new Models.PropertyTypes()
                        {
                            ID = item2.PropertyType.ID,
                            NameEng = item2.PropertyType.NameEng,
                            NameRus = item2.PropertyType.NameRus,
                            NameUkr = item2.PropertyType.NameUkr,
                            DescriptionEng = item2.PropertyType.DescriptionEng,
                            DescriptionRus = item2.PropertyType.DescriptionRus,
                            DescriptionUkr = item2.PropertyType.DescriptionUkr,
                            IsActive = item2.PropertyType.IsActive
                        }).FirstOrDefault(),
                    }).ToList(),
                    PhotosList = item.DevicesToPhotoes.Select(item1 => new Models.Photos()
                    {
                        ID = item1.Photo.ID,
                        Photo = item1.Photo.Photo1,
                        IsActive = item1.Photo.IsActive
                    }).ToList(),
                    PersonGuid = item.AdvertsToDevices.FirstOrDefault().Advert.PersonsToAdverts.FirstOrDefault().Person.Guid
                }).Where(item => item.PersonGuid == Person1).ToList();
            }
            else if (DeviceCategoryId > 0)
            {
                return db.Devices.Select(item => new Models.Devices()
                {
                    ID = item.ID,
                    DescriptionEng = item.DescriptionEng,
                    DescriptionRus = item.DescriptionRus,
                    DescriptionUkr = item.DescriptionUkr,
                    DeviceCategoryId = item.DeviceCategoryId,
                    VendorsId = item.VendorsId,
                    ModelsId = item.ModelsId,
                    SeriesId = item.SeriesToDevices.FirstOrDefault().SeriesId,
                    IsActive = item.IsActive,
                    PropertiesList = item.PropertyToDevices.Select(item1 => new Models.Properties()
                    {
                        ID = item1.Property.ID,
                        Value = item1.Property.Value,
                        IsActive = item1.Property.IsActive,
                        PropertyType = item1.Property.PropertyToPropertyTypes.Select(item2 => new Models.PropertyTypes()
                        {
                            ID = item2.PropertyType.ID,
                            NameEng = item2.PropertyType.NameEng,
                            NameRus = item2.PropertyType.NameRus,
                            NameUkr = item2.PropertyType.NameUkr,
                            DescriptionEng = item2.PropertyType.DescriptionEng,
                            DescriptionRus = item2.PropertyType.DescriptionRus,
                            DescriptionUkr = item2.PropertyType.DescriptionUkr,
                            IsActive = item2.PropertyType.IsActive
                        }).FirstOrDefault(),
                    }).ToList(),
                    PhotosList = item.DevicesToPhotoes.Select(item1 => new Models.Photos()
                    {
                        ID = item1.Photo.ID,
                        Photo = item1.Photo.Photo1,
                        IsActive = item1.Photo.IsActive
                    }).ToList()
                }).Where(item=>item.DeviceCategoryId==DeviceCategoryId).ToList();
            }
            return null;
        }

        //--------------------------------------------------Get/id-----------------------------------------------------------

        [HttpGet]
        public Models.Devices GetItem(long id)
        {

            return db.Devices.Select(item => new Models.Devices()
            {
                ID = item.ID,
                DescriptionEng = item.DescriptionEng,
                DescriptionRus = item.DescriptionRus,
                DescriptionUkr = item.DescriptionUkr,
                DeviceCategoryId = item.DeviceCategoryId,
                VendorsId = item.VendorsId,
                ModelsId = item.ModelsId,
                SeriesId = item.SeriesToDevices.FirstOrDefault().SeriesId,
                IsActive = item.IsActive,
                PropertiesList = item.PropertyToDevices.Select(item1 => new Models.Properties()
                {
                    ID = item1.Property.ID,
                    Value = item1.Property.Value,
                    IsActive = item1.Property.IsActive,
                    PropertyType = item1.Property.PropertyToPropertyTypes.Select(item2 => new Models.PropertyTypes()
                    {
                        ID = item2.PropertyType.ID,
                        NameEng = item2.PropertyType.NameEng,
                        NameRus = item2.PropertyType.NameRus,
                        NameUkr = item2.PropertyType.NameUkr,
                        DescriptionEng = item2.PropertyType.DescriptionEng,
                        DescriptionRus = item2.PropertyType.DescriptionRus,
                        DescriptionUkr = item2.PropertyType.DescriptionUkr,
                        IsActive = item2.PropertyType.IsActive
                    }).FirstOrDefault(),
                }).ToList(),
                PhotosList = item.DevicesToPhotoes.Select(item1 => new Models.Photos()
                {
                    ID = item1.Photo.ID,
                    Photo = item1.Photo.Photo1,
                    IsActive = item1.Photo.IsActive
                }).ToList()
            }).Where(item => item.ID==id).FirstOrDefault();
        }

        //--------------------------------------------------Create----------------------------------------------------------

        [HttpPost]
        public long? CreateItem(Models.Devices item)
        {
            var result = db.CreateDevice(item.DescriptionEng, item.DescriptionRus, item.DescriptionUkr, item.DeviceCategoryId, item.VendorsId, item.ModelsId, item.SeriesId).FirstOrDefault();

            foreach (var Ph in item.PhotosList)
                db.CreateDevicePhoto(result, Ph.Photo);

            foreach (var Pr in item.PropertiesList)
                db.CreatePropertyDevice(Pr.Value, Pr.PropertyType.ID, result);
            
            return result;
        }

        //--------------------------------------------------Update---------------------------------------------------------

        [HttpPut]
        public long? UpdateItem(Models.Devices item)
        {
            var result = db.UpdateDevice(item.ID,item.DescriptionEng, item.DescriptionRus, item.DescriptionUkr,item.IsActive, item.DeviceCategoryId, item.VendorsId, item.ModelsId, item.SeriesId).FirstOrDefault();

            foreach (var Ph in item.PhotosList)
                db.UpdateDevicePhoto(result,Ph.ID, Ph.Photo,Ph.IsActive);

            foreach (var Pr in item.PropertiesList)
                db.UpdatePropertyDevice(Pr.ID,Pr.Value,Pr.IsActive, Pr.PropertyType.ID, result);

            return result;
        }

        //--------------------------------------------------Delete---------------------------------------------------------

        [HttpDelete]
        public long DeleteItem(Models.Devices value)
        {
            var result = db.DeleteDevices(value.ID);
            return value.ID;
        }
    }
}