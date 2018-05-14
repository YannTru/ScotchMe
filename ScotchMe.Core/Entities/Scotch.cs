using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace ScotchMe.Entities
{
    public class Scotch : Entity
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public float Abv { get; set; }
        public int? Age { get; set; }
    }
}
