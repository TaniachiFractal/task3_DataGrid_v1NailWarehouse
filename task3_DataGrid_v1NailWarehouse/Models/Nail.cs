using System;
using System.Collections.Generic;
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
        public double Length { get; set; }

        /// <inheritdoc cref="Models.Material"/>
        public Material Material { get; set; }

        /// <summary>
        /// Количество на складе
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Минимальный предел количества
        /// </summary>
        public int MinCount { get; set; }

        /// <summary>
        /// Цена без НДС
        /// </summary>
        public decimal Price { get; set; }
    }
}
