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
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = (num1 * num1) + (num2 * num2);
            Console.Write("Result: " + result);
        }
    }
}
