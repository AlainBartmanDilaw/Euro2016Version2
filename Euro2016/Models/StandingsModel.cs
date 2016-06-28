using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Euro2016.EntityFramework;

namespace Euro2016.Models
{
    public class Standings
    {
        public List<Pool> Pools { get; set; }
        public List<FullUserStanding> FullUserStandings { get; set; }
    }
}