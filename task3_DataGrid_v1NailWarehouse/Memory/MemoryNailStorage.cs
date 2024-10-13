using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task3_DataGrid_v1NailWarehouse.Interfaces;
using task3_DataGrid_v1NailWarehouse.Models;

namespace task3_DataGrid_v1NailWarehouse.Memory
{
    /// <summary>
    /// Хранилище данных о <see cref="Nail"/>
    /// </summary>
    public class MemoryNailStorage : INailStorage
    {
        private readonly List<Nail> nails;

        /// <summary>
        /// Конструктор: Инициализация списка
        /// </summary>
        public MemoryNailStorage()
        {
            nails = new List<Nail>();
        }

        /// <summary>
        /// <inheritdoc cref="INailStorage.AddAsync(Nail)"/>
        /// </summary>
        public Task<Nail> AddAsync(Nail nail)
        {
            nails.Add(nail);
            return Task.FromResult(nail);
        }

        /// <summary>
        /// <inheritdoc cref="INailStorage.DeleteAsync(Guid)"/>
        /// </summary>
        public Task<bool> DeleteAsync(Guid id)
        {
            var nail = nails.FirstOrDefault(x => x.Id == id);
            if (nail != null)
            {
                nails.Remove(nail);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        /// <summary>
        /// <inheritdoc cref="INailStorage.EditAsync(Nail)"/>
        /// </summary>
        public Task EditAsync(Nail nail)
        {
            var target = nails.FirstOrDefault(n => n.Id == nail.Id);
            if (nail != null)
            {
                target.Name = nail.Name;
                target.Length = nail.Length;
                target.Material = nail.Material;
                target.Count = nail.Count;
                target.MinCount = nail.MinCount;
                target.Price = nail.Price;
            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// <inheritdoc cref="INailStorage.GetAllAsync()"/>
        /// </summary>
        public Task<IReadOnlyCollection<Nail>> GetAllAsync()
            => Task.FromResult<IReadOnlyCollection<Nail>>(nails);

    }
}
