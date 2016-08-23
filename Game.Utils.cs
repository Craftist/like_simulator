using System;

namespace Like_Simulator
{
    public partial class Game
    {
        /// <summary>
        /// Сохранить игру и выйти.
        /// </summary>
        public static void SaveAndExit()
        {
            /*try
            {
                using (Stream s = new FileStream("save\\main.sav", FileMode.OpenOrCreate))
                {
                    StreamWriter sw = new StreamWriter(s, Encoding.UTF8);
                    sw.Write("CurrentDay:" + Data.CurrentDay + "\r\n");
                    sw.Write("DailyJobSalary:" + Data.DailyJobSalary + "\r\n");
                    sw.Write("Happiness:" + Data.Happiness + "\r\n");
                    sw.Write("Hunger:" + Data.Hunger + "\r\n");
                    sw.Write("Money:" + Data.Money + "\r\n");
                    sw.Write("Name:" + Data.Name + "\r\n");
                    sw.Write("Thirst:" + Data.Thirst);
                    sw.Close();
                }
                using (Stream s = new FileStream("save\\inventory.sav", FileMode.OpenOrCreate))
                {
                    StreamWriter sw = new StreamWriter(s, Encoding.UTF8);
                    foreach (InventoryItem item in Data.Inventory.Slots.Values)
                    {
                        sw.Write(item.Name + ":" + item.Description + ":" + item.Quantity);
                    }
                    sw.Close();
                }
                using (Stream s = new FileStream("save\\curses.sav", FileMode.OpenOrCreate))
                {
                    StreamWriter sw = new StreamWriter(s, Encoding.UTF8);
                    foreach (Curse curse in Data.Curses.Values)
                    {
                        sw.Write(curse.Identifier + ":" + curse.Name + ":" +
                            curse.DayCought + ":" + curse.ExpiredIn);
                    }
                    sw.Close();
                }
            } catch (IOException e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"!!! ИСКЛЮЧЕНИЕ !!!
Выброшено исключение IOException!
Текст сообщения: " + e.Message + @"
Stack Trace:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(e.StackTrace);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(@"Что будем делать?
1 - Выйти из игры

Ваш ответ: ");
                var answer = Console.ReadLine();
                if (answer == "1")
                {
                    Exit();
                }
            }*/
            Console.WriteLine("Сохранение еще не поддерживается!");
            System.Threading.Thread.Sleep(1000);
            Exit();
        }

        /// <summary>
        /// Загрузить данные из файла.
        /// </summary>
        public static void LoadData()
        {
            /*using (Stream s = new FileStream("save\\main.sav", FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(s, Encoding.UTF8);
                string data = sr.ReadToEnd();
                // TODO доделать эту поеботню а то не работает сука
                string[] datas = data.Split(new char[] { '\r', '\n' });
                Data.CurrentDay     = Convert.ToInt32(datas[0].Split(new char[] { ':' })[1]);
                Data.DailyJobSalary = Convert.ToInt32(datas[1].Split(new char[] { ':' })[1]);
                Data.Happiness      = Convert.ToInt32(datas[2].Split(new char[] { ':' })[1]);
                Data.Hunger         = Convert.ToInt32(datas[3].Split(new char[] { ':' })[1]);
                Data.Money          = Convert.ToInt32(datas[4].Split(new char[] { ':' })[1]);
                Data.Name           = datas[5].Split(new char[] { ':' })[1];
                Data.Thirst         = Convert.ToInt32(datas[6].Split(new char[] { ':' })[1]);
                sr.Close();
            }
            using (Stream s = new FileStream("save\\inventory.sav", FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(s, Encoding.UTF8);
                foreach (string line in sr.ReadToEnd().Split(new char[] { '\r', '\n' }))
                {
                    string[] linearr = line.Split(new char[] { ':' });
                    Data.Inventory.Slots.Clear();
                    Data.Inventory.Slots.Add(Data.Inventory.Slots.Count,
                        new InventoryItem(linearr[0], linearr[1],
                            Convert.ToInt32(linearr[2])));
                }
                sr.Close();
            }
            using (Stream s = new FileStream("save\\curse.sav", FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(s, Encoding.UTF8);
                foreach (string line in sr.ReadToEnd().Split(new char[] { '\r', '\n' }))
                {
                    string[] linearr = line.Split(new char[] { ':' });
                    Data.Curses.Clear();
                    Data.Curses.Add(linearr[0],
                        new Curse(linearr[0], linearr[1],
                            Convert.ToInt32(linearr[3]) - Convert.ToInt32(linearr[2])));
                }
                sr.Close();
            }*/
            Console.WriteLine("Загрузка данных еще не поддерживается!");
            System.Threading.Thread.Sleep(1000);
        }

        /// <summary>
        /// Выход из игры.
        /// </summary>
        public static void Exit()
        {
            return;
        }

        /// <summary>
        /// Вернуться к игре.
        /// </summary>
        public static void ReturnToGame()
        {

        }

        /// <summary>
        /// Вывести на экран одну строку ошибки.
        /// </summary>
        /// <param name="message">Сообщение ошибки.</param>
        public static void DrawErrorLine(string message = "")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: " + message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Вывести на экран одну строку "Удачно".
        /// </summary>
        /// <param name="message">Сообщение.</param>
        public static void DrawSuccessrLine(string message = "")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Успех: " + message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Вывести на экран сообщение об ошибке.
        /// </summary>
        /// <param name="message">Сообщение ошибки.</param>
        public static void DrawError(string message = "")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Вывести на экран статистику.
        /// </summary>
        public static void PrintStats()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"=== Статистика ===
День " + Data.CurrentDay + @"
Имя     - " + Data.Name + @"
Деньги  - " + Data.Money + @"
Сытость - " + Data.Hunger + @"
Жажда   - " + Data.Thirst + "\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Переход на следующий день.
        /// </summary>
        public static void NextDay()
        {
            Data.Hunger -= new Random().Next(1, 5);
            Data.Happiness -= new Random().Next(0, 2);
            // Data.Thirst -= new Random().Next(0, 1);
            Data.Money += Data.DailyJobSalary;
            Data.CurrentDay++;
            Curse.Curse_Check();
        }

        /// <summary>
        /// Запрос на выход из игры.
        /// </summary>
        public static void AreYouSureToExit()
        {
            Console.Write(@"=== Выход из игры ===
Сохраниться? (y/n/c/r)
y         - Сохраниться и выйти
n         - Выйти без сохранения
c (или r) - Вернуться в игру

Ваш выбор: ");
            var action = Console.ReadLine();
            switch (action)
            {
                case "y":
                    SaveAndExit();
                    break;
                case "n":
                    Exit();
                    break;
                case "c":
                case "r":
                    ReturnToGame();
                    break;
            }
        }
    }
}

