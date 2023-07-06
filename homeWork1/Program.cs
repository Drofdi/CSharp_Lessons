using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите простой конвертор валют
            Console.WriteLine("Введите значение в долларах");
            string dollars = Console.ReadLine();
            int dollarsNum = int.Parse(dollars);
            int convertToRub = dollarsNum * 90;
            Console.WriteLine(dollars + "Dolllars = " + convertToRub + " Rubles");
        }
    }
}
