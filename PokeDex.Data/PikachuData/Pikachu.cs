using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex.Data.PikachuData
{
    public class Pikachu:Pokemon
    {
        public int PokeDexID { get; set; }
        public bool OwnerHasThunderStone { get; set; }// this helps pikachu turn into Raichu

        public void QuickAttack()
        {
            Console.WriteLine($"{Name} Attack: Quick Attack");
        }

        public void Slam()
        {
            Console.WriteLine($"{Name} Attack: I Slamed You!!!");
        }

        public Pikachu()
        {

        }

        public Pikachu(int pokeDexID, bool ownerHasThunderStone, string name, int nationalNumber, string type, string height, string weight, List<string> abilities)
            :base(name,nationalNumber,type,height,weight,abilities)
        {
            PokeDexID = pokeDexID;
            OwnerHasThunderStone = ownerHasThunderStone;
        }


        public Pikachu(int pokeDexID, string name, int nationalNumber, string type, string height, string weight, List<string> abilities)
          : base(name, nationalNumber, type, height, weight, abilities)
        {
            PokeDexID = pokeDexID;
            
        }
    }
}
