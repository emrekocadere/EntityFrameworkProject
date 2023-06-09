﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Team
    {
        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; }
        public Coach Coach { get; set; }
    }
}
