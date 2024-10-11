using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace task3_DataGrid_v1NailWarehouse.Models
{
    /// <summary>
    /// Класс объекта гвоздя
    /// </summary>
    public class Nail
    {
        /// <summary>
        /// Идентификатор гвоздя
        /// </summary>     
        public Guid Id { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Длина в миллиметрах
        /// </summary>
        public decimal Length { get; set; }

        /// <inheritdoc cref="Models.Material"/>
        public Material Material { get; set; }

        /// <summary>
        /// Количество на складе
        /// </summary>
        public decimal Count { get; set; }

        /// <summary>
        /// Минимальный предел количества
        /// </summary>
        public decimal MinCount { get; set; }

        /// <summary>
        /// Цена без НДС
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Создать копию гвоздя
        /// </summary>
        public Nail(Nail nail)
        {
            Id = nail.Id;
            Name = nail.Name;
            Length = nail.Length;
            Material = nail.Material;
            Count = nail.Count;
            MinCount = nail.MinCount;
            Price = nail.Price;
        }

        /// <summary>
        /// Создать гвоздь
        /// </summary>
        public Nail() { }
    }
}
