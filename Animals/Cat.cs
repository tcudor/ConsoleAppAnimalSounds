﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalSounds.Animals
{
    public class Cat : Animal
    {
        public override string Type => "Cat";
        public override string MakeSound() => "Miau";
    }
}
