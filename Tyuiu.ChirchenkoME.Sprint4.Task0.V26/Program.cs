using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.ChirchenkoME.Sprint4.Task0.V26.Lib;

namespace Tyuiu.ChirchenkoME.Sprint4.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            int[] numsArray = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            Console.WriteLine("Исходндыпй .массlив");

            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            int sumEven = ds.GetSumOddArrEl(numsArray);

            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }


            Console.WriteLine(sumEven);
            Console.ReadKey();

        }
    }
}
