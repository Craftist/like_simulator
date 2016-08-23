using System;
using System.Text;

namespace Like_Simulator
{
    public partial class Game
    {
        /// <summary>
        /// Посмотреть список болезней.
        /// </summary>
        public static void GoToCurses()
        {
            string status;
            StringBuilder stringBuilder = new StringBuilder();
            if (Data.Curses.Count == 0)
            {
                stringBuilder.Clear();
                stringBuilder.Append("Пусто");
            }
            else
            {
                foreach (Curse curse in Data.Curses.Values) {
                    stringBuilder.AppendLine(curse.Name);
                    stringBuilder.AppendLine("    Истекает через: " +
                        (curse.ExpiredIn - Data.CurrentDay) + " дней");
                    stringBuilder.AppendFormat(@"
curse.ExpiredIn - {0}
Data.CurrentDay - {1}", curse.ExpiredIn, Data.CurrentDay);
                }
            }
            status = stringBuilder.ToString();
            Console.Write(@"=== Болезни ===
" + status + @"
0 - Вернуться назад

Ваш выбор: ");
            Console.ForegroundColor = ConsoleColor.White;
            var action = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            switch (action)
            {
                case "0":
                    GoTo();
                    break;
                default:
                    GoToCurses();
                    break;
            }
        }
    }
}

