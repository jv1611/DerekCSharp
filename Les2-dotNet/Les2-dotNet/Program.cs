using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Les2_dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] favNums = new int[3];

            favNums[0] = 23;

            Console.WriteLine("favNums 0 : {0}", favNums[0]);
            Console.WriteLine("Waarom krijg ik steeds maar enkele aanhalingstekens");

            string[] customers = { "Bob", "Ikke", "en de rest" };

            var employees = new[] { "Mike", "Kees", "Jan" };

            Console.WriteLine( customers[0] + employees[1]);

            object[] randomArray = { "Paul", 1234, 3.1428 };
            Console.WriteLine("randomArray 0 : {0}", randomArray[2].GetType());
            Console.WriteLine("randomArray 0 : {0}", randomArray.Length);

            for(int i= 0; i<randomArray.Length; i++)
            {
                Console.WriteLine("Array {0} : Value {1}", i, randomArray[i]);
            }

            string[,] custNames = new string[2, 2]
            {
                {"Bob", "Koen" },
                {"Anna", "Truus" }
            };

            Console.WriteLine("Waarde multi data: {0}", custNames.GetValue(1,1));

            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int j=0; j < custNames.GetLength(1); j++)
                {
                    Console.Write("{0} ", custNames[i,j]);
                    Console.Write(custNames[i,j]);
                }
                Console.WriteLine();
            }

            int[] randNums = { 1, 3, 9, 2 };
            PrintArray(randNums, "ForEach");
            Console.WriteLine("9 at Index: {0}", Array.IndexOf(randNums, 9));
            Console.WriteLine();

            Array.Sort(randNums);
            PrintArray(randNums, "Sorted");
            Console.WriteLine("9 at Index: {0}", Array.IndexOf(randNums, 9));
            Console.WriteLine();

            randNums.SetValue(0, 1);

            Array.Reverse(randNums);
            PrintArray(randNums, "Reverse");
            Console.WriteLine("9 at Index: {0}", Array.IndexOf(randNums, 9));
            Console.WriteLine();

            int[] srcArray = { 11, 22, 33 };
            int[] destArray = new int[5]; // 5 geeft grote destArray
            int startInd = 1; // Start niet op index 0, maar op 1
            int length = 2; // Hoeveel moeten er gekopieerd worden? 2

            Array.Copy(srcArray, startInd, destArray, startInd, length);

            PrintArray(destArray, "Kopie"); // Blijkbaar moet ik tekst toevoegen.

            Array anotherArray = Array.CreateInstance(typeof(int), 10);// Er worden 10 int gemaakt
            srcArray.CopyTo(anotherArray, 4); // start op index 4 = positie 5

            foreach(int m in anotherArray)
            {
                Console.WriteLine("CopyTo: {0}", m);
            } // Nu worden alle 10 int in anotherArray geprint

            int[] numArray = { 1, 11, 22 };
            Console.WriteLine(">10: {0}", Array.Find(numArray, GT10));
            // Er is ook nog FindAll en FindIndex

            Console.ReadKey();
        }

        static void PrintArray(int[] intArray, string mess)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }

        private static bool GT10(int val)
        {
            return val > 10; // Nu kunnen we GT10 hierboven gebruiken
        }
    }
}
