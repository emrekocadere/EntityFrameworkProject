using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class League 
    { 
        public int Id { get; set; }
        public string name { get; set; }
        public List<Team>Teams { get; set; }
    }
}
