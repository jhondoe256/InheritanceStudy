using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex.Data
{
    //This is our 'Base' class.
    public class Pokemon
    {
        //we create our properties that represent our interpretation of what a pokemon should be
        public string Name { get; set; }
        public int NationalNumber { get; set; }
        public string Type { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public List<string> Abilities { get; set; }

        //we make our constructors....this one is empty
        public Pokemon()
        {

        }

        //we make our constructors....this one is full
        public Pokemon(string name, int nationalNumber, string type, string height, string weight, List<string> abilities)
        {
            Name = name;
            NationalNumber = nationalNumber;
            Type = type;
            Height = height;
            Weight = weight;
            Abilities = abilities;
        }

    }
}
