using System;
using System.Text;

namespace Like_Simulator
{
    /// <summary>
    /// Главный класс игры. Именно здесь происходит главная логика игры.
    /// </summary>
    public partial class Game
    {
        /// <summary>
        /// Перейти в меню.
        /// </summary>
        public static void GoTo()
        {
            Data.Place = Places.MENU;
            PrintStats();
            Console.Write(@"=== Like_Simulator ===
Выберите, куда вы хотите пойти:
1 - В кафе,
2 - В больницу,
3 - В магазин
4 - Читы
5 - Инвентарь (хранящиеся вещи)
6 - Список болезней
0 - Выход из игры

Ваш выбор: ");
            Console.ForegroundColor = ConsoleColor.White;
            var action = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            switch (action)
            {
                case "0":
                    AreYouSureToExit();
                    break;
                case "1":
                    GoToCafe();
                    break;
                case "2":
                    GoToHospital();
                    break;
                case "4":
                    GoToCheats();
                    break;
                case "5":
                    GoToInventory();
                    break;
                case "6":
                    GoToCurses();
                    break;
                default:
                    GoTo();
                    break;
            }
        }
    }
}