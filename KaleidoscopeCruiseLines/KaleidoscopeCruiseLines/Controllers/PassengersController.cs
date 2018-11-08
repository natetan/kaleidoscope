using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KaleidoscopeCruiseLines.Services;
using Newtonsoft.Json;

namespace KaleidoscopeCruiseLines.Controllers
{
    public class PassengersController : ApiController
    {
        private PassengerService pService = new PassengerService();

        //public PassengersController(PassengerService service)
        //{
        //    pService = service;
        //}

        // GET api/passengers
        public IEnumerable<Passengers> Get() //async Task<IHttpActionResult> IEnumerable<Passengers> Get()
        {
            var results = pService.getListOfPassengers();
            //return Ok(results);
            return results;
        }

        // GET api/passengers/{id}
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
