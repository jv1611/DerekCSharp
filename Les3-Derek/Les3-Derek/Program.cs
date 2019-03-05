using System;

namespace Les3_Derek
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age = 15;
            //bool canDrive = age >= 16 ? true : false;

            //switch (age)
            //{
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Go to Day Care");
            //        break; // break om uit switch-statement te komen
            //    case 3:
            //    case 4:
            //        Console.WriteLine("Go to Preschool");
            //        break;
            //    case 5:
            //        Console.WriteLine("Go to Kindergarten");
            //        break;
            //    default:
            //        Console.WriteLine("Go to another school");
            //        goto OtherSchool; // maak hieronder

            //}

            //OtherSchool:
            //Console.WriteLine("Basis, Voortgezet");

            //string name = "Derek";
            //string name2 = "Derek";

            //if(name.Equals(name2, StringComparison.Ordinal))
            //{
            //    Console.WriteLine("Namen zijn hetzelfde");
            //}

            int i = 1;

            while(i <= 10)
            {
                if(i % 4 == 0)
                {
                    i++;
                    continue; // Hiermee spring ik terug naar de while-loop
                }
                if (i == 9) break;
                Console.WriteLine(i);
                i++;
            }

            //Random rnd = new Random();
            //int secretNumber = rnd.Next(1, 11); // tussen 1 en 11
            //int numberGuessed = 0;

            //do
            //{
            //    Console.WriteLine("Enter nr tussen 1 en 10: ");
            //    numberGuessed = Convert.ToInt32(Console.ReadLine());
            //} while (secretNumber != numberGuessed);
            //if (secretNumber == numberGuessed)
            //{
            //    Console.WriteLine("Goed geraden!");
            //}

            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Delen door nul kan niet");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("De 'finally' function ruimt op wordt altijd uitgevoerd");
            }

            Console.ReadLine();
        }

        static double DoDivision(double x, double y)
        {
            if(y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
            
        }
    }
}
