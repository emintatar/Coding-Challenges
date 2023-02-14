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
            // 1'den 10'a kadar olan sayıların küplerinin toplamını bulan programı yazınız

            int result = 0;

            for (int i = 1; i <= 10; i++)
            {
                result += Convert.ToInt32(Math.Pow(i, 3));
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
