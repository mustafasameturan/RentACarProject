using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Power : IEntity
    {
        public int PowerId { get; set; }
        public int BrandId { get; set; }
        public int CarId { get; set; }
        public string HorsePower { get; set; }
    }
}
