using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class AdvertTypesController : ApiController
    {
        //--------------------------------------------------DB--------------------------------------------------------------

        LTopDBEntities db = new LTopDBEntities();

        //--------------------------------------------------Get-------------------------------------------------------------

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

        //--------------------------------------------------Get/id-----------------------------------------------------------

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

        //--------------------------------------------------Create----------------------------------------------------------

        [HttpPost]
        public long CreateItem(Models.AdvertTypes item)
        {
            var NewId = db.CreateAdvertType(item.NameEng, item.NameRus, item.NameUkr, item.DescriptionEng, item.DescriptionRus, item.DescriptionUkr);
            return (long)NewId.FirstOrDefault();
        }

        //--------------------------------------------------Update---------------------------------------------------------

        [HttpPut]
        public long UpdateItem(Models.AdvertTypes item)
        {
            var result = db.UpdateAdvertType(item.ID, item.NameEng, item.NameRus, item.NameUkr, item.DescriptionEng, item.DescriptionRus, item.DescriptionUkr, item.IsActive);
            return item.ID;
        }

        //--------------------------------------------------Delete---------------------------------------------------------

        [HttpDelete]
        public long DeleteItem(Models.AdvertTypes item)
        {
            var result = db.DeleteAdvertType(item.ID);
            return item.ID;
        }
    }
}