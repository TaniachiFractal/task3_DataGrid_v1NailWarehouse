using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task3_DataGrid_v1NailWarehouse.Constants;
using task3_DataGrid_v1NailWarehouse.Contracts.Interfaces;
using task3_DataGrid_v1NailWarehouse.Contracts.Models;
using task3_DataGrid_v1NailWarehouse.NailManagers.Models;

namespace task3_DataGrid_v1NailWarehouse.NailManagers.Managers
{
    /// <summary>
    /// Класс прослойки между <see cref="MemoryNailStorage"/> и представлением
    /// </summary>
    public class NailManager : INailManager
    {
        private readonly INailStorage nailStorage;

        /// <summary>
        /// Конструктор
        /// </summary>
        public NailManager(INailStorage nailStorage)
        {
            this.nailStorage = nailStorage;
        }

        /// <summary>
        /// <inheritdoc cref="INailManager.AddAsync(Nail)"/>
        /// </summary>
        public async Task<Nail> AddAsync(Nail person)
        {
            var result = await nailStorage.AddAsync(person);
            return result;
        }

        /// <summary>
        /// <inheritdoc cref="INailManager.DeleteAsync(Guid)"/>
        /// </summary>
        public async Task<bool> DeleteAsync(Guid id)
        {
            var result = await nailStorage.DeleteAsync(id);
            return result;
        }

        /// <summary>
        /// <inheritdoc cref="INailManager.EditAsync(Nail)"/>
        /// </summary>
        public Task EditAsync(Nail person)
            => nailStorage.EditAsync(person);

        /// <summary>
        /// <inheritdoc cref="INailManager.GetAllAsync()"/>
        /// </summary>
        public Task<IReadOnlyCollection<Nail>> GetAllAsync()
            => nailStorage.GetAllAsync();

        /// <summary>
        /// <inheritdoc cref="INailManager.GetStatsAsync()"/>
        /// </summary>
        public async Task<INailStats> GetStatsAsync()
        {
            var result = await nailStorage.GetAllAsync();
            return new NailStats
            {
                FullCount = result.Count,
                FullSummaryNoTax = result.Sum(nail => nail.Price * nail.Count),
                FullSummaryWithTax = result.Sum(nail => (nail.Price + (nail.Price * Constant.Tax)) * nail.Count),
            };
        }
    }
}
