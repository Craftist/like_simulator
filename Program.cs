using System;
using System.IO;

namespace Like_Simulator
{
    public class Program
    {
        /// <summary>
        /// Входная точка программы, где начинается и заканчивается ее управление.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        public static void Main(string[] args)
        {
            bool saveExists = true;
            try {
                new FileStream("save\\main.sav", FileMode.Open);
            } catch (DirectoryNotFoundException) {
                Directory.CreateDirectory("save");
            } catch (FileNotFoundException) {
                saveExists = false;
            }
            if (saveExists)
            {
                Console.Write(@"=== Открыть сохранение ===
Был найден файл сохранения. Вы хотите загрузить сохранение? (y/n): ");
                var answer = Console.ReadLine();
                if (answer == "y")
                {
                    Game.LoadData();
                }
            }
            Console.Write("Ваше имя: ");
            var name = Console.ReadLine();
            if (name.Trim() == string.Empty)
            {
                Game.Exit();
            }
            else
            {
                Data.Name = name.Replace(':', '-');
            }
            Console.WriteLine();
            Game.GoTo();
        }
    }
}

