using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Husman_prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the game: My Superhero Academy. Please, Choose a character and a name!");
            Console.ReadKey();

            Console.WriteLine("Choose nr 1 or 2");
            String PickCharacter = Console.ReadLine();

            if(PickCharacter != "1" && PickCharacter != "2")
            {
                Console.WriteLine("Im sorry, please pick one of the Options");
                Console.ReadKey();
            }
            else if(PickCharacter == "1" || PickCharacter == "2")
            {
                Console.WriteLine("Good Choice! You decided: " + PickCharacter);
                Console.ReadKey();
            }
            Console.WriteLine("Please choose a name for your character");
            Console.ReadLine();
            string Name = Console.ReadLine();

            Console.WriteLine("Your name is: " + Name);

            Supervillian ClassClown = new Supervillian();
            Superhero Bard = new Superhero();






            List<string> TerriblePoems = new List<string>();

            TerriblePoems.Add("Toss A coin To your witcher: the ripp of version");


        }
    }
}
