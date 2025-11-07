using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.ChirchenkoME.Sprint4.Task4.V9.Lib;

namespace Tyuiu.ChirchenkoME.Sprint4.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            // Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с клавиатуры в диапазоне от 1 до 8. Найдите сумму четных элементов массива. 3, 7, 3, 1, 5, 6, 3, 2, 1, 2, 1, 3, 2, 8, 1, 5, 8, 1, 5, 1, 3, 3, 4, 4, 6,
            int len = 5;
            int[,] numsArray = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.WriteLine($"Введите элемент массива [{i + 1},{j + 1}] (от 1 до 8):");
                    numsArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(numsArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int result = ds.Calculate(numsArray);
            Console.WriteLine("Сумма четных элементов массива:");
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
