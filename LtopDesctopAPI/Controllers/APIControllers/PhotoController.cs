using LtopDesctopAPI.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class PhotoController : ApiController
    {
        LTopDBEntities db = new LTopDBEntities();
        // GET api/<controller>
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

        // GET api/<controller>/5
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


        // POST api/<controller>/5
        [HttpPost]
        public long CreateItem(Guid PersonGuid, Models.Photos value)
        {
            var NewId = db.CreatePhoto(PersonGuid,value.Photo,value.IsActive);
            return (long)NewId.FirstOrDefault();
        }

        // PUT api/<controller>/5
        [HttpPut]
        public long UpdateItem(Models.Photos value)
        {
            var Id = db.UpdatePhoto(value.ID,value.Photo,value.IsActive);
            return (long)Id.FirstOrDefault();
        }



        // DELETE api/<controller>/5
        [HttpDelete]
        public long DeleteItem(long id)
        {
            var Id = db.DeletePhoto(id);
            return (long)Id.FirstOrDefault();
        }
    }
}