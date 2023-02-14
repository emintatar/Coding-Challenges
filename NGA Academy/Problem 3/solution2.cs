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
            int i = 1;
            while (i <= 10)
            {
                result += Convert.ToInt32(Math.Pow(i, 3));
                i++;
            }
            Console.WriteLine("Result: " + result);
        }
    }
}
