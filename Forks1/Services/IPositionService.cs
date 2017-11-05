﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Forks1.Models;

namespace Forks1.Services
{
    interface IPositionService
    {
        List<PositionViewModel> GetAll();
        PositionViewModel FindById(int id);
        PositionViewModel Create(PositionViewModel position);
        PositionViewModel Save(PositionViewModel position);
        void Delete(int id);
        void Dispose();
    }
}
