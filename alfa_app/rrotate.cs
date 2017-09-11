using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alfa_app
{
    /*
     * От Вас требуется написать функцию rrotate, которая принимает на вход
     * массив произвольных элементов и целое значение k. Функция должна
     * выполнить циклический сдвиг массива на k элементов вправо. Запрещается
     * использовать дополнительный массив.
     */
    public class rrotate
    {
        public static int rrotate_f<T>(T[] mass, int number)
        {
            try
            {
                T temp;
                Tuple<int, int, int> tuple = number >= 0 ?
                                             new Tuple<int, int, int>(mass.Length - 1, 0, -1) :
                                             new Tuple<int, int, int>(0, mass.Length - 1, 1);
                for (int i = 0; i < Math.Abs(number); i++)
                {
                    temp = mass[tuple.Item1];
                    for(int j = 0; j < mass.Length - 1; j++)
                    {
                        mass[tuple.Item1 + j * tuple.Item3] = mass[tuple.Item1 + tuple.Item3 + j * tuple.Item3];
                    }
                    mass[tuple.Item2] = temp;
                }
                foreach (T el in mass)
                    Console.WriteLine(el);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return 0;
        }
    }
}
