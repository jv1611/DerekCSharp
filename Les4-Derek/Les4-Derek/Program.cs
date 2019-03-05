using System;

namespace Les4_Derek
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = 5;
            //double y = 4;
            //Console.WriteLine("5 + 4 = {0}", 
            //    GetSum(x, y));

            //Console.WriteLine("x {0}", x);
            Console.WriteLine("6 + 7 = {0}", GetSum("6", "7"));

            //int solution;

            //DoubleIt(15, out solution);
            //Console.WriteLine("15 * 2 = {0}", solution);
            // pass by value hierboven

            // pass by reference
            //int num1 = 10;
            //int num2 = 20;
            //Console.WriteLine("Voor Swap num1 = {0}, num2 = {1}", num1, num2);
            //Swap(ref num1, ref num2);
            //Console.WriteLine("Na Swap num1 = {0}, num2 = {1}", num1, num2);

            // Params
            //Console.WriteLine("1 +2+3 = {0}",
            //    GetSumMore(1,2,3));

            // PrintInfo(zipCode: 15147, name: "Derek Banas");

            CarColor car1 = CarColor.Red;
            PaintCar(car1);

            Console.ReadLine();
        }

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("De auto kleur {0} met code {1}", cc, (int)cc);
        }

        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} woont in zip code {1}", name, zipCode);
        }

        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i; // hetzelfde als: sum = sum + i;
            }
            return sum;
        }

        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1; // pass by reference
            num1 = num2;
            num2 = temp;
        }

        static void DoubleIt(int x, out int solution)
        {
            solution = x *2; 
        }

        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x; // pass by value
            x = y;
            y = temp;
            return x + y;
        }

        // Hieronder Methode Overloading
        static double GetSum(string x="1", string y = "1")
        {   // Geen probleem met 2x GetSum, dit is string
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }
    }
}
