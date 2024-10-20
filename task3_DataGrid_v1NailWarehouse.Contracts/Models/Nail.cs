using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace task3_DataGrid_v1NailWarehouse.Contracts.Models
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
        [Required(ErrorMessage = "Введите название")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Название - строка от 3 до 50 символов")]
        public string Name { get; set; }

        /// <summary>
        /// Длина в миллиметрах
        /// </summary>
        [Range(0, 100000000)]
        public decimal Length { get; set; }

        /// <inheritdoc cref="Models.Material"/>
        [Range(0, 100000000)]
        public Material Material { get; set; }

        /// <summary>
        /// Количество на складе
        /// </summary>
        [Range(0, 100000000)]
        public decimal Count { get; set; }

        /// <summary>
        /// Минимальный предел количества
        /// </summary>
        [Range(0, 100000000)]
        public decimal MinCount { get; set; }

        /// <summary>
        /// Цена без НДС
        /// </summary>
        [Range(0, 100000000)]
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

        /// <summary>
        /// Проверка полей
        /// </summary>
        public bool Validate()
        {
            var context = new ValidationContext(this, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();
            return Validator.TryValidateObject(this, context, results, true);
        }
    }
}
