using LtopDesctopAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class DeviceCategoryController : ApiController
    {
        LTopDBEntities db = new LTopDBEntities();
        // GET api/<controller>
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

        // GET api/<controller>/5
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