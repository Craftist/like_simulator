using System;
using System.Collections.Generic;

namespace Like_Simulator
{
    /// <summary>
    /// Класс, описывающий инвентарь.
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// Количество слотов инвентаря.
        /// </summary>
        /// <value>Кол-во слотов инвентаря.</value>
        public static int SlotsCount
        {
            get
            {
                return Data.Inventory.Slots.Count;
            }
        }
        public Dictionary<int, InventoryItem> Slots = new Dictionary<int, InventoryItem>();
    }
}

