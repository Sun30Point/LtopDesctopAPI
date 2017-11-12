using LtopDesctopAPI.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class PhotoController : ApiController
    {
        //--------------------------------------------------DB--------------------------------------------------------------

        LTopDBEntities db = new LTopDBEntities();

        //--------------------------------------------------Get-------------------------------------------------------------

        [HttpGet]
        public List<Models.Photos> GetList()
        {
            return db.Photos.ToList().Select(item => new Models.Photos()
            {
                ID = item.ID,
                Photo = item.Photo1,
                IsActive = item.IsActive
            }).ToList();
        }

        //--------------------------------------------------Get/id-----------------------------------------------------------

        [HttpGet]
        public Models.Photos GetItem(long id)
        {
            return db.Photos.Select(item => new Models.Photos()
            {
                ID = item.ID,
                Photo = item.Photo1,
                IsActive = item.IsActive
            }).Where(item => item.ID == id).FirstOrDefault();
        }

        //--------------------------------------------------Create----------------------------------------------------------

        [HttpPost]
        public long? CreateItem(string PersonGuid, long DeviceId, Models.Photos item)
        {
            if (PersonGuid != string.Empty && PersonGuid != null)
            {
                return (long)db.CreatePersonPhoto(Guid.Parse(PersonGuid), item.Photo).FirstOrDefault();
            }
            else
                if (DeviceId > 0)
            {
                return (long)db.CreateDevicePhoto(DeviceId, item.Photo).FirstOrDefault();
            }
            return null;
        }

        //--------------------------------------------------Update---------------------------------------------------------

        [HttpPut]
        public long UpdateItem(Models.Photos item)
        {
            var result = db.UpdatePhoto(item.ID, item.Photo, item.IsActive);
            return item.ID;
        }



        //--------------------------------------------------Delete---------------------------------------------------------

        [HttpDelete]
        public long DeleteItem(Models.Photos item)
        {
            var result = db.DeletePhoto(item.ID);
            return item.ID;
        }
    }
}