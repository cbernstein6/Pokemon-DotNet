using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public class GymBadge
    {
        public int GymBadgeId { get; set; }
        public string BadgeName { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}