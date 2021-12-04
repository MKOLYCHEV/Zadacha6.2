using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение (слова разделяются пробелами, знаки препинания не используются).");
            string startString = Console.ReadLine();
            string tempString = startString.ToLower();
            string[] stringArray = tempString.Split();
            string finalString=String.Join("",stringArray);
            bool f = false;
            for (int i = 0; i < finalString.Length / 2; i++)
                if (finalString[i] != finalString[finalString.Length - i - 1])
                {
                    Console.WriteLine("Введенное предложение не является палиндромом.");
                    f = true;
                    break;
                }
            if (!f) Console.WriteLine("Введенное предложение является палиндромом.");
            Console.ReadKey();
        }
    }
}
