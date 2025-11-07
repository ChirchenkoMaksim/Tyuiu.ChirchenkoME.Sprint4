using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.ChirchenkoME.Sprint4.Task6.V3.Lib;

namespace Tyuiu.ChirchenkoME.Sprint4.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            // Дан строковый массив данных ["Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"] используя класс Array подсчитайте количество элементов, длина которых меньше 6.
            string[] monthsArray = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < monthsArray.Length; i++)
            {
                Console.WriteLine(monthsArray[i]);
            }
            int result = ds.Calculate(monthsArray);
            Console.WriteLine("Количество элементов, длина которых меньше 6:");
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}