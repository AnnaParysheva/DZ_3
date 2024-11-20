using System;

namespace Files_Labs
{
    enum Days_of_week
    {
        Понедельник=1,
        Вторник=2,
        Среда=3,
        Четверг=4,
        Пятница=5,
        Суббота=6,
        Воскресенье=7
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Дана последовательность из 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию.В случае отрицательного ответа определить порядковый номер первого числа, которое нарушает данную последовательность. Использовать break.
            Console.WriteLine("1. Дана последовательность из 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию.");
            int[] numbers = new int[10];
            int j = 0;
            Console.WriteLine("Введите 10 чисел:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Число N{i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int index_mistakes = -1;
            for (j = 0; j < numbers.Length - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    index_mistakes = j + 2;
                    break;
                }
            }
            if (index_mistakes == -1)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            else
            {
                Console.WriteLine($"Последовательность нарушена на позиции {index_mistakes}");
            }
            //2. Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14. Порядковые номера остальных карт соответствуют их названиям(«шестерка», «девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство соответствующей карты. Использовать try-catch-finally.
            Console.WriteLine("2. По заданному номеру карты k(6 <= k <= 14) определить достоинство соответствующей карты.");
            try
            {
                Console.Write("Введите номер карты (от 6 до 14): ");
                int k = int.Parse(Console.ReadLine());
                if (k < 6 || k > 14)
                {
                    throw new ArgumentOutOfRangeException("Номер карты должен быть в диапазоне от 6 до 14.");
                }
                string value;
                switch (k)
                {
                    case 6:
                        value = "шестёрка";
                        break;
                    case 7:
                        value = "семёрка";
                        break;
                    case 8:
                        value = "восьмёрка";
                        break;
                    case 9:
                        value = "девятка";
                        break;
                    case 10:
                        value = "десятка";
                        break;
                    case 11:
                        value = "валет";
                        break;
                    case 12:
                        value = "дама";
                        break;
                    case 13:
                        value = "король";
                        break;
                    case 14:
                        value = "туз";
                        break;
                    default:
                        value = null; 
                        break;
                }

                Console.WriteLine($"Достоинство карты: {value}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }
            // 3. Напишите программу, которая принимает на входе строку и производит выходные данные в соответствии со следующей таблицей:
            /* Примечание. По умолчанию используется “все остальное”: если входные данные
            функции не соответствуют ни одному из значений в таблице, то возвращаемое значение
            должно быть «Beer».
            Убедитесь, что вы охватили случаи, когда некоторые слова не отображаются с
            правильным написанием заглавных букв.Например, ввод «pOLitiCIaN» должен
            по - прежнему возвращать «Your tax dollars». */
            Console.WriteLine("3. Напишите программу, которая принимает на входе строку и производит выходные данные в соответствии со следующей таблицей");
            Console.WriteLine("Введите строку:");
            string stroka= Console.ReadLine().ToLower();
            string result;
            switch (stroka)
                {
                    case "jabroni":
                        result = "Patron Tequila";
                        break;
                    case "school counselor":
                        result = "Anything with Alcohol";
                        break;
                    case "programmer":
                        result = "Hipster Craft Beer";
                        break;
                    case "bike gang member":
                        result = "Moonshine";
                        break;
                    case "politician":
                        result = "Your tax dollars";
                        break;
                    case "rapper":
                        result = "Cristal";
                        break;
                    default:
                        result="Beer";
                        break;
                }

                Console.WriteLine(result);
            //4. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,...,7) выводит на экран его название(понедельник, вторник, ..., воскресенье). Использовать enum.
            Console.WriteLine("4. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).");
            Console.Write("Введите номер дня недели: ");
            byte number_day = byte.Parse(Console.ReadLine());
            if (number_day >= 1 && number_day <= 7)
            {
                Days_of_week day = (Days_of_week)number_day;
                Console.WriteLine($"День недели: {day}");
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите число от 1 до 7.");
            }
            //5. Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к результату.Вывести на экран сколько кукол в “сумке”.
            Console.WriteLine("5. Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента Hello Kitty или Barbie doll необходимо положить их в “сумку”, т.е. прибавить к результату. Вывести на экран сколько кукол в “сумке”.");
            string[] toys = { "Hello Kitty", "Barbie doll", "Plush bear", "Toy car", "Barbie doll", "Dollhouse", "Hello Kitty" };
            int count = 0;
            foreach (string toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество кукол в “сумке”: {count}");
            Console.ReadKey();
        }
    }
}
