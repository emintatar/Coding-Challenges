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
            Console.WriteLine("Number 1 and Number 2: ");
            int result = Convert.ToInt32(Math.Pow(Convert.ToInt32(Console.ReadLine()), 2) + Math.Pow(Convert.ToInt32(Console.ReadLine()), 2));
            Console.WriteLine("Result: " + result);
          
        }
    }
}
