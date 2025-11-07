using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChirchenkoME.Sprint4.Task6.V3.Lib
{
    public class DataService : ISprint4Task6V3
    {
        // Дан строковый массив данных ["Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"] используя класс Array подсчитайте количество элементов, длина которых меньше 6.
        public int Calculate(string[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length < 6)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
