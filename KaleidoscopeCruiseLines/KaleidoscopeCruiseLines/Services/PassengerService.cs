using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaleidoscopeCruiseLines.Services
{
    public interface IPassengerService
    {
        List<Passengers> getListOfPassengers();
    }

    public class PassengerService : IPassengerService
    {
        private DatabaseContext dbContext;

        public PassengerService()
        {
            dbContext = new DatabaseContext();
        }

        public List<Passengers> getListOfPassengers()
        {
            var results = dbContext.Passengers.ToList();
            return results;
        }
    }
}