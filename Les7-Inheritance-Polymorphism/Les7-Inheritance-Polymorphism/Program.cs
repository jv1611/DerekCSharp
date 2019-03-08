using System;

namespace Les7_Inheritance_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woef",
                Sound2 = "Blaf"
            };

            grover.Sound = "Wooooof";
            whiskers.MakeSound(); // MakeSound is een functie met CW
            grover.MakeSound();

            whiskers.SetAnimalIdInfo(123, "Sally");
            grover.SetAnimalIdInfo(1234, "Derek");

            whiskers.GetAnimalIdInfo();
            grover.GetAnimalIdInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine("Is my animal healthy? {0}", getHealth.HealthyWeigth(11, 46));

            Animal monkey = new Animal()
            {
                Name = "Appie",
                Sound = "Ieeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Woeef",
                Sound2 = "Grommmm"
            };

            monkey.MakeSound();
            spot.MakeSound();

            Console.ReadLine();
        }
    }
}
