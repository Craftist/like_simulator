using System;
using System.Diagnostics;

namespace Like_Simulator
{
    public partial class Game
    {
        /// <summary>
        /// Перейти в кафе.
        /// </summary>
        public static void GoToCafe()
        {
            PrintStats();
            Console.Write(@"=== Кафе ===
1 - Поесть мороженого
    Цена: 10 рублей (у вас сейчас %$s% рублей)
    Восполнит: 3-5 голода, 0-1 настроения
    1% шанс подхватить простуду
2 - Съесть бутерброд
    Цена: 20 рублей (у вас сейчас %$s% рублей)
    Восполнит: 7-8 голода, 0-3 настроения
3 - Съесть тарелку горячего супа
    Цена: 45 рублей (у вас сейчас %$s% рублей)
    Восполнит: 12-14 голода, 2-3 настроения
    5% шанс избавиться от простуды
0 - Вернуться назад

Ваш выбор: ".Replace("%$s%", Convert.ToString(Data.Money)));
            Console.ForegroundColor = ConsoleColor.White;
            var action = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            switch (action)
            {
                case "0":
                    GoTo();
                    break;
                case "1":
                    Cafe_Add(10,
                        new int[] { 3, 5 },
                        new int[] { 0, 1 },
                        delegate
                        {
                            //if (new Random().Next(1, 100) == 1)
                            //{
                            Data.Curses.Add(Data.Curses.Count, new Curse("cold", "Простуда", 30));
                            //}
                        }
                    );
                    NextDay();
                    GoToCafe();
                    break;
                case "2":
                    Cafe_Add(20,
                        new int[] { 7, 8 },
                        new int[] { 0, 3 });
                    NextDay();
                    GoToCafe();
                    break;
                case "3":
                    Cafe_Add(20,
                        new int[] { 7, 8 },
                        new int[] { 0, 3 },
                        delegate {
                        if (new Random().Next(1, 100/5) == 1) {
                            int i = 0;
                            foreach (Curse curse in Data.Curses.Values)
                            {
                                if (curse.Identifier == "cold") {
                                    Data.Curses.Remove(i);
                                }
                                i++;
                            }
                        }
                    }
                    );
                    NextDay();
                    GoToCafe();
                    break;
                default:
                    GoToCafe();
                    break;
            }
        }

        // <summary>
        /// Делегат для кафе.
        /// Выполняет действия, свойственные для побочных эффектов от
        /// еды - отравление, отрыжка, простуда.
        /// </summary>
        public delegate void CafeDelegate();
        /// <summary>
        /// Покупает и тут же съедает еду.
        /// </summary>
        /// <param name="Food_Price">Цена еды.</param>
        /// <param name="addHunger">Массив из двух элементов, где
        /// первый элемент - меньший порог рандома, а второй
        /// - верхний порог рандома.</param>
        /// <param name="addHappiness">Массив из двух элементов, где
        /// первый элемент - меньший порог рандома, а второй
        /// - верхний порог рандома.</param>
        /// <param name="callableIfGood">Этот делегат выполняется,
        /// если пользователю хватило денег на еду.</param>
        public static void Cafe_Add(int Food_Price, int[] addHunger, int[] addHappiness,
            CafeDelegate callableIfGood = null)
        {
            if (Data.Money >= Food_Price)
            {
                Data.Money -= Food_Price;
                Data.Hunger += new Random().Next(addHunger[0], addHunger[1]);
                if (Data.Hunger > 100)
                    Data.Hunger = 100;
                Data.Happiness += new Random().Next(addHappiness[0], addHappiness[1]);
                if (Data.Happiness > 100)
                    Data.Happiness = 100;
                if (callableIfGood != null)
                {
                    ((CafeDelegate)callableIfGood)();
                }
            }
            else
            {
                DrawErrorLine("У вас нет " + Food_Price + " рублей");
            }
        }
    }
}

