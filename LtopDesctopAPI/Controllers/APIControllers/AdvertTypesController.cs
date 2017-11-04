using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class AdvertTypesController : ApiController
    {
        LTopDBEntities db = new LTopDBEntities();
        // GET api/<controller>
        [HttpGet]
        public List<Models.AdvertTypes> GetList()
        {
            return db.AdvertTypes.ToList().Select(item => new Models.AdvertTypes()
            {
                ID = item.ID,
                NameEng = item.NameEng,
                NameRus = item.NameRus,
                NameUkr = item.NameUkr,
                DescriptionEng = item.DescriptionEng,
                DescriptionRus = item.DescriptionRus,
                DescriptionUkr = item.DescriptionUkr,
                IsActive = item.IsActive
            }).ToList();
        }

        // GET api/<controller>/5
        [HttpGet]
        public Models.AdvertTypes GetItem(int id)
        {
            return db.AdvertTypes.Select(item => new Models.AdvertTypes()
            {
                ID = item.ID,
                NameEng = item.NameEng,
                NameRus = item.NameRus,
                NameUkr = item.NameUkr,
                DescriptionEng = item.DescriptionEng,
                DescriptionRus = item.DescriptionRus,
                DescriptionUkr = item.DescriptionUkr,
                IsActive = item.IsActive
            }).Where(item => item.ID == id).FirstOrDefault();
        }


        // POST api/<controller>/5
        [HttpPost]
        public long CreateItem(Models.AdvertTypes value)
        {
            var NewId = db.CreateAdvertType(value.NameEng, value.NameRus, value.NameUkr, value.DescriptionEng, value.DescriptionRus, value.DescriptionUkr);
            return (long)NewId.FirstOrDefault();
        }

        // PUT api/<controller>/5
        [HttpPut]
        public long UpdateItem(Models.AdvertTypes value)
        {
            var result = db.UpdateAdvertType(value.ID, value.NameEng, value.NameRus, value.NameUkr, value.DescriptionEng, value.DescriptionRus, value.DescriptionUkr, value.IsActive);
            return value.ID;
        }



        // DELETE api/<controller>/5
        [HttpDelete]
        public long DeleteItem(Models.AdvertTypes value)
        {
            var result = db.DeleteAdvertType(value.ID);
            return value.ID;
        }
    }
}