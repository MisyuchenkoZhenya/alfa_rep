using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alfa_app
{
    /*От Вас требуется написать функцию bsearch, которая принимает на вход
     * отсортированный по убыванию массив целых чисел и целое число X. В
     * качестве результата функция должна возвращать индекс последнего
     * элемента массива, строго большего X. В Вашей реализации функция может
     * принимать любое количество любых параметров, только 2 этих параметра обязательны.
     */
    public class bsearch
    {
        public static int bsearch_f(int[] mass, int number, params object[] argv)
        {
            int index_of_last_elem = -1;
            try
            {
                if (mass[0] < number)
                    throw new Exception("No items greater than a given number");
                for(int index = 0; index < mass.Length; index++)
                {
                    if (mass[index] > number)
                        index_of_last_elem = index;
                    else
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return index_of_last_elem;
        }
    }
}
