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
            // Doğum tarihi girilen kişinin yaşını hesaplayan program

            Console.Write("Birth Date: ");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
            DateTime currentDate = DateTime.Now;
            TimeSpan result = currentDate - birthDate;
            int age = Convert.ToInt32(result.Days / 365);
            Console.WriteLine("Age: " + age);
        }
    }
}
