using System;
using task3_DataGrid_v1NailWarehouse.Contracts.Models;

namespace task3_DataGrid_v1NailWarehouse.Classes
{
    /// <summary>
    /// Помощник для генерации данных
    /// </summary>
    public static class DataGenerator
    {
        /// <summary>
        /// Сгенерировать <see cref="Nail"/> по стандартным параметрам или по заданным
        /// </summary>
        public static Nail CreateNail(Action<Nail> addInfo = null)
        {
            var newNail = new Nail
            {
                Id = Guid.NewGuid(),
                Name = "Без названия",
                Length = 1.0M,
                Material = Material.Copper,
                Count = 10,
                MinCount = 1,
                Price = 100.0M
            };

            addInfo?.Invoke(newNail);

            return newNail;
        }
    }
}
