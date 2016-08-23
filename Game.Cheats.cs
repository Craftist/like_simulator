using System;

namespace Like_Simulator
{
    public partial class Game
    {
        /// <summary>
        /// Перейти в меню читов.
        /// </summary>
        public static void GoToCheats()
        {
            PrintStats();
            Console.Write(@"=== Читы ===
- addmoney {value}
    Добавляет {value} денег персонажу
- additem Name Descrption Quantity
    Добавляет {Quantity} вещей {Name} с описанием {Description} в инвентарь
        Пробел: '_'
        Символ '_': '__'
        К примеру: чтобы было имя ""Мама мыла раму"", напишите так: ""Мама_мыла_раму""
0 - Вернуться назад

Ваш выбор: ");
            Console.ForegroundColor = ConsoleColor.White;
            var action = Console.ReadLine().Split(' ');
            Console.ForegroundColor = ConsoleColor.Gray;
            switch (action[0])
            {
                case "addmoney":
                    Data.Money += Convert.ToInt32(action[1]);
                    GoToCheats();
                    break;
                case "additem":
                    var _name = action[1].Replace('_', ' ').Replace("__", "_");
                    var _desc = action[2].Replace('_', ' ').Replace("__", "_");
                    var _qty = Convert.ToInt32(action[3]);
                    Data.Inventory.Slots.Add(Data.Inventory.Slots.Count,
                        new InventoryItem(_name, _desc, _qty));
                    GoToCheats();
                    break;
                case "0":
                    GoTo();
                    break;
                default:
                    Console.WriteLine("Ошибка: Неизвестный чит-код");
                    GoToCheats();
                    break;
            }
        }
    }
}

