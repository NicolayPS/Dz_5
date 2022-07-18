using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №6 - Запросить у пользователя целочисленное значение N ");
            Console.WriteLine("Сформировать двумерный массив размера NxN");
            Console.WriteLine("Проверить, является ли введенная с клавиатуры матрица магическим квадратом.");
            Console.WriteLine("У вас 10 попыток, удачи!");
            int o = 1;
            while (o < 11)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Попытка №{0} из 10!", o);
                Console.WriteLine("Введите размерность (целочисленное значение) N:");
                int n = Convert.ToInt32(Console.ReadLine());
                int m = n;
                int s = 0;
                int[] arr = new int [s];
                if (n > 0)
                {
                    int[,] array = new int[n, m];
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Введите строку №{0}", (j + 1));
                        for (int i = 0; i < m; i++)
                        {
                            array[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.WriteLine(" Массив: ");
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine(" ");
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write(array[i, j]);
                        }
                    }
                    

                }
                else
                {
                    Console.WriteLine("Введите положительное число");
                }
                Console.WriteLine();
                o++;
                Console.WriteLine(" ");
                Console.WriteLine("Для продолжения нажмите любую кнопку");
                Console.ReadKey();
            }

            Console.WriteLine(" ");
            Console.WriteLine("Cпасибо!");
            Console.ReadKey();
        }
    }
}
