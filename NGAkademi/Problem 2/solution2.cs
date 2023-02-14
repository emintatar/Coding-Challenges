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
            // Kullanıcının girdiği iki sayının karelerinin toplamını veren uygulamayı yazınız
            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = Convert.ToInt32(Math.Pow(num1, 2) + Math.Pow(num2, 2));
            Console.Write("Result: " + result);
        }
    }
}
