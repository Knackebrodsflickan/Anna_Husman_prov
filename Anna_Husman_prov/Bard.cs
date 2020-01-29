using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Husman_prov
{
    class Bard : Superhero
    {
       public int MaxDamage(int MaxDamage)
        {
            return Generator.Next(50, 100); 
        }
        public int MinDamage(int MinDamage)
        {
            return Generator.Next(5, 49);
        }
        
        

    }
}
