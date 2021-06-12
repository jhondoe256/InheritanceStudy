using PokeDex.Data;
using PokeDex.Data.CharmanderData;
using PokeDex.Data.PikachuData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex
{
    class Program
    {
        static void Main(string[] args)
        {
            //I will create a pokemon (from the base class to show all of the properties w/n a pokemon object) Make this abstract in the end...
            var pokemon = new Pokemon();

            //I can use the (.) opperator to access the properties and methods that are public and associated to the Pokemon class....
            //The wreches represent the properties
            //The Purple wireframe 3d boxes represent the Methods
            pokemon.Name = "benny";
            pokemon.Abilities = new List<string>() { "fire","ice"};
            pokemon.Height = "2ft";

            //now we want to utilize Inheritance to Create a Charizard object....
            //show how the charmander obj has the pokemon properties with the . operator...
            Charmander charmander = new Charmander(true,"Char-char",37,"Fire-lizzard","2ft","50lbs",new List<string> {"Blaze","Solar Power"});
            charmander.FireBlitz();
            charmander.Growl();

            Console.WriteLine();

            Pikachu pikachu = new Pikachu(1135,"Chewy-chew-chu",1,"Eletric-rodent","1ft","25lbs",new List<string> {"Eletric"});
            pikachu.QuickAttack();
            pikachu.Slam();

            
            Console.WriteLine();


            Raichu raichu = new Raichu(false, 2, "Rai-01", 1135, "Eletric-rodent", "2.5ft", "30lbs", new List<string> { "Eletric", "Lighting Rod" });
            raichu.Slam();
            raichu.QuickAttack();
            raichu.ThunderShok();
            raichu.LightScreen();


            Console.WriteLine();


            Raichu raichu2 = new Raichu(true, 3, "Rai-02", 178, "Eletric-rodent", "2.5ft", "20lbs", new List<string> { "Eletric", "Lighting Rod" });
            raichu2.Slam();
            raichu2.QuickAttack();
            raichu2.ThunderShok();
            raichu2.LightScreen();



            Console.ReadKey();
        }
    }
}
