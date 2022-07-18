using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1 ");
            Console.WriteLine("Сформировать одномерный массив из 7 элементов. ");
            Console.WriteLine("Заполнить массив числами, вводимыми с клавиатуры,");
            Console.WriteLine("определить среднее арифметическое элементов.");
            Console.WriteLine(" ");
            Console.WriteLine("У вас 15 попыток");
            int o = 0;
            while (o < 15)
            {
                int[] array = new int[7];
                int s = 0;
                int k = 0;
                Console.WriteLine("Введите 7 чисел:");
                for (int i = 0; i < 7; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    s += array[i];
                    k++;
                }
                Console.WriteLine("Среднее арифмитическое чисел");
                Console.WriteLine(((double)s) / k);
            }
            Console.WriteLine("Cпасибо!");
            Console.ReadKey();
        }
    }
}