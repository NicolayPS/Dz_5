using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №2 -  Сформировать одномерный массив из 15 элементов, которые выбираются ");
            Console.WriteLine("случайным образом из диапазона [0; 50]. Определить сумму максимального и минимального ");
            Console.WriteLine("элементов массива.");
            Console.WriteLine(" ");
            Console.WriteLine("У вас 15 попыток , для продолжение нажмите любую кнопку");
            int o = 1;
            int s = 0;
            while (o < 16)
            {
                Console.ReadKey();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("{0} попытка ", o);
                int[] array = new int[15]; Random random = new Random();
                for (int i = 0; i < 15; i++)
                {
                    array[i] = random.Next(0, 51);
                    Console.Write("{0} ", array[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < (14); i++)
                {
                    for (int j = i + 1; j < 15; j++)
                    {
                        if (array[i] > array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < 15; i++)
                {
                    Console.Write("{0} ", array[i]);
                }
                s = array[0] + array[14];
                Console.WriteLine(" ");
                Console.WriteLine("Сумма max + min ={0} ",s);
                o++;
                Console.WriteLine("Для продолжение нажмите любую кнопку");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Cпасибо!");
            Console.ReadKey();
        }
    }
}
