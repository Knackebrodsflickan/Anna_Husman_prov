using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Husman_prov
{
    class Supervillian 
    {
        public static Random gen = new Random();

        public static int HpSuperVillian;
        static public string name;

        public Supervillian()
        {
            HpSuperVillian = 200;
        }

        public int GetVillianHp()
        {
            if(HpSuperVillian < 0)
            {
                HpSuperVillian = 0;
            }
            return HpSuperVillian;
        }

        public void HurtSuperHero(int amount)
        {
            HpSuperVillian -= amount;
        }

        public int Attack()
        {
            return gen.Next(5, 100);
        }

    }
}
