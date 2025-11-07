using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.ChirchenkoME.Sprint4.Task5.V9.Lib;

namespace Tyuiu.ChirchenkoME.Sprint4.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            // Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными значениями в диапазоне от -4 до 4. Найти количество положительных элементов.
            int len = 5;
            int[,] numsArray = new int[len, len];
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    numsArray[i, j] = rand.Next(-4, 5);
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
            Console.WriteLine("Количество положительных элементов массива:");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
