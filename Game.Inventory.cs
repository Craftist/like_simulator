using System;
using System.Text;

namespace Like_Simulator
{
    public partial class Game
    {
        /// <summary>
        /// Просмотреть инвентарь.
        /// </summary>
        public static void GoToInventory()
        {
            string status;
            StringBuilder stringBuilder = new StringBuilder();
            if (Data.Inventory.Slots.Count == 0)
            {
                stringBuilder.Clear();
                stringBuilder.Append("Пусто");
            }
            else
            {
                foreach (InventoryItem item in Data.Inventory.Slots.Values) {
                    stringBuilder.AppendLine(item.Name);
                    stringBuilder.AppendLine("    Описание:   " + item.Description);
                    stringBuilder.AppendLine("    Количество: " + item.Quantity);
                }
            }
            status = stringBuilder.ToString();
            Console.Write("=== Инвентарь ===\r\n");
            DrawErrorLine("Инвентарь пуст");
            Console.Write("0 - Вернуться назад\r\n\r\nВаш выбор: ");
            Console.ForegroundColor = ConsoleColor.White;
            var action = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            switch (action)
            {
                case "0":
                    GoTo();
                    break;
                default:
                    GoToInventory();
                    break;
            }
        }
    }
}

