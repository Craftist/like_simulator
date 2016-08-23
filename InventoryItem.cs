using System;

namespace Like_Simulator
{
    /// <summary>
    /// Класс, описывающий слот инвентаря.
    /// </summary>
    public class InventoryItem
    {
        /// <summary>
        /// Имя предмета.
        /// </summary>
        public string Name;
        /// <summary>
        /// Описание предмета.
        /// </summary>
        public string Description;
        /// <summary>
        /// Количество предмета.
        /// </summary>
        public int Quantity;
        /// <summary>
        /// Базовый конструктор класса InventoryItem.
        /// </summary>
        public InventoryItem()
            : this("Undefined name", "Undefined description", 1) {}
        /// <summary>
        /// Полный конструктор класса InventoryItem.
        /// </summary>
        /// <param name="name">Название предмета.</param>
        /// <param name="desc">Описание предмета.</param>
        /// <param name="qty">Количество предмета.</param>
        public InventoryItem(string name, string desc, int qty)
        {
            this.Name = name;
            this.Description = desc;
            this.Quantity = qty;
        }
        public void Consume()
        {
            if (this.Name == "Яблоко")
            {
                Data.Hunger += 3;
            }
        }
    }
}

