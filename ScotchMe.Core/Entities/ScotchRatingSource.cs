using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace ScotchMe.Entities
{
    public class ScotchRatingSource : Entity
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
