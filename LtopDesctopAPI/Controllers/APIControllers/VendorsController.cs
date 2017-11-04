using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class VendorsController : ApiController
    {
        LTopDBEntities db = new LTopDBEntities();
        // GET api/<controller>
        [HttpGet]
        public List<Models.Vendors> GetList()
        {
          return  db.Vendors.ToList().Select(item => new Models.Vendors()
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
        public Models.Vendors GetItem(int id)
        {
           return db.Vendors.Select(item => new Models.Vendors()
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
        public long CreateItem(Models.Vendors value)
        {
            var NewId = db.CreateVendors(value.NameEng,value.NameRus,value.NameUkr,value.DescriptionEng,value.DescriptionRus,value.DescriptionUkr);
            return (long)NewId.FirstOrDefault();
        }

        // PUT api/<controller>/5
        [HttpPut]
        public long UpdateItem(Models.Vendors value)
        {
            var result = db.UpdateVendors(value.ID, value.NameEng, value.NameRus, value.NameUkr, value.DescriptionEng, value.DescriptionRus, value.DescriptionUkr,value.IsActive);
            return value.ID;
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public long DeleteItem(Models.Vendors value)
        {
            var result = db.DeleteVendors(value.ID);
            return value.ID;
        }
    }
}