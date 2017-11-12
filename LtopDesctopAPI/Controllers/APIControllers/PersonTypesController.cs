using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class PersonTypesController : ApiController
    {
        //--------------------------------------------------DB--------------------------------------------------------------

        LTopDBEntities db = new LTopDBEntities();

        //--------------------------------------------------Get-------------------------------------------------------------

        [HttpGet]
        public List<Models.PersonTypes> GetList()
        {
            return db.PersonTypes.ToList().Select(item => new Models.PersonTypes()
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
        public Models.PersonTypes GetItem(int id)
        {
            return db.PersonTypes.Select(item => new Models.PersonTypes()
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
    }
}