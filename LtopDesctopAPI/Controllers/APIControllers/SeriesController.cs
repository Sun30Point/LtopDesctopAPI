using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class SeriesController : ApiController
    {
        //--------------------------------------------------DB--------------------------------------------------------------

        LTopDBEntities db = new LTopDBEntities();

        //--------------------------------------------------Get-------------------------------------------------------------
        [HttpGet]
        public List<Models.Series> GetList()
        {
            return db.Series.ToList().Select(item => new Models.Series()
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
        public  Models.Series GetItem(int id)
        {
            return db. Series.Select(item => new  Models.Series()
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
        public long CreateItem(Models.Series item)
        {
            var NewId = db.CreateSeries(item.NameEng, item.NameRus, item.NameUkr, item.DescriptionEng, item.DescriptionRus, item.DescriptionUkr);
            return (long)NewId.FirstOrDefault();
        }

        //--------------------------------------------------Update---------------------------------------------------------
        [HttpPut]
        public long UpdateItem( Models.Series item)
        {
            var result = db.UpdateSeries(item.ID, item.NameEng, item.NameRus, item.NameUkr, item.DescriptionEng, item.DescriptionRus, item.DescriptionUkr,item.IsActive);
            return item.ID;
        }



        //--------------------------------------------------Delete---------------------------------------------------------
        [HttpDelete]
        public long DeleteItem(Models.Series item)
        {
            var result = db.DeleteSeries(item.ID);
            return item.ID;
        }
    }
}