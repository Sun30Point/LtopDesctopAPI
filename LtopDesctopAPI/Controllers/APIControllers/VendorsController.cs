using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class VendorsController : ApiController
    {
        //--------------------------------------------------DB--------------------------------------------------------------

        LTopDBEntities db = new LTopDBEntities();

        //--------------------------------------------------Get-------------------------------------------------------------

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

        //--------------------------------------------------Get/id-----------------------------------------------------------

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

        //--------------------------------------------------Create----------------------------------------------------------

        [HttpPost]
        public long CreateItem(Models.Vendors item)
        {
            var NewId = db.CreateVendors(item.NameEng,item.NameRus,item.NameUkr,item.DescriptionEng,item.DescriptionRus,item.DescriptionUkr);
            return (long)NewId.FirstOrDefault();
        }

        //--------------------------------------------------Update---------------------------------------------------------

        [HttpPut]
        public long UpdateItem(Models.Vendors item)
        {
            var result = db.UpdateVendors(item.ID, item.NameEng, item.NameRus, item.NameUkr, item.DescriptionEng, item.DescriptionRus, item.DescriptionUkr,item.IsActive);
            return item.ID;
        }

        //--------------------------------------------------Delete---------------------------------------------------------

        [HttpDelete]
        public long DeleteItem(Models.Vendors item)
        {
            var result = db.DeleteVendors(item.ID);
            return item.ID;
        }
    }
}