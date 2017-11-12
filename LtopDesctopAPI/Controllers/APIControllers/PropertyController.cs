using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class PropertyController : ApiController
    {
        //--------------------------------------------------DB--------------------------------------------------------------

        LTopDBEntities db = new LTopDBEntities();

        //--------------------------------------------------Get/(SeriesId or ModelsId or DevicesId)-------------------------
        [HttpGet]
        public List<Models.Properties> GetList(long ID, string TypeQuery)
        {
            switch (TypeQuery.ToLower())
            {
                case "series":
                    return db.PropertyToSeries.Select(item => new Models.Properties()
                    {
                        ID = item.Property.ID,
                        Value = item.Property.Value,
                        IsActive = item.Property.IsActive,
                        PropertyType = item.Property.PropertyToPropertyTypes.Select(item1 => new Models.PropertyTypes()
                        {
                            ID = item1.PropertyType.ID,
                            NameEng = item1.PropertyType.NameEng,
                            NameRus = item1.PropertyType.NameRus,
                            NameUkr = item1.PropertyType.NameUkr,
                            DescriptionEng = item1.PropertyType.DescriptionEng,
                            DescriptionRus = item1.PropertyType.DescriptionRus,
                            DescriptionUkr = item1.PropertyType.DescriptionUkr,
                            IsActive = item1.PropertyType.IsActive
                        }).FirstOrDefault(),
                        SeriesId = item.Series.ID
                    }).Where(item => item.SeriesId == ID).ToList();

                case "models":
                    return db.PropertyToModels.Select(item => new Models.Properties()
                    {
                        ID = item.Property.ID,
                        Value = item.Property.Value,
                        IsActive = item.Property.IsActive,
                        PropertyType = item.Property.PropertyToPropertyTypes.Select(item1 => new Models.PropertyTypes()
                        {
                            ID = item1.PropertyType.ID,
                            NameEng = item1.PropertyType.NameEng,
                            NameRus = item1.PropertyType.NameRus,
                            NameUkr = item1.PropertyType.NameUkr,
                            DescriptionEng = item1.PropertyType.DescriptionEng,
                            DescriptionRus = item1.PropertyType.DescriptionRus,
                            DescriptionUkr = item1.PropertyType.DescriptionUkr,
                            IsActive = item1.PropertyType.IsActive
                        }).FirstOrDefault(),
                        ModelsId = item.Model.ID
                    }).Where(item => item.ModelsId == ID).ToList();

                case "device":
                    return db.PropertyToDevices.Select(item => new Models.Properties()
                    {
                        ID = item.Property.ID,
                        Value = item.Property.Value,
                        IsActive = item.Property.IsActive,
                        PropertyType = item.Property.PropertyToPropertyTypes.Select(item1 => new Models.PropertyTypes()
                        {
                            ID = item1.PropertyType.ID,
                            NameEng = item1.PropertyType.NameEng,
                            NameRus = item1.PropertyType.NameRus,
                            NameUkr = item1.PropertyType.NameUkr,
                            DescriptionEng = item1.PropertyType.DescriptionEng,
                            DescriptionRus = item1.PropertyType.DescriptionRus,
                            DescriptionUkr = item1.PropertyType.DescriptionUkr,
                            IsActive = item1.PropertyType.IsActive
                        }).FirstOrDefault(),
                        DeviceId = item.Device.ID
                    }).Where(item => item.DeviceId == ID).ToList();
            }
            return null;
        }

        //--------------------------------------------------Get/id-----------------------------------------------------------

        [HttpGet]
        public Models.Properties GetItem(int id)
        {
            return db.Properties.Select(item => new Models.Properties()
            {
                ID = item.ID,
                Value = item.Value,
                IsActive = item.IsActive,
                PropertyType = item.PropertyToPropertyTypes.Select(item1 => new Models.PropertyTypes()
                {
                    ID = item1.PropertyType.ID,
                    NameEng = item1.PropertyType.NameEng,
                    NameRus = item1.PropertyType.NameRus,
                    NameUkr = item1.PropertyType.NameUkr,
                    DescriptionEng = item1.PropertyType.DescriptionEng,
                    DescriptionRus = item1.PropertyType.DescriptionRus,
                    DescriptionUkr = item1.PropertyType.DescriptionUkr,
                    IsActive = item1.PropertyType.IsActive
                }).FirstOrDefault()
            }).Where(item => item.ID == id).FirstOrDefault();
        }

        //--------------------------------------------------Create----------------------------------------------------------

        [HttpPost]
        public long? CreateItem(Models.Properties item, long PropertyTypeId, long ID,string TypeQuery)
        {
            switch (TypeQuery.ToLower())
            {
                case "series":  
                    return db.CreatePropertySeries(item.Value, PropertyTypeId, ID).FirstOrDefault();

                case "models":
                    return db.CreatePropertyModels(item.Value, PropertyTypeId, ID).FirstOrDefault();

                case "device":
                    return db.CreatePropertyDevice(item.Value, PropertyTypeId, ID);
            }
            return null;
        }

        //--------------------------------------------------Update---------------------------------------------------------

        [HttpPut]
        public long? UpdateItem(Models.Properties item, long PropertyTypeId, long ID, string TypeQuery)
        {
            switch (TypeQuery.ToLower())
            {
                case "series":
                    return db.UpdatePropertySeries(item.ID,item.Value, item.IsActive, PropertyTypeId, ID).FirstOrDefault();

                case "models":
                    return db.UpdatePropertyModels(item.ID, item.Value, item.IsActive, PropertyTypeId, ID).FirstOrDefault();

                case "device":
                    return db.UpdatePropertyDevice(item.ID, item.Value, item.IsActive, PropertyTypeId, ID).FirstOrDefault();
            }
            return null;
        }

        //--------------------------------------------------Delete---------------------------------------------------------

        [HttpDelete]
        public long DeleteItem(Models.Properties item)
        {
            var result = db.DeleteProperty(item.ID);
            return item.ID;
        }
    }
}