using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Подсчитать количество четных и нечетных чисел в заданном интервале (while)
            Console.WriteLine("Enter interval");
            int count = 0;
            int interval = int.Parse(Console.ReadLine());
            int even = 0; int odd = 0;
            int resultEven = 0;
            int resultOdd = 0;
            int result = 0;
            while (count < interval)
            {
                count++;
                if (count % 2 == 0)
                {
                    even++;
                    resultEven += count;
                    result += count;
                }
                else
                {
                    odd++;
                    resultOdd += count;
                    result += count;
                }
            }
            Console.WriteLine("В заданном интервале от 0 до " + interval + ": Четных чисел : " + even + ", Нечетных чисел : " + odd + ", Сумма Четных : " +
                resultEven + ", Cумма нечетных : " + resultOdd + ", Общая сумма всех чисел : " + result);
        }
    }
}
