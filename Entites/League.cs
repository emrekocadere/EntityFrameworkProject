using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    internal class League
    { 
        public int Id { get; set; }
        public string name { get; set; }
        public Coach Coach { get; set; }
    }
}
