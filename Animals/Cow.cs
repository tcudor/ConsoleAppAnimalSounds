using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalSounds.Animals
{
    public class Cow : Animal
    {
        public override string Type => "Cow";
        public override string MakeSound() => "Moo";
    }
}
