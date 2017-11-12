using LtopDesctopAPI.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class AdvertsController : ApiController
    {
        //--------------------------------------------------DB--------------------------------------------------------------

        LTopDBEntities db = new LTopDBEntities();

        //--------------------------------------------------Get-------------------------------------------------------------

        [HttpGet]
        public List<Models.Adverts> GetList()
        {
            return db.Adverts.Select(item => new Models.Adverts()
            {
                ID = item.ID,
                DescriptionEng = item.DescriptionEng,
                DescriptionRus = item.DescriptionRus,
                DescriptionUkr = item.DescriptionUkr,
                IsActive = item.IsActive,
                PersonGuid = item.PersonsToAdverts.FirstOrDefault().Person.Guid,
                AdvertTypeID = item.AdvertsToAdvertTypes.FirstOrDefault().AdvertType.ID,
                DeviceID = item.AdvertsToDevices.FirstOrDefault().Device.ID
            }).ToList();
        }

        //--------------------------------------------------GetList/PersonGuid,DeviceCategoryId------------------------------

        [HttpGet]
        public List<Models.Adverts> GetList(string PersonGuid, int DeviceCategoryId)
        {
            Guid Person1 = Guid.Parse(PersonGuid??"00000000-0000-0000-0000-000000000000");
            if (Person1 != Guid.Empty)
            {
                return db.Adverts.Select(item => new Models.Adverts()
                {
                    ID = item.ID,
                    DescriptionEng = item.DescriptionEng,
                    DescriptionRus = item.DescriptionRus,
                    DescriptionUkr = item.DescriptionUkr,
                    IsActive = item.IsActive,
                    PersonGuid = item.PersonsToAdverts.FirstOrDefault().Person.Guid,
                    AdvertTypeID = item.AdvertsToAdvertTypes.FirstOrDefault().AdvertType.ID,
                    DeviceID = item.AdvertsToDevices.FirstOrDefault().Device.ID
                }).Where(item => item.PersonGuid == Person1).ToList();
            }
            else if (DeviceCategoryId > 0)
            {
                return db.Adverts.Select(item => new Models.Adverts()
                {
                    ID = item.ID,
                    DescriptionEng = item.DescriptionEng,
                    DescriptionRus = item.DescriptionRus,
                    DescriptionUkr = item.DescriptionUkr,
                    IsActive = item.IsActive,
                    PersonGuid = item.PersonsToAdverts.FirstOrDefault().Person.Guid,
                    AdvertTypeID = item.AdvertsToAdvertTypes.FirstOrDefault().AdvertType.ID,
                    DeviceID = item.AdvertsToDevices.FirstOrDefault().Device.ID,
                    DeviceCategoryId = item.AdvertsToDevices.FirstOrDefault().Device.DeviceCategory.ID
                }).Where(item => item.DeviceCategoryId == DeviceCategoryId).ToList();
            }
            return null;
        }

        //--------------------------------------------------Get/id-----------------------------------------------------------

        [HttpGet]
        public Models.Adverts GetItem(long id)
        {
            return db.Adverts.Select(item => new Models.Adverts()
            {
                ID = item.ID,
                DescriptionEng = item.DescriptionEng,
                DescriptionRus = item.DescriptionRus,
                DescriptionUkr = item.DescriptionUkr,
                IsActive = item.IsActive,
                PersonGuid = item.PersonsToAdverts.FirstOrDefault().Person.Guid,
                AdvertTypeID = item.AdvertsToAdvertTypes.FirstOrDefault().AdvertType.ID,
                DeviceID = item.AdvertsToDevices.FirstOrDefault().Device.ID,
                DeviceCategoryId = item.AdvertsToDevices.FirstOrDefault().Device.DeviceCategory.ID
            }).Where(item => item.ID == id).FirstOrDefault();
        }

        //--------------------------------------------------Create----------------------------------------------------------
      
        [HttpPost]
        public long? CreateItem(Models.Adverts item)
        {
            var result = db.CreateAdverts(item.PersonGuid, item.DescriptionEng, item.DescriptionRus, item.DescriptionUkr, item.AdvertTypeID, item.DeviceID).FirstOrDefault();

            return result;
        }

        //--------------------------------------------------Update---------------------------------------------------------
       
        [HttpPut]
        public long? UpdateItem(Models.Adverts item)
        {
            var result = db.UpdateAdverts(item.PersonGuid,item.ID, item.DescriptionEng, item.DescriptionRus, item.DescriptionUkr, item.IsActive,item.AdvertTypeID,item.DeviceID).FirstOrDefault();

            return result;
        }

        //--------------------------------------------------Delete---------------------------------------------------------

        [HttpDelete]
        public long DeleteItem(Models.Adverts item)
        {
            var result = db.DeleteAdverts(item.ID);
            return item.ID;
        }
    }
}