using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int i = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            while (a <= i)
            {
                Console.WriteLine("Последовательность чисел: " + a);
                a *= 2;
            }
        }
    }
}
