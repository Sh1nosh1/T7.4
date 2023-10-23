using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Класс SrtingBuilder

                //Способы создания строкового объекта

                //1 способ: создание пустойстроки размером 16 символов
                //StringBuilder sb1 = new StringBuilder();
                //WriteLine(sb1);

                ////2 способ: инициализация строки и выделение памяти под 4 символа
                //StringBuilder sb2 = new StringBuilder("abcd");
                //WriteLine(sb2);

                ////3 способ: создание пустой строки и выделение памяти под 100 символов
                //StringBuilder sb3 = new StringBuilder(100);
                //WriteLine(sb3);

                ////4 способ: инициализация строки и выделение памяти под 100 символов
                //StringBuilder sb4 = new StringBuilder("abcd", 100);
                //WriteLine(sb4);

                ////5 способ: инициализация подстрокой "bcd" и выделение памяти под 100 символов
                //StringBuilder sb5 = new StringBuilder("abcdefg", 1, 3, 100);
                //WriteLine(sb5);

                ////Способы создания строкового объекта
                //StringBuilder sb = new StringBuilder("Привет мир");
                //WriteLine($"Длина строки: {sb.Length}");
                //WriteLine($"Емкость строки: {sb.Capacity}");

                ////методы
                //StringBuilder s6 = new StringBuilder("Название: ");
                //WriteLine($"Длина строки: {s6.Length}"); // 10
                //WriteLine($"Емкость строки: {s6.Capacity}"); // 16
                //s6.Append(" Руководство");
                //WriteLine($"Длина строки: {s6.Length}"); // 22
                //WriteLine($"Емкость строки: {s6.Capacity}"); // 3
                //s6.Append(" по C#");
                //WriteLine($"Длина строки: {s6.Length}"); // 28
                //WriteLine($"Емкость строки: {s6.Capacity}"); // 32

                string longest = "";
                Write("Введите строку: ");
                StringBuilder s = new StringBuilder(ReadLine());
                string[] array = s.ToString().Split(' ');
                foreach (string element in array)
                {
                    if(element.Length > longest.Length)
                    {
                        longest = element;
                    }
                }
                WriteLine($"\nДлинное слово: {longest}");

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
