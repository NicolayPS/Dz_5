using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №4 - Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].");
            Console.WriteLine("Определить количество нечетных положительных элементов, стоящих на четных местах.");
            Console.WriteLine("У вас 15 попыток, для продолжения нажмите любую кнопку");
            int o = 1;
            while (o < 16)
            {
                Console.ReadKey();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Попытка №{0} ", o);
                int[] array = new int[20]; Random random = new Random();
                Console.WriteLine("Исходный массив");
                int t = 0;
                int c = 0;
                for (int i = 0; i < 20; i++)
                {
                    array[i] = random.Next(-50, 51);
                    Console.Write("{0,2} ", array[i]);
                }
                Console.WriteLine();
                Console.Write("Нечетные положительные чисела на четных местах: ");
                for (int i = 1; i < 20; i=i+2)
                {
                    if (array[i] > 0 && array[i]%2!=0)
                    {
                        Console.Write("{0,2} ", array[i]);
                        t++;
                        c = t;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Количество положительных чисел = ");
                Console.WriteLine(c);
                o++;
                Console.WriteLine(" ");
                Console.WriteLine("Для продолжения нажмите любую кнопку");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Cпасибо!");
            Console.ReadKey();
        }
    }
}
