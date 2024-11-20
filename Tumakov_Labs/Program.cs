using System;

namespace Tumakov_Labs
{
    enum Month
    {
        января=1,
        февраля=2,
        марта=3,
        апреля=4,
        мая=5,
        июня=6,
        июля=7,
        августа=8,
        сентября=9,
        октября=10,
        ноября=11,
        декабря=12
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня в году), переводит этот число в месяц и день месяца.Например, число 40 соответствует 9 февраля(високосный год не учитывать).
            Console.WriteLine("Задание 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня в году), переводит этот число в месяц и день месяца.");
            Console.Write("Введите номер дня в году (от 1 до 365): ");
            int day1 = 0;
            int i1 = 0;
            int number_day1 = int.Parse(Console.ReadLine());
            int[] days_in_month1 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (i1 = 0; i1 < days_in_month1.Length; i1++)
            {
                if (number_day1 <= days_in_month1[i1])
                {
                    day1 = number_day1;
                    break;
                }
                number_day1 -= days_in_month1[i1];
            }
            Month month1 = (Month)i1 + 1;
            Console.WriteLine($"{day1} {month1}");
            // Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать исключение, и выдавать на экран сообщение.
            Console.WriteLine("Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного пользователем.");
            try
            {
                Console.Write("Введите номер дня в году (от 1 до 365): ");
                int day2 = 0;
                int i2 = 0;
                int number_day2 = int.Parse(Console.ReadLine());
                if (number_day2 < 1 || number_day2 > 365)
                {
                    throw new ArgumentOutOfRangeException();
                }
                int[] days_in_month2 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                for (i2 = 0; i2 < days_in_month2.Length; i2++)
                {
                    if (number_day2 <= days_in_month2[i2])
                    {
                        day2 = number_day2;
                        break;
                    }
                    number_day2 -= days_in_month2[i2];
                }
                Month month2 = (Month)i2 + 1;
                Console.WriteLine($"{day2} {month2}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Номер дня должен быть в диапазоне от 1 до 365.");
            }
            // Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она учитывала год(високосный или нет). Год вводится с экрана. (Год високосный, если он делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный год.Однако, если он делится без остатка на 400, это високосный год.)
            Console.WriteLine("Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она учитывала год(високосный или нет).");
            try
            {
                Console.Write("Введите год: ");
                int year = int.Parse(Console.ReadLine());
                bool visokos = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
                int max_day = visokos ? 366 : 365;
                Console.Write($"Введите номер дня в году (от 1 до {max_day}): ");
                int day = 0;
                int i = 0;
                int number_day = int.Parse(Console.ReadLine());
                if (number_day < 1 || number_day > max_day)
                {
                    throw new ArgumentOutOfRangeException($"Номер дня должен быть в диапазоне от 1 до {max_day}.");
                }
                int[] days_in_month = { 31, visokos ? 29: 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                for (i = 0; i < days_in_month.Length; i++)
                {
                    if (number_day <= days_in_month[i])
                    {
                        day = number_day;
                        break;
                    }
                    number_day -= days_in_month[i];
                }
                Month month = (Month)i + 1;
                Console.WriteLine($"{day} {month} {year}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
