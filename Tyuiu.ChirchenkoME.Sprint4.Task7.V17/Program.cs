using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.ChirchenkoME.Sprint4.Task7.V17.Lib;

namespace Tyuiu.ChirchenkoME.Sprint4.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            // Дана строка из одноразрядных цифр "753159864". Преобразуйте ее в матрицу 3 на 3 и подсчитайте количество четных чисел.
            int n = 3;
            int m = 3;
            string value = "753159864";
            Console.WriteLine("Исходные данные:");
            Console.WriteLine($"n = {n}, m = {m}, value = {value}");
            int result = ds.Calculate(n, m, value);
            Console.WriteLine("Количество четных чисел в матрице:");
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}