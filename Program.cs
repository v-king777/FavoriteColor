using System;

namespace FavoriteColor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "blue", "red", "magenta", "green", "cyan", "yellow", "white", "other" };
            Console.Write("Напишите свой любимый цвет на английском: ");
            string favColor = Console.ReadLine().Replace(" ", "").ToLower();

            while (Array.IndexOf(colors, favColor) == -1) //Повторять, пока не будет введён цвет из списка
            {
                Console.WriteLine("Я не знаю такого цвета! Попробуйте ещё раз или напишите 'other'");
                Console.Write("Напишите свой любимый цвет на английском: ");
                favColor = Console.ReadLine().Replace(" ", "").ToLower();
            }

            switch (favColor)
            {
                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш любимый цвет - синий!");
                    break;

                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш любимый цвет - красный!");
                    break;

                case "magenta":
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш любимый цвет - пурпурный!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш любимый цвет - зелёный!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш любимый цвет - голубой!");
                    break;

                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш любимый цвет - жёлтый!");
                    break;

                case "white":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш любимый цвет - белый!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Я пока только учусь и знаю всего 7 цветов!");
                    break;
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey(); //Выход из программы
        }
    }
}
