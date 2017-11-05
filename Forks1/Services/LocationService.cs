using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Forks1.Models;
using System.Data.Entity;

namespace Forks1.Services
{
    public class LocationService : ILocationService
    {
        private Forks1DB db = new Forks1DB();

        public List<LocationViewModel> GetAll()
        {
            var locationList = db.Locations.ToList();
            return locationList.Select(loc => LocDto(loc)).ToList();
        }

        private static LocationViewModel LocDto(Location loc)
        {
            return new LocationViewModel
            {
                LocationId = loc.LocationId,
                LocationName = loc.LocationName,
                Email = loc.Email,
                Phone = loc.Phone,
                Address = loc.Address,
                City = loc.City,
                State = loc.State,
                ZipCode = loc.ZipCode
            };

        }
    }
}