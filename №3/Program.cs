using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №3 Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]");
            Console.WriteLine("Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.");
            Console.WriteLine("У вас 15 попыток, для продолжения нажмите любую кнопку");
            int o = 1;
            while (o < 16)
            {
                Console.ReadKey();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("{0} попытка ", o);
                int[] array = new int[10]; Random random = new Random();
                Console.WriteLine("Исходный массив");
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(-50, 51);
                    Console.Write("{0,4} ", array[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = i + 1; j < 5; j++)
                    {
                        if (array[i] > array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }
                for (int i = 5; i < 10; i++)
                {
                    for (int j = i + 1; j < 10; j++)
                    {
                        if (array[j] > array[i])
                        {
                            int t = array[j];
                            array[j] = array[i];
                            array[i] = t;
                        }
                    }
                }
                Console.WriteLine("Полученный массив");
                for (int i = 0; i < 10; i++)
                {

                    Console.Write("{0,4} ", array[i]); 
                }
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
