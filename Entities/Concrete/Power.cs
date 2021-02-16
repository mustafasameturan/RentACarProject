using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Power : IEntity
    {
        public string PowerId { get; set; }
        public int BrandId { get; set; }
        public int HorsePower { get; set; }
    }
}
