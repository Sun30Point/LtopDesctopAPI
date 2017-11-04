using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class PropertyController : ApiController
    {
        LTopDBEntities db = new LTopDBEntities();
        // GET api/<controller>
        [HttpGet]
        public List<Models.Properties> GetList(long PropertyType, string Value, long ID, string TypeQuery)
        {
            // Получить список Property_GetList SeriecID или DeviceID или ModelID(PrperrtyType, Value, ID)

            switch (TypeQuery.ToLower())
            {
                case "series":
                    return db.Properties.ToList().Select(item => new Models.Properties()
                    {
                        ID =item.ID,
                        Value = item.Value,
                        IsActive = item.IsActive
                    }).ToList();

                case "models":
                    return db.Properties.ToList().Select(item => new Models.Properties()
                    {
                        ID = item.ID,
                        Value = item.Value,
                        IsActive = item.IsActive
                    }).ToList();

                case "device":
                    return db.Properties.ToList().Select(item => new Models.Properties()
                    {
                        ID = item.ID,
                        Value = item.Value,
                        IsActive = item.IsActive
                    }).ToList();

            }
            return null;
        }

        // GET api/<controller>/5
        [HttpGet]
        public Models.Properties GetItem(int id)
        {
            return db.Properties.Select(item => new Models.Properties()
            {
                ID = item.ID,
                Value = item.Value,
                IsActive = item.IsActive
            }).Where(item => item.ID == id).FirstOrDefault();
        }




        // POST api/<controller>/5
        [HttpPost]
        public long? CreateItem(Models.Properties value, long PropertyTypeId, long ID,string TypeQuery)
        {
            switch (TypeQuery.ToLower())
            {
                case "series":  
                    return db.CreatePropertySeries(value.Value, PropertyTypeId, ID).FirstOrDefault();

                case "models":
                    return db.CreatePropertyModels(value.Value, PropertyTypeId, ID).FirstOrDefault();

                case "device":
                    return db.CreatePropertyDevice(value.Value, PropertyTypeId, ID);
            }
            return null;
        }

        //PUT api/<controller>/5
        [HttpPut]
        public long? UpdateItem(Models.Properties value, long PropertyTypeId, long ID, string TypeQuery)
        {
            switch (TypeQuery.ToLower())
            {
                case "series":
                    return db.UpdatePropertySeries(value.ID,value.Value, value.IsActive, PropertyTypeId, ID).FirstOrDefault();

                case "models":
                    return db.UpdatePropertyModels(value.ID, value.Value, value.IsActive, PropertyTypeId, ID).FirstOrDefault();

                case "device":
                    return db.UpdatePropertyDevice(value.ID, value.Value, value.IsActive, PropertyTypeId, ID).FirstOrDefault();
            }
            return null;
        }



        // DELETE api/<controller>/5
        [HttpDelete]
        public long DeleteItem(Models.Properties value)
        {
            var result = db.DeleteProperty(value.ID);
            return value.ID;
        }
    }
}