using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Player 
    {
        public override string ToString()
        {
            return "Id: "+Id+" Name: "+Name+" Surname: "+Surname+" Team: "+Team;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }  
    }
}
