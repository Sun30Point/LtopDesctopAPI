using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class DeviceCategoryController : ApiController
    {
        //--------------------------------------------------DB--------------------------------------------------------------

        LTopDBEntities db = new LTopDBEntities();

        //--------------------------------------------------Get-------------------------------------------------------------

        [HttpGet]
        public List<Models.DeviceCategory> GetList()
        {
            return db.DeviceCategories.ToList().Select(item => new Models.DeviceCategory()
            {
                ID = item.ID,
                Type = item.Type,
                IsActive = item.IsActive
            }).ToList();
        }

        //--------------------------------------------------Get/id-----------------------------------------------------------

        [HttpGet]
        public Models.DeviceCategory GetItem(long id)
        {
            return db.DeviceCategories.Select(item => new Models.DeviceCategory()
            {
                ID = item.ID,
                Type = item.Type,
                IsActive = item.IsActive
            }).Where(item => item.ID == id).FirstOrDefault();
        }

    }
}