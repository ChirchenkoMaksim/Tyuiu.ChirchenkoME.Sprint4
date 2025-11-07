using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChirchenkoME.Sprint4.Task3.V11.Lib
{
    public class DataService : ISprint4Task3V11
    {
        public int Calculate(int[,] array)
        {
            // Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне от 4 до 9. Подсчитайте количество нечетных элементов во всем массиве. 8, 6, 9, 4, 5, 9, 4, 8, 5, 6, 9, 7, 9, 8, 4, 4, 6, 5, 7, 8, 6, 6, 7, 6, 4,
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
