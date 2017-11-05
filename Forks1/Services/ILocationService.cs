using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forks1.Models;
using System.Data.Entity;

namespace Forks1.Services
{
    interface ILocationService
    {
        List<LocationViewModel> GetAll();
    }
}
