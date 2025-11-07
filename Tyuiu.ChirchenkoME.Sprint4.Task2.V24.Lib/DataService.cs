using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChirchenkoME.Sprint4.Task2.V24.Lib
{
    public class DataService : ISprint4Task2V24
    {
        public int Calculate(int[] array)
        {
            // Дан одномерный целочисленный массив на 12 элементов заполненный случайными в диапазоне от 4 до 9 подсчитать сумму нечетных элементов массива.
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
