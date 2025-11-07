using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChirchenkoME.Sprint4.Task7.V17.Lib
{
    public class DataService : ISprint4Task7V17
    {
        public int Calculate(int n, int m, string value)
        {
            // Дана строка из одноразрядных цифр "753159864". Преобразуйте ее в матрицу 3 на 3 и подсчитайте количество четных чисел.
            int count = 0;
            int index = 0;
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    if (matrix[i, j] % 2 == 0)
                    {
                        count++;
                    }
                    index++;
                }
            }
            return count;
        }
    }
}
