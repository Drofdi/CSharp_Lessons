using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hWork_calc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leftValue = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            int rightValue = int.Parse(Console.ReadLine());
            int result = 0;

            switch (symbol)
            {
                case  "+":
                    result = leftValue + rightValue; 
                    break;
                    case "-": result = leftValue - rightValue; 
                    break;
                case "*": result = leftValue * rightValue;
                    break;
                case "/": result = leftValue / rightValue;
                    break;
                    default:
                    Console.WriteLine("Inncorect symbol");
                    break;
            } 
            Console.WriteLine(result);
        }
    }
}
