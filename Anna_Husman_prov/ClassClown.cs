using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Husman_prov
{
    class ClassClown : Supervillian
    {
        public int MaxDamage(int MaxDamage)
        {
            return gen.Next(60, 99);
        }
        public int MinDamage(int MinDamage)
        {
            return gen.Next(60, 99);
        }

    }
}
