using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите число введеное с клавиатуры на четность
            int number;
            Console.WriteLine("Введите число чтобы проверить его на четность");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) {
                Console.WriteLine(number + " Четное чсило");
            }
            else
            {
                Console.WriteLine(number + " Нечетное чсило");
            }

        }
    }
}
