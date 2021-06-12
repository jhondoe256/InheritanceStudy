using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex.Data.CharmanderData
{
    //Charmander will Inherit from the Pokemon base class....
    public class Charmander : Pokemon
    {
        public bool IsDeClawed { get; set; }


        public Charmander()
        {

        }

        public Charmander(bool isDeClawed,string name, int nationalNumber, string type, string height, string weight, List<string> abilities)
            :base(name,nationalNumber,type,height,weight,abilities)
        {
            IsDeClawed = isDeClawed;
        }


        public void Growl() 
        {
            Console.WriteLine("Charmander Attack: Growl!");
        }

        public void FireBlitz()
        {
            Console.WriteLine("Charmander Attack: Fire is upon you!");
        }
    }
}
