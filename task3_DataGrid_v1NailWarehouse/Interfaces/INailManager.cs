using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using task3_DataGrid_v1NailWarehouse.Memory;
using task3_DataGrid_v1NailWarehouse.Models;

namespace task3_DataGrid_v1NailWarehouse.Interfaces
{
    /// <summary>
    /// Интерфейс прослойки между <see cref="MemoryNailStorage"/> и представлением
    /// </summary>
    public interface INailManager
    {
        /// <summary>
        /// Асинхронное получение всех данных
        /// </summary>
        Task<IReadOnlyCollection<Nail>> GetAllAsync();

        /// <summary>
        /// Асинхронная операция добавления
        /// </summary>
        Task<Nail> AddAsync(Nail nail);

        /// <summary>
        /// Асинхронная операция изменения
        /// </summary>
        Task EditAsync(Nail nail);

        /// <summary>
        /// Асинхронная операция удаления
        /// </summary>
        Task<bool> DeleteAsync(Guid id);

        /// <summary>
        /// Асинхронная получение суммарных данных
        /// </summary>
        Task<INailStats> GetStatsAsync();
    }
}
