using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Husman_prov
{
    class Superhero
    {
        public static Random Generator = new Random();

        public static int HpSuperHero;
        static public string name;

        public Superhero()
        {
            HpSuperHero = 200;
        }

        public int GetSuperHeroHp()
        {
            if(HpSuperHero < 0)
            {
                HpSuperHero = 0;
            }
            return HpSuperHero;

        }
        public void HurtSuperHero(int amount)
        {
            HpSuperHero -= amount;
        }
        public int Attack()
        {
            return Generator.Next(3, 101);
        }

    }
}
