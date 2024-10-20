using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task3_DataGrid_v1NailWarehouse.Contracts.Interfaces;
using task3_DataGrid_v1NailWarehouse.Contracts.Models;

namespace task3_DataGrid_v1NailWarehouse.Memory
{
    /// <inheritdoc cref="INailStorage"/>
    public class MemoryNailStorage : INailStorage
    {
        private readonly List<Nail> nails;

        /// <summary>
        /// Конструктор
        /// </summary>
        public MemoryNailStorage()
        {
            nails = new List<Nail>();
        }

        /// <inheritdoc/>
        public Task<Nail> AddAsync(Nail nail)
        {
            nails.Add(nail);
            return Task.FromResult(nail);
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public Task EditAsync(Nail nail)
        {
            var target = nails.FirstOrDefault(n => n.Id == nail.Id);
            if (nail != null && target != null)
            {
                target.Name = nail.Name;
                target.Length = nail.Length;
                target.Material = nail.Material;
                target.Count = nail.Count;
                target.MinCount = nail.MinCount;
                target.Price = nail.Price;
                return Task.CompletedTask;
            }
            return null;
        }

        /// <inheritdoc/>
        public Task<IReadOnlyCollection<Nail>> GetAllAsync()
            => Task.FromResult<IReadOnlyCollection<Nail>>(nails);

    }
}
