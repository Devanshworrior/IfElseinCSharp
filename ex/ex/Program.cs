using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age");
            string strage = Console.ReadLine();
            int age = Convert.ToInt32(strage);
            if (age > 18)
            {
                Console.WriteLine("To Make a driving licence");
            }
            else
            {
                Console.WriteLine("Do Not Make a driving licence");
            }
            Console.ReadLine();
        }

    }
}
