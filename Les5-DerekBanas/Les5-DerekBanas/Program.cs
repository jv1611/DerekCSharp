using System;

namespace Les5_DerekBanas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rect1;
            //rect1.length = 200;
            //rect1.width = 50;
            //Console.WriteLine("Area of rect1: {0}", rect1.Area());

            //Rectangle rect2 = new Rectangle(110, 40);
            //Console.WriteLine("Area of rectX: {0}", rect2.Area());

            // Classes
            // We hebben zojuist via Add de Class Animal.cs gemaakt
            //Animal fox = new Animal()
            //{
            //    name = "Red",
            //    sound = "Raaww"
            //};

            //fox.MakeSound();

            //Animal koe = new Animal("Berta", "Melken");

            //koe.MakeSound();

            //Console.WriteLine("# of Animals : {0}",
            //    Animal.GetNumAnimals());

            // Nu hebben we ShapeMath.cs gemaakt
            Console.WriteLine("Area of Rectangle: {0}", ShapeMath.GetArea("rectangle", 5, 6));
            // Rectangle in .GetArea moet hetzelfde geschreven zijn als in ShapeMath.cs!!!
            
            Console.ReadLine();
        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area() // = method
            {
                return length * width;
            }

        }
    }
}
