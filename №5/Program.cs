using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №5 - Запросить у пользователя целочисленное значение N ");
            Console.WriteLine("Сформировать двумерный массив размера NxN");
            Console.WriteLine("У вас 15 попыток, удачи!");
            int o = 1;
            while (o < 16)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Попытка №{0} ", o);
                Console.WriteLine("Введите размерность N:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[,] array = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = ((i == j) || (i + j == n - 1) || ((i + j) % 2 == 0)) ? 1 : 0;
                        Console.Write("{0} ", array[i, j]);
                    }
                    Console.WriteLine();

                }
                Console.WriteLine();
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