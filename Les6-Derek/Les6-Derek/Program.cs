using System;

namespace Les6_Derek
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";

            Console.WriteLine("De kat heet {0} en {1} id= {2}", 
                cat.GetName(), cat.Sound, cat.idNum);

            Animal dog = new Animal("Gruff", "Woef");
            Console.WriteLine("De hond heet {0} en {1}", dog.GetName(), dog.Sound);

            dog.Owner = "Leila";
            Console.WriteLine("De hond heet {0} en {1} id={2}", 
                dog.GetName(), dog.Owner, dog.idNum);

            Console.ReadLine();
        }
    }
}
