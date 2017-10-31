using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class ModelsController : ApiController
    {
        LTopDBEntities db = new LTopDBEntities();
        // GET api/<controller>
        [HttpGet]
        public List<Models.Models> GetList()
        {
            return db.Models.ToList().Select(item => new Models.Models()
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
        public Models.Models GetItem(int id)
        {
            return db.Models.Select(item => new Models.Models()
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
        public long CreateItem(Models.Models value)
        {
            var NewId = db.CreateModel(value.NameEng, value.NameRus, value.NameUkr, value.DescriptionEng, value.DescriptionRus, value.DescriptionUkr,value.IsActive);
            return (long)NewId.FirstOrDefault();
        }

        // PUT api/<controller>/5
        [HttpPut]
        public long UpdateItem(Models.Models value)
        {
            var Id = db.UpdateModel(value.ID, value.NameEng, value.NameRus, value.NameUkr, value.DescriptionEng, value.DescriptionRus, value.DescriptionUkr,value.IsActive);
            return (long)Id.FirstOrDefault();
        }



        // DELETE api/<controller>/5
        [HttpDelete]
        public long DeleteItem(long id)
        {
            var Id = db.DeleteModel(id);
            return (long)Id.FirstOrDefault();
        }
    }
}