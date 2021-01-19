using System;

namespace FavoriteColor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "blue", "red", "magenta", "green", "cyan", "yellow", "white", "other", "брандахлыст" };
            int i = 0;

            while (true)
            {
                Console.Write("Напишите свой любимый цвет на английском: ");
                string favColor = Console.ReadLine().Replace(" ", "").ToLower();

                while (Array.IndexOf(colors, favColor) == -1) //Повторять, пока не будет введено значение из colors
                {
                    Console.WriteLine("Я не знаю такого цвета! Попробуйте ещё раз или напишите 'other'");
                    Console.WriteLine("Стоп-слово 'брандахлыст'");
                    Console.Write("Напишите свой любимый цвет на английском: ");
                    favColor = Console.ReadLine().Replace(" ", "").ToLower();
                }

                if (favColor == "брандахлыст") //Стоп-слово))
                {
                    Console.WriteLine("Цикл остановлен!");
                    break;
                }

                Console.WriteLine("Итерация {0}", i);
                switch (favColor)
                {
                    case "blue":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет - синий!");
                        break;

                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет - красный!");
                        break;

                    case "magenta":
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет - пурпурный!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет - зелёный!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет - голубой!");
                        break;

                    case "yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет - жёлтый!");
                        break;

                    case "white":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет - белый!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Я пока только учусь и знаю всего 7 цветов!");
                        break;
                }

                i++;
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();

            Console.WriteLine("\nА ещё я умею переворачивать имя наизнанку:)");
            Console.Write("Введите своё имя: ");
            var name = Console.ReadLine();

            for (int j = name.Length -1; j >= 0; j--)
            {
                Console.Write(name[j] + " ");
            }

            Console.WriteLine("\n\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
        }
    }
}
