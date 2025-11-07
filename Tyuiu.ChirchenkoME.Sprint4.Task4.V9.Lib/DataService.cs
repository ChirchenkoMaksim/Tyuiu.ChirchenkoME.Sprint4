using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChirchenkoME.Sprint4.Task4.V9.Lib
{
    public class DataService : ISprint4Task4V9
    {
        public int Calculate(int[,] matrix)
        {
            // Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с клавиатуры в диапазоне от 1 до 8. Найдите сумму четных элементов массива. 3, 7, 3, 1, 5, 6, 3, 2, 1, 2, 1, 3, 2, 8, 1, 5, 8, 1, 5, 1, 3, 3, 4, 4, 6,
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
