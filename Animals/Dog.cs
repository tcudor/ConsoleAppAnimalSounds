using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalSounds.Animals
{
    public class Dog : Animal
    {
        public override string Type => "Dog";
        public override string MakeSound() => "Ham";
    }
}
