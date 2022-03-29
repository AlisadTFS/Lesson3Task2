using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите фразу: ");
            string text = Console.ReadLine();
            char[] arraytext = text.ToCharArray();
            Array.Reverse(arraytext);
            Console.Write("Результат: ");
            Console.WriteLine(arraytext);
            
        }
    }
}
