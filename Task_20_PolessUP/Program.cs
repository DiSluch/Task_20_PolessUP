using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());

            int counter = 1;

            for (int i = 3; i <= n; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) break;
                    if (j == i - 1) counter++;
                }
            }
            Console.WriteLine("Вывод:" +counter);
            Console.ReadKey();
        }
    }
}
