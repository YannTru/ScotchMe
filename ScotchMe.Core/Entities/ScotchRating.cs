using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace ScotchMe.Entities
{
    public class ScotchRating : Entity
    {
        [ForeignKey("ScotchId")]
        public int ScotchId { get; set; }
        public Scotch Scotch { get; set; }

        public float Rating { get; set; }

        [ForeignKey("ScotchRatingSourceId")]
        public int ScotchRatingSourceId { get; set; }
        public ScotchRatingSource ScotchRatingSource { get; set; }
    }
}
