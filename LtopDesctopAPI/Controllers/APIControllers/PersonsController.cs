using LtopDesctopAPI.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class PersonsController : ApiController
    {
        //--------------------------------------------------DB--------------------------------------------------------------

        LTopDBEntities db = new LTopDBEntities();

        //--------------------------------------------------Get-------------------------------------------------------------

        [HttpGet]
        public List<Models.Persons> GetList()
        {
            return db.Persons.ToList().Select(item => new Models.Persons()
            {
                Guid = item.Guid,
                Name = item.Name,
                Email = item.Email,
                Phone = item.Phone,
                Skype = item.Skype,
                Password = item.Password,
                Salt = item.Salt,
                IsActive = item.IsActive,
                IsBlocked = item.IsBlocked
            }).ToList();
        }

        //--------------------------------------------------Get/id-----------------------------------------------------------

        [HttpGet]
        public Models.Persons GetItem(Guid PersonGuid)
        {
            return db.Persons.Select(item => new Models.Persons()
            {
                Guid = item.Guid,
                Name = item.Name,
                Email = item.Email,
                Phone = item.Phone,
                Skype = item.Skype,
                Password = item.Password,
                Salt = item.Salt,
                IsActive = item.IsActive,
                IsBlocked = item.IsBlocked
            }).Where(item => item.Guid == PersonGuid).FirstOrDefault();
        }


        //--------------------------------------------------Create----------------------------------------------------------

        [HttpPost]
        public Guid CreateItem(Models.Persons item)
        {
            item.Guid = Guid.NewGuid();
            db.CreatePerson(
                item.Guid,
                item.Name,
                item.Email,
                item.Phone,
                item.Skype,
                item.Password,
                item.Salt);
            return item.Guid;
        }

        //--------------------------------------------------Update---------------------------------------------------------

        [HttpPut]
        public Guid UpdateItem(Models.Persons item)
        {
            db.UpdatePerson(
                item.Guid,
                item.Name,
                item.Email,
                item.Phone,
                item.Skype,
                item.Password,
                item.Salt,
                item.IsActive,
                item.IsBlocked);
            return item.Guid;
        }

        //--------------------------------------------------Delete---------------------------------------------------------

        [HttpDelete]
        public Guid DeleteItem(Models.Persons item)
        {
            var result = db.DeletePerson(item.Guid);
            return item.Guid;
        }
    }
}