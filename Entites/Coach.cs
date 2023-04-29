using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Coach 
    {
        public override string ToString()
        {
            return "ID: "+Id+" , Name: "+Name+" , Surname: "+Surname+" Team: "+Team.Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }


    }
}
