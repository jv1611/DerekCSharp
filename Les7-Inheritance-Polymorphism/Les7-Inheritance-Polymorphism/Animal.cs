using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les7_Inheritance_Polymorphism
{
    class Animal
    {
        private string name;
        protected string sound; // Kan gewijzigd worden door subclass

        protected AnimalIdInfo animalIdInfo = new AnimalIdInfo();
        // Deze AnimalIdInfo verwijst naar AnimalIdInfo.cs, haalt gegevens op.

        public void SetAnimalIdInfo(int idNum, string owner)
        {
            animalIdInfo.IdNum = idNum;
            animalIdInfo.Owner = owner;
        }

        public void GetAnimalIdInfo()
        {
            Console.WriteLine($"{Name} had the ID of {animalIdInfo.IdNum} " +
                $"and is owned by {animalIdInfo.Owner}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{name} says {sound}");
            // Door $ kunnen we meteen gebruik maken van Name en Sound ipv {0} en {1}, name, sound
        }

        public Animal()
            :this("No Name", "No Sound") { }

        public Animal(string name)
            :this(name, "No Sound"){ }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                }
                sound = value;
            }
        }

        public class AnimalHealth // Dit is een InnerClass
        {
            public bool HealthyWeigth(double heigth, double weigth)
            {
                double calc = heigth / weigth;
                if ((calc >= 0.18) && (calc <= 0.27))
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
