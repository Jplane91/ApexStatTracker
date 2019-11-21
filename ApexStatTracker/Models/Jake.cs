using System;
using System.Collections.Generic;

namespace ApexStatTracker.Models
{
    public partial class Jake
    {
        public int GameNumber { get; set; }
        public int Damage { get; set; }
        public int Kills { get; set; }
        public int Revives { get; set; }
        public int Respawns { get; set; }
        public int Revived { get; set; }
        public double GameScore { get; set; }
    }
}
