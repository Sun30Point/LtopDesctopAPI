using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class ModelsController : ApiController
    {
        //--------------------------------------------------DB--------------------------------------------------------------

        LTopDBEntities db = new LTopDBEntities();

        //--------------------------------------------------Get-------------------------------------------------------------

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

        //--------------------------------------------------Get/id-----------------------------------------------------------

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


        //--------------------------------------------------Create----------------------------------------------------------

        [HttpPost]
        public long CreateItem(Models.Models item)
        {
            var NewId = db.CreateModel(item.NameEng, item.NameRus, item.NameUkr, item.DescriptionEng, item.DescriptionRus, item.DescriptionUkr);
            return (long)NewId.FirstOrDefault();
        }

        //--------------------------------------------------Update---------------------------------------------------------

        [HttpPut]
        public long UpdateItem(Models.Models item)
        {
            var result = db.UpdateModel(item.ID, item.NameEng, item.NameRus, item.NameUkr, item.DescriptionEng, item.DescriptionRus, item.DescriptionUkr,item.IsActive);
            return item.ID;
        }

        //--------------------------------------------------Delete---------------------------------------------------------

        [HttpDelete]
        public long DeleteItem(Models.Models item)
        {
            var result = db.DeleteModel(item.ID);
            return item.ID;
        }
    }
}