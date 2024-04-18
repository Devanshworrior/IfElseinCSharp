using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseinCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. if else
            Console.WriteLine("Enter Your Age : ");
            string strage = Console.ReadLine();
            int age = Convert.ToInt32(strage);
            if (age < 2)
            {
                Console.WriteLine("You are just born");
            }
            else if (age < 10)
                    {
                Console.WriteLine("Please finish your high school ");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are below 18");
            }
            else if (age < 75)
            {
                Console.WriteLine("Drive a car");
            }
            else
            {
                Console.WriteLine("You Cannot Drive a Car.");
            }

            //2. Switch case
            string car = Console.ReadLine();
            int amanage = Convert.ToInt32(car);
            switch (amanage)
            {
                case 18:
                    {
                        Console.WriteLine("Drive a car");
                        break;
                    }
                case 28:
                    {
                        Console.WriteLine("Motor");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enjoy");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
