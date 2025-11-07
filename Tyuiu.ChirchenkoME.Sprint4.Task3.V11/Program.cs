using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.ChirchenkoME.Sprint4.Task3.V11.Lib;

namespace Tyuiu.ChirchenkoME.Sprint4.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int len;
            Console.WriteLine("Введите размерность массива (5):");
            len = Convert.ToInt32(Console.ReadLine());
            int[,] numsArray = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.WriteLine($"Введите элемент массива [{i + 1},{j + 1}] (от 4 до 9):");
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
            Console.WriteLine("количество нечетных элементов во всем массиве:");
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}