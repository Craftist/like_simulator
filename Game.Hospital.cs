using System;

namespace Like_Simulator
{
    public partial class Game
    {
        /// <summary>
        /// Что-то делать, если хватило денег на лечение
        /// </summary>
        public delegate void HospitalDelegate();
        /// <summary>
        /// Лечить игрока.
        /// </summary>
        /// <param name="price">Цена лечения.</param>
        /// <param name="addHealth">Массив из двух элементов, показывающие,
        /// на сколько вылечить персонажа.</param>
        /// <param name="callback">Делегат, выполняющийся, если
        /// персонажу хватило денег для лечения.</param>
        public static void Hospital_Add(int price, int[] addHealth, HospitalDelegate callback = null)
        {
            if (Data.Money >= price)
            {
                Data.Money -= price;
                Data.Health += new Random().Next(addHealth[0], addHealth[1]);
                if (Data.Health > 100)
                    Data.Health = 100;
                if (callback != null)
                {
                    ((HospitalDelegate)callback)();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Ошибка: у вас нет " + price + " рублей");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        /// <summary>
        /// Идти в больницу
        /// </summary>
        public static void GoToHospital()
        {
            Data.Place = Places.HOSPITAL;
            PrintStats();
            Console.Write(@"=== Больница ===
1 - Лечиться у плохого доктора
    Добавляет: 1-5 здоровья
    Лечит 1 рандомную болезнь с 50% шансом
    Цена: 50 рублей
2 - Лечиться у хорошего доктора
    Добавляет: 5-12 здоровья
    Лечит 1 рандомную болезнь с 90% шансом
    Цена: 250 рублей
3 - Лечиться в клинике
    Добавляет: 25-50 здоровья
    Лечит 1 рандомную болезнь с 100% шансом и еще 1 рандомную с 50% шансом
    Цена: 1200 рублей

Ваш ответ: ");
            Console.ForegroundColor = ConsoleColor.White;
            var answer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            switch (answer)
            {
                case "0":
                    GoTo();
                    break;
                case "1":
                    Hospital_Add(50, new int[] { 1, 5 }, delegate
                        {
                            if (new Random().Next(0, 1) == 1)
                            {
                                Data.Curses.Remove(new Random().Next(0, Data.Curses.Keys.Count - 1));
                            }
                        });
                    GoToHospital();
                    break;
            }
        }
    }
}

