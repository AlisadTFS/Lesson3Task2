using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static bool CheckInput(string wordbook, char inputkey)
        {
            bool result = false;
            foreach (char key in wordbook)
            {
                if (key == inputkey)
                {
                    result = true;
                    break;
                }

            }
            return result;
        }
        static string InputData(string wordbook, string title)
        {
            ConsoleKeyInfo inkey;
            string tmpstr = null;
            Console.Clear();
            Console.Write(title);
            while (true)
            {
                inkey = Console.ReadKey(true);
                if (CheckInput(wordbook, inkey.KeyChar))
                {
                    tmpstr += inkey.KeyChar;
                    Console.Write(inkey.KeyChar);
                }
                else if (inkey.KeyChar == (char)8)
                {

                    if (tmpstr != null && tmpstr.Length > 0)
                    {
                        tmpstr = tmpstr.Remove(tmpstr.Length - 1);
                        Console.Clear();
                        Console.Write(title + tmpstr);
                    }

                }
                if (inkey.KeyChar == (char)13 && tmpstr != "" && tmpstr != null)
                {
                    Console.WriteLine();
                    break;
                }
            }
            return tmpstr;

        }

        static void Main(string[] args)
        {
            const string RuLang = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            const string EnLang = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            const string Numb = "0123456789";
            string[,] phonebook = new string[5, 2];
            string name = null;
            string phone = null;
            int i = 0;
            ConsoleKeyInfo presskey;
            do
            {
                Console.Clear();
                name = null;
                name = InputData(RuLang, "Ваша имя: ");
                name += " " + InputData(RuLang, "Ваша Фамилия: ");
                phonebook[i, 0] = name;
                phone = null;
                phone = InputData(Numb, "Введите Ваш номер телефона: +7");
                phone += "/" + InputData(EnLang + "@.", "Введите свой e-mail: ");
                phonebook[i, 1] = phone;
                i++;
                if (i > phonebook.GetUpperBound(0))
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("ESC-Завершить. Нажмите любую кнопку-Продолжить");
                presskey = Console.ReadKey(true);
            }
            while (presskey.KeyChar != (char)27);
            Console.Clear();
            if (i > phonebook.GetUpperBound(0))
            {
                Console.WriteLine("Кончиласть память!!!");
            }
            for (int x = 0; x < i; x++)
            {
                Console.WriteLine($"Имя: {phonebook[x, 0]} контакты: {phonebook[x, 1]}");
            }

        }
    }
}
