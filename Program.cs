using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 22. Найдите сумму чисел, кратных 5, в диапазоне от 5 до 60 */

namespace Lab_3_1_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 5; i <= 60; i++)            
                if (i % 5 == 0)                
                    sum += i;
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
