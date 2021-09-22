using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = false;

            if (isTrue)
            {
                Console.WriteLine("I am in if condicion");
            }
            else
            {
                Console.WriteLine("I am in else condicion");
            }
            int age = 70;
            if (age < 18)
            {
                Console.WriteLine("Tu esi jaunietis");
            }
            else if (age >= 70)
            {
                Console.WriteLine("Tu esi senjors");
            }
            else
            {
                Console.WriteLine("Tu esi darbspējīgā vecumā");
            }


            int swichCase = 2;
            switch (swichCase)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("I do now what this was");
                    break;
            }
            string name = "Artis";
            switch (name)
            {
                case "a":
                    Console.WriteLine("Case 1");
                    break;
                case "b":
                    Console.WriteLine("Case 2");
                    break;
                case "Artis":
                    Console.WriteLine("Case 3");
                    break;
                case "ssss":
                    Console.WriteLine("Case 10");
                    break;
                default:
                    Console.WriteLine("I do now what this was");
                    break;
            }
        }
    }

}
