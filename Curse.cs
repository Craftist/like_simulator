using System;

namespace Like_Simulator
{
    /// <summary>
    /// Класс, описывающий болезнь.
    /// </summary>
    public class Curse
    {
        /// <summary>
        /// Название болезни (локализованное).
        /// </summary>
        public string Name;
        /// <summary>
        /// Идентификатор болезни (уникален).
        /// </summary>
        public string Identifier;
        /// <summary>
        /// День, когда болезнь была получена.
        /// </summary>
        public int DayCought;
        /// <summary>
        /// День, когда болезнь проходит.
        /// </summary>
        public int ExpiredIn;
        /// <summary>
        /// Базовый конструктор класса Curse.
        /// </summary>
        public Curse()
            : this("undefined", "Undefined curse", 0) {}
        /// <summary>
        /// Полный конструктор класса Curse.
        /// </summary>
        /// <param name="identifier">Идентификатор болезни (уникален).</param>
        /// <param name="name">Название болезни (локализованное).</param>
        /// <param name="daysExpired">Через сколько дней болезнь должна пройти.</param>
        public Curse(string identifier, string name, int daysExpired)
        {
            this.Identifier = identifier;
            this.Name = name;
            this.DayCought = Data.CurrentDay;
            this.ExpiredIn = this.DayCought + daysExpired;
        }
        /// <summary>
        /// Проверка болезней, обновление их сроков, удаление прошедших болезней.
        /// </summary>
        public static void Curse_Check()
        {
            foreach (Curse curse in Data.Curses.Values)
            {
                if (Data.CurrentDay >= curse.ExpiredIn)
                {
                    // Curse спадает
                    Data.Curses.Add(Data.Curses.Count, 
                        new Curse(curse.Identifier, curse.Name, curse.ExpiredIn - Data.CurrentDay));
                }
            }
        }
    }
}

