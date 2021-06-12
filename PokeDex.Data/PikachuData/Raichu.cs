using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex.Data.PikachuData
{
    public class Raichu:Pikachu
    {
        public bool EvolvedWithThunderStoneOutsideAlola { get; set; }
        public bool HasPsychicAbility
        {
            get
            {
                return (EvolvedWithThunderStoneOutsideAlola) ?false:true; 
            }
        }

        public void ThunderShok()
        {
            Console.WriteLine($"{Name} performed: T-H-U-N-D-E-R~~~~~Shock!");
        }

        public void LightScreen() 
        {
            if (HasPsychicAbility)
            {
                Console.WriteLine($"{Name} Performed: LightScreen!");
            }
            else
            {
                Console.WriteLine($"{Name}....This Pokemon doesn't have the ability to perform this attack!");
            }
        }

        public Raichu()
        {

        }

        public Raichu(bool evolvedWithThunderStoneOutsideAlola,int pokeDexID, string name, int nationalNumber, string type, string height, string weight, List<string> abilities)
            : base(pokeDexID,name,nationalNumber,type,height,weight,abilities)
        {
            EvolvedWithThunderStoneOutsideAlola = evolvedWithThunderStoneOutsideAlola;
        }

    }
}
