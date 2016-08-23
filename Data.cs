using System;
using System.Collections.Generic;

namespace Like_Simulator
{
    /// <summary>
    /// Контейнер информации.
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Имя игрока
        /// </summary>
        public static string Name;
        /// <summary>
        /// Уровень голода. При 0 игрок умирает.
        /// </summary>
        public static int Hunger = 100;
        /// <summary>
        /// Уровень жажды. При 0 игрок умирает.
        /// </summary>
        public static int Thirst = 100;
        /// <summary>
        /// Уровень счастья. При 0 игрок умирает.
        /// </summary>
        public static int Happiness = 100;
        /// <summary>
        /// Уровень здоровья. При 0 игрок умирает.
        /// </summary>
        public static int Health = 100;
        /// <summary>
        /// Количество денег. При 0 игрок (нет, не умирает) чувствует себя бомжом.
        /// </summary>
        public static int Money = 0;
        /// <summary>
        /// Текущий день.
        /// </summary>
        public static int CurrentDay = 1;
        /// <summary>
        /// Зарплата. Выдается ежедневно.
        /// </summary>
        public static int DailyJobSalary = 0;
        /// <summary>
        /// Слоты инвентаря.
        /// </summary>
        public static Inventory Inventory = new Inventory();
        /// <summary>
        /// Болезни игрока.
        /// </summary>
        public static Dictionary<int, Curse> Curses = new Dictionary<int, Curse>();
        /// <summary>
        /// Текущее местонахождение игрока.
        /// </summary>
        public static Places Place = Places.MENU;
    }
}

