using LtopDesctopAPI.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LtopDesctopAPI.Controllers.APIControllers
{
    public class PersonsController : ApiController
    {
        LTopDBEntities db = new LTopDBEntities();
        // GET api/<controller>
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

        // GET api/<controller>/5
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


        //POST api/<controller>/5
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
                item.Salt,
                item.IsActive,
                item.IsBlocked);
            return item.Guid;
        }

        //PUT api/<controller>/5
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



        // DELETE api/<controller>/5
        [HttpDelete]
        public Guid DeleteItem(Guid PersonGuid)
        {
            var Id = db.DeletePerson(PersonGuid);
            return PersonGuid;
        }
    }
}