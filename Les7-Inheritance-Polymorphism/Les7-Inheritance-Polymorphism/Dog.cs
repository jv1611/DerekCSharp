using System;
using System.Collections.Generic;
using System.Text;

namespace Les7_Inheritance_Polymorphism
{
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "Grrrrr";

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        public Dog(string name = "No Name", 
            string sound = "No Sound", 
            string sound2 = "No Sound 2")
            :base(name, sound) // hiermee wordt name en sound uit de Animal-class gehaald
        {
            Sound2 = sound2;
        }
    }
}
