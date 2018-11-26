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
