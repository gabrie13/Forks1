using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Forks1.Models;

namespace Forks1.Models
{
    public class Fork1DbSetInitializer : DropCreateDatabaseAlways<Forks1DB>
    {
        protected override void Seed(Forks1DB context)
        {
            base.Seed(context);
        }
    }
}