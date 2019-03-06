using System;

namespace Les5_DerekBanas
{
    class Animal
    {
        public string name;
        public string sound;

        public Animal()
        {
            name = "No Name"; 
            sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name")
        { // gegevens zijn hier niet echt nodig er is al een default hierboven
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name= "No Name", string sound = "No Sound")
        { // gegevens zijn hier niet echt nodig er is al een default hierboven
            this.sound = sound;
            this.name = name;
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        static int numOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }

    }
}
