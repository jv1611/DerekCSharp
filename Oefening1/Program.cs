using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(int i=0; i<args.Length; i++)
            {
                Console.WriteLine("Argument {0} : {1}", i, args[i]);
            }

            string[] myArgum = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join(", ", myArgum));

            SayHello();

            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");
            Console.Write(newString);

            Console.ReadKey();
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What's your name? : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
    }
}
