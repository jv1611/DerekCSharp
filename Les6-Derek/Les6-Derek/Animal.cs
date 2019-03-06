using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les6_Derek
{
    class Animal
    {
        private string name;
        private string sound;

        public const string Shelter = "Een huis voor Dieren";
        // const is niet te wijzigen

        public readonly int idNum;
        // readonly creeerd on the fly en is niet te wijzigen

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1} ", name, sound);
        }

        public Animal()
            :this("No Name", "No Sound") { }

        public Animal(string name)
            :this(name, "No Sound") { }

        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;

            NumOfAnimals = 1;
            Random rnd = new Random();
            idNum = rnd.Next(1, 2147483640); // nr tussen 1 en 2147483640
        }

        public void SetName(string name) // Setter
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            } else
            {
                this.name = "No name";
                Console.WriteLine("Geen cijfers in naam");
            }
        }

        public string GetName() // Getter
        {
            return name;
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if(value.Length > 10)
                {
                    sound = "Niet goed";
                    Console.WriteLine("Geluid is te lang");
                }
                sound = value;
            }
        }

        public string Owner { get; set; } = "No Owner";

        public static int numOfAnimals = 0;

        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }
    }
}
