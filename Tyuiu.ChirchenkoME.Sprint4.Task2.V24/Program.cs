using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.ChirchenkoME.Sprint4.Task2.V24.Lib;

namespace Tyuiu.ChirchenkoME.Sprint4.Task2.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int len;
            Console.WriteLine("Введите длину массива (12):");
            len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Введите элемент массива {i + 1} (от 4 до 9):");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
            int result = ds.Calculate(numsArray);
            Console.WriteLine("Сумма нечетных элементов массива:");
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}

