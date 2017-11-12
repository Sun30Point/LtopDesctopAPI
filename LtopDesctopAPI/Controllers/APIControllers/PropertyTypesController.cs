using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class PropertyTypesController : ApiController
    {
        //--------------------------------------------------DB--------------------------------------------------------------

        LTopDBEntities db = new LTopDBEntities();
        //--------------------------------------------------Get-------------------------------------------------------------
        [HttpGet]
        public List<Models.PropertyTypes> GetList()
        {
            return db.PropertyTypes.ToList().Select(item => new Models.PropertyTypes()
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
        public Models.PropertyTypes GetItem(int id)
        {
            return db.PropertyTypes.Select(item => new Models.PropertyTypes()
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
        public long CreateItem(Models.PropertyTypes value)
        {
            var NewId = db.CreatePropertyType(value.NameEng, value.NameRus, value.NameUkr, value.DescriptionEng, value.DescriptionRus, value.DescriptionUkr);
            return (long)NewId.FirstOrDefault();
        }

        //--------------------------------------------------Update---------------------------------------------------------
        [HttpPut]
        public long UpdateItem(Models.PropertyTypes value)
        {
            var result = db.UpdatePropertyType(value.ID, value.NameEng, value.NameRus, value.NameUkr, value.DescriptionEng, value.DescriptionRus, value.DescriptionUkr,value.IsActive);
            return value.ID;
        }


        //--------------------------------------------------Delete---------------------------------------------------------
        [HttpDelete]
        public long DeleteItem(Models.PropertyTypes value)
        {
            var result = db.DeletePropertyType(value.ID);
            return value.ID;
        }
    }
}