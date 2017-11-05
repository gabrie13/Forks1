using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Forks1.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        public string PositionName { get; set; }
    }
}