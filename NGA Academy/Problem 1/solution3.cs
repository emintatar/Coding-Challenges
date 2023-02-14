using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // İki sayının toplamını veren uygulamayı yazınız
            try
            {
                Console.Write("Number 1: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.Write("Number 2: ");
                int number2 = int.Parse(Console.ReadLine());
                int result = number1 + number2;
                Console.Write("Result: " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
