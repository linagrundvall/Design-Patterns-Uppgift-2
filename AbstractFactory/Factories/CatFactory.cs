﻿using Assignment2.AbstractFactory.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Factories
{
    internal class CatFactory : IFactory
    {
        public ICat CreateAnimal()
        {
            return new Cat();
        }
    }
}
