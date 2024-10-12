using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task3_DataGrid_v1NailWarehouse.Classes;
using task3_DataGrid_v1NailWarehouse.Interfaces;
using task3_DataGrid_v1NailWarehouse.Memory;
using task3_DataGrid_v1NailWarehouse.Models;

namespace task3_DataGrid_v1NailWarehouse.Manager
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
        /// Асинхронная операция добавления
        /// </summary>
        public async Task<Nail> AddAsync(Nail person)
        {
            var result = await nailStorage.AddAsync(person);
            return result;
        }

        /// <summary>
        /// Асинхронная операция удаления
        /// </summary>
        public async Task<bool> DeleteAsync(Guid id)
        {
            var result = await nailStorage.DeleteAsync(id);
            return result;
        }

        /// <summary>
        /// Асинхронная операция изменения
        /// </summary>
        public Task EditAsync(Nail person)
            => nailStorage.EditAsync(person);

        /// <summary>
        /// Асинхронно получить все объекты <see cref="Nail"/> из хранилища 
        /// </summary>
        public Task<IReadOnlyCollection<Nail>> GetAllAsync()
            => nailStorage.GetAllAsync();

        /// <summary>
        /// Асинхронно получить все вычисляемые данные о <see cref="Nail"/> из хранилища 
        /// </summary>
        public async Task<INailStats> GetStatsAsync()
        {
            var result = await nailStorage.GetAllAsync();
            return new NailStats
            {
                FullCount = result.Count,
                FullSummaryNoTax = result.Sum(nail => nail.Price * nail.Count),
                FullSummaryWithTax = result.Sum(nail => (nail.Price + (nail.Price * Constants.Tax)) * nail.Count),
            };
        }
    }
}
